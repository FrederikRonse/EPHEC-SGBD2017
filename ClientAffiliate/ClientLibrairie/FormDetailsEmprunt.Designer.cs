namespace ClientLibrairie
{
    partial class FormDetailsEmprunt
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLibrary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDailyPenalty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTarif = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxFee = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btEmprunter = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(12, 27);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(502, 20);
            this.textBoxTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Librairie d\'emprunt :";
            // 
            // textBoxLibrary
            // 
            this.textBoxLibrary.Location = new System.Drawing.Point(13, 79);
            this.textBoxLibrary.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLibrary.Name = "textBoxLibrary";
            this.textBoxLibrary.ReadOnly = true;
            this.textBoxLibrary.Size = new System.Drawing.Size(266, 20);
            this.textBoxLibrary.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 149);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Pénalité journalière :";
            // 
            // textBoxDailyPenalty
            // 
            this.textBoxDailyPenalty.Location = new System.Drawing.Point(443, 142);
            this.textBoxDailyPenalty.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDailyPenalty.Name = "textBoxDailyPenalty";
            this.textBoxDailyPenalty.ReadOnly = true;
            this.textBoxDailyPenalty.Size = new System.Drawing.Size(36, 20);
            this.textBoxDailyPenalty.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 62);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tarif :";
            // 
            // textBoxTarif
            // 
            this.textBoxTarif.Location = new System.Drawing.Point(287, 79);
            this.textBoxTarif.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTarif.Name = "textBoxTarif";
            this.textBoxTarif.ReadOnly = true;
            this.textBoxTarif.Size = new System.Drawing.Size(192, 20);
            this.textBoxTarif.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(309, 110);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Montant de Base :";
            // 
            // textBoxFee
            // 
            this.textBoxFee.Location = new System.Drawing.Point(424, 110);
            this.textBoxFee.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFee.Name = "textBoxFee";
            this.textBoxFee.ReadOnly = true;
            this.textBoxFee.Size = new System.Drawing.Size(55, 20);
            this.textBoxFee.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btEmprunter);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 183);
            this.panel1.TabIndex = 20;
            // 
            // btEmprunter
            // 
            this.btEmprunter.Location = new System.Drawing.Point(130, 112);
            this.btEmprunter.Name = "btEmprunter";
            this.btEmprunter.Size = new System.Drawing.Size(96, 46);
            this.btEmprunter.TabIndex = 0;
            this.btEmprunter.Text = "Emprunter";
            this.btEmprunter.UseVisualStyleBackColor = true;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(55, 191);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(2);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(406, 372);
            this.dgvItems.TabIndex = 21;
            this.dgvItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellContentClick);
            // 
            // FormDetailsEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 574);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxFee);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxTarif);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxDailyPenalty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLibrary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDetailsEmprunt";
            this.Text = "Formulaire d\'emprunt";
            this.Load += new System.EventHandler(this.FormDetails_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLibrary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDailyPenalty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTarif;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxFee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btEmprunter;
        private System.Windows.Forms.DataGridView dgvItems;
    }
}