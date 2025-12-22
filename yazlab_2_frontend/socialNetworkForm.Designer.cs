using yazlab_2_frontend.CustomWidgets;

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
            delete = new Button();
            dfs_trigger = new Button();
            bfs_trigger = new Button();
            degreeLabel = new Label();
            label1 = new Label();
            button1 = new Button();
            label5 = new Label();
            idLabel = new Label();
            label3 = new Label();
            nameLabel = new Label();
            label2 = new Label();
            CanvasPanel = new Panel();
            customButton2 = new CustomButton();
            customButton1 = new CustomButton();
            startNodeLabel = new Label();
            startNodeValue = new Label();
            AttributePanel.SuspendLayout();
            CanvasPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AttributePanel
            // 
            AttributePanel.BackColor = SystemColors.ControlLightLight;
            AttributePanel.Controls.Add(startNodeValue);
            AttributePanel.Controls.Add(startNodeLabel);
            AttributePanel.Controls.Add(delete);
            AttributePanel.Controls.Add(dfs_trigger);
            AttributePanel.Controls.Add(bfs_trigger);
            AttributePanel.Controls.Add(degreeLabel);
            AttributePanel.Controls.Add(label1);
            AttributePanel.Controls.Add(button1);
            AttributePanel.Controls.Add(label5);
            AttributePanel.Controls.Add(idLabel);
            AttributePanel.Controls.Add(label3);
            AttributePanel.Controls.Add(nameLabel);
            AttributePanel.Controls.Add(label2);
            AttributePanel.Dock = DockStyle.Right;
            AttributePanel.Location = new Point(499, 0);
            AttributePanel.Name = "AttributePanel";
            AttributePanel.Size = new Size(244, 577);
            AttributePanel.TabIndex = 0;
            // 
            // delete
            // 
            delete.Location = new Point(70, 440);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 10;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // dfs_trigger
            // 
            dfs_trigger.Location = new Point(126, 271);
            dfs_trigger.Name = "dfs_trigger";
            dfs_trigger.Size = new Size(94, 29);
            dfs_trigger.TabIndex = 9;
            dfs_trigger.Text = "DFS trigger";
            dfs_trigger.UseVisualStyleBackColor = true;
            dfs_trigger.Click += dfs_trigger_click;
            // 
            // bfs_trigger
            // 
            bfs_trigger.Location = new Point(6, 271);
            bfs_trigger.Name = "bfs_trigger";
            bfs_trigger.Size = new Size(94, 29);
            bfs_trigger.TabIndex = 8;
            bfs_trigger.Text = "BFS trigger";
            bfs_trigger.UseVisualStyleBackColor = true;
            bfs_trigger.Click += bfs_trigger_Click;
            // 
            // degreeLabel
            // 
            degreeLabel.AutoSize = true;
            degreeLabel.ForeColor = SystemColors.MenuText;
            degreeLabel.Location = new Point(90, 174);
            degreeLabel.Name = "degreeLabel";
            degreeLabel.Size = new Size(49, 20);
            degreeLabel.TabIndex = 7;
            degreeLabel.Text = "Name";
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
            button1.Location = new Point(12, 344);
            button1.Name = "button1";
            button1.Size = new Size(127, 42);
            button1.TabIndex = 0;
            button1.TabStop = false;
            button1.Text = "AddNode";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(6, 174);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 6;
            label5.Text = "Degree";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            idLabel.Location = new Point(78, 97);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(99, 35);
            idLabel.TabIndex = 3;
            idLabel.Text = "123132";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(6, 141);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 4;
            label3.Text = "Name";
            label3.Click += label3_Click_1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.ForeColor = SystemColors.MenuText;
            nameLabel.Location = new Point(90, 141);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(49, 20);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(6, 97);
            label2.Name = "label2";
            label2.Size = new Size(79, 35);
            label2.TabIndex = 2;
            label2.Text = "Node";
            label2.Click += label2_Click;
            // 
            // CanvasPanel
            // 
            CanvasPanel.BackColor = Color.Silver;
            CanvasPanel.Controls.Add(customButton2);
            CanvasPanel.Controls.Add(customButton1);
            CanvasPanel.Dock = DockStyle.Fill;
            CanvasPanel.Location = new Point(0, 0);
            CanvasPanel.Name = "CanvasPanel";
            CanvasPanel.Size = new Size(499, 577);
            CanvasPanel.TabIndex = 1;
            CanvasPanel.Paint += CanvasPanel_Paint_1;
            CanvasPanel.MouseClick += CanvasPanel_MouseClick;
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
            // startNodeLabel
            // 
            startNodeLabel.AutoSize = true;
            startNodeLabel.Location = new Point(6, 208);
            startNodeLabel.Name = "startNodeLabel";
            startNodeLabel.Size = new Size(81, 20);
            startNodeLabel.TabIndex = 11;
            startNodeLabel.Text = "Start Node";
            // 
            // startNodeValue
            // 
            startNodeValue.AutoSize = true;
            startNodeValue.Location = new Point(90, 208);
            startNodeValue.Name = "startNodeValue";
            startNodeValue.Size = new Size(72, 20);
            startNodeValue.TabIndex = 12;
            startNodeValue.Text = "startnode";
            // 
            // socialNetworkForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 577);
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
        private CustomButton customButton1;
        private CustomButton customButton2;
        private Label idLabel;
        private Label label5;
        private Label nameLabel;
        private Label label3;
        private Label degreeLabel;
        private Button bfs_trigger;
        private Button dfs_trigger;
        private Button delete;
        private Label startNodeValue;
        private Label startNodeLabel;
    }
}