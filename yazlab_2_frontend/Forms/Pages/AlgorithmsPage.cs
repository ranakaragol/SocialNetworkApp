using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using yazlab_2_frontend.Algorithms;
using yazlab_2_frontend.Models;

namespace yazlab_2_frontend.Forms.Pages
{
    public partial class AlgorithmsPage : UserControl
    {
        // Değişkenler
        private Node selected_node = null;
        private Edge selected_edge = null;
        private bool nodeMode = true;
        private Point currentMousePoint;
        private Node movingNode = null;
        private Node drawingSourceNode = null;

        // Sonsuz döngüyü engellemek için bayrak (Flag)
        private bool isProgrammaticChange = false;

        private sealed class DoubleBufferedPanel : Panel
        {
            public DoubleBufferedPanel() { DoubleBuffered = true; ResizeRedraw = true; }
        }

        private readonly DoubleBufferedPanel _canvas;

        // Algoritma çalışma zamanı tutar
        private Stopwatch stopwatch = new Stopwatch();

        // Loglama metodu
        private void AddLog(string algorithmName, string message)
        {
            string timestamp = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff");
            string logLine = $"[{timestamp}] [{algorithmName}] {message}";

            // listbox un en üstüne eklenir
            lstLogs.Items.Insert(0, logLine);
        }

        // Maliyet hesaplama metodu
        private double CalculatePathCost(List<Node> path)
        {
            if (path == null || path.Count < 2) return 0;
            double totalCost = 0;

            for (int i = 0; i < path.Count - 1; i++)
            {
                Node current = path[i];
                Node next = path[i + 1];

                // İki düğüm arasındaki kenarı bul ve ağırlığını topla
                var edge = GraphStore.Edges.FirstOrDefault(e =>
                    (e.startNode == current && e.endNode == next) ||
                    (e.startNode == next && e.endNode == current));

                if (edge != null) totalCost += edge.Weight;
            }
            return totalCost;
        }

        public AlgorithmsPage()
        {
            InitializeComponent();

            _canvas = new DoubleBufferedPanel { Dock = DockStyle.Fill, BackColor = Color.White };
            panelAlgoCanvas.Controls.Add(_canvas);

            _canvas.Paint += Canvas_Paint;
            _canvas.MouseDown += panelCanvas_MouseDown;
            _canvas.MouseMove += panelCanvas_MouseMove;
            _canvas.MouseUp += panelCanvas_MouseUp;

            // --- 3. İSTEK: BAŞKA SAYFADA DÜĞÜM EKLENSE BİLE GÜNCELLE ---
            // GraphStore değiştiğinde (Node ekle/sil) Combo'yu tazele
            GraphStore.GraphChanged += () =>
            {
                if (IsHandleCreated)
                {
                    BeginInvoke(new Action(() =>
                    {
                        RefreshStartCombo();
                        _canvas.Invalidate();
                    }));
                }
            };

            // Sayfa görünür olduğunda (Sekme değişince) Combo'yu tazele
            this.VisibleChanged += (s, e) => { if (this.Visible) RefreshStartCombo(); };

            // --- 2. İSTEK: COMBOBOX SEÇİMİ DEĞİŞİRSE GRAPH DA DEĞİŞSİN ---
            cmbStart.SelectedIndexChanged += CmbStart_SelectedIndexChanged;
        }

        // combobox güncelleme metodu
        private void RefreshStartCombo()
        {
            isProgrammaticChange = true;

            object currentSelection = cmbStart.SelectedItem;
            cmbStart.BeginUpdate();
            cmbStart.Items.Clear();

            // Id ler sırayla eklenir
            foreach (var node in GraphStore.Nodes.OrderBy(x => x.Id))
            {
                cmbStart.Items.Add(node.Id);
            }

            // eski seçim korunmaya çalışılır
            if (currentSelection != null && cmbStart.Items.Contains(currentSelection))
                cmbStart.SelectedItem = currentSelection;
            else if (cmbStart.Items.Count > 0)
                cmbStart.SelectedIndex = 0;

            cmbStart.EndUpdate();
            isProgrammaticChange = false;

            object currentEndSelection = cmbTarget.SelectedItem;
            cmbTarget.BeginUpdate();
            cmbTarget.Items.Clear();

            foreach (var node in GraphStore.Nodes.OrderBy(x => x.Id))
            {
                // start ile aynı olsada yinede combobox target e ekliyoruz
                cmbTarget.Items.Add(node.Id);
            }

            if (currentEndSelection != null && cmbTarget.Items.Contains(currentEndSelection))
                cmbTarget.SelectedItem = currentEndSelection;
            else if (cmbTarget.Items.Count > 0)
                cmbTarget.SelectedIndex = cmbTarget.Items.Count > 1 ? 1 : 0;

            cmbTarget.EndUpdate();

            isProgrammaticChange = false;
        }

        // combobox eventi
        private void CmbStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isProgrammaticChange) return;

            if (cmbStart.SelectedItem != null)
            {
                int id = (int)cmbStart.SelectedItem;
                // Grafikteki o düğümü bul ve seçili yap
                selected_node = GraphStore.Nodes.FirstOrDefault(n => n.Id == id);
                _canvas.Invalidate();
            }
        }

        private async void btnRun_Click(object sender, EventArgs e)
        {
            // Eğer selected_node boşsa ama combobox doluysa, combobox'takini baz al
            if (selected_node == null && cmbStart.SelectedItem != null)
            {
                int id = (int)cmbStart.SelectedItem;
                selected_node = GraphStore.Nodes.FirstOrDefault(n => n.Id == id);
            }

            string selectedAlgo = cmbAlgorithms.Text.Trim();

            bool isAnalysisAlgo = (selectedAlgo == "Bağlı bileşenler" || selectedAlgo == "Merkezilik" || selectedAlgo == "Welsh-Powell");

            if (!isAnalysisAlgo && selected_node == null)
            {
                MessageBox.Show("Lütfen önce bir başlangıç düğümü seçin!");
                return;
            }

            // Tabloya yazdırma hazırlığı 
            lblDurumValue.Text = "Durum: Hesaplanıyor...";
            lblDurumValue.ForeColor = Color.Orange;
            lblMaliyetValue.Text = "Maliyet: -";
            lblTimeValue.Text = "Süre: -";

            btnRun.Enabled = false;
            stopwatch.Restart();

            List<Node> resultPath = null;
            double cost = 0;
            bool runPathAnimation = false;

            try
            {
                if (selectedAlgo == "BFS")
                {
                    resultPath = GraphAlgorithms.BFS_algorithm(selected_node, GraphStore.Edges, GraphStore.Nodes);
                    if (resultPath != null) cost = resultPath.Count;
                    runPathAnimation = true;
                }
                else if (selectedAlgo == "DFS")
                {
                    resultPath = GraphAlgorithms.RunDFS(selected_node, GraphStore.Edges, GraphStore.Nodes);
                    if (resultPath != null) cost = resultPath.Count;
                    runPathAnimation = true;
                }
                else if (selectedAlgo == "Dijkstra")
                {
                    if (cmbTarget.SelectedItem == null)
                    {
                        MessageBox.Show("Dijkstra için lütfen bir HEDEF (Bitiş) düğümü seçin!");
                        btnRun.Enabled = true;
                        return;
                    }

                    int endId = (int)cmbTarget.SelectedItem;
                    Node targetNode = GraphStore.Nodes.FirstOrDefault(n => n.Id == endId);

                    if (targetNode == selected_node)
                    {
                        MessageBox.Show("Başlangıç ve Bitiş düğümü aynı olamaz!");
                        btnRun.Enabled = true;
                        return;
                    }

                    var path = GraphAlgorithms.Dijkstra_algorithm(selected_node, targetNode, GraphStore.Edges, GraphStore.Nodes);

                    if (path != null)
                    {
                        resultPath = path;
                        cost = CalculatePathCost(path);
                        runPathAnimation = true;
                    }
                    else
                    {
                        MessageBox.Show("Bu iki düğüm arasında bir yol bulunamadı.");
                        runPathAnimation = false;
                    }
                }
                else if (selectedAlgo == "A*")
                {
                    if (cmbTarget.SelectedItem == null)
                    {
                        MessageBox.Show("A* için HEDEF düğüm seçmelisiniz!");
                        btnRun.Enabled = true;
                        return;
                    }
                    int endId = (int)cmbTarget.SelectedItem;
                    Node targetNode = GraphStore.Nodes.FirstOrDefault(n => n.Id == endId);

                    var path = GraphAlgorithms.AStar_Algorithm(selected_node, targetNode, GraphStore.Edges, GraphStore.Nodes);
                    if (path != null)
                    {
                        resultPath = path;
                        cost = CalculatePathCost(path);
                        runPathAnimation = true;
                    }
                    else
                    {
                        MessageBox.Show("Yol bulunamadı.");
                        runPathAnimation = false;
                    }
                }
                else if (selectedAlgo == "Bağlı bileşenler")
                {
                    // başlangıç düğümü seçmeye gerek yok bu algoritma tüm grafiğe bakar
                    var components = GraphAlgorithms.ConnectedComponents_Algorithm(GraphStore.Nodes, GraphStore.Edges);
                    stopwatch.Stop();
                    cost = components.Count;

                    // Rastgele renk üretici
                    Random rnd = new Random();

                    foreach (var group in components)
                    {
                        // Grup için rastgele renk seçilir
                        Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

                        foreach (var node in group)
                        {
                            node.NodeRengi = randomColor;
                            _canvas.Invalidate();
                            _canvas.Update();
                            await Task.Delay(200); // Renkler boyanır
                        }
                    }

                    long elapsedMsComp = stopwatch.ElapsedMilliseconds;
                    lblDurumValue.Text = "Durum: Hesaplandı!";
                    lblTimeValue.Text = $"Süre: {elapsedMsComp} ms";
                    lblMaliyetValue.Text = $"Maliyet: {cost}";
                    AddLog(selectedAlgo, $"Hesaplama tamamlandı. Süre: {elapsedMsComp} ms, Sonuç: {cost}");

                    btnRun.Enabled = true;
                    return;
                }
                else if (selectedAlgo == "Merkezilik")
                {
                    var scores = GraphAlgorithms.DegreeCentrality_Algorithm(GraphStore.Nodes, GraphStore.Edges);
                    stopwatch.Stop();
                    cost = scores.Values.Max();

                    // Görsel olarak derecesi yüksek olanın çapı arttırılır 
                    foreach (var item in scores)
                    {
                        Node n = item.Key;
                        int degree = item.Value;

                        // Standart boyut 18 üzerinden 3 er 3 er arttırılır ama 50 de biter
                        int newRadius = 18 + (degree * 3);
                        if (newRadius > 50) newRadius = 50;

                        n.radius = newRadius;

                        // Rengide bağlantı sayısına göre koyulaşır
                        int redIntensity = Math.Min(255, 100 + (degree * 20));
                        n.NodeRengi = Color.FromArgb(redIntensity, 50, 50);
                    }

                    _canvas.Invalidate();

                    long elapsedMsCent = stopwatch.ElapsedMilliseconds;
                    lblDurumValue.Text = "Durum: Hesaplandı!";
                    lblTimeValue.Text = $"Süre: {elapsedMsCent} ms";
                    lblMaliyetValue.Text = $"Maliyet: {cost}";
                    AddLog(selectedAlgo, $"Hesaplama tamamlandı. Süre: {elapsedMsCent} ms, Sonuç: {cost}");

                    MessageBox.Show("Düğümler derecelerine göre boyutlandırıldı.");
                    btnRun.Enabled = true;
                    return;
                }
                else if (selectedAlgo == "Welsh-Powell")
                {
                    var colorGroups = GraphAlgorithms.WelshPowell_Algorithm(GraphStore.Nodes, GraphStore.Edges);
                    stopwatch.Stop();
                    cost = colorGroups.Count;

                    // Kullanılacak renk paleti sırasıyla kırmızı mavi yeşil turuncu mor turkuaz diye gider
                    Color[] palette = new Color[] {
                        Color.Red, Color.Blue, Color.Green, Color.Orange, Color.Purple, Color.Teal, Color.Brown, Color.Magenta
                    };

                    foreach (var group in colorGroups)
                    {
                        int colorIndex = group.Key;
                        // Eğer palet yetmezse rastgele renk üretilir
                        Color groupColor = (colorIndex < palette.Length) ? palette[colorIndex] : Color.FromArgb(new Random().Next(256), new Random().Next(256), new Random().Next(256));

                        foreach (var node in group.Value)
                        {
                            node.NodeRengi = groupColor;
                            // Görselleştirme için çap ı standart yapalım belki merkezilikden çapı artmıştır
                            node.radius = 18;

                            _canvas.Invalidate();
                            _canvas.Update();
                            await Task.Delay(300); // Boyama animasyonu
                        }
                    }

                    long elapsedMsWP = stopwatch.ElapsedMilliseconds;
                    lblDurumValue.Text = ": Hesaplandı!";
                    lblTimeValue.Text = $"Süre: {elapsedMsWP} ms";
                    lblMaliyetValue.Text = $"Maliyet: {cost}";
                    AddLog(selectedAlgo, $"Hesaplama tamamlandı. Süre: {elapsedMsWP} ms, Sonuç: {cost}");

                    // Kromatik sayıyı göster
                    MessageBox.Show($"Grafik toplam {colorGroups.Count} renk ile boyandı. (Kromatik Sayı: {colorGroups.Count})");
                    btnRun.Enabled = true;
                    return;
                }
                else
                {
                    MessageBox.Show("Lütfen bir algoritma seçin!");
                    btnRun.Enabled = true;
                    return;
                }
            }
            // Hata yakalandımı loga kaydedilir
            catch (Exception ex)
            {
                stopwatch.Stop();
                AddLog(selectedAlgo, "HATA: " + ex.Message);
                btnRun.Enabled = true;
                return;
            }

            stopwatch.Stop();

            // sonuçlar yazdırılır
            long elapsedMs = stopwatch.ElapsedMilliseconds;
            lblDurumValue.Text = "Hesaplandı!";
            lblTimeValue.Text = elapsedMs.ToString();
            lblMaliyetValue.Text = cost.ToString();
            // Maliyet değeri algoritmalar arası değişiyor
            // Örneğin BFS ve DFS için adım sayısı iken Welsh Powell içinse kullanılan renk sayısıdır

            AddLog(selectedAlgo, $"Hesaplama tamamlandı. Süre: {elapsedMs} ms, Maliyet/Adım: {cost}");

            if (runPathAnimation && resultPath != null)
            {
                await runAlgorithmAsync(resultPath);
            }

            btnRun.Enabled = true;
        }

        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            Node clickedNode = null;
            foreach (var node in GraphStore.Nodes)
            {
                if (node.IsHit(e.Location)) { clickedNode = node; break; }
            }

            if (clickedNode != null)
            {
                selected_node = clickedNode;
                selected_edge = null;

                // Tıklanan düğüm combobox da seçilir
                isProgrammaticChange = true;
                if (cmbStart.Items.Contains(clickedNode.Id))
                {
                    cmbStart.SelectedItem = clickedNode.Id;
                }
                isProgrammaticChange = false;

                if (nodeMode) movingNode = clickedNode;
                else { drawingSourceNode = clickedNode; currentMousePoint = e.Location; }

                _canvas.Invalidate();
                return;
            }

            // Kenar kontrolü...
            Edge clickedEdge = null;
            foreach (var edge in GraphStore.Edges)
            {
                if (edge.IsHit(e.Location)) { clickedEdge = edge; break; }
            }

            if (clickedEdge != null) { selected_edge = clickedEdge; selected_node = null; }
            else { selected_node = null; selected_edge = null; }

            _canvas.Invalidate();
        }

        private void panelCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (nodeMode && movingNode != null) { movingNode.location = e.Location; _canvas.Invalidate(); }
            else if (!nodeMode && drawingSourceNode != null) { currentMousePoint = e.Location; _canvas.Invalidate(); }
        }

        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (!nodeMode && drawingSourceNode != null)
            {
                foreach (var targetNode in GraphStore.Nodes)
                {
                    if (targetNode.IsHit(e.Location) && targetNode != drawingSourceNode)
                    {
                        bool zatenVarMi = GraphStore.Edges.Any(edge =>
                            (edge.startNode == drawingSourceNode && edge.endNode == targetNode) ||
                            (edge.endNode == drawingSourceNode && edge.startNode == targetNode));

                        if (!zatenVarMi) GraphStore.AddEdge(drawingSourceNode, targetNode);
                    }
                }
            }
            movingNode = null; drawingSourceNode = null; _canvas.Invalidate();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int gridSize = 20;
            using (Pen p = new Pen(Color.FromArgb(245, 245, 245)))
            {
                for (int x = 0; x < _canvas.Width; x += gridSize) e.Graphics.DrawLine(p, x, 0, x, _canvas.Height);
                for (int y = 0; y < _canvas.Height; y += gridSize) e.Graphics.DrawLine(p, 0, y, _canvas.Width, y);
            }

            using var edgePen = new Pen(Color.Gray, 2);
            foreach (var edge in GraphStore.Edges)
            {
                if (edge.startNode != null && edge.endNode != null)
                    e.Graphics.DrawLine(edgePen, edge.startNode.location, edge.endNode.location);
            }

            if (!nodeMode && drawingSourceNode != null)
            {
                using var previewPen = new Pen(Color.DarkGray, 2) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };
                e.Graphics.DrawLine(previewPen, drawingSourceNode.location, currentMousePoint);
            }

            foreach (var n in GraphStore.Nodes)
            {

                bool selected = selected_node == n;

                using var brush = new SolidBrush(selected ? Color.LightSkyBlue : n.NodeRengi);
                using var borderPen = new Pen(selected ? Color.DodgerBlue : Color.DimGray, selected ? 3 : 2);
                float radius = n.radius > 0 ? n.radius : 18;
                var rect = new RectangleF(n.location.X - radius, n.location.Y - radius, radius * 2, radius * 2);
                e.Graphics.FillEllipse(brush, rect);
                e.Graphics.DrawEllipse(borderPen, rect);

                //ıd görünümü
                string text = n.Id.ToString();

                using var font = new Font("Segoe UI", 10f, FontStyle.Bold);
                using var textBrush = new SolidBrush(Color.Black);

                var sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                e.Graphics.DrawString(text, font, textBrush, rect, sf);
            }
        }

        private async Task runAlgorithmAsync(List<Node> resultNodes)
        {
            // Önce renkleri temizle ki yeni yol net gözüksün
            foreach (var n in GraphStore.Nodes) n.NodeRengi = Color.WhiteSmoke;
            _canvas.Invalidate();

            foreach (var n in resultNodes)
            {
                // Color oldColor = n.NodeRengi; 
                n.NodeRengi = Color.Yellow;
                _canvas.Invalidate(); _canvas.Update();
                await Task.Delay(500);

                // Yolu göstermek için yeşil yapıp öyle bırakılır
                n.NodeRengi = Color.LightGreen;
            }
            _canvas.Invalidate();
        }

        // Button Eventleri
        private void button1_Click(object sender, EventArgs e) { nodeMode = true; }
        private void button2_Click(object sender, EventArgs e) { nodeMode = false; }

        private void lstLogs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClearResult_Click(object sender, EventArgs e)
        {

        }
    }
}