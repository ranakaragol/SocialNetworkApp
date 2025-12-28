using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using yazlab_2_frontend.Models;
using static System.Net.Mime.MediaTypeNames;


namespace yazlab_2_frontend.Forms.Pages
{
    public partial class GraphViewPage : UserControl

    {

        // Seçilen node nin id si
        private Node selected_node = null;
        // Seçilen edge nin id si
        private Edge selected_edge = null;
        // Node yer değiştirme modundamı yoksa Edge çekme modundamı onu belirten değişken
        private bool nodeMode = false;
        // Farenin konumunu tutan değişken
        Point currentMousePoint;
        // Yer değiştiren node yi tutar
        private Node movingNode = null;
        // Çizgi çekilen kaynak node yi tutar
        private Node drawingSourceNode = null;



        // Flicker olmaması için double buffered panel

        private sealed class DoubleBufferedPanel : Panel
        {

            public DoubleBufferedPanel()

            {

                DoubleBuffered = true;

                ResizeRedraw = true;

            }

        }



        private readonly DoubleBufferedPanel _canvas;


        public GraphViewPage()
        {
            InitializeComponent();

            _canvas = new DoubleBufferedPanel
            {

                Dock = DockStyle.Fill,

            };

            // komşuları gösteren gridview in sadece okunabilmesini sağlar
            neighborsgridview.ReadOnly = true;

            panelCanvas.Controls.Add(_canvas);

            _canvas.Paint += Canvas_Paint;
            _canvas.MouseDown += panelCanvas_MouseDown;
            _canvas.MouseMove += panelCanvas_MouseMove;
            _canvas.MouseUp += panelCanvas_MouseUp;

            GraphStore.GraphChanged += () => _canvas.Invalidate();
            // Kod karmaşasını önlemek amacıyla buton tıklama eventleri fonksiyonlara yazıldı 

            //btnRandomLayout.Click += (_, __) => { RandomLayout(); _canvas.Invalidate(); };

            //btnResetSelection.Click += (_, __) => { ClearSelection(); _canvas.Invalidate(); };

            RandomLayout();

        }
        private void RandomLayout()

        {

            var rnd = new Random();

            var w = Math.Max(300, _canvas.ClientSize.Width);
            var h = Math.Max(300, _canvas.ClientSize.Height);

            foreach (var node in GraphStore.Nodes)
            {

                float x = rnd.Next(40, w - 40);
                float y = rnd.Next(40, h - 40);
                node.location = new Point((int)x, (int)y);
            }

        }

        private void Canvas_Paint(object? sender, PaintEventArgs e)
        {
            // Arka plana grid çizimi
            int gridSize = 20;
            using (Bitmap bmp = new Bitmap(gridSize, gridSize))
            using (Graphics gTemp = Graphics.FromImage(bmp))
            {
                using (Pen p = new Pen(Color.FromArgb(240, 240, 240))) // hafif bir gri renktir
                {
                    gTemp.DrawLine(p, 0, gridSize - 1, gridSize, gridSize - 1);
                    gTemp.DrawLine(p, gridSize - 1, 0, gridSize - 1, gridSize);
                }

                using (TextureBrush brush = new TextureBrush(bmp))
                {
                    e.Graphics.FillRectangle(brush, _canvas.ClientRectangle);
                }
            }


            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Edge çizimi
            using var edgePen = new Pen(Color.Gray, 2);
            foreach (var edge in GraphStore.Edges)
            {
                // idler üzerinden düğüm bulunur
                var nodeA = edge.startNode;
                var nodeB = edge.endNode;

                if (nodeA != null && nodeB != null)
                {
                    e.Graphics.DrawLine(edgePen, nodeA.location, nodeB.location);
                }
            }
            if (!nodeMode && drawingSourceNode != null)
            {
                using var previewPen = new Pen(Color.FromArgb(150, Color.Gray), 2); // Hafif şeffaf gri
                previewPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash; // Kesikli çizgi daha şık durur

                e.Graphics.DrawLine(previewPen, drawingSourceNode.location, currentMousePoint);
            }

            // Node çizimi
            foreach (var n in GraphStore.Nodes)
            {
                Point p = n.location; // Doğrudan node'un içindeki koordinatlar alınır
                bool selected = selected_node == n;

                using var brush = new SolidBrush(selected ? Color.LightSkyBlue : n.NodeRengi);
                using var borderPen = new Pen(selected ? Color.DodgerBlue : Color.DimGray, selected ? 3 : 2);
                float r = n.radius > 0 ? n.radius : 18;
                var rect = new RectangleF(p.X - r, p.Y - r, r * 2, r * 2);

                e.Graphics.FillEllipse(brush, rect);
                e.Graphics.DrawEllipse(borderPen, rect);


                // --- ID yazısı (node’un ortasına) ---
                string text = n.Id.ToString();

                using var font = new System.Drawing.Font("Segoe UI", selected ? 11f : 10f, System.Drawing.FontStyle.Bold);
                using var textBrush = new SolidBrush(Color.Black);

                var sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                e.Graphics.DrawString(text, font, textBrush, rect, sf);
            }
        }


        // Seçimi silmeyi sağlar
        private void ClearSelection()

        {

            selected_node = null;
            selected_edge = null;

            grpSelectedNode.Text = "Seçiniz...";


            lblSelIdValue.Text = "-";

            lblSelAktValue.Text = "-";

            lblSelEtkValue.Text = "-";

            lblSelDegreeValue.Text = "-";


            neighborsgridview.Rows.Clear();

        }

        private List<Node> GetNeighbors(Node node)

        {

            var neighbors = new List<Node>();


            foreach (var e in GraphStore.Edges)
            {

                if (e.startNode == node) neighbors.Add(e.endNode);

                else if (e.endNode == node) neighbors.Add(e.startNode);

            }

            return neighbors;

        }


        // çizimleri yapmayı tetikleyecek buton eventi
        private void btnRandomLayout_Click(object sender, EventArgs e)
        {
            RandomLayout(); _canvas.Invalidate();
        }
        // seçimi temizlemeyi tetikleyecek buton eventi
        private void btnResetSelection_Click(object sender, EventArgs e)
        {
            ClearSelection();
            _canvas.Invalidate();
        }
        private void panelCanvas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            Node clickedNode = null;
            Edge clickedEdge = null;

            // Önce düğümler kontrol edilir
            foreach (var node in GraphStore.Nodes)
            {
                if (node.IsHit(e.Location))
                {
                    clickedNode = node;
                    break;
                }
            }

            if (clickedNode != null)
            {
                // demekki bir nodeye tıklandı
                selected_node = clickedNode;
                selected_edge = null; // node seçildiği için seçilen edge yi temizler kod karmaşasını önlemek için


                showNodeInfo(clickedNode);


                if (nodeMode)
                {
                    movingNode = clickedNode;
                }
                else
                {
                    drawingSourceNode = clickedNode;
                    currentMousePoint = e.Location;
                }

                _canvas.Invalidate();
                return; // node bulunduysa edge kontrolüne gerek yoktur
            }

            // eğer node ye tıklanmadıysa edge kontrolü yap
            foreach (var edge in GraphStore.Edges)
            {

                if (edge.IsHit(e.Location))
                {
                    clickedEdge = edge;
                    break;
                }
            }

            if (clickedEdge != null)
            {
                selected_edge = clickedEdge;
                // aynı şekil buradada edge seçildiği için seçilen node yi temizler kod karmaşasını önlemek için
                selected_node = null;


                showEdgeInfo(clickedEdge);
            }
            else
            {
                // boşluğa tıklandı demektir her şey temizlenir
                ClearSelection();
            }

            _canvas.Invalidate();
        }

        private void panelCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            // Node Yer değiştirme modu ve tabi yer değiştirilcek node varmı ona bakar
            if (nodeMode && movingNode != null)
            {
                // Node un yeni konumunu farenin konumu yapar
                movingNode.location = e.Location;
                // Taşınan node’a bağlı edge’lerin weight’ini güncelle
                foreach (var edge in GraphStore.Edges.Where(ed => ed.startNode == movingNode || ed.endNode == movingNode))
                {
                    edge.Weight = GraphStore.ComputeWeight(edge.startNode, edge.endNode);
                }
                _canvas.Invalidate(); // Node nin hareket ettiğini göstermek için canvas sürekli yeniden çizilir
            }

            // Edge çizme modu
            else if (!nodeMode && drawingSourceNode != null)
            {
                currentMousePoint = e.Location;
                _canvas.Invalidate();
            }
        }

        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (nodeMode)
            {
                // node taşımayı bitir
                movingNode = null;
            }
            else
            {
                // edge çizmeyi bitir
                if (drawingSourceNode != null)
                {
                    foreach (var targetNode in GraphStore.Nodes)
                    {
                        // Bıraktığımız yerde node varmı ve başlangıçtaki node ile aynımı kontrol eder
                        if (targetNode.IsHit(e.Location) && targetNode != drawingSourceNode)
                        {
                            // Normalde AddEdge fonksiyonu aynı nodeler arasında edge çekilince hata fırlatsada
                            // Sistem çökmemesi için bir kontrol ile aynı nodeler arasına edge çekilmesi engellenir
                            bool zatenVarMi = GraphStore.Edges.Any(e =>
                                (e.startNode == drawingSourceNode && e.endNode == targetNode) ||
                                (e.endNode == drawingSourceNode && e.startNode == targetNode));

                            if (!zatenVarMi)
                            {
                                // Eğer bağlantı yoksa ana önbelleğe eklenir
                                GraphStore.AddEdge(drawingSourceNode, targetNode);
                            }
                        }
                    }
                    // başarıyla bir edge oluşturuldu yada node taşındı
                    drawingSourceNode = null;
                    _canvas.Invalidate();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nodeMode = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nodeMode = false;

        }

        // Node bilgileri gösteren method
        private void showNodeInfo(Node node)
        {
            // Node bilgileri yazdırılır
            grpSelectedNode.Text = "Seçilen Node";

            // Node için gerekli bilgiler ve bilgileri belirten labeller güncellenir
            lblSelAkt.Text = "Aktiflik";
            lblSelEtk.Text = "Etkileşim";
            lblSelDegree.Visible = true;
            lblSelDegreeValue.Visible = true;

            lblSelIdValue.Text = node.Id.ToString();
            lblSelAktValue.Text = node.Aktiflik.ToString();
            lblSelEtkValue.Text = node.Etkilesim.ToString();

            // Dereceyi “gerçek edge sayısından” hesapla (BaglantiSayisi bazen eski kalabilir)
            int degree = node.GetDegree(GraphStore.Edges);
            lblSelDegreeValue.Text = degree.ToString();


            var neighbors = GetNeighbors(node);

            neighborsgridview.Rows.Clear();

            foreach (var neighbor in neighbors)
            {
                // DataGridView'e yeni bir satır ekle
                neighborsgridview.Rows.Add(
                    neighbor.Id, 
                    neighbor.Name, 
                    neighbor.Aktiflik.ToString("0.##"), 
                    neighbor.Etkilesim, 
                    neighbor.BaglantiSayisi);
            }

        }

        // Edge bilgilerini gösteren method
        private void showEdgeInfo(Edge edge)
        {

            // edge bilgileri yazdırılır
            grpSelectedNode.Text = "Seçilen edge"; // Label isminize göre güncelleyin

            // Edge için gerekli bilgiler ve bilgileri belirten labeller güncellenir
            lblSelAkt.Text = "KaynakId";
            lblSelEtk.Text = "HedefId";
            lblSelDegree.Visible = false;
            lblSelDegreeValue.Visible = false;

            lblSelIdValue.Text = selected_edge.Id.ToString();
            lblSelAktValue.Text = selected_edge.startNode.Id.ToString();
            lblSelEtkValue.Text = selected_edge.endNode.Id.ToString();


        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(selected_edge == null && selected_node == null)
            {
                MessageBox.Show("Lütfen Düğüm yada Kenar seçiniz" , "Uyarı");
                return;
            }
            else if(selected_edge == null)
            {
                GraphStore.RemoveNode(selected_node);
            }
            else {

                GraphStore.RemoveEdge(selected_edge.startNode , selected_edge.endNode);

            }
        }
    }

}

