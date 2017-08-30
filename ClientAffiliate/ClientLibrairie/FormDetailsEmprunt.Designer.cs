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
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDurée = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btEmprunter = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Location = new System.Drawing.Point(12, 27);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(502, 13);
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
            this.label3.Location = new System.Drawing.Point(8, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Librairie d\'emprunt :";
            // 
            // textBoxLibrary
            // 
            this.textBoxLibrary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLibrary.Location = new System.Drawing.Point(110, 45);
            this.textBoxLibrary.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLibrary.Name = "textBoxLibrary";
            this.textBoxLibrary.ReadOnly = true;
            this.textBoxLibrary.Size = new System.Drawing.Size(168, 13);
            this.textBoxLibrary.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Pénalité journalière :";
            // 
            // textBoxDailyPenalty
            // 
            this.textBoxDailyPenalty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDailyPenalty.Location = new System.Drawing.Point(397, 137);
            this.textBoxDailyPenalty.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDailyPenalty.Name = "textBoxDailyPenalty";
            this.textBoxDailyPenalty.ReadOnly = true;
            this.textBoxDailyPenalty.Size = new System.Drawing.Size(36, 13);
            this.textBoxDailyPenalty.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(282, 45);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tarif :";
            // 
            // textBoxTarif
            // 
            this.textBoxTarif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTarif.Location = new System.Drawing.Point(319, 45);
            this.textBoxTarif.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTarif.Name = "textBoxTarif";
            this.textBoxTarif.ReadOnly = true;
            this.textBoxTarif.Size = new System.Drawing.Size(192, 13);
            this.textBoxTarif.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 103);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Montant de Base :";
            // 
            // textBoxFee
            // 
            this.textBoxFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFee.Location = new System.Drawing.Point(397, 103);
            this.textBoxFee.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFee.Name = "textBoxFee";
            this.textBoxFee.ReadOnly = true;
            this.textBoxFee.Size = new System.Drawing.Size(55, 13);
            this.textBoxFee.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxMessage);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxDurée);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxFee);
            this.panel1.Controls.Add(this.btEmprunter);
            this.panel1.Controls.Add(this.textBoxDailyPenalty);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxLibrary);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBoxTarif);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 188);
            this.panel1.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "jours";
            // 
            // textBoxDurée
            // 
            this.textBoxDurée.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDurée.Location = new System.Drawing.Point(331, 71);
            this.textBoxDurée.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDurée.Name = "textBoxDurée";
            this.textBoxDurée.ReadOnly = true;
            this.textBoxDurée.Size = new System.Drawing.Size(26, 13);
            this.textBoxDurée.TabIndex = 21;
            this.textBoxDurée.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Durée : ";
            // 
            // btEmprunter
            // 
            this.btEmprunter.Location = new System.Drawing.Point(131, 103);
            this.btEmprunter.Name = "btEmprunter";
            this.btEmprunter.Size = new System.Drawing.Size(96, 46);
            this.btEmprunter.TabIndex = 0;
            this.btEmprunter.Text = "Emprunter";
            this.btEmprunter.UseVisualStyleBackColor = true;
            this.btEmprunter.Click += new System.EventHandler(this.btEmprunter_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(55, 196);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(2);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(406, 367);
            this.dgvItems.TabIndex = 21;
            this.dgvItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvItems_MouseDoubleClick);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxMessage.Location = new System.Drawing.Point(11, 154);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(500, 20);
            this.textBoxMessage.TabIndex = 23;
            // 
            // FormDetailsEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 574);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDetailsEmprunt";
            this.Text = "Formulaire d\'emprunt";
            this.Load += new System.EventHandler(this.FormDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDurée;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMessage;
    }
}