namespace yazlab_2_frontend.Forms.Pages
{
    partial class EdgesPage
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
            grpEdgeForm = new GroupBox();
            btnDeleteEdge = new Button();
            btnAddEdge = new Button();
            lblWeightValue = new Label();
            lblWeight = new Label();
            label1 = new Label();
            cmbTo = new ComboBox();
            cmbFrom = new ComboBox();
            grpEdgeList = new GroupBox();
            dgvEdges = new DataGridView();
            colFromId = new DataGridViewTextBoxColumn();
            colTold = new DataGridViewTextBoxColumn();
            colWeight = new DataGridViewTextBoxColumn();
            grpEdgeForm.SuspendLayout();
            grpEdgeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEdges).BeginInit();
            SuspendLayout();
            // 
            // grpEdgeForm
            // 
            grpEdgeForm.Controls.Add(btnDeleteEdge);
            grpEdgeForm.Controls.Add(btnAddEdge);
            grpEdgeForm.Controls.Add(lblWeightValue);
            grpEdgeForm.Controls.Add(lblWeight);
            grpEdgeForm.Controls.Add(label1);
            grpEdgeForm.Controls.Add(cmbTo);
            grpEdgeForm.Controls.Add(cmbFrom);
            grpEdgeForm.Dock = DockStyle.Left;
            grpEdgeForm.Location = new Point(0, 0);
            grpEdgeForm.Name = "grpEdgeForm";
            grpEdgeForm.Size = new Size(423, 635);
            grpEdgeForm.TabIndex = 0;
            grpEdgeForm.TabStop = false;
            grpEdgeForm.Text = "Bağlantı İşlemleri";
            // 
            // btnDeleteEdge
            // 
            btnDeleteEdge.Location = new Point(40, 243);
            btnDeleteEdge.Name = "btnDeleteEdge";
            btnDeleteEdge.Size = new Size(200, 36);
            btnDeleteEdge.TabIndex = 6;
            btnDeleteEdge.Text = "Bağlantı Sil";
            btnDeleteEdge.UseVisualStyleBackColor = true;
            btnDeleteEdge.Click += btnDeleteEdge_Click;
            // 
            // btnAddEdge
            // 
            btnAddEdge.Location = new Point(40, 201);
            btnAddEdge.Name = "btnAddEdge";
            btnAddEdge.Size = new Size(200, 36);
            btnAddEdge.TabIndex = 5;
            btnAddEdge.Text = "Bağlantı Ekle";
            btnAddEdge.UseVisualStyleBackColor = true;
            btnAddEdge.Click += btnAddEdge_Click;
            // 
            // lblWeightValue
            // 
            lblWeightValue.BorderStyle = BorderStyle.FixedSingle;
            lblWeightValue.Location = new Point(90, 139);
            lblWeightValue.Name = "lblWeightValue";
            lblWeightValue.Size = new Size(187, 25);
            lblWeightValue.TabIndex = 4;
            lblWeightValue.Text = "-";
            lblWeightValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI", 11F);
            lblWeight.Location = new Point(27, 140);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(52, 20);
            lblWeight.TabIndex = 3;
            lblWeight.Text = "Ağırlık";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(27, 36);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 2;
            label1.Text = "Bağlantı Id Girin:";
            // 
            // cmbTo
            // 
            cmbTo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTo.FormattingEnabled = true;
            cmbTo.Location = new Point(27, 97);
            cmbTo.Name = "cmbTo";
            cmbTo.Size = new Size(250, 23);
            cmbTo.TabIndex = 1;
            // 
            // cmbFrom
            // 
            cmbFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFrom.FormattingEnabled = true;
            cmbFrom.Location = new Point(27, 59);
            cmbFrom.Name = "cmbFrom";
            cmbFrom.Size = new Size(250, 23);
            cmbFrom.TabIndex = 0;
            // 
            // grpEdgeList
            // 
            grpEdgeList.Controls.Add(dgvEdges);
            grpEdgeList.Dock = DockStyle.Fill;
            grpEdgeList.Location = new Point(423, 0);
            grpEdgeList.Name = "grpEdgeList";
            grpEdgeList.Size = new Size(419, 635);
            grpEdgeList.TabIndex = 1;
            grpEdgeList.TabStop = false;
            grpEdgeList.Text = "Bağlantı Listesi";
            // 
            // dgvEdges
            // 
            dgvEdges.AllowUserToAddRows = false;
            dgvEdges.AllowUserToDeleteRows = false;
            dgvEdges.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEdges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEdges.Columns.AddRange(new DataGridViewColumn[] { colFromId, colTold, colWeight });
            dgvEdges.Dock = DockStyle.Fill;
            dgvEdges.Location = new Point(3, 19);
            dgvEdges.MultiSelect = false;
            dgvEdges.Name = "dgvEdges";
            dgvEdges.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEdges.Size = new Size(413, 613);
            dgvEdges.TabIndex = 0;
            // 
            // colFromId
            // 
            colFromId.HeaderText = "From Id";
            colFromId.Name = "colFromId";
            // 
            // colTold
            // 
            colTold.HeaderText = "To Id";
            colTold.Name = "colTold";
            // 
            // colWeight
            // 
            colWeight.HeaderText = "Ağırlık";
            colWeight.Name = "colWeight";
            // 
            // EdgesPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpEdgeList);
            Controls.Add(grpEdgeForm);
            Name = "EdgesPage";
            Size = new Size(842, 635);
            Load += EdgesPage_Load;
            grpEdgeForm.ResumeLayout(false);
            grpEdgeForm.PerformLayout();
            grpEdgeList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEdges).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpEdgeForm;
        private GroupBox grpEdgeList;
        private ComboBox cmbTo;
        private ComboBox cmbFrom;
        private Label lblWeightValue;
        private Label lblWeight;
        private Label label1;
        private Button btnDeleteEdge;
        private Button btnAddEdge;
        private DataGridView dgvEdges;
        private DataGridViewTextBoxColumn colFromId;
        private DataGridViewTextBoxColumn colTold;
        private DataGridViewTextBoxColumn colWeight;
    }
}
