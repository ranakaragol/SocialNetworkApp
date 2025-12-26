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
    public partial class EdgesPage : UserControl
    {
        public EdgesPage()
        {
            InitializeComponent();

            // DataGridView Temel Ayarları
            dgvEdges.ReadOnly = true;
            dgvEdges.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEdges.MultiSelect = false;
            dgvEdges.AllowUserToAddRows = false;
            dgvEdges.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Grid tıklandığında bilgileri TextBox getirme
            dgvEdges.SelectionChanged += dgvEdges_SelectionChanged;

            // Merkezi önbellek değişince gridview güncellenir
            GraphStore.GraphChanged += OnGraphChanged;

            // Her sekme değiştirildiğince grid güncellenir 
            this.VisibleChanged += (_, __) =>
            {
                if (this.Visible) RefreshGrid();
            };
        }

        private void OnGraphChanged()
        {
            if (IsHandleCreated)
            {
                BeginInvoke(new Action(() => RefreshGrid()));
            }
        }

        // Sayfa açılınca verileri yazdırma
        private void RefreshGrid()
        {
            dgvEdges.Rows.Clear();
            foreach (var e in GraphStore.Edges)
            {
                // Sütunlar: Edge ID , Başlangıç ID, Bitiş ID, Ağırlık tek tek yazılır
                dgvEdges.Rows.Add(e.Id,e.startNode.Id, e.endNode.Id, e.Weight.ToString("0.####"));
            }
        }

        // Rowa tıklayınca bilgileri textboxlara getiren fonksiyon
        private void dgvEdges_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEdges.SelectedRows.Count > 0)
            {
                // Grid deki seçili satırın hücrelerinden değerleri al
                string id = dgvEdges.SelectedRows[0].Cells[0].Value.ToString();
                string startId = dgvEdges.SelectedRows[0].Cells[1].Value.ToString();
                string endId = dgvEdges.SelectedRows[0].Cells[2].Value.ToString();
                string weight = dgvEdges.SelectedRows[0].Cells[3].Value.ToString();

                // Alınan değerler atanır
                edgeIdValue.Text = id;
                startNodeLabelValue.Text = startId;
                endNodeLabelValue.Text = endId;
                lblWeightValue.Text = weight;
            }
        }

        // Bağlantı ekleme butonu click eventi textboxlardaki bilgilerle yeni bir edge yani bağlantı oluşturur
        private void btnAddEdge_Click(object sender, EventArgs e)
        {
            // TextBox ların boş olup olmadığını kontrol eder
            if (string.IsNullOrWhiteSpace(startNodeLabelValue.Text) ||
                string.IsNullOrWhiteSpace(endNodeLabelValue.Text))
            {
                MessageBox.Show("Lütfen geçerli düğüm ID'leri giriniz.", "Uyarı");
                return;
            }

            try
            {
                int fromId = int.Parse(startNodeLabelValue.Text);
                int toId = int.Parse(endNodeLabelValue.Text);

                Node start = GraphStore.Nodes.FirstOrDefault(x => x.Id == fromId);
                Node end = GraphStore.Nodes.FirstOrDefault(y => y.Id == toId);

                // Eğer girilen id lerle eşleşen düğüm bulamazsa kullanıcıya mesaj verir
                if (start == null || end == null)
                {
                    MessageBox.Show("Girilen id değerleri başlangıç yada bitiş düğümüyle eşleşmiyor.", "Hata");
                    return;
                }

                // Aynı bağlantı varmı kontrolü
                bool alreadyExists = GraphStore.Edges.Any(edge =>
                    (edge.startNode == start && edge.endNode == end) ||
                    (edge.startNode == end && edge.endNode == start));

                // Aynı bağlantı bulunursa kullanıcıya uyarı verilir
                if (alreadyExists)
                {
                    MessageBox.Show("Bu bağlantı zaten mevcut!", "Uyarı");
                    return;
                }
                // Eğer başlangıç ve bitiş düğümünün id si aynıysa yine uyarı verir
                if (start == end)
                {
                    MessageBox.Show("Bir düğüm kendisine bağlanamaz!", "Hata");
                    return;
                }

                // Bağlantıyı ekler
                GraphStore.AddEdge(start, end);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen sadece sayısal ID giriniz.", "Format Hatası");
            }
        }

        // Seçilen bağlantıyı silen fonksiyon
        private void btnDeleteEdge_Click(object sender, EventArgs e)
        {
            if (dgvEdges.SelectedRows.Count > 0)
            {   

                int fromId = Convert.ToInt32(dgvEdges.SelectedRows[0].Cells[1].Value);
                int toId = Convert.ToInt32(dgvEdges.SelectedRows[0].Cells[2].Value);

                Node startnode = GraphStore.Nodes.FirstOrDefault(x => x.Id == fromId);
                Node endnode = GraphStore.Nodes.FirstOrDefault(y => y.Id == toId);

                GraphStore.RemoveEdge(startnode, endnode);

            }
        }
    }
}
