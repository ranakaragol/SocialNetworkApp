namespace yazlab_2_frontend.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlLeft = new Panel();
            btnExit = new Button();
            btnStats = new Button();
            btnImportExport = new Button();
            btnAlgorithms = new Button();
            btnEdges = new Button();
            btnNodes = new Button();
            btnGraphView = new Button();
            btnDashboard = new Button();
            pnlBrand = new Panel();
            lblBrand = new Label();
            pnlTop = new Panel();
            lblDateTime = new Label();
            lblTitle = new Label();
            pnlContent = new Panel();
            grpLog = new GroupBox();
            rtbLog = new RichTextBox();
            grpQuickActions = new GroupBox();
            tlpQuick = new TableLayoutPanel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ButonAddNode = new Button();
            grpSummary = new GroupBox();
            tlpSummary = new TableLayoutPanel();
            pnlCardTopDegree = new Panel();
            lblTopDegreeValue = new Label();
            lblTopDegree = new Label();
            pnlCardComponents = new Panel();
            lblComponentsValue = new Label();
            lblComponents = new Label();
            pnlCardEdges = new Panel();
            lblEdgesValue = new Label();
            lblEdges = new Label();
            pnlCardNodes = new Panel();
            lblNodesValue = new Label();
            lblNodes = new Label();
            pnlLeft.SuspendLayout();
            pnlBrand.SuspendLayout();
            pnlTop.SuspendLayout();
            pnlContent.SuspendLayout();
            grpLog.SuspendLayout();
            grpQuickActions.SuspendLayout();
            tlpQuick.SuspendLayout();
            grpSummary.SuspendLayout();
            tlpSummary.SuspendLayout();
            pnlCardTopDegree.SuspendLayout();
            pnlCardComponents.SuspendLayout();
            pnlCardEdges.SuspendLayout();
            pnlCardNodes.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = SystemColors.ControlLight;
            pnlLeft.Controls.Add(btnExit);
            pnlLeft.Controls.Add(btnStats);
            pnlLeft.Controls.Add(btnImportExport);
            pnlLeft.Controls.Add(btnAlgorithms);
            pnlLeft.Controls.Add(btnEdges);
            pnlLeft.Controls.Add(btnNodes);
            pnlLeft.Controls.Add(btnGraphView);
            pnlLeft.Controls.Add(btnDashboard);
            pnlLeft.Controls.Add(pnlBrand);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(240, 750);
            pnlLeft.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Top;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(0, 405);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(12, 0, 0, 0);
            btnExit.Size = new Size(240, 45);
            btnExit.TabIndex = 8;
            btnExit.TabStop = false;
            btnExit.Text = "Çıkış";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnStats
            // 
            btnStats.Dock = DockStyle.Top;
            btnStats.FlatStyle = FlatStyle.Flat;
            btnStats.Location = new Point(0, 360);
            btnStats.Name = "btnStats";
            btnStats.Padding = new Padding(12, 0, 0, 0);
            btnStats.Size = new Size(240, 45);
            btnStats.TabIndex = 7;
            btnStats.TabStop = false;
            btnStats.Text = "İstatistikler";
            btnStats.TextAlign = ContentAlignment.MiddleLeft;
            btnStats.UseVisualStyleBackColor = true;
            // 
            // btnImportExport
            // 
            btnImportExport.Dock = DockStyle.Top;
            btnImportExport.FlatStyle = FlatStyle.Flat;
            btnImportExport.Location = new Point(0, 315);
            btnImportExport.Name = "btnImportExport";
            btnImportExport.Padding = new Padding(12, 0, 0, 0);
            btnImportExport.Size = new Size(240, 45);
            btnImportExport.TabIndex = 6;
            btnImportExport.TabStop = false;
            btnImportExport.Text = "İçe/Dışa Aktar";
            btnImportExport.TextAlign = ContentAlignment.MiddleLeft;
            btnImportExport.UseVisualStyleBackColor = true;
            // 
            // btnAlgorithms
            // 
            btnAlgorithms.Dock = DockStyle.Top;
            btnAlgorithms.FlatStyle = FlatStyle.Flat;
            btnAlgorithms.Location = new Point(0, 270);
            btnAlgorithms.Name = "btnAlgorithms";
            btnAlgorithms.Padding = new Padding(12, 0, 0, 0);
            btnAlgorithms.Size = new Size(240, 45);
            btnAlgorithms.TabIndex = 5;
            btnAlgorithms.TabStop = false;
            btnAlgorithms.Text = "Algoritmalar";
            btnAlgorithms.TextAlign = ContentAlignment.MiddleLeft;
            btnAlgorithms.UseVisualStyleBackColor = true;
            // 
            // btnEdges
            // 
            btnEdges.Dock = DockStyle.Top;
            btnEdges.FlatStyle = FlatStyle.Flat;
            btnEdges.Location = new Point(0, 225);
            btnEdges.Name = "btnEdges";
            btnEdges.Padding = new Padding(12, 0, 0, 0);
            btnEdges.Size = new Size(240, 45);
            btnEdges.TabIndex = 4;
            btnEdges.TabStop = false;
            btnEdges.Text = "Bağlantılar";
            btnEdges.TextAlign = ContentAlignment.MiddleLeft;
            btnEdges.UseVisualStyleBackColor = true;
            // 
            // btnNodes
            // 
            btnNodes.Dock = DockStyle.Top;
            btnNodes.FlatStyle = FlatStyle.Flat;
            btnNodes.Location = new Point(0, 180);
            btnNodes.Name = "btnNodes";
            btnNodes.Padding = new Padding(12, 0, 0, 0);
            btnNodes.Size = new Size(240, 45);
            btnNodes.TabIndex = 3;
            btnNodes.TabStop = false;
            btnNodes.Text = "Düğümler";
            btnNodes.TextAlign = ContentAlignment.MiddleLeft;
            btnNodes.UseVisualStyleBackColor = true;
            // 
            // btnGraphView
            // 
            btnGraphView.Dock = DockStyle.Top;
            btnGraphView.FlatStyle = FlatStyle.Flat;
            btnGraphView.Location = new Point(0, 135);
            btnGraphView.Name = "btnGraphView";
            btnGraphView.Padding = new Padding(12, 0, 0, 0);
            btnGraphView.Size = new Size(240, 45);
            btnGraphView.TabIndex = 2;
            btnGraphView.TabStop = false;
            btnGraphView.Text = "Graph Görünümü";
            btnGraphView.TextAlign = ContentAlignment.MiddleLeft;
            btnGraphView.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Location = new Point(0, 90);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(12, 0, 0, 0);
            btnDashboard.Size = new Size(240, 45);
            btnDashboard.TabIndex = 1;
            btnDashboard.TabStop = false;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // pnlBrand
            // 
            pnlBrand.Controls.Add(lblBrand);
            pnlBrand.Dock = DockStyle.Top;
            pnlBrand.Location = new Point(0, 0);
            pnlBrand.Name = "pnlBrand";
            pnlBrand.Size = new Size(240, 90);
            pnlBrand.TabIndex = 0;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 14F);
            lblBrand.Location = new Point(12, 9);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(148, 25);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "SNA -Graph Lab";
            // 
            // pnlTop
            // 
            pnlTop.BackColor = SystemColors.ControlLight;
            pnlTop.Controls.Add(lblDateTime);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(240, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(911, 60);
            pnlTop.TabIndex = 1;
            // 
            // lblDateTime
            // 
            lblDateTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Segoe UI", 14F);
            lblDateTime.Location = new Point(739, 18);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(149, 25);
            lblDateTime.TabIndex = 1;
            lblDateTime.Text = "20.12.2025 11:00";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F);
            lblTitle.Location = new Point(20, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(118, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dashboard";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = SystemColors.ControlLight;
            pnlContent.Controls.Add(grpLog);
            pnlContent.Controls.Add(grpQuickActions);
            pnlContent.Controls.Add(grpSummary);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(240, 60);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(911, 690);
            pnlContent.TabIndex = 2;
            // 
            // grpLog
            // 
            grpLog.Controls.Add(rtbLog);
            grpLog.Dock = DockStyle.Fill;
            grpLog.Location = new Point(0, 340);
            grpLog.Name = "grpLog";
            grpLog.Padding = new Padding(10);
            grpLog.Size = new Size(911, 350);
            grpLog.TabIndex = 2;
            grpLog.TabStop = false;
            grpLog.Text = "Durum / Log";
            // 
            // rtbLog
            // 
            rtbLog.BackColor = SystemColors.ButtonFace;
            rtbLog.Dock = DockStyle.Fill;
            rtbLog.Location = new Point(10, 26);
            rtbLog.Name = "rtbLog";
            rtbLog.ReadOnly = true;
            rtbLog.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbLog.Size = new Size(891, 314);
            rtbLog.TabIndex = 0;
            rtbLog.Text = "";
            // 
            // grpQuickActions
            // 
            grpQuickActions.Controls.Add(tlpQuick);
            grpQuickActions.Dock = DockStyle.Top;
            grpQuickActions.Location = new Point(0, 150);
            grpQuickActions.Name = "grpQuickActions";
            grpQuickActions.Padding = new Padding(10);
            grpQuickActions.Size = new Size(911, 190);
            grpQuickActions.TabIndex = 1;
            grpQuickActions.TabStop = false;
            grpQuickActions.Text = "Hızlı İşlemler";
            // 
            // tlpQuick
            // 
            tlpQuick.ColumnCount = 2;
            tlpQuick.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpQuick.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpQuick.Controls.Add(button3, 1, 1);
            tlpQuick.Controls.Add(button2, 0, 1);
            tlpQuick.Controls.Add(button1, 1, 0);
            tlpQuick.Controls.Add(ButonAddNode, 0, 0);
            tlpQuick.Dock = DockStyle.Fill;
            tlpQuick.Location = new Point(10, 26);
            tlpQuick.Name = "tlpQuick";
            tlpQuick.RowCount = 2;
            tlpQuick.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpQuick.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpQuick.Size = new Size(891, 154);
            tlpQuick.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(455, 87);
            button3.Margin = new Padding(10);
            button3.Name = "button3";
            button3.Size = new Size(426, 57);
            button3.TabIndex = 3;
            button3.Text = "Dosyadan Yükle (JSON/CSV)";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(10, 87);
            button2.Margin = new Padding(10);
            button2.Name = "button2";
            button2.Size = new Size(425, 57);
            button2.TabIndex = 2;
            button2.Text = "Algoritma Çalıştır";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(455, 10);
            button1.Margin = new Padding(10);
            button1.Name = "button1";
            button1.Size = new Size(426, 57);
            button1.TabIndex = 1;
            button1.Text = "Bağlantı Ekle";
            button1.UseVisualStyleBackColor = false;
            // 
            // ButonAddNode
            // 
            ButonAddNode.BackColor = SystemColors.ActiveCaption;
            ButonAddNode.Dock = DockStyle.Fill;
            ButonAddNode.Font = new Font("Segoe UI", 12F);
            ButonAddNode.Location = new Point(10, 10);
            ButonAddNode.Margin = new Padding(10);
            ButonAddNode.Name = "ButonAddNode";
            ButonAddNode.Size = new Size(425, 57);
            ButonAddNode.TabIndex = 0;
            ButonAddNode.Text = "Düğüm Ekle";
            ButonAddNode.UseVisualStyleBackColor = false;
            // 
            // grpSummary
            // 
            grpSummary.Controls.Add(tlpSummary);
            grpSummary.Dock = DockStyle.Top;
            grpSummary.Location = new Point(0, 0);
            grpSummary.Name = "grpSummary";
            grpSummary.Padding = new Padding(10);
            grpSummary.Size = new Size(911, 150);
            grpSummary.TabIndex = 0;
            grpSummary.TabStop = false;
            grpSummary.Text = "Genel Özet";
            // 
            // tlpSummary
            // 
            tlpSummary.ColumnCount = 4;
            tlpSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.99867F));
            tlpSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.00275F));
            tlpSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9986477F));
            tlpSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9999352F));
            tlpSummary.Controls.Add(pnlCardTopDegree, 3, 0);
            tlpSummary.Controls.Add(pnlCardComponents, 2, 0);
            tlpSummary.Controls.Add(pnlCardEdges, 1, 0);
            tlpSummary.Controls.Add(pnlCardNodes, 0, 0);
            tlpSummary.Dock = DockStyle.Fill;
            tlpSummary.Location = new Point(10, 26);
            tlpSummary.Name = "tlpSummary";
            tlpSummary.RowCount = 1;
            tlpSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSummary.Size = new Size(891, 114);
            tlpSummary.TabIndex = 0;
            // 
            // pnlCardTopDegree
            // 
            pnlCardTopDegree.BorderStyle = BorderStyle.FixedSingle;
            pnlCardTopDegree.Controls.Add(lblTopDegreeValue);
            pnlCardTopDegree.Controls.Add(lblTopDegree);
            pnlCardTopDegree.Dock = DockStyle.Fill;
            pnlCardTopDegree.Location = new Point(676, 10);
            pnlCardTopDegree.Margin = new Padding(10);
            pnlCardTopDegree.Name = "pnlCardTopDegree";
            pnlCardTopDegree.Size = new Size(205, 94);
            pnlCardTopDegree.TabIndex = 4;
            // 
            // lblTopDegreeValue
            // 
            lblTopDegreeValue.AutoSize = true;
            lblTopDegreeValue.Font = new Font("Segoe UI", 10F);
            lblTopDegreeValue.Location = new Point(12, 45);
            lblTopDegreeValue.Name = "lblTopDegreeValue";
            lblTopDegreeValue.Size = new Size(17, 19);
            lblTopDegreeValue.TabIndex = 2;
            lblTopDegreeValue.Text = "0";
            // 
            // lblTopDegree
            // 
            lblTopDegree.AutoSize = true;
            lblTopDegree.Font = new Font("Segoe UI", 10F);
            lblTopDegree.Location = new Point(12, 15);
            lblTopDegree.Name = "lblTopDegree";
            lblTopDegree.Size = new Size(117, 19);
            lblTopDegree.TabIndex = 1;
            lblTopDegree.Text = "En Yüksek Derece";
            // 
            // pnlCardComponents
            // 
            pnlCardComponents.BorderStyle = BorderStyle.FixedSingle;
            pnlCardComponents.Controls.Add(lblComponentsValue);
            pnlCardComponents.Controls.Add(lblComponents);
            pnlCardComponents.Dock = DockStyle.Fill;
            pnlCardComponents.Location = new Point(454, 10);
            pnlCardComponents.Margin = new Padding(10);
            pnlCardComponents.Name = "pnlCardComponents";
            pnlCardComponents.Size = new Size(202, 94);
            pnlCardComponents.TabIndex = 3;
            // 
            // lblComponentsValue
            // 
            lblComponentsValue.AutoSize = true;
            lblComponentsValue.Font = new Font("Segoe UI", 10F);
            lblComponentsValue.Location = new Point(12, 45);
            lblComponentsValue.Name = "lblComponentsValue";
            lblComponentsValue.Size = new Size(17, 19);
            lblComponentsValue.TabIndex = 2;
            lblComponentsValue.Text = "0";
            // 
            // lblComponents
            // 
            lblComponents.AutoSize = true;
            lblComponents.Font = new Font("Segoe UI", 10F);
            lblComponents.Location = new Point(12, 15);
            lblComponents.Name = "lblComponents";
            lblComponents.Size = new Size(84, 19);
            lblComponents.TabIndex = 1;
            lblComponents.Text = "Bağlı Bileşen";
            // 
            // pnlCardEdges
            // 
            pnlCardEdges.BorderStyle = BorderStyle.FixedSingle;
            pnlCardEdges.Controls.Add(lblEdgesValue);
            pnlCardEdges.Controls.Add(lblEdges);
            pnlCardEdges.Dock = DockStyle.Fill;
            pnlCardEdges.Location = new Point(232, 10);
            pnlCardEdges.Margin = new Padding(10);
            pnlCardEdges.Name = "pnlCardEdges";
            pnlCardEdges.Size = new Size(202, 94);
            pnlCardEdges.TabIndex = 2;
            // 
            // lblEdgesValue
            // 
            lblEdgesValue.AutoSize = true;
            lblEdgesValue.Font = new Font("Segoe UI", 10F);
            lblEdgesValue.Location = new Point(12, 45);
            lblEdgesValue.Name = "lblEdgesValue";
            lblEdgesValue.Size = new Size(17, 19);
            lblEdgesValue.TabIndex = 2;
            lblEdgesValue.Text = "0";
            // 
            // lblEdges
            // 
            lblEdges.AutoSize = true;
            lblEdges.Font = new Font("Segoe UI", 10F);
            lblEdges.Location = new Point(12, 15);
            lblEdges.Name = "lblEdges";
            lblEdges.Size = new Size(106, 19);
            lblEdges.TabIndex = 1;
            lblEdges.Text = "Toplam Bağlantı";
            // 
            // pnlCardNodes
            // 
            pnlCardNodes.BorderStyle = BorderStyle.FixedSingle;
            pnlCardNodes.Controls.Add(lblNodesValue);
            pnlCardNodes.Controls.Add(lblNodes);
            pnlCardNodes.Dock = DockStyle.Fill;
            pnlCardNodes.Location = new Point(10, 10);
            pnlCardNodes.Margin = new Padding(10);
            pnlCardNodes.Name = "pnlCardNodes";
            pnlCardNodes.Size = new Size(202, 94);
            pnlCardNodes.TabIndex = 1;
            // 
            // lblNodesValue
            // 
            lblNodesValue.AutoSize = true;
            lblNodesValue.Font = new Font("Segoe UI", 10F);
            lblNodesValue.Location = new Point(12, 45);
            lblNodesValue.Name = "lblNodesValue";
            lblNodesValue.Size = new Size(17, 19);
            lblNodesValue.TabIndex = 1;
            lblNodesValue.Text = "0";
            // 
            // lblNodes
            // 
            lblNodes.AutoSize = true;
            lblNodes.Font = new Font("Segoe UI", 10F);
            lblNodes.Location = new Point(12, 15);
            lblNodes.Name = "lblNodes";
            lblNodes.Size = new Size(103, 19);
            lblNodes.TabIndex = 0;
            lblNodes.Text = "Toplam Düğüm";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 750);
            Controls.Add(pnlContent);
            Controls.Add(pnlTop);
            Controls.Add(pnlLeft);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sosyal Ağ Analizi Uygulaması";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            pnlLeft.ResumeLayout(false);
            pnlBrand.ResumeLayout(false);
            pnlBrand.PerformLayout();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlContent.ResumeLayout(false);
            grpLog.ResumeLayout(false);
            grpQuickActions.ResumeLayout(false);
            tlpQuick.ResumeLayout(false);
            grpSummary.ResumeLayout(false);
            tlpSummary.ResumeLayout(false);
            pnlCardTopDegree.ResumeLayout(false);
            pnlCardTopDegree.PerformLayout();
            pnlCardComponents.ResumeLayout(false);
            pnlCardComponents.PerformLayout();
            pnlCardEdges.ResumeLayout(false);
            pnlCardEdges.PerformLayout();
            pnlCardNodes.ResumeLayout(false);
            pnlCardNodes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeft;
        private Panel pnlBrand;
        private Label lblBrand;
        private Button btnDashboard;
        private Button btnExit;
        private Button btnStats;
        private Button btnImportExport;
        private Button btnAlgorithms;
        private Button btnEdges;
        private Button btnNodes;
        private Button btnGraphView;
        private Panel pnlTop;
        private Label lblTitle;
        private Label lblDateTime;
        private Panel pnlContent;
        private GroupBox grpSummary;
        private TableLayoutPanel tlpSummary;
        private Panel pnlCardTopDegree;
        private Panel pnlCardComponents;
        private Panel pnlCardEdges;
        private Panel pnlCardNodes;
        private Label lblTopDegreeValue;
        private Label lblTopDegree;
        private Label lblComponentsValue;
        private Label lblComponents;
        private Label lblEdgesValue;
        private Label lblEdges;
        private Label lblNodesValue;
        private Label lblNodes;
        private GroupBox grpQuickActions;
        private TableLayoutPanel tlpQuick;
        private Button ButonAddNode;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox grpLog;
        private RichTextBox rtbLog;
    }
}