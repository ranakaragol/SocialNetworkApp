using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yazlab_2_frontend.Models;

namespace yazlab_2_frontend.Forms.Pages
{
    public partial class ImportExportPage : UserControl
    {
        public ImportExportPage()
        {
            InitializeComponent();
            // Varsayılan seçimler (istersen kaldır)
            rbJson.Checked = true;
            radioButtonkomsulist.Checked = true;
            checkBox1.Checked = true;   // Düğümleri dahil et
            checkBox2.Checked = true;   // Bağlantıları dahil et
            checkBox3.Checked = true;   // Ağırlıkları dahil et

            // Sayfa görünür olunca güncelle
            this.VisibleChanged += (_, __) =>
            {
                if (this.Visible)
                    UpdateInfo();
            };

            // Graph değişince güncelle
            GraphStore.GraphChanged += () =>
            {
                if (!IsHandleCreated) return;
                BeginInvoke(new Action(UpdateInfo));
            };

            // Seçimler değişince üst bilgi güncellensin
            rbJson.CheckedChanged += (_, __) => UpdateInfo();
            rbCsv.CheckedChanged += (_, __) => UpdateInfo();

            // Komşuluk oluştur butonu
            btnBuildAdj.Click += BtnBuildAdj_Click;

            UpdateInfo();
        }

        // Üst bilgi + log
        private void UpdateInfo()
        {
            lblFormatInfo.Text = rbJson.Checked ? "Seçili Format: JSON" : "Seçili Format: CSV";

            rtbIOLog.AppendText(
                $"[{DateTime.Now:HH:mm:ss}] Node={GraphStore.Nodes.Count}, Edge={GraphStore.Edges.Count}\n");
        }

        // Komşuluk çıktısı
        private void BtnBuildAdj_Click(object sender, EventArgs e)
        {
            if (GraphStore.Nodes.Count == 0)
            {
                rtbPreview.Text = "Node yok.";
                return;
            }

            if (radioButtonkomsulist.Checked)
                rtbPreview.Text = BuildAdjList();
            else
                rtbPreview.Text = BuildAdjMatrix();
        }

        // Komşuluk Listesi (ID bazlı yazdırıyoruz)
        private string BuildAdjList()
        {
            var sb = new StringBuilder();

            var nodes = GraphStore.Nodes.OrderBy(n => n.Id).ToList();

            foreach (var n in nodes)
            {
                var neighbors = GraphStore.Edges
                    .Where(e => e.startNode == n || e.endNode == n)
                    .Select(e => e.startNode == n ? e.endNode : e.startNode)
                    .Distinct()
                    .OrderBy(x => x.Id)
                    .Select(x => x.Id);

                sb.AppendLine($"{n.Id}: {string.Join(", ", neighbors)}");
            }

            return sb.ToString();
        }

        // Komşuluk Matrisi (undirected 0/1)
        private string BuildAdjMatrix()
        {
            var nodes = GraphStore.Nodes.OrderBy(n => n.Id).ToList();
            int nCount = nodes.Count;

            int[,] mat = new int[nCount, nCount];

            // id->index
            var index = nodes
                .Select((node, i) => new { node.Id, i })
                .ToDictionary(x => x.Id, x => x.i);

            foreach (var e in GraphStore.Edges)
            {
                // startNode/endNode null gelmesin diye güvenli yazalım
                if (e.startNode == null || e.endNode == null) continue;

                int i = index[e.startNode.Id];
                int j = index[e.endNode.Id];

                mat[i, j] = 1;
                mat[j, i] = 1;
            }

            var sb = new StringBuilder();

            // header
            sb.Append("   ");
            foreach (var node in nodes)
                sb.Append($"{node.Id,4}");
            sb.AppendLine();

            // rows
            for (int r = 0; r < nCount; r++)
            {
                sb.Append($"{nodes[r].Id,3}");
                for (int c = 0; c < nCount; c++)
                    sb.Append($"{mat[r, c],4}");
                sb.AppendLine();
            }

            return sb.ToString();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

        }
        // Önizleme temizle
        private void btnClearPreview_Click(object sender, EventArgs e)
        {
            rtbPreview.Clear();
        }

        // Kopyala
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtbPreview.Text))
                Clipboard.SetText(rtbPreview.Text);
        }
    }
}
