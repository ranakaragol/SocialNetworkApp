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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace yazlab_2_frontend.Forms.Pages
{
    public partial class DashboardPage : UserControl
    {
        // MainForm bunu dinleyecek
        public event Action<string> NavigateRequested;
        public DashboardPage()
        {
            InitializeComponent();

        }

        private void DashboardPage_Load(object sender, EventArgs e)
        {
        }

        private void BtnAddNode_Click(object sender, EventArgs e)
        {
            NavigateRequested?.Invoke("Nodes");
        }

        private void ButtonAddEdge_Click(object sender, EventArgs e)
        {
            NavigateRequested?.Invoke("Edges");
        }

        private void ButtonRunAlgorithms_Click(object sender, EventArgs e)
        {
            NavigateRequested?.Invoke("Algorithms");
        }

        private void ButtonImportExport_Click(object sender, EventArgs e)
        {
            NavigateRequested?.Invoke("ImportExport");
        }
    }
}
