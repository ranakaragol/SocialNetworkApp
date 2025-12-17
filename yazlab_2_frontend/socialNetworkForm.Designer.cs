namespace yazlab_2_frontend
{
    partial class socialNetworkForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AttributePanel = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            CanvasPanel = new Panel();
            customButton2 = new CustomButton();
            customButton1 = new CustomButton();
            AttributePanel.SuspendLayout();
            CanvasPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AttributePanel
            // 
            AttributePanel.BackColor = SystemColors.AppWorkspace;
            AttributePanel.Controls.Add(label5);
            AttributePanel.Controls.Add(label4);
            AttributePanel.Controls.Add(label3);
            AttributePanel.Controls.Add(label2);
            AttributePanel.Controls.Add(label1);
            AttributePanel.Controls.Add(button1);
            AttributePanel.Dock = DockStyle.Right;
            AttributePanel.Location = new Point(531, 0);
            AttributePanel.Name = "AttributePanel";
            AttributePanel.Size = new Size(250, 558);
            AttributePanel.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 125);
            label5.Name = "label5";
            label5.Size = new Size(25, 20);
            label5.TabIndex = 5;
            label5.Text = "Id:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 185);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 4;
            label4.Text = "NumOfNeighbors:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 154);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 3;
            label3.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 96);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "Properties";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 34);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 1;
            label1.Text = "SocialNetworkApp";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 2;
            button1.Location = new Point(59, 484);
            button1.Name = "button1";
            button1.Size = new Size(127, 42);
            button1.TabIndex = 0;
            button1.TabStop = false;
            button1.Text = "AddNode";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CanvasPanel
            // 
            CanvasPanel.BackColor = Color.Silver;
            CanvasPanel.Controls.Add(customButton2);
            CanvasPanel.Controls.Add(customButton1);
            CanvasPanel.Dock = DockStyle.Fill;
            CanvasPanel.Location = new Point(0, 0);
            CanvasPanel.Name = "CanvasPanel";
            CanvasPanel.Size = new Size(531, 558);
            CanvasPanel.TabIndex = 1;
            CanvasPanel.Paint += CanvasPanel_Paint_1;
            CanvasPanel.Resize += CanvasPanel_Resize;
            // 
            // customButton2
            // 
            customButton2.BackgroundImage = Properties.Resources.pngwing_com__1_;
            customButton2.BackgroundImageLayout = ImageLayout.Zoom;
            customButton2.Location = new Point(50, 24);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(32, 30);
            customButton2.TabIndex = 3;
            customButton2.UseVisualStyleBackColor = true;
            customButton2.Click += customButton2_Click;
            customButton2.Paint += customButton2_Paint;
            // 
            // customButton1
            // 
            customButton1.BackgroundImage = Properties.Resources.pngwing_com;
            customButton1.BackgroundImageLayout = ImageLayout.Zoom;
            customButton1.Location = new Point(12, 24);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(32, 30);
            customButton1.TabIndex = 2;
            customButton1.UseVisualStyleBackColor = true;
            customButton1.Click += customButton1_Click;
            customButton1.Paint += customButton1_Paint;
            // 
            // socialNetworkForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 558);
            Controls.Add(CanvasPanel);
            Controls.Add(AttributePanel);
            Name = "socialNetworkForm";
            Text = "SocialNetworkForm";
            AttributePanel.ResumeLayout(false);
            AttributePanel.PerformLayout();
            CanvasPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel AttributePanel;
        private Button button1;
        private Panel CanvasPanel;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private CustomButton customButton1;
        private CustomButton customButton2;
    }
}