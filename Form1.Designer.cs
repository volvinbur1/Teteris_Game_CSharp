namespace Tetris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameFieldPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.newGameButton = new System.Windows.Forms.Button();
            this.pauseContinueButton = new System.Windows.Forms.Button();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.linesTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gameFieldPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameFieldPanel
            // 
            resources.ApplyResources(this.gameFieldPanel, "gameFieldPanel");
            this.gameFieldPanel.BackColor = System.Drawing.Color.White;
            this.gameFieldPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameFieldPanel.Controls.Add(this.label3);
            this.gameFieldPanel.Name = "gameFieldPanel";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // newGameButton
            // 
            resources.ApplyResources(this.newGameButton, "newGameButton");
            this.newGameButton.AllowDrop = true;
            this.newGameButton.BackColor = System.Drawing.Color.White;
            this.newGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newGameButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.TabStop = false;
            this.newGameButton.UseVisualStyleBackColor = false;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // pauseContinueButton
            // 
            resources.ApplyResources(this.pauseContinueButton, "pauseContinueButton");
            this.pauseContinueButton.AllowDrop = true;
            this.pauseContinueButton.BackColor = System.Drawing.Color.White;
            this.pauseContinueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pauseContinueButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pauseContinueButton.Name = "pauseContinueButton";
            this.pauseContinueButton.TabStop = false;
            this.pauseContinueButton.UseVisualStyleBackColor = false;
            this.pauseContinueButton.Click += new System.EventHandler(this.PauseContinueButton_Click);
            // 
            // scoreTextBox
            // 
            resources.ApplyResources(this.scoreTextBox, "scoreTextBox");
            this.scoreTextBox.AllowDrop = true;
            this.scoreTextBox.BackColor = System.Drawing.Color.White;
            this.scoreTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.ReadOnly = true;
            this.scoreTextBox.TabStop = false;
            // 
            // linesTextBox
            // 
            resources.ApplyResources(this.linesTextBox, "linesTextBox");
            this.linesTextBox.AllowDrop = true;
            this.linesTextBox.BackColor = System.Drawing.Color.White;
            this.linesTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.linesTextBox.Name = "linesTextBox";
            this.linesTextBox.ReadOnly = true;
            this.linesTextBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Tetris.Properties.Resources.tetris_background;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linesTextBox);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.pauseContinueButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.gameFieldPanel);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainKeyDownMethod);
            this.gameFieldPanel.ResumeLayout(false);
            this.gameFieldPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gameFieldPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button pauseContinueButton;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.TextBox linesTextBox;
    }
}

