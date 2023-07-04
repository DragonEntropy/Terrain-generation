namespace Terrain
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.madeByAlexanderJephthaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.madeWithMicrosoftVisualStudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codedInCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thereIsNoHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.amplitudeBox = new System.Windows.Forms.TextBox();
            this.bloatBox = new System.Windows.Forms.TextBox();
            this.spanBox = new System.Windows.Forms.TextBox();
            this.genBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.madeByAlexanderJephthaToolStripMenuItem,
            this.madeWithMicrosoftVisualStudioToolStripMenuItem,
            this.codedInCToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // madeByAlexanderJephthaToolStripMenuItem
            // 
            this.madeByAlexanderJephthaToolStripMenuItem.Name = "madeByAlexanderJephthaToolStripMenuItem";
            this.madeByAlexanderJephthaToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.madeByAlexanderJephthaToolStripMenuItem.Text = "Made by Alexander Jephtha";
            // 
            // madeWithMicrosoftVisualStudioToolStripMenuItem
            // 
            this.madeWithMicrosoftVisualStudioToolStripMenuItem.Name = "madeWithMicrosoftVisualStudioToolStripMenuItem";
            this.madeWithMicrosoftVisualStudioToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.madeWithMicrosoftVisualStudioToolStripMenuItem.Text = "Made with Microsoft Visual Studio";
            // 
            // codedInCToolStripMenuItem
            // 
            this.codedInCToolStripMenuItem.Name = "codedInCToolStripMenuItem";
            this.codedInCToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.codedInCToolStripMenuItem.Text = "Coded in C#";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.closeToolStripMenuItem.Text = "Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thereIsNoHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // thereIsNoHelpToolStripMenuItem
            // 
            this.thereIsNoHelpToolStripMenuItem.Name = "thereIsNoHelpToolStripMenuItem";
            this.thereIsNoHelpToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.thereIsNoHelpToolStripMenuItem.Text = "There is no help";
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(705, 32);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mainPanel.Location = new System.Drawing.Point(13, 61);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(767, 380);
            this.mainPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amplitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bloat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Generator Chance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Span";
            // 
            // amplitudeBox
            // 
            this.amplitudeBox.Location = new System.Drawing.Point(87, 33);
            this.amplitudeBox.Name = "amplitudeBox";
            this.amplitudeBox.Size = new System.Drawing.Size(59, 22);
            this.amplitudeBox.TabIndex = 7;
            this.amplitudeBox.Text = "1";
            // 
            // bloatBox
            // 
            this.bloatBox.Location = new System.Drawing.Point(231, 33);
            this.bloatBox.Name = "bloatBox";
            this.bloatBox.Size = new System.Drawing.Size(59, 22);
            this.bloatBox.TabIndex = 8;
            this.bloatBox.Text = "2";
            // 
            // spanBox
            // 
            this.spanBox.Location = new System.Drawing.Point(379, 32);
            this.spanBox.Name = "spanBox";
            this.spanBox.Size = new System.Drawing.Size(59, 22);
            this.spanBox.TabIndex = 9;
            this.spanBox.Text = "2";
            // 
            // genBox
            // 
            this.genBox.Location = new System.Drawing.Point(604, 33);
            this.genBox.Name = "genBox";
            this.genBox.Size = new System.Drawing.Size(59, 22);
            this.genBox.TabIndex = 10;
            this.genBox.Text = "0.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 453);
            this.Controls.Add(this.genBox);
            this.Controls.Add(this.spanBox);
            this.Controls.Add(this.bloatBox);
            this.Controls.Add(this.amplitudeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(810, 500);
            this.Name = "Form1";
            this.Text = "Terrain Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem madeByAlexanderJephthaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thereIsNoHelpToolStripMenuItem;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox amplitudeBox;
        private System.Windows.Forms.TextBox bloatBox;
        private System.Windows.Forms.TextBox spanBox;
        private System.Windows.Forms.TextBox genBox;
        private System.Windows.Forms.ToolStripMenuItem madeWithMicrosoftVisualStudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codedInCToolStripMenuItem;
    }
}

