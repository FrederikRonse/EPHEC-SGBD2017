namespace ClientLibrairie
{
    partial class MainForm
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
            this.bibliothèquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bibliothèquesToolStripMenuItem,
            this.lecteursToolStripMenuItem,
            this.retardsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bibliothèquesToolStripMenuItem
            // 
            this.bibliothèquesToolStripMenuItem.Name = "bibliothèquesToolStripMenuItem";
            this.bibliothèquesToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.bibliothèquesToolStripMenuItem.Text = "&Bibliothèques";
            this.bibliothèquesToolStripMenuItem.Click += new System.EventHandler(this.bibliothèquesToolStripMenuItem_Click);
            // 
            // lecteursToolStripMenuItem
            // 
            this.lecteursToolStripMenuItem.Name = "lecteursToolStripMenuItem";
            this.lecteursToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.lecteursToolStripMenuItem.Text = "&Lecteurs";
            this.lecteursToolStripMenuItem.Click += new System.EventHandler(this.lecteursToolStripMenuItem_Click);
            // 
            // retardsToolStripMenuItem
            // 
            this.retardsToolStripMenuItem.Name = "retardsToolStripMenuItem";
            this.retardsToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.retardsToolStripMenuItem.Text = "&Retards";
            this.retardsToolStripMenuItem.Click += new System.EventHandler(this.retardsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 953);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Admin Client";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bibliothèquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retardsToolStripMenuItem;
    }
}

