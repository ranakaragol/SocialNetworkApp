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
            grpView = new GroupBox();
            deleteBtn = new Button();
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
            updatePanel = new CustomControls.RoundedPanel();
            btnNodeRadiusUpdate = new Button();
            txtBoxNodeRadiusValue = new TextBox();
            label1 = new Label();
            btnColorChange = new Button();
            informationPanel = new CustomControls.RoundedPanel();
            lblSelId = new Label();
            lblSelAktValue = new Label();
            lblSelIdValue = new Label();
            lblSelEtkValue = new Label();
            lblSelDegreeValue = new Label();
            lblSelDegree = new Label();
            lblSelEtk = new Label();
            lblSelAkt = new Label();
            lblSelNameValue = new Label();
            colorDialog1 = new ColorDialog();
            panelCanvas.SuspendLayout();
            panelRight.SuspendLayout();
            grpView.SuspendLayout();
            grpNeighbors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)neighborsgridview).BeginInit();
            grpSelectedNode.SuspendLayout();
            updatePanel.SuspendLayout();
            informationPanel.SuspendLayout();
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
            // grpView
            // 
            grpView.Controls.Add(deleteBtn);
            grpView.Controls.Add(btnResetSelection);
            grpView.Controls.Add(btnRandomLayout);
            grpView.Dock = DockStyle.Bottom;
            grpView.Location = new Point(0, 911);
            grpView.Margin = new Padding(3, 4, 3, 4);
            grpView.Name = "grpView";
            grpView.Padding = new Padding(3, 4, 3, 4);
            grpView.Size = new Size(487, 180);
            grpView.TabIndex = 2;
            grpView.TabStop = false;
            grpView.Text = "Görünüm";
            grpView.Enter += grpView_Enter;
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
            grpNeighbors.Location = new Point(0, 299);
            grpNeighbors.Margin = new Padding(3, 4, 3, 4);
            grpNeighbors.Name = "grpNeighbors";
            grpNeighbors.Padding = new Padding(3, 4, 3, 4);
            grpNeighbors.Size = new Size(487, 329);
            grpNeighbors.TabIndex = 1;
            grpNeighbors.TabStop = false;
            grpNeighbors.Text = "Komşular";
            // 
            // neighborsgridview
            // 
            neighborsgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            neighborsgridview.Columns.AddRange(new DataGridViewColumn[] { Id, İsim, Aktiflik, Etkileşim, Derece });
            neighborsgridview.Dock = DockStyle.Fill;
            neighborsgridview.Location = new Point(3, 24);
            neighborsgridview.Name = "neighborsgridview";
            neighborsgridview.RowHeadersWidth = 51;
            neighborsgridview.Size = new Size(481, 301);
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
            grpSelectedNode.Controls.Add(updatePanel);
            grpSelectedNode.Controls.Add(informationPanel);
            grpSelectedNode.Controls.Add(lblSelNameValue);
            grpSelectedNode.Dock = DockStyle.Top;
            grpSelectedNode.Location = new Point(0, 0);
            grpSelectedNode.Margin = new Padding(3, 4, 3, 4);
            grpSelectedNode.Name = "grpSelectedNode";
            grpSelectedNode.Padding = new Padding(3, 4, 3, 4);
            grpSelectedNode.Size = new Size(487, 299);
            grpSelectedNode.TabIndex = 0;
            grpSelectedNode.TabStop = false;
            grpSelectedNode.Text = "Seçili Düğüm";
            grpSelectedNode.Enter += grpSelectedNode_Enter;
            // 
            // updatePanel
            // 
            updatePanel.BackColor = Color.White;
            updatePanel.BorderColor = Color.Gray;
            updatePanel.BorderRadius = 30;
            updatePanel.BorderSize = 1F;
            updatePanel.Controls.Add(btnNodeRadiusUpdate);
            updatePanel.Controls.Add(txtBoxNodeRadiusValue);
            updatePanel.Controls.Add(label1);
            updatePanel.Controls.Add(btnColorChange);
            updatePanel.Location = new Point(237, 76);
            updatePanel.Name = "updatePanel";
            updatePanel.Padding = new Padding(15);
            updatePanel.Size = new Size(209, 223);
            updatePanel.TabIndex = 10;
            // 
            // btnNodeRadiusUpdate
            // 
            btnNodeRadiusUpdate.BackColor = SystemColors.Control;
            btnNodeRadiusUpdate.Location = new Point(31, 102);
            btnNodeRadiusUpdate.Margin = new Padding(3, 4, 3, 4);
            btnNodeRadiusUpdate.Name = "btnNodeRadiusUpdate";
            btnNodeRadiusUpdate.Size = new Size(145, 33);
            btnNodeRadiusUpdate.TabIndex = 12;
            btnNodeRadiusUpdate.Text = "Çap Güncelle";
            btnNodeRadiusUpdate.UseVisualStyleBackColor = false;
            btnNodeRadiusUpdate.Click += btnNodeRadiusUpdate_Click;
            // 
            // txtBoxNodeRadiusValue
            // 
            txtBoxNodeRadiusValue.Location = new Point(40, 61);
            txtBoxNodeRadiusValue.Name = "txtBoxNodeRadiusValue";
            txtBoxNodeRadiusValue.Size = new Size(125, 27);
            txtBoxNodeRadiusValue.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(37, 15);
            label1.Name = "label1";
            label1.Size = new Size(46, 28);
            label1.TabIndex = 8;
            label1.Text = "Çap";
            label1.Click += label1_Click_1;
            // 
            // btnColorChange
            // 
            btnColorChange.BackColor = SystemColors.Control;
            btnColorChange.Location = new Point(31, 143);
            btnColorChange.Margin = new Padding(3, 4, 3, 4);
            btnColorChange.Name = "btnColorChange";
            btnColorChange.Size = new Size(145, 72);
            btnColorChange.TabIndex = 10;
            btnColorChange.Text = "Rengi Değiştir";
            btnColorChange.UseVisualStyleBackColor = false;
            btnColorChange.Click += btnColorChange_Click;
            // 
            // informationPanel
            // 
            informationPanel.BackColor = Color.White;
            informationPanel.BorderColor = Color.Gray;
            informationPanel.BorderRadius = 30;
            informationPanel.BorderSize = 1F;
            informationPanel.Controls.Add(lblSelId);
            informationPanel.Controls.Add(lblSelAktValue);
            informationPanel.Controls.Add(lblSelIdValue);
            informationPanel.Controls.Add(lblSelEtkValue);
            informationPanel.Controls.Add(lblSelDegreeValue);
            informationPanel.Controls.Add(lblSelDegree);
            informationPanel.Controls.Add(lblSelEtk);
            informationPanel.Controls.Add(lblSelAkt);
            informationPanel.Location = new Point(0, 76);
            informationPanel.Name = "informationPanel";
            informationPanel.Padding = new Padding(15);
            informationPanel.Size = new Size(209, 184);
            informationPanel.TabIndex = 9;
            // 
            // lblSelId
            // 
            lblSelId.AutoSize = true;
            lblSelId.Font = new Font("Segoe UI", 12F);
            lblSelId.Location = new Point(24, 24);
            lblSelId.Name = "lblSelId";
            lblSelId.Size = new Size(31, 28);
            lblSelId.TabIndex = 0;
            lblSelId.Text = "ID";
            // 
            // lblSelAktValue
            // 
            lblSelAktValue.AutoSize = true;
            lblSelAktValue.BackColor = Color.White;
            lblSelAktValue.Font = new Font("Segoe UI", 12F);
            lblSelAktValue.Location = new Point(126, 60);
            lblSelAktValue.Name = "lblSelAktValue";
            lblSelAktValue.Size = new Size(23, 28);
            lblSelAktValue.TabIndex = 3;
            lblSelAktValue.Text = "0";
            // 
            // lblSelIdValue
            // 
            lblSelIdValue.AutoSize = true;
            lblSelIdValue.BackColor = Color.White;
            lblSelIdValue.Font = new Font("Segoe UI", 12F);
            lblSelIdValue.Location = new Point(126, 24);
            lblSelIdValue.Name = "lblSelIdValue";
            lblSelIdValue.Size = new Size(20, 28);
            lblSelIdValue.TabIndex = 1;
            lblSelIdValue.Text = "-";
            // 
            // lblSelEtkValue
            // 
            lblSelEtkValue.AutoSize = true;
            lblSelEtkValue.Font = new Font("Segoe UI", 12F);
            lblSelEtkValue.Location = new Point(125, 97);
            lblSelEtkValue.Name = "lblSelEtkValue";
            lblSelEtkValue.Size = new Size(23, 28);
            lblSelEtkValue.TabIndex = 5;
            lblSelEtkValue.Text = "0";
            // 
            // lblSelDegreeValue
            // 
            lblSelDegreeValue.AutoSize = true;
            lblSelDegreeValue.Font = new Font("Segoe UI", 12F);
            lblSelDegreeValue.Location = new Point(125, 136);
            lblSelDegreeValue.Name = "lblSelDegreeValue";
            lblSelDegreeValue.Size = new Size(23, 28);
            lblSelDegreeValue.TabIndex = 7;
            lblSelDegreeValue.Text = "0";
            // 
            // lblSelDegree
            // 
            lblSelDegree.AutoSize = true;
            lblSelDegree.Font = new Font("Segoe UI", 12F);
            lblSelDegree.Location = new Point(23, 136);
            lblSelDegree.Name = "lblSelDegree";
            lblSelDegree.Size = new Size(72, 28);
            lblSelDegree.TabIndex = 6;
            lblSelDegree.Text = "Derece";
            // 
            // lblSelEtk
            // 
            lblSelEtk.AutoSize = true;
            lblSelEtk.Font = new Font("Segoe UI", 12F);
            lblSelEtk.Location = new Point(23, 97);
            lblSelEtk.Name = "lblSelEtk";
            lblSelEtk.Size = new Size(89, 28);
            lblSelEtk.TabIndex = 4;
            lblSelEtk.Text = "Etkileşim";
            // 
            // lblSelAkt
            // 
            lblSelAkt.AutoSize = true;
            lblSelAkt.Font = new Font("Segoe UI", 12F);
            lblSelAkt.Location = new Point(24, 60);
            lblSelAkt.Name = "lblSelAkt";
            lblSelAkt.Size = new Size(73, 28);
            lblSelAkt.TabIndex = 2;
            lblSelAkt.Text = "Aktiflik";
            // 
            // lblSelNameValue
            // 
            lblSelNameValue.AutoSize = true;
            lblSelNameValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSelNameValue.Location = new Point(6, 30);
            lblSelNameValue.Name = "lblSelNameValue";
            lblSelNameValue.Size = new Size(24, 32);
            lblSelNameValue.TabIndex = 8;
            lblSelNameValue.Text = "-";
            lblSelNameValue.Click += label1_Click;
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
            updatePanel.ResumeLayout(false);
            updatePanel.PerformLayout();
            informationPanel.ResumeLayout(false);
            informationPanel.PerformLayout();
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
        private Label lblSelNameValue;
        private CustomControls.RoundedPanel informationPanel;
        private CustomControls.RoundedPanel updatePanel;
        private Button btnColorChange;
        private Label label1;
        private Button btnNodeRadiusUpdate;
        private TextBox txtBoxNodeRadiusValue;
        private ColorDialog colorDialog1;
    }
}
