using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using yazlab_2_frontend.Models;
using yazlab_2_frontend.Models.JsonModels;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace yazlab_2_frontend.Forms.Pages
{
    public partial class ImportExportPage : UserControl
    {
        public ImportExportPage()
        {
            InitializeComponent();
            // Varsayılan seçimler
            rbJson.Checked = true;
            radioButtonkomsulist.Checked = true;
            checkBoxIncludeNodes.Checked = true;   // Düğümleri dahil et
            checkBoxIncludeEdges.Checked = true;   // Bağlantıları dahil et
            checkBoxIncludeWeights.Checked = true;   // Ağırlıkları dahil et

            // Button eventleri ilgili fonksiyonlara bağlanır
            btnSave.Click += btnSave_Click;
            btnCopy.Click += btnCopy_Click;
            btnClearPreview.Click += btnClearPreview_Click;
            btnBuildAdj.Click += btnBuildAdj_Click;

            rbJson.CheckedChanged += (_, __) => UpdateInfo();
            rbCsv.CheckedChanged += (_, __) => UpdateInfo();

            // Graph değişince UI güncellenir
            GraphStore.GraphChanged += OnGraphChanged;

            // Sayfa görünür olunca güncelle
            this.VisibleChanged += (_, __) =>
            {
                if (this.Visible) UpdateInfo();
            };

            UpdateInfo();
        }

        private void OnGraphChanged()
        {
            if (!IsHandleCreated)
                return;
            BeginInvoke(new Action(UpdateInfo));
        }

        private void UpdateInfo()
        {
            lblFormatInfo.Text = rbJson.Checked ? "Seçili Format: JSON" : "Seçili Format: CSV";
            Log($"Node={GraphStore.Nodes.Count}, Edge={GraphStore.Edges.Count}");
        }

        private void Log(string msg)
        {
            rtbIOLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {msg}\n");
        }

        // KOMŞULUK ÇIKTISI
        private void btnBuildAdj_Click(object sender, EventArgs e)
        {
            if (GraphStore.Nodes.Count == 0)
            {
                rtbPreview.Text = "Node yok.";
                Log("Komşuluk oluşturulamadı: Node yok.");
                return;
            }

            if (radioButtonkomsulist.Checked)
                rtbPreview.Text = BuildAdjList();
            else
                rtbPreview.Text = BuildAdjMatrix();
        }

        private string BuildAdjList()
        {
            var sb = new StringBuilder();
            var nodes = GraphStore.Nodes.OrderBy(n => n.Id).ToList();

            foreach (var n in nodes)
            {
                var neighbors = GraphStore.Edges
                    .Where(e => e.startNode == n || e.endNode == n)
                    .Select(e => e.startNode == n ? e.endNode : e.startNode)
                    .Where(x => x != null)
                    .Distinct()
                    .OrderBy(x => x.Id)
                    .Select(x => x.Id);

                sb.AppendLine($"{n.Id}: {string.Join(", ", neighbors)}");
            }

            Log("Komşuluk listesi oluşturuldu.");
            return sb.ToString();
        }

        private string BuildAdjMatrix()
        {
            var nodes = GraphStore.Nodes.OrderBy(n => n.Id).ToList();
            int nCount = nodes.Count;

            int[,] mat = new int[nCount, nCount];

            var index = nodes
                .Select((node, i) => new { node.Id, i })
                .ToDictionary(x => x.Id, x => x.i);

            foreach (var e in GraphStore.Edges)
            {
                if (e.startNode == null || e.endNode == null) continue;

                int i = index[e.startNode.Id];
                int j = index[e.endNode.Id];

                mat[i, j] = 1;
                mat[j, i] = 1;
            }

            var sb = new StringBuilder();

            sb.Append("   ");
            foreach (var node in nodes) sb.Append($"{node.Id,4}");
            sb.AppendLine();

            for (int r = 0; r < nCount; r++)
            {
                sb.Append($"{nodes[r].Id,3}");
                for (int c = 0; c < nCount; c++)
                    sb.Append($"{mat[r, c],4}");
                sb.AppendLine();
            }

            Log("Komşuluk matrisi oluşturuldu.");
            return sb.ToString();
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog();
            ofd.Filter = rbJson.Checked
                ? "JSON (*.json)|*.json|All Files (*.*)|*.*"
                : "CSV (*.csv)|*.csv|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = ofd.FileName;
                Log($"Dosya seçildi: {ofd.FileName}");
            }

        }
        // Önizleme temizle
        private void btnClearPreview_Click(object sender, EventArgs e)
        {
            rtbPreview.Clear();
            Log("Önizleme temizlendi.");
        }

        // Kopyala
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtbPreview.Text))
            {
                Clipboard.SetText(rtbPreview.Text);
                Log("Önizleme kopyalandı.");
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var path = textBoxFilePath.Text?.Trim();
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
            {
                MessageBox.Show("Geçerli bir dosya seçmelisin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string content = File.ReadAllText(path, Encoding.UTF8);
                rtbPreview.Text = content;

                if (rbJson.Checked)
                    ImportFromJson(content);
                else
                    ImportFromCsv(content);

                // UI refresh için
                GraphStore.NotifyGraphChanged();
                Log("Import OK -> " + Path.GetFileName(path));
            }
            catch (Exception ex)
            {
                Log("Import HATA: " + ex.Message);
                MessageBox.Show(ex.Message, "Import Hatası",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog();
            sfd.Filter = rbJson.Checked
                ? "JSON (*.json)|*.json|All Files (*.*)|*.*"
                : "CSV (*.csv)|*.csv|All Files (*.*)|*.*";

            sfd.FileName = rbJson.Checked ? "graph.json" : "graph.csv";

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                string output = rbJson.Checked ? ExportToJson() : ExportToCsv();
                File.WriteAllText(sfd.FileName, output, Encoding.UTF8);

                textBoxFilePath.Text = sfd.FileName;
                rtbPreview.Text = output;

                Log("Export OK -> " + Path.GetFileName(sfd.FileName));
            }
            catch (Exception ex)
            {
                Log("Export HATA: " + ex.Message);
                MessageBox.Show(ex.Message, "Export Hatası",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        //EXPORT
        private string ExportToJson()
        {
            bool includeNodes = checkBoxIncludeNodes.Checked;
            bool includeEdges = checkBoxIncludeEdges.Checked;
            bool includeWeights = checkBoxIncludeWeights.Checked;

            var graph = new JsonGraph
            {
                nodes = includeNodes
                    ? GraphStore.Nodes.Select(n => new JsonNode
                    {
                        id = n.Id,
                        name = n.Name,
                        aktiflik = n.Aktiflik,
                        etkilesim = n.Etkilesim,
                        baglantiSayisi = n.BaglantiSayisi,
                        radius = n.radius,
                        nodeRengi = ColorToHex(n.NodeRengi)
                    }).ToList()
                    : null,

                edges = includeEdges
                 ? GraphStore.Edges
                    .Where(e => e.startNode != null && e.endNode != null)
                    .Select(e => new JsonEdge
                    {
                        id = e.Id,
                        from = e.startNode.Id,
                        to = e.endNode.Id,
                        weight = includeWeights ? e.Weight : (double?)null
                    }).ToList()
                    : null
            };

            var opt = new JsonSerializerOptions
            {
                WriteIndented = checkBoxJsonIndented.Checked // JSON girintili
            };

            return JsonSerializer.Serialize(graph, opt);
        }

        private string ExportToCsv()
        {
            bool includeNodes = checkBoxIncludeNodes.Checked;
            bool includeEdges = checkBoxIncludeEdges.Checked;
            bool includeWeights = checkBoxIncludeWeights.Checked;

            var sb = new StringBuilder();

            // Nodes bölümü
            if (includeNodes)
            {
                sb.AppendLine("#NODES");
                sb.AppendLine("id,name,aktiflik,etkilesim,baglantiSayisi,radius,nodeRengi");

                foreach (var n in GraphStore.Nodes.OrderBy(x => x.Id))
                {
                    sb.AppendLine($"{n.Id},{CsvEscape(n.Name)}," +
                          $"{n.Aktiflik.ToString(System.Globalization.CultureInfo.InvariantCulture)}," +
                          $"{n.Etkilesim}," +
                          $"{n.BaglantiSayisi}," +
                          $"{n.radius.ToString(System.Globalization.CultureInfo.InvariantCulture)}," +
                          $"{ColorToHex(n.NodeRengi)}");
                }
                sb.AppendLine();
            }

            // Edges bölümü
            if (includeEdges)
            {
                sb.AppendLine("#EDGES");
                sb.AppendLine(includeWeights ? "id,from,to,weight" : "id,from,to");

                foreach (var e in GraphStore.Edges.Where(x => x.startNode != null && x.endNode != null))
                {
                    if (includeWeights)
                        sb.AppendLine($"{e.Id},{e.startNode.Id},{e.endNode.Id}," +
                                      $"{e.Weight.ToString(System.Globalization.CultureInfo.InvariantCulture)}");
                    else
                        sb.AppendLine($"{e.Id},{e.startNode.Id},{e.endNode.Id}");
                }
            }

            return sb.ToString();
        }

        private string CsvEscape(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            if (s.Contains(',') || s.Contains('"') || s.Contains('\n') || s.Contains('\r'))
                return "\"" + s.Replace("\"", "\"\"") + "\"";
            return s;
        }


        private void ImportFromJson(string json)
        {
            var data = JsonSerializer.Deserialize<JsonGraph>(json);
            if (data == null) throw new Exception("JSON parse edilemedi.");

            GraphStore.Nodes.Clear();
            GraphStore.Edges.Clear();

            // Nodes
            if (data.nodes != null)
            {
                foreach (var n in data.nodes)
                {
                    GraphStore.Nodes.Add(new Node
                    {
                        Id = n.id,
                        Name = n.name ?? "",
                        Aktiflik = n.aktiflik,
                        Etkilesim = n.etkilesim,
                        BaglantiSayisi = 0,
                        radius = n.radius,
                        NodeRengi = HexToColor(n.nodeRengi)
                    });
                }
            }

            // Edges
            if (data.edges != null)
            {
                foreach (var e in data.edges)
                {
                    var a = GraphStore.Nodes.FirstOrDefault(x => x.Id == e.from);
                    var b = GraphStore.Nodes.FirstOrDefault(x => x.Id == e.to);
                    if (a == null || b == null) continue;

                    double w = e.weight ?? GraphStore.ComputeWeight(a, b);

                    GraphStore.Edges.Add(new Edge
                    {
                        Id = e.id,
                        startNode = a,
                        endNode = b,
                        Weight = w
                    });
                }
            }

            // Dereceyi gerçek edge listesine göre günceller
            foreach (var node in GraphStore.Nodes)
                node.BaglantiSayisi = node.GetDegree(GraphStore.Edges);

            GraphStore.SyncIdCountersFromData();
            Log("JSON import edildi.");
        }

        private void ImportFromCsv(string csv)
        {
            GraphStore.Nodes.Clear();
            GraphStore.Edges.Clear();

            using var sr = new StringReader(csv);

            string mode = "";
            bool headerSkipped = false;
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                line = line.Trim();
                if (line.Length == 0) continue;

                if (line.StartsWith("#"))
                {
                    mode = line; // #NODES / #EDGES şeklinde yazar
                    headerSkipped = false;
                    continue;
                }

                if (!headerSkipped)
                {
                    headerSkipped = true; // header satırını atla
                    continue;
                }

                var parts = SplitCsv(line);

                if (mode == "#NODES")
                {
                    // id,name,aktiflik,etkilesim,baglantiSayisi,radius,nodeRengi
                    if (parts.Length < 7) continue;

                    GraphStore.Nodes.Add(new Node
                    {
                        Id = int.Parse(parts[0]),
                        Name = parts[1] ?? "",
                        Aktiflik = double.Parse(parts[2], CultureInfo.InvariantCulture),
                        Etkilesim = int.Parse(parts[3], CultureInfo.InvariantCulture),
                        BaglantiSayisi = 0, // aşağıda hesaplanacak
                        radius = float.Parse(parts[5], CultureInfo.InvariantCulture),
                        NodeRengi = HexToColor(parts[6]),
                    });
                }
                else if (mode == "#EDGES")
                {
                    // id,from,to,(weight)
                    if (parts.Length < 3) continue;

                    int id = int.Parse(parts[0]);
                    int from = int.Parse(parts[1]);
                    int to = int.Parse(parts[2]);

                    var a = GraphStore.Nodes.FirstOrDefault(x => x.Id == from);
                    var b = GraphStore.Nodes.FirstOrDefault(x => x.Id == to);
                    if (a == null || b == null) continue;

                    double w = (parts.Length >= 4)
                        ? double.Parse(parts[3], CultureInfo.InvariantCulture)
                        : GraphStore.ComputeWeight(a, b);

                    GraphStore.Edges.Add(new Edge
                    {
                        Id = id,
                        startNode = a,
                        endNode = b,
                        Weight = w
                    });
                }
            }

            foreach (var node in GraphStore.Nodes)
                node.BaglantiSayisi = node.GetDegree(GraphStore.Edges);

            GraphStore.SyncIdCountersFromData();
            Log("CSV import edildi.");
        }

        private string[] SplitCsv(string line)
        {
            var list = new System.Collections.Generic.List<string>();
            var sb = new StringBuilder();
            bool inQuotes = false;

            for (int i = 0; i < line.Length; i++)
            {
                char ch = line[i];

                if (ch == '"')
                {
                    if (inQuotes && i + 1 < line.Length && line[i + 1] == '"')
                    {
                        sb.Append('"');
                        i++;
                    }
                    else
                    {
                        inQuotes = !inQuotes;
                    }
                }
                else if (ch == ',' && !inQuotes)
                {
                    list.Add(sb.ToString());
                    sb.Clear();
                }
                else
                {
                    sb.Append(ch);
                }
            }

            list.Add(sb.ToString());
            return list.ToArray();
        }

        private string ColorToHex(Color color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }
        private Color HexToColor(string hex)
        {
            if (string.IsNullOrWhiteSpace(hex))
                return Color.Black;

            return ColorTranslator.FromHtml(hex);
        }

    }

}

