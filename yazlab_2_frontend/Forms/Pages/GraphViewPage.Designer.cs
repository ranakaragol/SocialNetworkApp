namespace yazlab_2_frontend.Forms.Pages
{
    partial class GraphViewPage
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
            panelCanvas = new Panel();
            panelRight = new Panel();
            grpView = new GroupBox();
            btnResetSelection = new Button();
            btnRandomLayout = new Button();
            grpNeighbors = new GroupBox();
            lstNeighbors = new ListBox();
            grpSelectedNode = new GroupBox();
            lblSelDegreeValue = new Label();
            lblSelDegree = new Label();
            lblSelEtkValue = new Label();
            lblSelEtk = new Label();
            lblSelAktValue = new Label();
            lblSelAkt = new Label();
            lblSelIdValue = new Label();
            lblSelId = new Label();
            panelRight.SuspendLayout();
            grpView.SuspendLayout();
            grpNeighbors.SuspendLayout();
            grpSelectedNode.SuspendLayout();
            SuspendLayout();
            // 
            // panelCanvas
            // 
            panelCanvas.BackColor = SystemColors.ControlLight;
            panelCanvas.Dock = DockStyle.Left;
            panelCanvas.Location = new Point(0, 0);
            panelCanvas.Margin = new Padding(3, 4, 3, 4);
            panelCanvas.Name = "panelCanvas";
            panelCanvas.Size = new Size(1006, 1091);
            panelCanvas.TabIndex = 0;
            panelCanvas.Paint += panelCanvas_Paint;
            panelCanvas.MouseDown += panelCanvas_MouseDown;
            panelCanvas.MouseMove += panelCanvas_MouseMove;
            panelCanvas.MouseUp += panelCanvas_MouseUp;
            // 
            // panelRight
            // 
            panelRight.BackColor = SystemColors.ControlLight;
            panelRight.Controls.Add(grpView);
            panelRight.Controls.Add(grpNeighbors);
            panelRight.Controls.Add(grpSelectedNode);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(1006, 0);
            panelRight.Margin = new Padding(3, 4, 3, 4);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(229, 1091);
            panelRight.TabIndex = 1;
            // 
            // grpView
            // 
            grpView.Controls.Add(btnResetSelection);
            grpView.Controls.Add(btnRandomLayout);
            grpView.Dock = DockStyle.Top;
            grpView.Location = new Point(0, 520);
            grpView.Margin = new Padding(3, 4, 3, 4);
            grpView.Name = "grpView";
            grpView.Padding = new Padding(3, 4, 3, 4);
            grpView.Size = new Size(229, 160);
            grpView.TabIndex = 2;
            grpView.TabStop = false;
            grpView.Text = "Görünüm";
            // 
            // btnResetSelection
            // 
            btnResetSelection.BackColor = SystemColors.Control;
            btnResetSelection.Location = new Point(176, 44);
            btnResetSelection.Margin = new Padding(3, 4, 3, 4);
            btnResetSelection.Name = "btnResetSelection";
            btnResetSelection.Size = new Size(144, 72);
            btnResetSelection.TabIndex = 1;
            btnResetSelection.Text = "Seçimi Temizle";
            btnResetSelection.UseVisualStyleBackColor = false;
            btnResetSelection.Click += btnResetSelection_Click;
            // 
            // btnRandomLayout
            // 
            btnRandomLayout.BackColor = SystemColors.Control;
            btnRandomLayout.Location = new Point(24, 44);
            btnRandomLayout.Margin = new Padding(3, 4, 3, 4);
            btnRandomLayout.Name = "btnRandomLayout";
            btnRandomLayout.Size = new Size(145, 72);
            btnRandomLayout.TabIndex = 0;
            btnRandomLayout.Text = "Yerleşimi Yenile";
            btnRandomLayout.UseVisualStyleBackColor = false;
            btnRandomLayout.Click += btnRandomLayout_Click;
            // 
            // grpNeighbors
            // 
            grpNeighbors.Controls.Add(lstNeighbors);
            grpNeighbors.Dock = DockStyle.Top;
            grpNeighbors.Location = new Point(0, 227);
            grpNeighbors.Margin = new Padding(3, 4, 3, 4);
            grpNeighbors.Name = "grpNeighbors";
            grpNeighbors.Padding = new Padding(3, 4, 3, 4);
            grpNeighbors.Size = new Size(229, 293);
            grpNeighbors.TabIndex = 1;
            grpNeighbors.TabStop = false;
            grpNeighbors.Text = "Komşular";
            // 
            // lstNeighbors
            // 
            lstNeighbors.BackColor = SystemColors.ControlLight;
            lstNeighbors.Dock = DockStyle.Fill;
            lstNeighbors.FormattingEnabled = true;
            lstNeighbors.Location = new Point(3, 24);
            lstNeighbors.Margin = new Padding(3, 4, 3, 4);
            lstNeighbors.Name = "lstNeighbors";
            lstNeighbors.Size = new Size(223, 265);
            lstNeighbors.TabIndex = 0;
            // 
            // grpSelectedNode
            // 
            grpSelectedNode.Controls.Add(lblSelDegreeValue);
            grpSelectedNode.Controls.Add(lblSelDegree);
            grpSelectedNode.Controls.Add(lblSelEtkValue);
            grpSelectedNode.Controls.Add(lblSelEtk);
            grpSelectedNode.Controls.Add(lblSelAktValue);
            grpSelectedNode.Controls.Add(lblSelAkt);
            grpSelectedNode.Controls.Add(lblSelIdValue);
            grpSelectedNode.Controls.Add(lblSelId);
            grpSelectedNode.Dock = DockStyle.Top;
            grpSelectedNode.Location = new Point(0, 0);
            grpSelectedNode.Margin = new Padding(3, 4, 3, 4);
            grpSelectedNode.Name = "grpSelectedNode";
            grpSelectedNode.Padding = new Padding(3, 4, 3, 4);
            grpSelectedNode.Size = new Size(229, 227);
            grpSelectedNode.TabIndex = 0;
            grpSelectedNode.TabStop = false;
            grpSelectedNode.Text = "Seçili Düğüm";
            // 
            // lblSelDegreeValue
            // 
            lblSelDegreeValue.AutoSize = true;
            lblSelDegreeValue.Location = new Point(87, 180);
            lblSelDegreeValue.Name = "lblSelDegreeValue";
            lblSelDegreeValue.Size = new Size(17, 20);
            lblSelDegreeValue.TabIndex = 7;
            lblSelDegreeValue.Text = "0";
            // 
            // lblSelDegree
            // 
            lblSelDegree.AutoSize = true;
            lblSelDegree.Location = new Point(19, 180);
            lblSelDegree.Name = "lblSelDegree";
            lblSelDegree.Size = new Size(56, 20);
            lblSelDegree.TabIndex = 6;
            lblSelDegree.Text = "Derece";
            // 
            // lblSelEtkValue
            // 
            lblSelEtkValue.AutoSize = true;
            lblSelEtkValue.Location = new Point(87, 139);
            lblSelEtkValue.Name = "lblSelEtkValue";
            lblSelEtkValue.Size = new Size(17, 20);
            lblSelEtkValue.TabIndex = 5;
            lblSelEtkValue.Text = "0";
            // 
            // lblSelEtk
            // 
            lblSelEtk.AutoSize = true;
            lblSelEtk.Location = new Point(19, 139);
            lblSelEtk.Name = "lblSelEtk";
            lblSelEtk.Size = new Size(68, 20);
            lblSelEtk.TabIndex = 4;
            lblSelEtk.Text = "Etkileşim";
            // 
            // lblSelAktValue
            // 
            lblSelAktValue.AutoSize = true;
            lblSelAktValue.BackColor = SystemColors.ControlLight;
            lblSelAktValue.Location = new Point(87, 93);
            lblSelAktValue.Name = "lblSelAktValue";
            lblSelAktValue.Size = new Size(17, 20);
            lblSelAktValue.TabIndex = 3;
            lblSelAktValue.Text = "0";
            // 
            // lblSelAkt
            // 
            lblSelAkt.AutoSize = true;
            lblSelAkt.Location = new Point(19, 93);
            lblSelAkt.Name = "lblSelAkt";
            lblSelAkt.Size = new Size(55, 20);
            lblSelAkt.TabIndex = 2;
            lblSelAkt.Text = "Aktiflik";
            // 
            // lblSelIdValue
            // 
            lblSelIdValue.AutoSize = true;
            lblSelIdValue.BackColor = SystemColors.ControlLight;
            lblSelIdValue.Location = new Point(87, 52);
            lblSelIdValue.Name = "lblSelIdValue";
            lblSelIdValue.Size = new Size(15, 20);
            lblSelIdValue.TabIndex = 1;
            lblSelIdValue.Text = "-";
            // 
            // lblSelId
            // 
            lblSelId.AutoSize = true;
            lblSelId.Location = new Point(19, 52);
            lblSelId.Name = "lblSelId";
            lblSelId.Size = new Size(24, 20);
            lblSelId.TabIndex = 0;
            lblSelId.Text = "ID";
            // 
            // GraphViewPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panelRight);
            Controls.Add(panelCanvas);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GraphViewPage";
            Size = new Size(1235, 1091);
            panelRight.ResumeLayout(false);
            grpView.ResumeLayout(false);
            grpNeighbors.ResumeLayout(false);
            grpSelectedNode.ResumeLayout(false);
            grpSelectedNode.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCanvas;
        private Panel panelRight;
        private GroupBox grpSelectedNode;
        private Label lblSelId;
        private Label lblSelDegreeValue;
        private Label lblSelDegree;
        private Label lblSelEtkValue;
        private Label lblSelEtk;
        private Label lblSelAktValue;
        private Label lblSelAkt;
        private Label lblSelIdValue;
        private GroupBox grpView;
        private Button btnResetSelection;
        private Button btnRandomLayout;
        private GroupBox grpNeighbors;
        private ListBox lstNeighbors;
    }
}
