namespace yazlab_2_frontend.Forms.Pages
{
    partial class NodesPage
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
            grpNodeForm = new GroupBox();
            button3 = new Button();
            btnDeleteNode = new Button();
            btnAddNode = new Button();
            numericUpDown2 = new NumericUpDown();
            lblNumEtk = new Label();
            numericUpDown1 = new NumericUpDown();
            lblNumAkt = new Label();
            txtNodeName = new TextBox();
            label2 = new Label();
            txtNodeId = new TextBox();
            label1 = new Label();
            grpNodeList = new GroupBox();
            dataGridViewNodes = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            Aktiflik = new DataGridViewTextBoxColumn();
            Etkileşim = new DataGridViewTextBoxColumn();
            Baglantisayisi = new DataGridViewTextBoxColumn();
            Cap = new DataGridViewTextBoxColumn();
            Renk = new DataGridViewTextBoxColumn();
            grpNodeForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            grpNodeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNodes).BeginInit();
            SuspendLayout();
            // 
            // grpNodeForm
            // 
            grpNodeForm.Controls.Add(button3);
            grpNodeForm.Controls.Add(btnDeleteNode);
            grpNodeForm.Controls.Add(btnAddNode);
            grpNodeForm.Controls.Add(numericUpDown2);
            grpNodeForm.Controls.Add(lblNumEtk);
            grpNodeForm.Controls.Add(numericUpDown1);
            grpNodeForm.Controls.Add(lblNumAkt);
            grpNodeForm.Controls.Add(txtNodeName);
            grpNodeForm.Controls.Add(label2);
            grpNodeForm.Controls.Add(txtNodeId);
            grpNodeForm.Controls.Add(label1);
            grpNodeForm.Dock = DockStyle.Left;
            grpNodeForm.Location = new Point(0, 0);
            grpNodeForm.Margin = new Padding(3, 4, 3, 4);
            grpNodeForm.Name = "grpNodeForm";
            grpNodeForm.Padding = new Padding(3, 4, 3, 4);
            grpNodeForm.Size = new Size(453, 892);
            grpNodeForm.TabIndex = 0;
            grpNodeForm.TabStop = false;
            grpNodeForm.Text = "Düğüm İşlemleri";
            // 
            // button3
            // 
            button3.Location = new Point(80, 292);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(91, 36);
            button3.TabIndex = 10;
            button3.Text = "Temizle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnDeleteNode
            // 
            btnDeleteNode.Location = new Point(130, 253);
            btnDeleteNode.Margin = new Padding(3, 4, 3, 4);
            btnDeleteNode.Name = "btnDeleteNode";
            btnDeleteNode.Size = new Size(91, 31);
            btnDeleteNode.TabIndex = 9;
            btnDeleteNode.Text = "Sil";
            btnDeleteNode.UseVisualStyleBackColor = true;
            btnDeleteNode.Click += btnDeleteNode_Click;
            // 
            // btnAddNode
            // 
            btnAddNode.Location = new Point(32, 252);
            btnAddNode.Margin = new Padding(3, 4, 3, 4);
            btnAddNode.Name = "btnAddNode";
            btnAddNode.Size = new Size(91, 32);
            btnAddNode.TabIndex = 8;
            btnAddNode.Text = "Ekle";
            btnAddNode.UseVisualStyleBackColor = true;
            btnAddNode.Click += btnAddNode_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(109, 187);
            numericUpDown2.Margin = new Padding(3, 4, 3, 4);
            numericUpDown2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(114, 27);
            numericUpDown2.TabIndex = 7;
            // 
            // lblNumEtk
            // 
            lblNumEtk.AutoSize = true;
            lblNumEtk.Font = new Font("Segoe UI", 10F);
            lblNumEtk.Location = new Point(32, 187);
            lblNumEtk.Name = "lblNumEtk";
            lblNumEtk.Size = new Size(76, 23);
            lblNumEtk.TabIndex = 6;
            lblNumEtk.Text = "Etkileşim";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown1.Location = new Point(109, 136);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(114, 27);
            numericUpDown1.TabIndex = 5;
            // 
            // lblNumAkt
            // 
            lblNumAkt.AutoSize = true;
            lblNumAkt.Font = new Font("Segoe UI", 10F);
            lblNumAkt.Location = new Point(32, 136);
            lblNumAkt.Name = "lblNumAkt";
            lblNumAkt.Size = new Size(60, 23);
            lblNumAkt.TabIndex = 4;
            lblNumAkt.Text = "Aktiflik";
            // 
            // txtNodeName
            // 
            txtNodeName.Location = new Point(109, 88);
            txtNodeName.Margin = new Padding(3, 4, 3, 4);
            txtNodeName.Name = "txtNodeName";
            txtNodeName.Size = new Size(114, 27);
            txtNodeName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(31, 89);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // txtNodeId
            // 
            txtNodeId.Location = new Point(109, 49);
            txtNodeId.Margin = new Padding(3, 4, 3, 4);
            txtNodeId.Name = "txtNodeId";
            txtNodeId.Size = new Size(114, 27);
            txtNodeId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(31, 51);
            label1.Name = "label1";
            label1.Size = new Size(27, 23);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // grpNodeList
            // 
            grpNodeList.Controls.Add(dataGridViewNodes);
            grpNodeList.Dock = DockStyle.Fill;
            grpNodeList.Location = new Point(453, 0);
            grpNodeList.Margin = new Padding(3, 4, 3, 4);
            grpNodeList.Name = "grpNodeList";
            grpNodeList.Padding = new Padding(3, 4, 3, 4);
            grpNodeList.Size = new Size(742, 892);
            grpNodeList.TabIndex = 1;
            grpNodeList.TabStop = false;
            grpNodeList.Text = "Düğüm Listesi";
            // 
            // dataGridViewNodes
            // 
            dataGridViewNodes.AllowUserToResizeRows = false;
            dataGridViewNodes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNodes.Columns.AddRange(new DataGridViewColumn[] { Id, colName, Aktiflik, Etkileşim, Baglantisayisi, Cap, Renk });
            dataGridViewNodes.Dock = DockStyle.Fill;
            dataGridViewNodes.Location = new Point(3, 24);
            dataGridViewNodes.Margin = new Padding(3, 4, 3, 4);
            dataGridViewNodes.Name = "dataGridViewNodes";
            dataGridViewNodes.ReadOnly = true;
            dataGridViewNodes.RowHeadersWidth = 51;
            dataGridViewNodes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewNodes.Size = new Size(736, 864);
            dataGridViewNodes.TabIndex = 0;
            dataGridViewNodes.CellClick += dataGridViewNodes_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 125;
            // 
            // Aktiflik
            // 
            Aktiflik.HeaderText = "Aktiflik";
            Aktiflik.MinimumWidth = 6;
            Aktiflik.Name = "Aktiflik";
            Aktiflik.ReadOnly = true;
            Aktiflik.Width = 125;
            // 
            // Etkileşim
            // 
            Etkileşim.HeaderText = "Etkileşim";
            Etkileşim.MinimumWidth = 6;
            Etkileşim.Name = "Etkileşim";
            Etkileşim.ReadOnly = true;
            Etkileşim.Width = 125;
            // 
            // Baglantisayisi
            // 
            Baglantisayisi.HeaderText = "Bağlantı Sayısı";
            Baglantisayisi.MinimumWidth = 6;
            Baglantisayisi.Name = "Baglantisayisi";
            Baglantisayisi.ReadOnly = true;
            Baglantisayisi.Width = 125;
            // 
            // Cap
            // 
            Cap.HeaderText = "Cap";
            Cap.MinimumWidth = 6;
            Cap.Name = "Cap";
            Cap.ReadOnly = true;
            Cap.Width = 125;
            // 
            // Renk
            // 
            Renk.HeaderText = "Renk";
            Renk.MinimumWidth = 6;
            Renk.Name = "Renk";
            Renk.ReadOnly = true;
            Renk.Width = 125;
            // 
            // NodesPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(grpNodeList);
            Controls.Add(grpNodeForm);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NodesPage";
            Size = new Size(1195, 892);
            grpNodeForm.ResumeLayout(false);
            grpNodeForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            grpNodeList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNodes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpNodeForm;
        private TextBox txtNodeName;
        private Label label2;
        private TextBox txtNodeId;
        private Label label1;
        private GroupBox grpNodeList;
        private NumericUpDown numericUpDown1;
        private Label lblNumAkt;
        private Button button3;
        private Button btnDeleteNode;
        private Button btnAddNode;
        private NumericUpDown numericUpDown2;
        private Label lblNumEtk;
        private DataGridView dataGridViewNodes;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn Aktiflik;
        private DataGridViewTextBoxColumn Etkileşim;
        private DataGridViewTextBoxColumn Baglantisayisi;
        private DataGridViewTextBoxColumn Cap;
        private DataGridViewTextBoxColumn Renk;
    }
}
