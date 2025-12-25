using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yazlab_2_frontend.Forms.Pages;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace yazlab_2_frontend.Forms
{
    public partial class MainForm : Form
    {

        private readonly Dictionary<PageType, UserControl> Pages = new();

        public MainForm()
        {
            InitializeComponent();
            WireUpMenuEvents();
            InitializePages();

            Navigate(PageType.Dashboard);
            StartClock();
        }

        public enum PageType
        {
            Dashboard,
            GraphView,
            Nodes,
            Edges,
            Algorithms,
            ImportExport,
            Stats
        }

        private void WireUpMenuEvents()
        {

            btnDashboard.Click += (_, __) => Navigate(PageType.Dashboard);
            btnGraphView.Click += (_, __) => Navigate(PageType.GraphView);
            btnNodes.Click += (_, __) => Navigate(PageType.Nodes);
            btnEdges.Click += (_, __) => Navigate(PageType.Edges);
            btnAlgorithms.Click += (_, __) => Navigate(PageType.Algorithms);
            btnImportExport.Click += (_, __) => Navigate(PageType.ImportExport);
            btnStats.Click += (_, __) => Navigate(PageType.Stats);
            btnExit.Click += (_, __) => Close();
        }

        private void InitializePages()

        {
            //Pages
            Pages[PageType.Dashboard] = new DashboardPage();
            Pages[PageType.GraphView] = new GraphViewPage();
            Pages[PageType.Nodes] = new NodesPage();
            Pages[PageType.Edges] = new EdgesPage();
            Pages[PageType.Algorithms] = new AlgorithmsPage();
            Pages[PageType.ImportExport]=new ImportExportPage();
            Pages[PageType.Stats] = new StatsPage();
           
            foreach (var page in Pages.Values)

                page.Dock = DockStyle.Fill;

        }

        private void Navigate(PageType page)

        {

            lblTitle.Text = page switch
            {

                PageType.Dashboard => "Dashboard",
                PageType.GraphView => "Graf Görünümü",
                PageType.Nodes => "Düğümler",
                PageType.Edges => "Bağlantılar",
                PageType.Algorithms => "Algoritmalar",
                PageType.ImportExport => "İçe/Dışa Aktar",
                PageType.Stats => "İstatistikler",
                _ => "Sayfa"

            };

            Log($"Sayfa açıldı: {lblTitle.Text}");
            pnlContent.Controls.Clear();

            if (Pages.TryGetValue(page, out var control))
                pnlContent.Controls.Add(control);

        }

        private void Log(string message)
        {

            if (rtbLog == null) 
                return;

            string line = $"[{DateTime.Now:HH:mm:ss}] {message}";

            rtbLog.AppendText(line + Environment.NewLine);
            rtbLog.ScrollToCaret();

        }


        //güncel zamana bilgisini sayfaya yükleme
        private System.Windows.Forms.Timer _clockTimer;
        private void StartClock()
        {

            if (lblDateTime == null) return;
            _clockTimer = new System.Windows.Forms.Timer();
            _clockTimer.Interval = 1000;
            _clockTimer.Tick += (_, __) =>

            {
                lblDateTime.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            };

            _clockTimer.Start();

        }
        private void pnlCardNodes_Paint(object sender, PaintEventArgs e)
        { }
        private void MainForm_Load(object sender, EventArgs e)
        { }
        private void btnGraphView_Click(object sender, EventArgs e)
        { }
    }
}

