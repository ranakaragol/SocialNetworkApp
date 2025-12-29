using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yazlab_2_frontend.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace yazlab_2_frontend.Forms.Pages
{
    public partial class DashboardPage : UserControl
    {
        public event Action<MainForm.PageType>? NavigateRequested;
        public DashboardPage()
        {
            InitializeComponent();

            GraphStore.GraphChanged += OnGraphChanged;

            this.HandleDestroyed += (_, __) =>
            {
                GraphStore.GraphChanged -= OnGraphChanged;
            };

            // İlk açılışta da güncelle
            this.Load += (_, __) => RefreshSummary();
            this.VisibleChanged += (_, __) => { if (this.Visible) RefreshSummary(); };

        }
        private void OnGraphChanged()
        {
            if (!IsHandleCreated) return;

            // UI thread
            BeginInvoke(new Action(() =>
            {
                RefreshSummary();
                AppendLog("Graf güncellendi.");
            }));
        }
        private void RefreshSummary()
        {
            // Toplam düğüm/bağlantı
            lblNodesValue.Text = GraphStore.Nodes.Count.ToString();
            lblEdgesValue.Text = GraphStore.Edges.Count.ToString();

            // Bağlı bileşen sayısı (component)
            lblComponentsValue.Text = CountConnectedComponents().ToString();

            // En yüksek derece
            lblTopDegreeValue.Text = GetMaxDegree().ToString();
        }
        private int GetMaxDegree()
        {
            // En yüksek dereceyi bulur
            if (GraphStore.Nodes.Count == 0) return 0;
            return GraphStore.Nodes.Max(n => n.GetDegree(GraphStore.Edges));
     
        }

        private int CountConnectedComponents()
        {
            // Graf boşsa makineyi yormadan 0 bileşen diyebiliriz 
            if (GraphStore.Nodes.Count == 0) return 0;

            var visited = new System.Collections.Generic.HashSet<int>();
            int components = 0;

            foreach (var node in GraphStore.Nodes)
            {
                if (visited.Contains(node.Id)) continue;

                components++;
                var q = new System.Collections.Generic.Queue<Node>();
                q.Enqueue(node);
                visited.Add(node.Id);

                while (q.Count > 0)
                {
                    var cur = q.Dequeue();

                    
                    foreach (var edge in GraphStore.Edges)
                    {
                        Node? neighbor = null;
                        if (edge.startNode == cur) neighbor = edge.endNode;
                        else if (edge.endNode == cur) neighbor = edge.startNode;

                        if (neighbor != null && !visited.Contains(neighbor.Id))
                        {
                            visited.Add(neighbor.Id);
                            q.Enqueue(neighbor);
                        }
                    }
                }
            }

            return components;
        }
        private void AppendLog(string message)
        {
            if (rtbLog == null) return;
            rtbLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}{Environment.NewLine}");
            rtbLog.ScrollToCaret();
        }

        private void DashboardPage_Load(object sender, EventArgs e)
        {
        }

        private void BtnAddNode_Click(object sender, EventArgs e)
        {
            NavigateRequested?.Invoke(MainForm.PageType.Nodes);
        }

        private void ButtonAddEdge_Click(object sender, EventArgs e)
        {
            NavigateRequested?.Invoke(MainForm.PageType.Edges);
        }

        private void ButtonRunAlgorithms_Click(object sender, EventArgs e)
        {
            NavigateRequested?.Invoke(MainForm.PageType.Algorithms);
        }

        private void ButtonImportExport_Click(object sender, EventArgs e)
        {
            NavigateRequested?.Invoke(MainForm.PageType.ImportExport);
        }
    }
}
