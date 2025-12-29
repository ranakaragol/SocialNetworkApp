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
            updatePanel = new yazlab_2_frontend.CustomControls.RoundedPanel();
            btnNodeRadiusUpdate = new Button();
            txtBoxNodeRadiusValue = new TextBox();
            label1 = new Label();
            btnColorChange = new Button();
            informationPanel = new yazlab_2_frontend.CustomControls.RoundedPanel();
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
            panelCanvas.Name = "panelCanvas";
            panelCanvas.Size = new Size(880, 818);
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
            button2.Location = new Point(46, 15);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(31, 22);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.pngwing_com;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(10, 15);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(31, 22);
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
            panelRight.Location = new Point(880, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(426, 818);
            panelRight.TabIndex = 1;
            // 
            // grpView
            // 
            grpView.Controls.Add(deleteBtn);
            grpView.Controls.Add(btnResetSelection);
            grpView.Controls.Add(btnRandomLayout);
            grpView.Dock = DockStyle.Bottom;
            grpView.Location = new Point(0, 683);
            grpView.Name = "grpView";
            grpView.Size = new Size(426, 135);
            grpView.TabIndex = 2;
            grpView.TabStop = false;
            grpView.Text = "Görünüm";
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = SystemColors.Control;
            deleteBtn.Location = new Point(285, 33);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(126, 54);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Sil";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // btnResetSelection
            // 
            btnResetSelection.BackColor = SystemColors.Control;
            btnResetSelection.Location = new Point(154, 33);
            btnResetSelection.Name = "btnResetSelection";
            btnResetSelection.Size = new Size(126, 54);
            btnResetSelection.TabIndex = 1;
            btnResetSelection.Text = "Seçimi Temizle";
            btnResetSelection.UseVisualStyleBackColor = false;
            btnResetSelection.Click += btnResetSelection_Click;
            // 
            // btnRandomLayout
            // 
            btnRandomLayout.BackColor = SystemColors.Control;
            btnRandomLayout.Location = new Point(21, 33);
            btnRandomLayout.Name = "btnRandomLayout";
            btnRandomLayout.Size = new Size(127, 54);
            btnRandomLayout.TabIndex = 0;
            btnRandomLayout.Text = "Yerleşimi Yenile";
            btnRandomLayout.UseVisualStyleBackColor = false;
            btnRandomLayout.Click += btnRandomLayout_Click;
            // 
            // grpNeighbors
            // 
            grpNeighbors.Controls.Add(neighborsgridview);
            grpNeighbors.Dock = DockStyle.Top;
            grpNeighbors.Location = new Point(0, 224);
            grpNeighbors.Name = "grpNeighbors";
            grpNeighbors.Size = new Size(426, 247);
            grpNeighbors.TabIndex = 1;
            grpNeighbors.TabStop = false;
            grpNeighbors.Text = "Komşular";
            // 
            // neighborsgridview
            // 
            neighborsgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            neighborsgridview.Columns.AddRange(new DataGridViewColumn[] { Id, İsim, Aktiflik, Etkileşim, Derece });
            neighborsgridview.Dock = DockStyle.Fill;
            neighborsgridview.Location = new Point(3, 19);
            neighborsgridview.Margin = new Padding(3, 2, 3, 2);
            neighborsgridview.Name = "neighborsgridview";
            neighborsgridview.RowHeadersWidth = 51;
            neighborsgridview.Size = new Size(420, 225);
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
            grpSelectedNode.Name = "grpSelectedNode";
            grpSelectedNode.Size = new Size(426, 224);
            grpSelectedNode.TabIndex = 0;
            grpSelectedNode.TabStop = false;
            grpSelectedNode.Text = "Seçili Düğüm";
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
            updatePanel.Location = new Point(207, 57);
            updatePanel.Margin = new Padding(3, 2, 3, 2);
            updatePanel.Name = "updatePanel";
            updatePanel.Padding = new Padding(13, 11, 13, 11);
            updatePanel.Size = new Size(183, 167);
            updatePanel.TabIndex = 10;
            // 
            // btnNodeRadiusUpdate
            // 
            btnNodeRadiusUpdate.BackColor = SystemColors.Control;
            btnNodeRadiusUpdate.Location = new Point(27, 76);
            btnNodeRadiusUpdate.Name = "btnNodeRadiusUpdate";
            btnNodeRadiusUpdate.Size = new Size(127, 25);
            btnNodeRadiusUpdate.TabIndex = 12;
            btnNodeRadiusUpdate.Text = "Çap Güncelle";
            btnNodeRadiusUpdate.UseVisualStyleBackColor = false;
            btnNodeRadiusUpdate.Click += btnNodeRadiusUpdate_Click;
            // 
            // txtBoxNodeRadiusValue
            // 
            txtBoxNodeRadiusValue.Location = new Point(35, 46);
            txtBoxNodeRadiusValue.Margin = new Padding(3, 2, 3, 2);
            txtBoxNodeRadiusValue.Name = "txtBoxNodeRadiusValue";
            txtBoxNodeRadiusValue.Size = new Size(110, 23);
            txtBoxNodeRadiusValue.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(32, 11);
            label1.Name = "label1";
            label1.Size = new Size(37, 21);
            label1.TabIndex = 8;
            label1.Text = "Çap";
            // 
            // btnColorChange
            // 
            btnColorChange.BackColor = SystemColors.Control;
            btnColorChange.Location = new Point(27, 107);
            btnColorChange.Name = "btnColorChange";
            btnColorChange.Size = new Size(127, 54);
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
            informationPanel.Location = new Point(0, 57);
            informationPanel.Margin = new Padding(3, 2, 3, 2);
            informationPanel.Name = "informationPanel";
            informationPanel.Padding = new Padding(13, 11, 13, 11);
            informationPanel.Size = new Size(183, 138);
            informationPanel.TabIndex = 9;
            // 
            // lblSelId
            // 
            lblSelId.AutoSize = true;
            lblSelId.Font = new Font("Segoe UI", 12F);
            lblSelId.Location = new Point(21, 18);
            lblSelId.Name = "lblSelId";
            lblSelId.Size = new Size(25, 21);
            lblSelId.TabIndex = 0;
            lblSelId.Text = "ID";
            // 
            // lblSelAktValue
            // 
            lblSelAktValue.AutoSize = true;
            lblSelAktValue.BackColor = Color.White;
            lblSelAktValue.Font = new Font("Segoe UI", 12F);
            lblSelAktValue.Location = new Point(110, 45);
            lblSelAktValue.Name = "lblSelAktValue";
            lblSelAktValue.Size = new Size(19, 21);
            lblSelAktValue.TabIndex = 3;
            lblSelAktValue.Text = "0";
            // 
            // lblSelIdValue
            // 
            lblSelIdValue.AutoSize = true;
            lblSelIdValue.BackColor = Color.White;
            lblSelIdValue.Font = new Font("Segoe UI", 12F);
            lblSelIdValue.Location = new Point(110, 18);
            lblSelIdValue.Name = "lblSelIdValue";
            lblSelIdValue.Size = new Size(16, 21);
            lblSelIdValue.TabIndex = 1;
            lblSelIdValue.Text = "-";
            // 
            // lblSelEtkValue
            // 
            lblSelEtkValue.AutoSize = true;
            lblSelEtkValue.Font = new Font("Segoe UI", 12F);
            lblSelEtkValue.Location = new Point(109, 73);
            lblSelEtkValue.Name = "lblSelEtkValue";
            lblSelEtkValue.Size = new Size(19, 21);
            lblSelEtkValue.TabIndex = 5;
            lblSelEtkValue.Text = "0";
            // 
            // lblSelDegreeValue
            // 
            lblSelDegreeValue.AutoSize = true;
            lblSelDegreeValue.Font = new Font("Segoe UI", 12F);
            lblSelDegreeValue.Location = new Point(109, 102);
            lblSelDegreeValue.Name = "lblSelDegreeValue";
            lblSelDegreeValue.Size = new Size(19, 21);
            lblSelDegreeValue.TabIndex = 7;
            lblSelDegreeValue.Text = "0";
            // 
            // lblSelDegree
            // 
            lblSelDegree.AutoSize = true;
            lblSelDegree.Font = new Font("Segoe UI", 12F);
            lblSelDegree.Location = new Point(20, 102);
            lblSelDegree.Name = "lblSelDegree";
            lblSelDegree.Size = new Size(58, 21);
            lblSelDegree.TabIndex = 6;
            lblSelDegree.Text = "Derece";
            // 
            // lblSelEtk
            // 
            lblSelEtk.AutoSize = true;
            lblSelEtk.Font = new Font("Segoe UI", 12F);
            lblSelEtk.Location = new Point(20, 73);
            lblSelEtk.Name = "lblSelEtk";
            lblSelEtk.Size = new Size(72, 21);
            lblSelEtk.TabIndex = 4;
            lblSelEtk.Text = "Etkileşim";
            // 
            // lblSelAkt
            // 
            lblSelAkt.AutoSize = true;
            lblSelAkt.Font = new Font("Segoe UI", 12F);
            lblSelAkt.Location = new Point(21, 45);
            lblSelAkt.Name = "lblSelAkt";
            lblSelAkt.Size = new Size(58, 21);
            lblSelAkt.TabIndex = 2;
            lblSelAkt.Text = "Aktiflik";
            // 
            // lblSelNameValue
            // 
            lblSelNameValue.AutoSize = true;
            lblSelNameValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSelNameValue.Location = new Point(5, 22);
            lblSelNameValue.Name = "lblSelNameValue";
            lblSelNameValue.Size = new Size(20, 25);
            lblSelNameValue.TabIndex = 8;
            lblSelNameValue.Text = "-";
            // 
            // GraphViewPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panelRight);
            Controls.Add(panelCanvas);
            Name = "GraphViewPage";
            Size = new Size(1306, 818);
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
