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







            // Grid temel ayar

            dgvEdges.ReadOnly = true;

            dgvEdges.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvEdges.MultiSelect = false;

            dgvEdges.AllowUserToAddRows = false;



            // İlk yükleme

            //RefreshCombos();

            //RefreshGrid();

            //ShowPreviewWeight();



            // Node/Edge değişince otomatik güncelle

            GraphStore.GraphChanged += OnGraphChanged;



            this.VisibleChanged += (_, __) =>

            {

                if (this.Visible)

                {



                    RefreshCombos();

                    RefreshGrid();

                    ShowPreviewWeight();

                }

            };





            // Seçim değişince weight önizle

            cmbFrom.SelectedIndexChanged += (_, __) => ShowPreviewWeight();

            cmbTo.SelectedIndexChanged += (_, __) => ShowPreviewWeight();



            // Butonlar

            btnAddEdge.Click += btnAddEdge_Click;

            btnDeleteEdge.Click += btnDeleteEdge_Click;

            ClearForm();



        }





        private void OnGraphChanged()

        {

            if (!IsHandleCreated)

            {

                // Handle yoksa şimdi yapamıyoruz, sayfa açılınca VisibleChanged yakalayacak.

                return;

            }



            BeginInvoke(new Action(() =>

            {

                RefreshCombos();

                RefreshGrid();

                ShowPreviewWeight();

            }));

        }



        private void RefreshCombos()

        {

            cmbFrom.BeginUpdate();

            cmbTo.BeginUpdate();



            cmbFrom.Items.Clear();

            cmbTo.Items.Clear();



            foreach (var n in GraphStore.Nodes.OrderBy(x => x.Id))

            {

                cmbFrom.Items.Add(n.Id);

                cmbTo.Items.Add(n.Id);

            }



            cmbFrom.EndUpdate();

            cmbTo.EndUpdate();



            if (cmbFrom.Items.Count > 0) cmbFrom.SelectedIndex = 0;

            if (cmbTo.Items.Count > 0) cmbTo.SelectedIndex = 0;

        }



        private void RefreshGrid()

        {

            MessageBox.Show("Edges count=" + GraphStore.Edges.Count + " | Grid cols=" + dgvEdges.Columns.Count);



            dgvEdges.Rows.Clear();



            foreach (var e in GraphStore.Edges)

                dgvEdges.Rows.Add(e.startNode.Id, e.endNode.Id, e.Weight.ToString("0.####"));

        }

        private void ShowPreviewWeight()

        {

            if (cmbFrom.SelectedItem == null || cmbTo.SelectedItem == null)

            {

                lblWeightValue.Text = "-";

                return;

            }



            int a = (int)cmbFrom.SelectedItem;

            int b = (int)cmbTo.SelectedItem;

            Node startnode = GraphStore.Nodes.FirstOrDefault(x => x.Id == a);
            Node endnode = GraphStore.Nodes.FirstOrDefault(y => y.Id == b);


            if (a == b)

            {

                lblWeightValue.Text = "Self-loop yok";

                return;

            }



            lblWeightValue.Text = GraphStore.ComputeWeight(startnode, endnode).ToString("0.####");

        }

        private void EdgesPage_Load(object sender, EventArgs e)

        {



        }



        private void btnAddEdge_Click(object sender, EventArgs e)

        {

            if (cmbFrom.SelectedItem == null || cmbTo.SelectedItem == null) return;



            int a = (int)cmbFrom.SelectedItem;

            int b = (int)cmbTo.SelectedItem;

            Node startnode = GraphStore.Nodes.FirstOrDefault(x => x.Id == a);
            Node endnode = GraphStore.Nodes.FirstOrDefault(y => y.Id == b);




            try { GraphStore.AddEdge(startnode, endnode); }

            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }



        private void btnDeleteEdge_Click(object sender, EventArgs e)

        {
            Node startnode = GraphStore.Nodes.FirstOrDefault(x => x.Id == (int)cmbFrom.SelectedItem);
            Node endnode = GraphStore.Nodes.FirstOrDefault(y => y.Id == (int)cmbTo.SelectedItem);

            // Grid’den seçili edge varsa onu sil

            if (dgvEdges.SelectedRows.Count > 0)

            {

                int a = Convert.ToInt32(dgvEdges.SelectedRows[0].Cells[0].Value);

                int b = Convert.ToInt32(dgvEdges.SelectedRows[0].Cells[1].Value);




                GraphStore.RemoveEdge(startnode, endnode);

                return;

            }



            if (cmbFrom.SelectedItem == null || cmbTo.SelectedItem == null) return;



            GraphStore.RemoveEdge(startnode , endnode) ;

        }

        private void ClearForm()

        {

            if (cmbFrom.Items.Count > 0) cmbFrom.SelectedIndex = 0;

            if (cmbTo.Items.Count > 0) cmbTo.SelectedIndex = 0;

            lblWeightValue.Text = "-";

        }

    }

}
