namespace yazlab_2_frontend.Forms.Pages
{
    partial class AlgorithmsPage
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
            grpAlgorithms = new GroupBox();
            btnClearResult = new Button();
            btnRun = new Button();
            cmbTarget = new ComboBox();
            cmbStart = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbAlgorithms = new ComboBox();
            tabResults = new TabControl();
            tabPreview = new TabPage();
            panelAlgoCanvas = new Panel();
            tabOutput = new TabPage();
            splitOut = new SplitContainer();
            lblMaliyetValue = new Label();
            lblMaliyet = new Label();
            lblDurumValue = new Label();
            label7 = new Label();
            lblTimeValue = new Label();
            labelTime = new Label();
            rtbLog = new RichTextBox();
            dgvResult = new DataGridView();
            grpAlgorithms.SuspendLayout();
            tabResults.SuspendLayout();
            tabPreview.SuspendLayout();
            tabOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitOut).BeginInit();
            splitOut.Panel1.SuspendLayout();
            splitOut.Panel2.SuspendLayout();
            splitOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // grpAlgorithms
            // 
            grpAlgorithms.Controls.Add(btnClearResult);
            grpAlgorithms.Controls.Add(btnRun);
            grpAlgorithms.Controls.Add(cmbTarget);
            grpAlgorithms.Controls.Add(cmbStart);
            grpAlgorithms.Controls.Add(label3);
            grpAlgorithms.Controls.Add(label2);
            grpAlgorithms.Controls.Add(label1);
            grpAlgorithms.Controls.Add(cmbAlgorithms);
            grpAlgorithms.Dock = DockStyle.Left;
            grpAlgorithms.Font = new Font("Segoe UI", 10F);
            grpAlgorithms.Location = new Point(0, 0);
            grpAlgorithms.Margin = new Padding(3, 4, 3, 4);
            grpAlgorithms.Name = "grpAlgorithms";
            grpAlgorithms.Padding = new Padding(3, 4, 3, 4);
            grpAlgorithms.Size = new Size(415, 775);
            grpAlgorithms.TabIndex = 0;
            grpAlgorithms.TabStop = false;
            grpAlgorithms.Text = "Algoritmalar";
            // 
            // btnClearResult
            // 
            btnClearResult.Font = new Font("Segoe UI", 10F);
            btnClearResult.Location = new Point(111, 209);
            btnClearResult.Margin = new Padding(3, 4, 3, 4);
            btnClearResult.Name = "btnClearResult";
            btnClearResult.Size = new Size(136, 36);
            btnClearResult.TabIndex = 7;
            btnClearResult.Text = "Sonucu Temizle";
            btnClearResult.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Segoe UI", 10F);
            btnRun.Location = new Point(254, 209);
            btnRun.Margin = new Padding(3, 4, 3, 4);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(136, 36);
            btnRun.TabIndex = 6;
            btnRun.Text = "Çalıştır";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // cmbTarget
            // 
            cmbTarget.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTarget.FormattingEnabled = true;
            cmbTarget.Location = new Point(184, 147);
            cmbTarget.Margin = new Padding(3, 4, 3, 4);
            cmbTarget.Name = "cmbTarget";
            cmbTarget.Size = new Size(205, 31);
            cmbTarget.TabIndex = 5;
            // 
            // cmbStart
            // 
            cmbStart.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStart.FormattingEnabled = true;
            cmbStart.Location = new Point(184, 108);
            cmbStart.Margin = new Padding(3, 4, 3, 4);
            cmbStart.Name = "cmbStart";
            cmbStart.Size = new Size(205, 31);
            cmbStart.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(37, 152);
            label3.Name = "label3";
            label3.Size = new Size(117, 23);
            label3.TabIndex = 3;
            label3.Text = "Hedef Düğüm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(37, 113);
            label2.Name = "label2";
            label2.Size = new Size(153, 23);
            label2.TabIndex = 2;
            label2.Text = "Başlangıç Düğümü";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(37, 75);
            label1.Name = "label1";
            label1.Size = new Size(104, 23);
            label1.TabIndex = 1;
            label1.Text = "Algoritmalar";
            // 
            // cmbAlgorithms
            // 
            cmbAlgorithms.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlgorithms.FormattingEnabled = true;
            cmbAlgorithms.Items.AddRange(new object[] { "BFS", "DFS", "Dijkstra", "A*", "Bağlı bileşenler", "Merkezilik", "Welsh-Powell" });
            cmbAlgorithms.Location = new Point(184, 69);
            cmbAlgorithms.Margin = new Padding(3, 4, 3, 4);
            cmbAlgorithms.Name = "cmbAlgorithms";
            cmbAlgorithms.Size = new Size(205, 31);
            cmbAlgorithms.TabIndex = 0;
            // 
            // tabResults
            // 
            tabResults.Controls.Add(tabPreview);
            tabResults.Controls.Add(tabOutput);
            tabResults.Dock = DockStyle.Fill;
            tabResults.Font = new Font("Segoe UI", 10F);
            tabResults.Location = new Point(415, 0);
            tabResults.Margin = new Padding(3, 4, 3, 4);
            tabResults.Name = "tabResults";
            tabResults.SelectedIndex = 0;
            tabResults.Size = new Size(404, 775);
            tabResults.TabIndex = 1;
            // 
            // tabPreview
            // 
            tabPreview.Controls.Add(panelAlgoCanvas);
            tabPreview.Location = new Point(4, 32);
            tabPreview.Margin = new Padding(3, 4, 3, 4);
            tabPreview.Name = "tabPreview";
            tabPreview.Padding = new Padding(3, 4, 3, 4);
            tabPreview.Size = new Size(396, 739);
            tabPreview.TabIndex = 0;
            tabPreview.Text = "Görsel";
            tabPreview.UseVisualStyleBackColor = true;
            // 
            // panelAlgoCanvas
            // 
            panelAlgoCanvas.Dock = DockStyle.Fill;
            panelAlgoCanvas.Location = new Point(3, 4);
            panelAlgoCanvas.Margin = new Padding(3, 4, 3, 4);
            panelAlgoCanvas.Name = "panelAlgoCanvas";
            panelAlgoCanvas.Size = new Size(390, 731);
            panelAlgoCanvas.TabIndex = 0;
            // 
            // tabOutput
            // 
            tabOutput.Controls.Add(splitOut);
            tabOutput.Location = new Point(4, 32);
            tabOutput.Margin = new Padding(3, 4, 3, 4);
            tabOutput.Name = "tabOutput";
            tabOutput.Padding = new Padding(3, 4, 3, 4);
            tabOutput.Size = new Size(396, 739);
            tabOutput.TabIndex = 1;
            tabOutput.Text = "Tablo/Çıktı";
            tabOutput.UseVisualStyleBackColor = true;
            // 
            // splitOut
            // 
            splitOut.Dock = DockStyle.Fill;
            splitOut.Location = new Point(3, 4);
            splitOut.Margin = new Padding(3, 4, 3, 4);
            splitOut.Name = "splitOut";
            splitOut.Orientation = Orientation.Horizontal;
            // 
            // splitOut.Panel1
            // 
            splitOut.Panel1.Controls.Add(lblMaliyetValue);
            splitOut.Panel1.Controls.Add(lblMaliyet);
            splitOut.Panel1.Controls.Add(lblDurumValue);
            splitOut.Panel1.Controls.Add(label7);
            splitOut.Panel1.Controls.Add(lblTimeValue);
            splitOut.Panel1.Controls.Add(labelTime);
            // 
            // splitOut.Panel2
            // 
            splitOut.Panel2.Controls.Add(rtbLog);
            splitOut.Panel2.Controls.Add(dgvResult);
            splitOut.Size = new Size(390, 731);
            splitOut.SplitterDistance = 268;
            splitOut.SplitterWidth = 5;
            splitOut.TabIndex = 0;
            // 
            // lblMaliyetValue
            // 
            lblMaliyetValue.AutoSize = true;
            lblMaliyetValue.Location = new Point(138, 108);
            lblMaliyetValue.Name = "lblMaliyetValue";
            lblMaliyetValue.Size = new Size(17, 23);
            lblMaliyetValue.TabIndex = 5;
            lblMaliyetValue.Text = "-";
            // 
            // lblMaliyet
            // 
            lblMaliyet.AutoSize = true;
            lblMaliyet.Location = new Point(15, 108);
            lblMaliyet.Name = "lblMaliyet";
            lblMaliyet.Size = new Size(125, 23);
            lblMaliyet.TabIndex = 4;
            lblMaliyet.Text = "Toplam Maliyet";
            // 
            // lblDurumValue
            // 
            lblDurumValue.AutoSize = true;
            lblDurumValue.Location = new Point(138, 69);
            lblDurumValue.Name = "lblDurumValue";
            lblDurumValue.Size = new Size(17, 23);
            lblDurumValue.TabIndex = 3;
            lblDurumValue.Text = "-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 69);
            label7.Name = "label7";
            label7.Size = new Size(63, 23);
            label7.TabIndex = 2;
            label7.Text = "Durum";
            // 
            // lblTimeValue
            // 
            lblTimeValue.AutoSize = true;
            lblTimeValue.Location = new Point(138, 31);
            lblTimeValue.Name = "lblTimeValue";
            lblTimeValue.Size = new Size(17, 23);
            lblTimeValue.TabIndex = 1;
            lblTimeValue.Text = "-";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(15, 31);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(119, 23);
            labelTime.TabIndex = 0;
            labelTime.Text = "Çalışma Süresi";
            // 
            // rtbLog
            // 
            rtbLog.Dock = DockStyle.Bottom;
            rtbLog.Location = new Point(0, 259);
            rtbLog.Margin = new Padding(3, 4, 3, 4);
            rtbLog.Name = "rtbLog";
            rtbLog.ReadOnly = true;
            rtbLog.Size = new Size(390, 199);
            rtbLog.TabIndex = 1;
            rtbLog.Text = "";
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Dock = DockStyle.Fill;
            dgvResult.Location = new Point(0, 0);
            dgvResult.Margin = new Padding(3, 4, 3, 4);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.Size = new Size(390, 458);
            dgvResult.TabIndex = 0;
            // 
            // AlgorithmsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabResults);
            Controls.Add(grpAlgorithms);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AlgorithmsPage";
            Size = new Size(819, 775);
            grpAlgorithms.ResumeLayout(false);
            grpAlgorithms.PerformLayout();
            tabResults.ResumeLayout(false);
            tabPreview.ResumeLayout(false);
            tabOutput.ResumeLayout(false);
            splitOut.Panel1.ResumeLayout(false);
            splitOut.Panel1.PerformLayout();
            splitOut.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitOut).EndInit();
            splitOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpAlgorithms;
        private Label label1;
        private ComboBox cmbAlgorithms;
        private Label label3;
        private Label label2;
        private ComboBox cmbTarget;
        private ComboBox cmbStart;
        private Button btnClearResult;
        private Button btnRun;
        private TabControl tabResults;
        private TabPage tabPreview;
        private TabPage tabOutput;
        private Panel panelAlgoCanvas;
        private SplitContainer splitOut;
        private Label lblDurumValue;
        private Label label7;
        private Label lblTimeValue;
        private Label labelTime;
        private Label lblMaliyetValue;
        private Label lblMaliyet;
        private DataGridView dgvResult;
        private RichTextBox rtbLog;
    }
}
