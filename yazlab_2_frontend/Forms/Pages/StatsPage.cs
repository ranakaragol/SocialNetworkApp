using System;
using System.Drawing; // Color için gerekli
using System.Linq;
using System.Windows.Forms;
using yazlab_2_frontend.Models;
using yazlab_2_frontend.Algorithms;
using System.Windows.Forms.DataVisualization.Charting;

namespace yazlab_2_frontend.Forms.Pages
{
    public partial class StatsPage : UserControl
    {
        public StatsPage()
        {
            InitializeComponent();

            // chart ayar fonksiyonları çağrılır
            ConfigureCharts();
            InitGrid();

            // sayfa ilk açılınca veriler yüklenir
            UpdateStats();

            
            GraphStore.GraphChanged += () =>
            {
                if (this.IsHandleCreated)
                {
                    this.BeginInvoke(new Action(UpdateStats));
                }
            };

            // Sekme değişip geri geldiğince güncellenir
            this.VisibleChanged += (s, e) =>
            {
                if (this.Visible) UpdateStats();
            };
        }

        // 
        private void InitGrid()
        {
            
            dgvTopDegree.Columns.Clear();

            
            dgvTopDegree.ColumnCount = 4;

            dgvTopDegree.Columns[0].Name = "Sıra";
            dgvTopDegree.Columns[1].Name = "Düğüm ID";
            dgvTopDegree.Columns[2].Name = "İsim";
            dgvTopDegree.Columns[3].Name = "Derece";

            dgvTopDegree.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTopDegree.RowHeadersVisible = false;
            dgvTopDegree.AllowUserToAddRows = false;
            dgvTopDegree.ReadOnly = true;
            dgvTopDegree.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void UpdateStats()
        {
            // Düğüm ve kenar sayıları alınır
            int nodeCount = GraphStore.Nodes.Count;
            int edgeCount = GraphStore.Edges.Count;

            // Etiketlere yazdırılır
            labelNodesValue.Text = nodeCount.ToString();
            labelEdgesValue.Text = edgeCount.ToString();

            // Bağlı bileşen sayısı bulunur
            var components = GraphAlgorithms.ConnectedComponents_Algorithm(GraphStore.Nodes, GraphStore.Edges);
            labelComponentValue.Text = components.Count.ToString();

            // Yoğunluk hesaplama
            if (nodeCount < 2)
            {
                labelDensityValue.Text = "0";
            }
            else
            {
                double maxEdges = (double)nodeCount * (nodeCount - 1) / 2;
                double density = edgeCount / maxEdges;
                labelDensityValue.Text = density.ToString("0.##");
            }

            // En Yüksek Dereceli 10 Düğüm
            var topNodes = GraphStore.Nodes.Select(n => new
            {
                NodeObj = n,
                Degree = GraphStore.Edges.Count(e => e.startNode == n || e.endNode == n)
            })
            .OrderByDescending(x => x.Degree)
            .Take(10)
            .ToList();

            dgvTopDegree.Rows.Clear();

            int rank = 1;
            foreach (var item in topNodes)
            {
                // Sıra, ID, İsim, Derece
                dgvTopDegree.Rows.Add(rank, item.NodeObj.Id, item.NodeObj.Name, item.Degree);
                rank++;
            }

            // Grafikleri güncelle
            UpdateChartNodeData();
            UpdateChartDistData();
        }

        private void UpdateChartNodeData()
        {
            var nodeStats = GraphStore.Nodes
                .Select(n => new
                {
                    Id = n.Id,
                    Degree = GraphStore.Edges.Count(e => e.startNode == n || e.endNode == n)
                })
                .OrderBy(x => x.Id)
                .ToList();

            // Degrees serisi daha önce configurecharts da tanımlanmıştı
            if (chartNodeDegrees.Series.IndexOf("Degrees") != -1)
            {
                chartNodeDegrees.Series["Degrees"].Points.Clear();
                foreach (var item in nodeStats)
                {
                    chartNodeDegrees.Series["Degrees"].Points.AddXY(item.Id, item.Degree);
                }
            }
        }

        private void UpdateChartDistData()
        {
            var distribution = GraphStore.Nodes
                .Select(n => GraphStore.Edges.Count(e => e.startNode == n || e.endNode == n))
                .GroupBy(degree => degree)
                .OrderBy(g => g.Key)
                .ToDictionary(g => g.Key, g => g.Count());

            // Dist seriside aynı şekil configurecharts da tanımlandı
            if (chartDistribution.Series.IndexOf("Dist") != -1)
            {
                chartDistribution.Series["Dist"].Points.Clear();
                foreach (var item in distribution)
                {
                    chartDistribution.Series["Dist"].Points.AddXY(item.Key, item.Value);
                }
            }
        }

        private void ConfigureCharts()
        {
            // Düğüm dereceleri grafik ayarı
            chartNodeDegrees.Series.Clear();
            chartNodeDegrees.Titles.Clear();
            chartNodeDegrees.ChartAreas.Clear();

            ChartArea area1 = new ChartArea("MainArea");
            area1.AxisX.Interval = 1;
            area1.AxisX.MajorGrid.LineColor = Color.LightGray;
            area1.AxisY.MajorGrid.LineColor = Color.LightGray;
            area1.AxisX.Title = "Düğüm ID";
            area1.AxisY.Title = "Derece";
            chartNodeDegrees.ChartAreas.Add(area1);

            chartNodeDegrees.Titles.Add("Düğüm Popülerliği");
            chartNodeDegrees.Titles[0].Font = new Font("Arial", 10, FontStyle.Bold);

            Series s1 = new Series("Degrees");
            s1.ChartType = SeriesChartType.Column;
            s1.Color = Color.SteelBlue;
            s1.IsValueShownAsLabel = true;
            chartNodeDegrees.Series.Add(s1);

            // Grafik Ayarı
            chartDistribution.Series.Clear();
            chartDistribution.Titles.Clear();
            chartDistribution.ChartAreas.Clear();

            ChartArea area2 = new ChartArea("DistArea");
            area2.AxisX.MajorGrid.LineColor = Color.LightGray;
            area2.AxisY.MajorGrid.LineColor = Color.LightGray;
            area2.AxisX.Title = "Derece (Bağlantı Sayısı)";
            area2.AxisY.Title = "Kişi Sayısı";
            chartDistribution.ChartAreas.Add(area2);

            chartDistribution.Titles.Add("Bağlantı Dağılımı");
            chartDistribution.Titles[0].Font = new Font("Arial", 10, FontStyle.Bold);

            Series s2 = new Series("Dist");
            s2.ChartType = SeriesChartType.Column;
            s2.Color = Color.Coral;
            s2.IsValueShownAsLabel = true;
            chartDistribution.Series.Add(s2);
        }
    }
}