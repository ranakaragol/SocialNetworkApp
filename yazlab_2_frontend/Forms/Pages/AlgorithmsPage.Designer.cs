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
            button2 = new Button();
            button1 = new Button();
            tabOutput = new TabPage();
            splitOut = new SplitContainer();
            lblMaliyetValue = new Label();
            lblMaliyet = new Label();
            lblDurumValue = new Label();
            label7 = new Label();
            lblTimeValue = new Label();
            labelTime = new Label();
            label4 = new Label();
            lstLogs = new ListBox();
            grpAlgorithms.SuspendLayout();
            tabResults.SuspendLayout();
            tabPreview.SuspendLayout();
            panelAlgoCanvas.SuspendLayout();
            tabOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitOut).BeginInit();
            splitOut.Panel1.SuspendLayout();
            splitOut.Panel2.SuspendLayout();
            splitOut.SuspendLayout();
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
            grpAlgorithms.Name = "grpAlgorithms";
            grpAlgorithms.Size = new Size(363, 581);
            grpAlgorithms.TabIndex = 0;
            grpAlgorithms.TabStop = false;
            grpAlgorithms.Text = "Algoritmalar";
            // 
            // btnClearResult
            // 
            btnClearResult.Font = new Font("Segoe UI", 10F);
            btnClearResult.Location = new Point(97, 157);
            btnClearResult.Name = "btnClearResult";
            btnClearResult.Size = new Size(119, 27);
            btnClearResult.TabIndex = 7;
            btnClearResult.Text = "Sonucu Temizle";
            btnClearResult.UseVisualStyleBackColor = true;
            btnClearResult.Click += btnClearResult_Click;
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Segoe UI", 10F);
            btnRun.Location = new Point(222, 157);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(119, 27);
            btnRun.TabIndex = 6;
            btnRun.Text = "Çalıştır";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // cmbTarget
            // 
            cmbTarget.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTarget.FormattingEnabled = true;
            cmbTarget.Location = new Point(161, 110);
            cmbTarget.Name = "cmbTarget";
            cmbTarget.Size = new Size(180, 25);
            cmbTarget.TabIndex = 5;
            // 
            // cmbStart
            // 
            cmbStart.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStart.FormattingEnabled = true;
            cmbStart.Location = new Point(161, 81);
            cmbStart.Name = "cmbStart";
            cmbStart.Size = new Size(180, 25);
            cmbStart.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(14, 112);
            label3.Name = "label3";
            label3.Size = new Size(95, 19);
            label3.TabIndex = 3;
            label3.Text = "Hedef Düğüm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(14, 83);
            label2.Name = "label2";
            label2.Size = new Size(123, 19);
            label2.TabIndex = 2;
            label2.Text = "Başlangıç Düğümü";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(14, 55);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 1;
            label1.Text = "Algoritmalar";
            // 
            // cmbAlgorithms
            // 
            cmbAlgorithms.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlgorithms.FormattingEnabled = true;
            cmbAlgorithms.Items.AddRange(new object[] { "BFS", "DFS", "Dijkstra", "A*", "Bağlı bileşenler", "Merkezilik", "Welsh-Powell" });
            cmbAlgorithms.Location = new Point(161, 52);
            cmbAlgorithms.Name = "cmbAlgorithms";
            cmbAlgorithms.Size = new Size(180, 25);
            cmbAlgorithms.TabIndex = 0;
            // 
            // tabResults
            // 
            tabResults.Controls.Add(tabPreview);
            tabResults.Controls.Add(tabOutput);
            tabResults.Dock = DockStyle.Fill;
            tabResults.Font = new Font("Segoe UI", 10F);
            tabResults.Location = new Point(363, 0);
            tabResults.Name = "tabResults";
            tabResults.SelectedIndex = 0;
            tabResults.Size = new Size(472, 581);
            tabResults.TabIndex = 1;
            // 
            // tabPreview
            // 
            tabPreview.Controls.Add(panelAlgoCanvas);
            tabPreview.Location = new Point(4, 26);
            tabPreview.Name = "tabPreview";
            tabPreview.Padding = new Padding(3, 3, 3, 3);
            tabPreview.Size = new Size(464, 551);
            tabPreview.TabIndex = 0;
            tabPreview.Text = "Görsel";
            tabPreview.UseVisualStyleBackColor = true;
            // 
            // panelAlgoCanvas
            // 
            panelAlgoCanvas.Controls.Add(button2);
            panelAlgoCanvas.Controls.Add(button1);
            panelAlgoCanvas.Dock = DockStyle.Fill;
            panelAlgoCanvas.Location = new Point(3, 3);
            panelAlgoCanvas.Name = "panelAlgoCanvas";
            panelAlgoCanvas.Size = new Size(458, 545);
            panelAlgoCanvas.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.pngwing_com__1_;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(46, 13);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(31, 22);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.pngwing_com;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(10, 13);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(31, 22);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabOutput
            // 
            tabOutput.Controls.Add(splitOut);
            tabOutput.Location = new Point(4, 26);
            tabOutput.Name = "tabOutput";
            tabOutput.Padding = new Padding(3, 3, 3, 3);
            tabOutput.Size = new Size(464, 551);
            tabOutput.TabIndex = 1;
            tabOutput.Text = "Tablo/Çıktı";
            tabOutput.UseVisualStyleBackColor = true;
            // 
            // splitOut
            // 
            splitOut.Dock = DockStyle.Fill;
            splitOut.Location = new Point(3, 3);
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
            splitOut.Panel2.Controls.Add(label4);
            splitOut.Panel2.Controls.Add(lstLogs);
            splitOut.Size = new Size(458, 545);
            splitOut.SplitterDistance = 199;
            splitOut.TabIndex = 0;
            // 
            // lblMaliyetValue
            // 
            lblMaliyetValue.AutoSize = true;
            lblMaliyetValue.Location = new Point(121, 81);
            lblMaliyetValue.Name = "lblMaliyetValue";
            lblMaliyetValue.Size = new Size(15, 19);
            lblMaliyetValue.TabIndex = 5;
            lblMaliyetValue.Text = "-";
            // 
            // lblMaliyet
            // 
            lblMaliyet.AutoSize = true;
            lblMaliyet.Location = new Point(13, 81);
            lblMaliyet.Name = "lblMaliyet";
            lblMaliyet.Size = new Size(102, 19);
            lblMaliyet.TabIndex = 4;
            lblMaliyet.Text = "Toplam Maliyet";
            // 
            // lblDurumValue
            // 
            lblDurumValue.AutoSize = true;
            lblDurumValue.Location = new Point(121, 52);
            lblDurumValue.Name = "lblDurumValue";
            lblDurumValue.Size = new Size(15, 19);
            lblDurumValue.TabIndex = 3;
            lblDurumValue.Text = "-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 52);
            label7.Name = "label7";
            label7.Size = new Size(52, 19);
            label7.TabIndex = 2;
            label7.Text = "Durum";
            // 
            // lblTimeValue
            // 
            lblTimeValue.AutoSize = true;
            lblTimeValue.Location = new Point(121, 23);
            lblTimeValue.Name = "lblTimeValue";
            lblTimeValue.Size = new Size(15, 19);
            lblTimeValue.TabIndex = 1;
            lblTimeValue.Text = "-";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(13, 23);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(96, 19);
            labelTime.TabIndex = 0;
            labelTime.Text = "Çalışma Süresi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(3, 12);
            label4.Name = "label4";
            label4.Size = new Size(43, 25);
            label4.TabIndex = 2;
            label4.Text = "Log";
            // 
            // lstLogs
            // 
            lstLogs.FormattingEnabled = true;
            lstLogs.ItemHeight = 17;
            lstLogs.Location = new Point(3, 38);
            lstLogs.Margin = new Padding(3, 2, 3, 2);
            lstLogs.Name = "lstLogs";
            lstLogs.Size = new Size(1062, 412);
            lstLogs.TabIndex = 1;
            lstLogs.SelectedIndexChanged += lstLogs_SelectedIndexChanged;
            // 
            // AlgorithmsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabResults);
            Controls.Add(grpAlgorithms);
            Name = "AlgorithmsPage";
            Size = new Size(835, 581);
            grpAlgorithms.ResumeLayout(false);
            grpAlgorithms.PerformLayout();
            tabResults.ResumeLayout(false);
            tabPreview.ResumeLayout(false);
            panelAlgoCanvas.ResumeLayout(false);
            tabOutput.ResumeLayout(false);
            splitOut.Panel1.ResumeLayout(false);
            splitOut.Panel1.PerformLayout();
            splitOut.Panel2.ResumeLayout(false);
            splitOut.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitOut).EndInit();
            splitOut.ResumeLayout(false);
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
        private RichTextBox rtbLog;
        private Button button2;
        private Button button1;
        private ListBox lstLogs;
        private Label label4;
    }
}
