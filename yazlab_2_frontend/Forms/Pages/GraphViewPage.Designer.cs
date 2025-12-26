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
            button2 = new Button();
            button1 = new Button();
            panelRight = new Panel();
            deleteBtn = new Button();
            grpView = new GroupBox();
            btnResetSelection = new Button();
            btnRandomLayout = new Button();
            grpNeighbors = new GroupBox();
            neighborsgridview = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            İsim = new DataGridViewTextBoxColumn();
            Aktiflik = new DataGridViewTextBoxColumn();
            Etkileşim = new DataGridViewTextBoxColumn();
            Derece = new DataGridViewTextBoxColumn();
            grpSelectedNode = new GroupBox();
            lblSelDegreeValue = new Label();
            lblSelDegree = new Label();
            lblSelEtkValue = new Label();
            lblSelEtk = new Label();
            lblSelAktValue = new Label();
            lblSelAkt = new Label();
            lblSelIdValue = new Label();
            lblSelId = new Label();
            panelCanvas.SuspendLayout();
            panelRight.SuspendLayout();
            grpView.SuspendLayout();
            grpNeighbors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)neighborsgridview).BeginInit();
            grpSelectedNode.SuspendLayout();
            SuspendLayout();
            // 
            // panelCanvas
            // 
            panelCanvas.BackColor = SystemColors.ControlLight;
            panelCanvas.Controls.Add(button2);
            panelCanvas.Controls.Add(button1);
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
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.pngwing_com__1_;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(53, 20);
            button2.Name = "button2";
            button2.Size = new Size(35, 29);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.pngwing_com;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(12, 20);
            button1.Name = "button1";
            button1.Size = new Size(35, 29);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            panelRight.Size = new Size(487, 1091);
            panelRight.TabIndex = 1;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = SystemColors.Control;
            deleteBtn.Location = new Point(326, 44);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(144, 72);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Sil";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // grpView
            // 
            grpView.Controls.Add(deleteBtn);
            grpView.Controls.Add(btnResetSelection);
            grpView.Controls.Add(btnRandomLayout);
            grpView.Dock = DockStyle.Top;
            grpView.Location = new Point(0, 520);
            grpView.Margin = new Padding(3, 4, 3, 4);
            grpView.Name = "grpView";
            grpView.Padding = new Padding(3, 4, 3, 4);
            grpView.Size = new Size(487, 160);
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
            grpNeighbors.Controls.Add(neighborsgridview);
            grpNeighbors.Dock = DockStyle.Top;
            grpNeighbors.Location = new Point(0, 227);
            grpNeighbors.Margin = new Padding(3, 4, 3, 4);
            grpNeighbors.Name = "grpNeighbors";
            grpNeighbors.Padding = new Padding(3, 4, 3, 4);
            grpNeighbors.Size = new Size(487, 293);
            grpNeighbors.TabIndex = 1;
            grpNeighbors.TabStop = false;
            grpNeighbors.Text = "Komşular";
            // 
            // neighborsgridview
            // 
            neighborsgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            neighborsgridview.Columns.AddRange(new DataGridViewColumn[] { Id, İsim, Aktiflik, Etkileşim, Derece });
            neighborsgridview.Location = new Point(3, 45);
            neighborsgridview.Name = "neighborsgridview";
            neighborsgridview.RowHeadersWidth = 51;
            neighborsgridview.Size = new Size(679, 241);
            neighborsgridview.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // İsim
            // 
            İsim.HeaderText = "İsim";
            İsim.MinimumWidth = 6;
            İsim.Name = "İsim";
            İsim.Width = 125;
            // 
            // Aktiflik
            // 
            Aktiflik.HeaderText = "Aktiflik";
            Aktiflik.MinimumWidth = 6;
            Aktiflik.Name = "Aktiflik";
            Aktiflik.Width = 125;
            // 
            // Etkileşim
            // 
            Etkileşim.HeaderText = "Etkileşim";
            Etkileşim.MinimumWidth = 6;
            Etkileşim.Name = "Etkileşim";
            Etkileşim.Width = 125;
            // 
            // Derece
            // 
            Derece.HeaderText = "Derece";
            Derece.MinimumWidth = 6;
            Derece.Name = "Derece";
            Derece.Width = 125;
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
            grpSelectedNode.Size = new Size(487, 227);
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
            Size = new Size(1493, 1091);
            panelCanvas.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            grpView.ResumeLayout(false);
            grpNeighbors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)neighborsgridview).EndInit();
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
        private Button button2;
        private Button button1;
        private DataGridView neighborsgridview;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn İsim;
        private DataGridViewTextBoxColumn Aktiflik;
        private DataGridViewTextBoxColumn Etkileşim;
        private DataGridViewTextBoxColumn Derece;
        private Button deleteBtn;
    }
}
