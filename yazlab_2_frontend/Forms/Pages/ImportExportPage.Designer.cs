namespace yazlab_2_frontend.Forms.Pages
{
    partial class ImportExportPage
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
            splitContainer1 = new SplitContainer();
            grpAdj = new GroupBox();
            btnBuildAdj = new Button();
            radioButtonkomsuMatris = new RadioButton();
            radioButtonkomsulist = new RadioButton();
            grbExportOptions = new GroupBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            grpFileOps = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnBrowse = new Button();
            btnLoad = new Button();
            btnSave = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            rbCsv = new RadioButton();
            rbJson = new RadioButton();
            label1 = new Label();
            tabControlIO = new TabControl();
            tabPreview = new TabPage();
            lblFormatInfo = new Label();
            rtbPreview = new RichTextBox();
            btnClearPreview = new Button();
            btnCopy = new Button();
            tabLog = new TabPage();
            rtbIOLog = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            grpAdj.SuspendLayout();
            grbExportOptions.SuspendLayout();
            grpFileOps.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabControlIO.SuspendLayout();
            tabPreview.SuspendLayout();
            tabLog.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(grpAdj);
            splitContainer1.Panel1.Controls.Add(grbExportOptions);
            splitContainer1.Panel1.Controls.Add(grpFileOps);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControlIO);
            splitContainer1.Size = new Size(685, 575);
            splitContainer1.SplitterDistance = 350;
            splitContainer1.TabIndex = 0;
            // 
            // grpAdj
            // 
            grpAdj.Controls.Add(btnBuildAdj);
            grpAdj.Controls.Add(radioButtonkomsuMatris);
            grpAdj.Controls.Add(radioButtonkomsulist);
            grpAdj.Dock = DockStyle.Fill;
            grpAdj.Font = new Font("Segoe UI", 10F);
            grpAdj.Location = new Point(0, 440);
            grpAdj.Name = "grpAdj";
            grpAdj.Size = new Size(350, 135);
            grpAdj.TabIndex = 2;
            grpAdj.TabStop = false;
            grpAdj.Text = "Komşuculuk Çıktısı";
            // 
            // btnBuildAdj
            // 
            btnBuildAdj.Location = new Point(19, 96);
            btnBuildAdj.Name = "btnBuildAdj";
            btnBuildAdj.Size = new Size(118, 36);
            btnBuildAdj.TabIndex = 6;
            btnBuildAdj.Text = "Oluştur";
            btnBuildAdj.UseVisualStyleBackColor = true;
            // 
            // radioButtonkomsuMatris
            // 
            radioButtonkomsuMatris.AutoSize = true;
            radioButtonkomsuMatris.Location = new Point(19, 64);
            radioButtonkomsuMatris.Name = "radioButtonkomsuMatris";
            radioButtonkomsuMatris.Size = new Size(147, 23);
            radioButtonkomsuMatris.TabIndex = 5;
            radioButtonkomsuMatris.TabStop = true;
            radioButtonkomsuMatris.Text = "Komşuculuk Matrisi";
            radioButtonkomsuMatris.UseVisualStyleBackColor = true;
            // 
            // radioButtonkomsulist
            // 
            radioButtonkomsulist.AutoSize = true;
            radioButtonkomsulist.Location = new Point(19, 35);
            radioButtonkomsulist.Name = "radioButtonkomsulist";
            radioButtonkomsulist.Size = new Size(142, 23);
            radioButtonkomsulist.TabIndex = 4;
            radioButtonkomsulist.TabStop = true;
            radioButtonkomsulist.Text = "Komşuculuk Listesi";
            radioButtonkomsulist.UseVisualStyleBackColor = true;
            // 
            // grbExportOptions
            // 
            grbExportOptions.Controls.Add(checkBox4);
            grbExportOptions.Controls.Add(checkBox3);
            grbExportOptions.Controls.Add(checkBox2);
            grbExportOptions.Controls.Add(checkBox1);
            grbExportOptions.Dock = DockStyle.Top;
            grbExportOptions.Font = new Font("Segoe UI", 10F);
            grbExportOptions.Location = new Point(0, 220);
            grbExportOptions.Name = "grbExportOptions";
            grbExportOptions.Size = new Size(350, 220);
            grbExportOptions.TabIndex = 1;
            grbExportOptions.TabStop = false;
            grbExportOptions.Text = "Dışa Aktarım";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(19, 125);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(106, 23);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "JSON girintili";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(19, 96);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(133, 23);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Ağırlıkları dahil et";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(19, 67);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(144, 23);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Bağlantıları dahil et";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(19, 38);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(141, 23);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Düğümleri dahil et";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // grpFileOps
            // 
            grpFileOps.Controls.Add(tableLayoutPanel1);
            grpFileOps.Controls.Add(textBox1);
            grpFileOps.Controls.Add(label2);
            grpFileOps.Controls.Add(rbCsv);
            grpFileOps.Controls.Add(rbJson);
            grpFileOps.Controls.Add(label1);
            grpFileOps.Dock = DockStyle.Top;
            grpFileOps.Font = new Font("Segoe UI", 10F);
            grpFileOps.Location = new Point(0, 0);
            grpFileOps.Name = "grpFileOps";
            grpFileOps.Size = new Size(350, 220);
            grpFileOps.TabIndex = 0;
            grpFileOps.TabStop = false;
            grpFileOps.Text = "Dosya İşlemleri";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.1672F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.41908F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.413723F));
            tableLayoutPanel1.Controls.Add(btnBrowse, 0, 0);
            tableLayoutPanel1.Controls.Add(btnLoad, 1, 0);
            tableLayoutPanel1.Controls.Add(btnSave, 2, 0);
            tableLayoutPanel1.Location = new Point(19, 156);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(264, 40);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // btnBrowse
            // 
            btnBrowse.Dock = DockStyle.Fill;
            btnBrowse.Location = new Point(4, 4);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(80, 32);
            btnBrowse.TabIndex = 0;
            btnBrowse.Text = "Gözat";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Dock = DockStyle.Fill;
            btnLoad.Location = new Point(91, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(80, 32);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Yükle";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(178, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 32);
            btnSave.TabIndex = 2;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 118);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(200, 25);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(19, 96);
            label2.Name = "label2";
            label2.Size = new Size(77, 19);
            label2.TabIndex = 3;
            label2.Text = "Dosya Yolu";
            // 
            // rbCsv
            // 
            rbCsv.AutoSize = true;
            rbCsv.Location = new Point(85, 57);
            rbCsv.Name = "rbCsv";
            rbCsv.Size = new Size(52, 23);
            rbCsv.TabIndex = 2;
            rbCsv.Text = "CSV";
            rbCsv.UseVisualStyleBackColor = true;
            // 
            // rbJson
            // 
            rbJson.AutoSize = true;
            rbJson.Location = new Point(19, 57);
            rbJson.Name = "rbJson";
            rbJson.Size = new Size(60, 23);
            rbJson.TabIndex = 1;
            rbJson.Text = "JSON";
            rbJson.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(19, 35);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 0;
            label1.Text = "Format";
            // 
            // tabControlIO
            // 
            tabControlIO.Controls.Add(tabPreview);
            tabControlIO.Controls.Add(tabLog);
            tabControlIO.Dock = DockStyle.Fill;
            tabControlIO.Font = new Font("Segoe UI", 10F);
            tabControlIO.Location = new Point(0, 0);
            tabControlIO.Name = "tabControlIO";
            tabControlIO.SelectedIndex = 0;
            tabControlIO.Size = new Size(331, 575);
            tabControlIO.TabIndex = 0;
            // 
            // tabPreview
            // 
            tabPreview.Controls.Add(lblFormatInfo);
            tabPreview.Controls.Add(rtbPreview);
            tabPreview.Controls.Add(btnClearPreview);
            tabPreview.Controls.Add(btnCopy);
            tabPreview.Font = new Font("Segoe UI", 10F);
            tabPreview.Location = new Point(4, 26);
            tabPreview.Name = "tabPreview";
            tabPreview.Padding = new Padding(3);
            tabPreview.Size = new Size(323, 545);
            tabPreview.TabIndex = 0;
            tabPreview.Text = "Önizleme";
            tabPreview.UseVisualStyleBackColor = true;
            // 
            // lblFormatInfo
            // 
            lblFormatInfo.AutoSize = true;
            lblFormatInfo.Font = new Font("Segoe UI", 10F);
            lblFormatInfo.Location = new Point(6, 60);
            lblFormatInfo.Name = "lblFormatInfo";
            lblFormatInfo.Size = new Size(156, 19);
            lblFormatInfo.TabIndex = 3;
            lblFormatInfo.Text = "Seçili Format: JSON/CSV";
            // 
            // rtbPreview
            // 
            rtbPreview.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rtbPreview.Location = new Point(6, 98);
            rtbPreview.Name = "rtbPreview";
            rtbPreview.ReadOnly = true;
            rtbPreview.Size = new Size(317, 96);
            rtbPreview.TabIndex = 2;
            rtbPreview.Text = "";
            rtbPreview.WordWrap = false;
            // 
            // btnClearPreview
            // 
            btnClearPreview.Location = new Point(87, 11);
            btnClearPreview.Name = "btnClearPreview";
            btnClearPreview.Size = new Size(78, 37);
            btnClearPreview.TabIndex = 1;
            btnClearPreview.Text = "Temizle";
            btnClearPreview.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(6, 11);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(75, 37);
            btnCopy.TabIndex = 0;
            btnCopy.Text = "Kopyala";
            btnCopy.UseVisualStyleBackColor = true;
            // 
            // tabLog
            // 
            tabLog.Controls.Add(rtbIOLog);
            tabLog.Location = new Point(4, 26);
            tabLog.Name = "tabLog";
            tabLog.Padding = new Padding(3);
            tabLog.Size = new Size(323, 545);
            tabLog.TabIndex = 1;
            tabLog.Text = "Log/Hatalar";
            tabLog.UseVisualStyleBackColor = true;
            // 
            // rtbIOLog
            // 
            rtbIOLog.Dock = DockStyle.Fill;
            rtbIOLog.Location = new Point(3, 3);
            rtbIOLog.Name = "rtbIOLog";
            rtbIOLog.ReadOnly = true;
            rtbIOLog.Size = new Size(317, 539);
            rtbIOLog.TabIndex = 0;
            rtbIOLog.Text = "";
            // 
            // ImportExportPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "ImportExportPage";
            Size = new Size(685, 575);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            grpAdj.ResumeLayout(false);
            grpAdj.PerformLayout();
            grbExportOptions.ResumeLayout(false);
            grbExportOptions.PerformLayout();
            grpFileOps.ResumeLayout(false);
            grpFileOps.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tabControlIO.ResumeLayout(false);
            tabPreview.ResumeLayout(false);
            tabPreview.PerformLayout();
            tabLog.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox grpFileOps;
        private RadioButton rbJson;
        private Label label1;
        private RadioButton rbCsv;
        private TextBox textBox1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox grbExportOptions;
        private Button btnBrowse;
        private Button btnLoad;
        private Button btnSave;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox grpAdj;
        private RadioButton radioButtonkomsuMatris;
        private RadioButton radioButtonkomsulist;
        private Button btnBuildAdj;
        private TabControl tabControlIO;
        private TabPage tabPreview;
        private Button btnClearPreview;
        private Button btnCopy;
        private TabPage tabLog;
        private RichTextBox rtbPreview;
        private Label lblFormatInfo;
        private RichTextBox rtbIOLog;
    }
}
