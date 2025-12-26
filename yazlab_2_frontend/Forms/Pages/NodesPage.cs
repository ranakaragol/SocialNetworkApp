using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using yazlab_2_frontend.Models;

namespace yazlab_2_frontend.Forms.Pages
{
    public partial class NodesPage : UserControl
    {
        public NodesPage()
        {
            InitializeComponent();
            InitGrid();

            // Bu sayfanın graphstore deki değişiklikleri dinlemesini sağlar
            GraphStore.GraphChanged += () => {

                if (this.IsHandleCreated)
                {
                    this.BeginInvoke(new Action(RefreshGrid));
                }
            };


            this.VisibleChanged += (s, e) => {
                if (this.Visible)
                {
                    RefreshGrid();
                }
            };

        }
        private void InitGrid()
        {
            dataGridViewNodes.AutoGenerateColumns = false;

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dataGridViewNodes.Rows.Clear();
            foreach (var n in GraphStore.Nodes)
            {
                dataGridViewNodes.Rows.Add(n.Id, n.Name, n.Aktiflik, n.Etkilesim, n.BaglantiSayisi , n.radius , n.NodeRengi);
            }
        }
        private void btnAddNode_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNodeId.Text, out int id))
            {
                MessageBox.Show("Geçerli bir ID giriniz");
                return;
            }

            if (GraphStore.Nodes.Exists(n => n.Id == id))
            {
                MessageBox.Show("Bu ID zaten var");
                return;
            }

            var node = new Node
            {
                Id = id,
                Name = txtNodeName.Text,
                Aktiflik = (double)numericUpDown1.Value,
                Etkilesim = (int)numericUpDown2.Value,
                BaglantiSayisi = 0
            };

            GraphStore.AddNode(node);
            // MessageBox.Show("NodesPage sonrası GraphStore.Nodes.Count = " + GraphStore.Nodes.Count);
            RefreshGrid();
            ClearForm();


        }
        private void ClearForm()
        {
            txtNodeId.Clear();
            txtNodeName.Clear();
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
        }

        private void btnDeleteNode_Click(object sender, EventArgs e)
        {
            if (dataGridViewNodes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silmek için listeden bir düğüm seç.");
                return;
            }

            int id = Convert.ToInt32(dataGridViewNodes.SelectedRows[0].Cells[0].Value);

            Node deleted_node = GraphStore.Nodes.Find(n => n.Id == id);
            
            GraphStore.RemoveNode(deleted_node);   
            RefreshGrid();
            ClearForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dataGridViewNodes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridViewNodes.Rows[e.RowIndex];

            txtNodeId.Text = row.Cells[0].Value?.ToString();
            txtNodeName.Text = row.Cells[1].Value?.ToString();

            numericUpDown1.Value = Convert.ToDecimal(row.Cells[2].Value);
            numericUpDown2.Value = Convert.ToDecimal(row.Cells[3].Value);
        }
    }
}
