using System;
using System.Linq;
using System.Windows.Forms;
using yazlab_2_frontend.Models;
using yazlab_2_frontend.Algorithms; // Algoritmaları kullanmak için ekle

namespace yazlab_2_frontend.Forms.Pages
{
    public partial class StatsPage : UserControl
    {
        public StatsPage()
        {
            InitializeComponent();

            // Sayfa ilk açılınca veriler yüklenir
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

        private void UpdateStats()
        {
            //Düğüm ve kenar sayıları alınır
            int nodeCount = GraphStore.Nodes.Count;
            int edgeCount = GraphStore.Edges.Count;

            // Etiketlere yazdırılır
            labelNodesValue.Text = nodeCount.ToString();
            labelEdgesValue.Text = edgeCount.ToString();

            // 2. Bağlı Bileşen Sayısı (Adalar)
            var components = GraphAlgorithms.ConnectedComponents_Algorithm(GraphStore.Nodes, GraphStore.Edges);
            labelComponentValue.Text = components.Count.ToString();

            // --- 3. YOĞUNLUK HESAPLAMA ---
            if (nodeCount < 2)
            {
                // Tek düğüm varsa yada hiç düğüm yoksa yoğunluk hesaplanmaz
                labelDensityValue.Text = "0";
            }
            else
            {
                // Maksimum olabilecek kenar sayısı: n * (n-1) / 2
                double maxEdges = (double)nodeCount * (nodeCount - 1) / 2;

              
                double density = edgeCount / maxEdges;
                labelDensityValue.Text = density.ToString("0.##");

 
            }


            var topNodes = GraphStore.Nodes
        .Select(n => new
        {
            NodeObj = n,
            Degree = GraphStore.Edges.Count(e => e.startNode == n || e.endNode == n)
        })
        .OrderByDescending(x => x.Degree)
        .Take(5)
        .ToList();

            dgvTopDegree.Rows.Clear();

            foreach (var item in topNodes)
            {

                dgvTopDegree.Rows.Add(item.NodeObj.Id, item.NodeObj.Name, item.Degree);

         
            }
        }
    }
}