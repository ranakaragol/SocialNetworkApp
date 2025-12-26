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
            edgeIdValue = new Label();
            edgeIdLabel = new Label();
            startNodeIdLabel = new Label();
            startNodeLabelValue = new TextBox();
            endNodeIdlabel = new Label();
            endNodeLabelValue = new TextBox();
            btnDeleteEdge = new Button();
            btnAddEdge = new Button();
            lblWeightValue = new Label();
            lblWeight = new Label();
            grpEdgeList = new GroupBox();
            dgvEdges = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
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
            grpEdgeForm.Controls.Add(edgeIdValue);
            grpEdgeForm.Controls.Add(edgeIdLabel);
            grpEdgeForm.Controls.Add(startNodeIdLabel);
            grpEdgeForm.Controls.Add(startNodeLabelValue);
            grpEdgeForm.Controls.Add(endNodeIdlabel);
            grpEdgeForm.Controls.Add(endNodeLabelValue);
            grpEdgeForm.Controls.Add(btnDeleteEdge);
            grpEdgeForm.Controls.Add(btnAddEdge);
            grpEdgeForm.Controls.Add(lblWeightValue);
            grpEdgeForm.Controls.Add(lblWeight);
            grpEdgeForm.Dock = DockStyle.Left;
            grpEdgeForm.Location = new Point(0, 0);
            grpEdgeForm.Margin = new Padding(3, 4, 3, 4);
            grpEdgeForm.Name = "grpEdgeForm";
            grpEdgeForm.Padding = new Padding(3, 4, 3, 4);
            grpEdgeForm.Size = new Size(483, 847);
            grpEdgeForm.TabIndex = 0;
            grpEdgeForm.TabStop = false;
            grpEdgeForm.Text = "Bağlantı İşlemleri";
            // 
            // edgeIdValue
            // 
            edgeIdValue.AutoSize = true;
            edgeIdValue.Font = new Font("Segoe UI", 19F);
            edgeIdValue.Location = new Point(27, 141);
            edgeIdValue.Name = "edgeIdValue";
            edgeIdValue.Size = new Size(33, 45);
            edgeIdValue.TabIndex = 12;
            edgeIdValue.Text = "-";
            // 
            // edgeIdLabel
            // 
            edgeIdLabel.AutoSize = true;
            edgeIdLabel.Font = new Font("Segoe UI", 19F);
            edgeIdLabel.Location = new Point(27, 83);
            edgeIdLabel.Name = "edgeIdLabel";
            edgeIdLabel.Size = new Size(171, 45);
            edgeIdLabel.TabIndex = 11;
            edgeIdLabel.Text = "Bağlantı Id";
            edgeIdLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // startNodeIdLabel
            // 
            startNodeIdLabel.AutoSize = true;
            startNodeIdLabel.Font = new Font("Segoe UI", 12F);
            startNodeIdLabel.Location = new Point(27, 240);
            startNodeIdLabel.Name = "startNodeIdLabel";
            startNodeIdLabel.Size = new Size(167, 28);
            startNodeIdLabel.TabIndex = 10;
            startNodeIdLabel.Text = "Kaynak Düğüm Id";
            // 
            // startNodeLabelValue
            // 
            startNodeLabelValue.Location = new Point(27, 281);
            startNodeLabelValue.Name = "startNodeLabelValue";
            startNodeLabelValue.Size = new Size(218, 27);
            startNodeLabelValue.TabIndex = 9;
            startNodeLabelValue.Text = "-";
            // 
            // endNodeIdlabel
            // 
            endNodeIdlabel.AutoSize = true;
            endNodeIdlabel.Font = new Font("Segoe UI", 12F);
            endNodeIdlabel.Location = new Point(27, 313);
            endNodeIdlabel.Name = "endNodeIdlabel";
            endNodeIdlabel.Size = new Size(156, 28);
            endNodeIdlabel.TabIndex = 8;
            endNodeIdlabel.Text = "Hedef Düğüm Id";
            // 
            // endNodeLabelValue
            // 
            endNodeLabelValue.Location = new Point(27, 354);
            endNodeLabelValue.Name = "endNodeLabelValue";
            endNodeLabelValue.Size = new Size(218, 27);
            endNodeLabelValue.TabIndex = 7;
            endNodeLabelValue.Text = "-";
            // 
            // btnDeleteEdge
            // 
            btnDeleteEdge.Location = new Point(55, 550);
            btnDeleteEdge.Margin = new Padding(3, 4, 3, 4);
            btnDeleteEdge.Name = "btnDeleteEdge";
            btnDeleteEdge.Size = new Size(229, 48);
            btnDeleteEdge.TabIndex = 6;
            btnDeleteEdge.Text = "Bağlantı Sil";
            btnDeleteEdge.UseVisualStyleBackColor = true;
            btnDeleteEdge.Click += btnDeleteEdge_Click;
            // 
            // btnAddEdge
            // 
            btnAddEdge.Location = new Point(55, 494);
            btnAddEdge.Margin = new Padding(3, 4, 3, 4);
            btnAddEdge.Name = "btnAddEdge";
            btnAddEdge.Size = new Size(229, 48);
            btnAddEdge.TabIndex = 5;
            btnAddEdge.Text = "Bağlantı Ekle";
            btnAddEdge.UseVisualStyleBackColor = true;
            btnAddEdge.Click += btnAddEdge_Click;
            // 
            // lblWeightValue
            // 
            lblWeightValue.BorderStyle = BorderStyle.FixedSingle;
            lblWeightValue.Location = new Point(112, 411);
            lblWeightValue.Name = "lblWeightValue";
            lblWeightValue.Size = new Size(213, 33);
            lblWeightValue.TabIndex = 4;
            lblWeightValue.Text = "-";
            lblWeightValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI", 11F);
            lblWeight.Location = new Point(27, 413);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(66, 25);
            lblWeight.TabIndex = 3;
            lblWeight.Text = "Ağırlık";
            // 
            // grpEdgeList
            // 
            grpEdgeList.Controls.Add(dgvEdges);
            grpEdgeList.Dock = DockStyle.Fill;
            grpEdgeList.Location = new Point(483, 0);
            grpEdgeList.Margin = new Padding(3, 4, 3, 4);
            grpEdgeList.Name = "grpEdgeList";
            grpEdgeList.Padding = new Padding(3, 4, 3, 4);
            grpEdgeList.Size = new Size(479, 847);
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
            dgvEdges.Columns.AddRange(new DataGridViewColumn[] { Id, colFromId, colTold, colWeight });
            dgvEdges.Dock = DockStyle.Fill;
            dgvEdges.Location = new Point(3, 24);
            dgvEdges.Margin = new Padding(3, 4, 3, 4);
            dgvEdges.MultiSelect = false;
            dgvEdges.Name = "dgvEdges";
            dgvEdges.RowHeadersWidth = 51;
            dgvEdges.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEdges.Size = new Size(473, 819);
            dgvEdges.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            // 
            // colFromId
            // 
            colFromId.HeaderText = "StartNodeId";
            colFromId.MinimumWidth = 6;
            colFromId.Name = "colFromId";
            // 
            // colTold
            // 
            colTold.HeaderText = "EndNodeId";
            colTold.MinimumWidth = 6;
            colTold.Name = "colTold";
            // 
            // colWeight
            // 
            colWeight.HeaderText = "Weight";
            colWeight.MinimumWidth = 6;
            colWeight.Name = "colWeight";
            // 
            // EdgesPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpEdgeList);
            Controls.Add(grpEdgeForm);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EdgesPage";
            Size = new Size(962, 847);
            grpEdgeForm.ResumeLayout(false);
            grpEdgeForm.PerformLayout();
            grpEdgeList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEdges).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpEdgeForm;
        private GroupBox grpEdgeList;
        private Label lblWeightValue;
        private Label lblWeight;
        private Label label1;
        private Button btnDeleteEdge;
        private Button btnAddEdge;
        private DataGridView dgvEdges;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn colFromId;
        private DataGridViewTextBoxColumn colTold;
        private DataGridViewTextBoxColumn colWeight;
        private Label edgeIdValue;
        private Label edgeIdLabel;
        private Label startNodeIdLabel;
        private TextBox startNodeLabelValue;
        private Label endNodeIdlabel;
        private TextBox endNodeLabelValue;
    }
}
