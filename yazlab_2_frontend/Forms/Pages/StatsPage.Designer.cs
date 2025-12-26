namespace yazlab_2_frontend.Forms.Pages
{
    partial class StatsPage
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            tlpSummary = new TableLayoutPanel();
            panelCardNodes = new Panel();
            labelNodesValue = new Label();
            label1 = new Label();
            panelCardEdges = new Panel();
            label3 = new Label();
            labelEdgesValue = new Label();
            panelCardComponents = new Panel();
            label5 = new Label();
            labelComponentValue = new Label();
            pnlCardDensity = new Panel();
            label7 = new Label();
            labelDensityValue = new Label();
            splitStatsMain = new SplitContainer();
            grpTopDegree = new GroupBox();
            dgvTopDegree = new DataGridView();
            colNodeId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colDegree = new DataGridViewTextBoxColumn();
            tabStats = new TabControl();
            tabChart = new TabPage();
            grpCharts = new GroupBox();
            panelChartPlaceholder = new Panel();
            label2 = new Label();
            tabTimes = new TabPage();
            dgvTimes = new DataGridView();
            colAlgo = new DataGridViewTextBoxColumn();
            colMsSmall = new DataGridViewTextBoxColumn();
            colMsMedium = new DataGridViewTextBoxColumn();
            colNotes = new DataGridViewTextBoxColumn();
            grpStatsLog = new GroupBox();
            rtbStatsLog = new RichTextBox();
            tlpSummary.SuspendLayout();
            panelCardNodes.SuspendLayout();
            panelCardEdges.SuspendLayout();
            panelCardComponents.SuspendLayout();
            pnlCardDensity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitStatsMain).BeginInit();
            splitStatsMain.Panel1.SuspendLayout();
            splitStatsMain.Panel2.SuspendLayout();
            splitStatsMain.SuspendLayout();
            grpTopDegree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTopDegree).BeginInit();
            tabStats.SuspendLayout();
            tabChart.SuspendLayout();
            grpCharts.SuspendLayout();
            panelChartPlaceholder.SuspendLayout();
            tabTimes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTimes).BeginInit();
            grpStatsLog.SuspendLayout();
            SuspendLayout();
            // 
            // tlpSummary
            // 
            tlpSummary.ColumnCount = 4;
            tlpSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.00111F));
            tlpSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0039482F));
            tlpSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.996439F));
            tlpSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9985065F));
            tlpSummary.Controls.Add(panelCardNodes, 0, 0);
            tlpSummary.Controls.Add(panelCardEdges, 1, 0);
            tlpSummary.Controls.Add(panelCardComponents, 2, 0);
            tlpSummary.Controls.Add(pnlCardDensity, 3, 0);
            tlpSummary.Dock = DockStyle.Top;
            tlpSummary.Location = new Point(0, 0);
            tlpSummary.Margin = new Padding(3, 4, 3, 4);
            tlpSummary.Name = "tlpSummary";
            tlpSummary.RowCount = 1;
            tlpSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSummary.Size = new Size(1026, 147);
            tlpSummary.TabIndex = 0;
            // 
            // panelCardNodes
            // 
            panelCardNodes.BorderStyle = BorderStyle.FixedSingle;
            panelCardNodes.Controls.Add(labelNodesValue);
            panelCardNodes.Controls.Add(label1);
            panelCardNodes.Dock = DockStyle.Fill;
            panelCardNodes.Font = new Font("Segoe UI", 10F);
            panelCardNodes.Location = new Point(9, 11);
            panelCardNodes.Margin = new Padding(9, 11, 9, 11);
            panelCardNodes.Name = "panelCardNodes";
            panelCardNodes.Size = new Size(238, 125);
            panelCardNodes.TabIndex = 0;
            // 
            // labelNodesValue
            // 
            labelNodesValue.AutoSize = true;
            labelNodesValue.Font = new Font("Segoe UI", 12F);
            labelNodesValue.Location = new Point(31, 71);
            labelNodesValue.Name = "labelNodesValue";
            labelNodesValue.Size = new Size(23, 28);
            labelNodesValue.TabIndex = 1;
            labelNodesValue.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 31);
            label1.Name = "label1";
            label1.Size = new Size(127, 23);
            label1.TabIndex = 0;
            label1.Text = "Toplam Düğüm";
            // 
            // panelCardEdges
            // 
            panelCardEdges.BorderStyle = BorderStyle.FixedSingle;
            panelCardEdges.Controls.Add(label3);
            panelCardEdges.Controls.Add(labelEdgesValue);
            panelCardEdges.Dock = DockStyle.Fill;
            panelCardEdges.Font = new Font("Segoe UI", 10F);
            panelCardEdges.Location = new Point(265, 11);
            panelCardEdges.Margin = new Padding(9, 11, 9, 11);
            panelCardEdges.Name = "panelCardEdges";
            panelCardEdges.Size = new Size(238, 125);
            panelCardEdges.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 31);
            label3.Name = "label3";
            label3.Size = new Size(132, 23);
            label3.TabIndex = 3;
            label3.Text = "Toplam Bağlantı";
            // 
            // labelEdgesValue
            // 
            labelEdgesValue.AutoSize = true;
            labelEdgesValue.Font = new Font("Segoe UI", 12F);
            labelEdgesValue.Location = new Point(39, 71);
            labelEdgesValue.Name = "labelEdgesValue";
            labelEdgesValue.Size = new Size(23, 28);
            labelEdgesValue.TabIndex = 2;
            labelEdgesValue.Text = "0";
            // 
            // panelCardComponents
            // 
            panelCardComponents.BorderStyle = BorderStyle.FixedSingle;
            panelCardComponents.Controls.Add(label5);
            panelCardComponents.Controls.Add(labelComponentValue);
            panelCardComponents.Dock = DockStyle.Fill;
            panelCardComponents.Font = new Font("Segoe UI", 10F);
            panelCardComponents.Location = new Point(521, 11);
            panelCardComponents.Margin = new Padding(9, 11, 9, 11);
            panelCardComponents.Name = "panelCardComponents";
            panelCardComponents.Size = new Size(238, 125);
            panelCardComponents.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 31);
            label5.Name = "label5";
            label5.Size = new Size(105, 23);
            label5.TabIndex = 3;
            label5.Text = "Bağlı Bileşen";
            // 
            // labelComponentValue
            // 
            labelComponentValue.AutoSize = true;
            labelComponentValue.Font = new Font("Segoe UI", 12F);
            labelComponentValue.Location = new Point(35, 71);
            labelComponentValue.Name = "labelComponentValue";
            labelComponentValue.Size = new Size(23, 28);
            labelComponentValue.TabIndex = 2;
            labelComponentValue.Text = "0";
            // 
            // pnlCardDensity
            // 
            pnlCardDensity.BorderStyle = BorderStyle.FixedSingle;
            pnlCardDensity.Controls.Add(label7);
            pnlCardDensity.Controls.Add(labelDensityValue);
            pnlCardDensity.Dock = DockStyle.Fill;
            pnlCardDensity.Font = new Font("Segoe UI", 10F);
            pnlCardDensity.Location = new Point(777, 11);
            pnlCardDensity.Margin = new Padding(9, 11, 9, 11);
            pnlCardDensity.Name = "pnlCardDensity";
            pnlCardDensity.Size = new Size(240, 125);
            pnlCardDensity.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(34, 31);
            label7.Name = "label7";
            label7.Size = new Size(80, 23);
            label7.TabIndex = 3;
            label7.Text = "Yoğunluk";
            // 
            // labelDensityValue
            // 
            labelDensityValue.AutoSize = true;
            labelDensityValue.Font = new Font("Segoe UI", 12F);
            labelDensityValue.Location = new Point(34, 71);
            labelDensityValue.Name = "labelDensityValue";
            labelDensityValue.Size = new Size(49, 28);
            labelDensityValue.TabIndex = 2;
            labelDensityValue.Text = "0.00";
            // 
            // splitStatsMain
            // 
            splitStatsMain.Dock = DockStyle.Fill;
            splitStatsMain.Location = new Point(0, 147);
            splitStatsMain.Margin = new Padding(3, 4, 3, 4);
            splitStatsMain.Name = "splitStatsMain";
            // 
            // splitStatsMain.Panel1
            // 
            splitStatsMain.Panel1.Controls.Add(grpTopDegree);
            // 
            // splitStatsMain.Panel2
            // 
            splitStatsMain.Panel2.Controls.Add(tabStats);
            splitStatsMain.Size = new Size(1026, 764);
            splitStatsMain.SplitterDistance = 509;
            splitStatsMain.SplitterWidth = 5;
            splitStatsMain.TabIndex = 1;
            // 
            // grpTopDegree
            // 
            grpTopDegree.Controls.Add(dgvTopDegree);
            grpTopDegree.Dock = DockStyle.Fill;
            grpTopDegree.Font = new Font("Segoe UI", 10F);
            grpTopDegree.Location = new Point(0, 0);
            grpTopDegree.Margin = new Padding(3, 4, 3, 4);
            grpTopDegree.Name = "grpTopDegree";
            grpTopDegree.Padding = new Padding(3, 4, 3, 4);
            grpTopDegree.Size = new Size(509, 764);
            grpTopDegree.TabIndex = 0;
            grpTopDegree.TabStop = false;
            grpTopDegree.Text = "En Yüksek Dereceli 5 Düğüm";
            // 
            // dgvTopDegree
            // 
            dgvTopDegree.AllowUserToAddRows = false;
            dgvTopDegree.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTopDegree.Columns.AddRange(new DataGridViewColumn[] { colNodeId, colName, colDegree });
            dgvTopDegree.Dock = DockStyle.Fill;
            dgvTopDegree.Location = new Point(3, 27);
            dgvTopDegree.Margin = new Padding(3, 4, 3, 4);
            dgvTopDegree.Name = "dgvTopDegree";
            dgvTopDegree.ReadOnly = true;
            dgvTopDegree.RowHeadersWidth = 51;
            dgvTopDegree.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTopDegree.Size = new Size(503, 733);
            dgvTopDegree.TabIndex = 0;
            // 
            // colNodeId
            // 
            colNodeId.HeaderText = "Id";
            colNodeId.MinimumWidth = 6;
            colNodeId.Name = "colNodeId";
            colNodeId.ReadOnly = true;
            colNodeId.Width = 125;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 125;
            // 
            // colDegree
            // 
            colDegree.HeaderText = "Derece";
            colDegree.MinimumWidth = 6;
            colDegree.Name = "colDegree";
            colDegree.ReadOnly = true;
            colDegree.Width = 125;
            // 
            // tabStats
            // 
            tabStats.Controls.Add(tabChart);
            tabStats.Controls.Add(tabTimes);
            tabStats.Dock = DockStyle.Fill;
            tabStats.Font = new Font("Segoe UI", 10F);
            tabStats.Location = new Point(0, 0);
            tabStats.Margin = new Padding(3, 4, 3, 4);
            tabStats.Name = "tabStats";
            tabStats.SelectedIndex = 0;
            tabStats.Size = new Size(512, 764);
            tabStats.TabIndex = 0;
            // 
            // tabChart
            // 
            tabChart.Controls.Add(grpCharts);
            tabChart.Font = new Font("Segoe UI", 10F);
            tabChart.Location = new Point(4, 32);
            tabChart.Margin = new Padding(3, 4, 3, 4);
            tabChart.Name = "tabChart";
            tabChart.Padding = new Padding(3, 4, 3, 4);
            tabChart.Size = new Size(504, 728);
            tabChart.TabIndex = 0;
            tabChart.Text = "Grafik";
            tabChart.UseVisualStyleBackColor = true;
            // 
            // grpCharts
            // 
            grpCharts.Controls.Add(panelChartPlaceholder);
            grpCharts.Dock = DockStyle.Fill;
            grpCharts.Location = new Point(3, 4);
            grpCharts.Margin = new Padding(3, 4, 3, 4);
            grpCharts.Name = "grpCharts";
            grpCharts.Padding = new Padding(3, 4, 3, 4);
            grpCharts.Size = new Size(498, 720);
            grpCharts.TabIndex = 0;
            grpCharts.TabStop = false;
            grpCharts.Text = "Dağılım";
            // 
            // panelChartPlaceholder
            // 
            panelChartPlaceholder.BorderStyle = BorderStyle.FixedSingle;
            panelChartPlaceholder.Controls.Add(label2);
            panelChartPlaceholder.Dock = DockStyle.Fill;
            panelChartPlaceholder.Location = new Point(3, 27);
            panelChartPlaceholder.Margin = new Padding(3, 4, 3, 4);
            panelChartPlaceholder.Name = "panelChartPlaceholder";
            panelChartPlaceholder.Size = new Size(492, 689);
            panelChartPlaceholder.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 7);
            label2.Name = "label2";
            label2.Size = new Size(207, 23);
            label2.TabIndex = 0;
            label2.Text = "grafik sonradan eklenecek";
            // 
            // tabTimes
            // 
            tabTimes.Controls.Add(dgvTimes);
            tabTimes.Location = new Point(4, 32);
            tabTimes.Margin = new Padding(3, 4, 3, 4);
            tabTimes.Name = "tabTimes";
            tabTimes.Padding = new Padding(3, 4, 3, 4);
            tabTimes.Size = new Size(504, 728);
            tabTimes.TabIndex = 1;
            tabTimes.Text = "Çalışma Süreleri";
            tabTimes.UseVisualStyleBackColor = true;
            // 
            // dgvTimes
            // 
            dgvTimes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTimes.Columns.AddRange(new DataGridViewColumn[] { colAlgo, colMsSmall, colMsMedium, colNotes });
            dgvTimes.Dock = DockStyle.Fill;
            dgvTimes.Location = new Point(3, 4);
            dgvTimes.Margin = new Padding(3, 4, 3, 4);
            dgvTimes.Name = "dgvTimes";
            dgvTimes.ReadOnly = true;
            dgvTimes.RowHeadersWidth = 51;
            dgvTimes.Size = new Size(498, 720);
            dgvTimes.TabIndex = 0;
            // 
            // colAlgo
            // 
            colAlgo.HeaderText = "Algoritma";
            colAlgo.MinimumWidth = 6;
            colAlgo.Name = "colAlgo";
            colAlgo.ReadOnly = true;
            colAlgo.Width = 125;
            // 
            // colMsSmall
            // 
            colMsSmall.HeaderText = "10-20 Düğüm ms";
            colMsSmall.MinimumWidth = 6;
            colMsSmall.Name = "colMsSmall";
            colMsSmall.ReadOnly = true;
            colMsSmall.Width = 125;
            // 
            // colMsMedium
            // 
            colMsMedium.HeaderText = "50-100 Düğüm ms";
            colMsMedium.MinimumWidth = 6;
            colMsMedium.Name = "colMsMedium";
            colMsMedium.ReadOnly = true;
            colMsMedium.Width = 125;
            // 
            // colNotes
            // 
            colNotes.HeaderText = "Not";
            colNotes.MinimumWidth = 6;
            colNotes.Name = "colNotes";
            colNotes.ReadOnly = true;
            colNotes.Width = 125;
            // 
            // grpStatsLog
            // 
            grpStatsLog.Controls.Add(rtbStatsLog);
            grpStatsLog.Dock = DockStyle.Bottom;
            grpStatsLog.Font = new Font("Segoe UI", 10F);
            grpStatsLog.Location = new Point(0, 724);
            grpStatsLog.Margin = new Padding(3, 4, 3, 4);
            grpStatsLog.Name = "grpStatsLog";
            grpStatsLog.Padding = new Padding(3, 4, 3, 4);
            grpStatsLog.Size = new Size(1026, 187);
            grpStatsLog.TabIndex = 2;
            grpStatsLog.TabStop = false;
            grpStatsLog.Text = "Log";
            // 
            // rtbStatsLog
            // 
            rtbStatsLog.Dock = DockStyle.Fill;
            rtbStatsLog.Location = new Point(3, 27);
            rtbStatsLog.Margin = new Padding(3, 4, 3, 4);
            rtbStatsLog.Name = "rtbStatsLog";
            rtbStatsLog.ReadOnly = true;
            rtbStatsLog.Size = new Size(1020, 156);
            rtbStatsLog.TabIndex = 0;
            rtbStatsLog.Text = "";
            // 
            // StatsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpStatsLog);
            Controls.Add(splitStatsMain);
            Controls.Add(tlpSummary);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StatsPage";
            Size = new Size(1026, 911);
            tlpSummary.ResumeLayout(false);
            panelCardNodes.ResumeLayout(false);
            panelCardNodes.PerformLayout();
            panelCardEdges.ResumeLayout(false);
            panelCardEdges.PerformLayout();
            panelCardComponents.ResumeLayout(false);
            panelCardComponents.PerformLayout();
            pnlCardDensity.ResumeLayout(false);
            pnlCardDensity.PerformLayout();
            splitStatsMain.Panel1.ResumeLayout(false);
            splitStatsMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitStatsMain).EndInit();
            splitStatsMain.ResumeLayout(false);
            grpTopDegree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTopDegree).EndInit();
            tabStats.ResumeLayout(false);
            tabChart.ResumeLayout(false);
            grpCharts.ResumeLayout(false);
            panelChartPlaceholder.ResumeLayout(false);
            panelChartPlaceholder.PerformLayout();
            tabTimes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTimes).EndInit();
            grpStatsLog.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpSummary;
        private Panel panelCardNodes;
        private Panel panelCardEdges;
        private Panel panelCardComponents;
        private Panel pnlCardDensity;
        private Label labelNodesValue;
        private Label label1;
        private Label label3;
        private Label labelEdgesValue;
        private Label label5;
        private Label labelComponentValue;
        private Label label7;
        private Label labelDensityValue;
        private SplitContainer splitStatsMain;
        private GroupBox grpTopDegree;
        private DataGridView dgvTopDegree;
        private DataGridViewTextBoxColumn colNodeId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colDegree;
        private TabControl tabStats;
        private TabPage tabChart;
        private TabPage tabTimes;
        private GroupBox grpCharts;
        private Panel panelChartPlaceholder;
        private Label label2;
        private DataGridView dgvTimes;
        private DataGridViewTextBoxColumn colAlgo;
        private DataGridViewTextBoxColumn colMsSmall;
        private DataGridViewTextBoxColumn colMsMedium;
        private DataGridViewTextBoxColumn colNotes;
        private GroupBox grpStatsLog;
        private RichTextBox rtbStatsLog;
    }
}
