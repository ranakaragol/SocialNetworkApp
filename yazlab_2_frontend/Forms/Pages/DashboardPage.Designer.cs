namespace yazlab_2_frontend.Forms.Pages
{
    partial class DashboardPage
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
            grpQuickActions = new GroupBox();
            tlpQuick = new TableLayoutPanel();
            ButtonImportExport = new Button();
            ButtonRunAlgorithms = new Button();
            ButtonAddEdge = new Button();
            ButonAddNode = new Button();
            grpLog = new GroupBox();
            rtbLog = new RichTextBox();
            grpSummary.SuspendLayout();
            tlpSummary.SuspendLayout();
            pnlCardTopDegree.SuspendLayout();
            pnlCardComponents.SuspendLayout();
            pnlCardEdges.SuspendLayout();
            pnlCardNodes.SuspendLayout();
            grpQuickActions.SuspendLayout();
            tlpQuick.SuspendLayout();
            grpLog.SuspendLayout();
            SuspendLayout();
            // 
            // grpSummary
            // 
            grpSummary.Controls.Add(tlpSummary);
            grpSummary.Dock = DockStyle.Top;
            grpSummary.Location = new Point(0, 0);
            grpSummary.Name = "grpSummary";
            grpSummary.Padding = new Padding(10);
            grpSummary.Size = new Size(1017, 190);
            grpSummary.TabIndex = 1;
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
            tlpSummary.Size = new Size(997, 154);
            tlpSummary.TabIndex = 0;
            // 
            // pnlCardTopDegree
            // 
            pnlCardTopDegree.BorderStyle = BorderStyle.FixedSingle;
            pnlCardTopDegree.Controls.Add(lblTopDegreeValue);
            pnlCardTopDegree.Controls.Add(lblTopDegree);
            pnlCardTopDegree.Dock = DockStyle.Fill;
            pnlCardTopDegree.Location = new Point(757, 10);
            pnlCardTopDegree.Margin = new Padding(10);
            pnlCardTopDegree.Name = "pnlCardTopDegree";
            pnlCardTopDegree.Size = new Size(230, 134);
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
            pnlCardComponents.Location = new Point(508, 10);
            pnlCardComponents.Margin = new Padding(10);
            pnlCardComponents.Name = "pnlCardComponents";
            pnlCardComponents.Size = new Size(229, 134);
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
            pnlCardEdges.Location = new Point(259, 10);
            pnlCardEdges.Margin = new Padding(10);
            pnlCardEdges.Name = "pnlCardEdges";
            pnlCardEdges.Size = new Size(229, 134);
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
            pnlCardNodes.Size = new Size(229, 134);
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
            // grpQuickActions
            // 
            grpQuickActions.Controls.Add(tlpQuick);
            grpQuickActions.Dock = DockStyle.Top;
            grpQuickActions.Location = new Point(0, 190);
            grpQuickActions.Name = "grpQuickActions";
            grpQuickActions.Padding = new Padding(10);
            grpQuickActions.Size = new Size(1017, 210);
            grpQuickActions.TabIndex = 2;
            grpQuickActions.TabStop = false;
            grpQuickActions.Text = "Hızlı İşlemler";
            // 
            // tlpQuick
            // 
            tlpQuick.ColumnCount = 2;
            tlpQuick.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpQuick.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpQuick.Controls.Add(ButtonImportExport, 1, 1);
            tlpQuick.Controls.Add(ButtonRunAlgorithms, 0, 1);
            tlpQuick.Controls.Add(ButtonAddEdge, 1, 0);
            tlpQuick.Controls.Add(ButonAddNode, 0, 0);
            tlpQuick.Dock = DockStyle.Fill;
            tlpQuick.Location = new Point(10, 26);
            tlpQuick.Name = "tlpQuick";
            tlpQuick.RowCount = 2;
            tlpQuick.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpQuick.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpQuick.Size = new Size(997, 174);
            tlpQuick.TabIndex = 0;
            // 
            // ButtonImportExport
            // 
            ButtonImportExport.BackColor = SystemColors.ActiveCaption;
            ButtonImportExport.Dock = DockStyle.Fill;
            ButtonImportExport.Font = new Font("Segoe UI", 12F);
            ButtonImportExport.Location = new Point(508, 97);
            ButtonImportExport.Margin = new Padding(10);
            ButtonImportExport.Name = "ButtonImportExport";
            ButtonImportExport.Size = new Size(479, 67);
            ButtonImportExport.TabIndex = 3;
            ButtonImportExport.Text = "Dosyadan Yükle (JSON/CSV)";
            ButtonImportExport.UseVisualStyleBackColor = false;
            ButtonImportExport.Click += ButtonImportExport_Click;
            // 
            // ButtonRunAlgorithms
            // 
            ButtonRunAlgorithms.BackColor = SystemColors.ActiveCaption;
            ButtonRunAlgorithms.Dock = DockStyle.Fill;
            ButtonRunAlgorithms.Font = new Font("Segoe UI", 12F);
            ButtonRunAlgorithms.Location = new Point(10, 97);
            ButtonRunAlgorithms.Margin = new Padding(10);
            ButtonRunAlgorithms.Name = "ButtonRunAlgorithms";
            ButtonRunAlgorithms.Size = new Size(478, 67);
            ButtonRunAlgorithms.TabIndex = 2;
            ButtonRunAlgorithms.Text = "Algoritma Çalıştır";
            ButtonRunAlgorithms.UseVisualStyleBackColor = false;
            ButtonRunAlgorithms.Click +=ButtonRunAlgorithms_Click;
            // 
            // ButtonAddEdge
            // 
            ButtonAddEdge.BackColor = SystemColors.ActiveCaption;
            ButtonAddEdge.Dock = DockStyle.Fill;
            ButtonAddEdge.Font = new Font("Segoe UI", 12F);
            ButtonAddEdge.Location = new Point(508, 10);
            ButtonAddEdge.Margin = new Padding(10);
            ButtonAddEdge.Name = "ButtonAddEdge";
            ButtonAddEdge.Size = new Size(479, 67);
            ButtonAddEdge.TabIndex = 1;
            ButtonAddEdge.Text = "Bağlantı Ekle";
            ButtonAddEdge.UseVisualStyleBackColor = false;
            ButtonAddEdge.Click += ButtonAddEdge_Click;
            // 
            // ButonAddNode
            // 
            ButonAddNode.BackColor = SystemColors.ActiveCaption;
            ButonAddNode.Dock = DockStyle.Fill;
            ButonAddNode.Font = new Font("Segoe UI", 12F);
            ButonAddNode.Location = new Point(10, 10);
            ButonAddNode.Margin = new Padding(10);
            ButonAddNode.Name = "ButonAddNode";
            ButonAddNode.Size = new Size(478, 67);
            ButonAddNode.TabIndex = 0;
            ButonAddNode.Text = "Düğüm Ekle";
            ButonAddNode.UseVisualStyleBackColor = false;
            ButonAddNode.Click += BtnAddNode_Click;
            // 
            // grpLog
            // 
            grpLog.Controls.Add(rtbLog);
            grpLog.Dock = DockStyle.Fill;
            grpLog.Location = new Point(0, 400);
            grpLog.Name = "grpLog";
            grpLog.Padding = new Padding(10);
            grpLog.Size = new Size(1017, 327);
            grpLog.TabIndex = 3;
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
            rtbLog.Size = new Size(997, 291);
            rtbLog.TabIndex = 0;
            rtbLog.Text = "";
            // 
            // DashboardPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(grpLog);
            Controls.Add(grpQuickActions);
            Controls.Add(grpSummary);
            Name = "DashboardPage";
            Size = new Size(1017, 727);
            Load += DashboardPage_Load;
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
            grpQuickActions.ResumeLayout(false);
            tlpQuick.ResumeLayout(false);
            grpLog.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpSummary;
        private TableLayoutPanel tlpSummary;
        private Panel pnlCardTopDegree;
        private Label lblTopDegreeValue;
        private Label lblTopDegree;
        private Panel pnlCardComponents;
        private Label lblComponentsValue;
        private Label lblComponents;
        private Panel pnlCardEdges;
        private Label lblEdgesValue;
        private Label lblEdges;
        private Panel pnlCardNodes;
        private Label lblNodesValue;
        private Label lblNodes;
        private GroupBox grpQuickActions;
        private TableLayoutPanel tlpQuick;
        private Button ButtonImportExport;
        private Button ButtonRunAlgorithms;
        private Button ButtonAddEdge;
        private Button ButonAddNode;
        private GroupBox grpLog;
        private RichTextBox rtbLog;
    }
}
