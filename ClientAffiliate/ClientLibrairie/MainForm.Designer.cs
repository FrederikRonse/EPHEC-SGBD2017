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
            this.EmprunterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpruntsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmprunterToolStripMenuItem,
            this.WishToolStripMenuItem,
            this.EmpruntsToolStripMenuItem,
            this.ProfilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(957, 29);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EmprunterToolStripMenuItem
            // 
            this.EmprunterToolStripMenuItem.Name = "EmprunterToolStripMenuItem";
            this.EmprunterToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.EmprunterToolStripMenuItem.Text = "&Emprunter";
            this.EmprunterToolStripMenuItem.Click += new System.EventHandler(this.bibliothèquesToolStripMenuItem_Click);
            // 
            // WishToolStripMenuItem
            // 
            this.WishToolStripMenuItem.Name = "WishToolStripMenuItem";
            this.WishToolStripMenuItem.Size = new System.Drawing.Size(135, 25);
            this.WishToolStripMenuItem.Text = "Livres &Souhaités";
            this.WishToolStripMenuItem.Click += new System.EventHandler(this.whishListToolStripMenuItem_Click);
            // 
            // EmpruntsToolStripMenuItem
            // 
            this.EmpruntsToolStripMenuItem.Name = "EmpruntsToolStripMenuItem";
            this.EmpruntsToolStripMenuItem.Size = new System.Drawing.Size(122, 25);
            this.EmpruntsToolStripMenuItem.Text = "&Mes Emprunts";
            this.EmpruntsToolStripMenuItem.Click += new System.EventHandler(this.retardsToolStripMenuItem_Click);
            // 
            // ProfilToolStripMenuItem
            // 
            this.ProfilToolStripMenuItem.Name = "ProfilToolStripMenuItem";
            this.ProfilToolStripMenuItem.Size = new System.Drawing.Size(95, 25);
            this.ProfilToolStripMenuItem.Text = "Mon &Profil";
            this.ProfilToolStripMenuItem.Click += new System.EventHandler(this.ProfilToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 774);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Bienvenue";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EmprunterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmpruntsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProfilToolStripMenuItem;
    }
}

