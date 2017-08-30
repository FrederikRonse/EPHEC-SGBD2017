namespace ClientLibrairie
{
    partial class FormLect
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
            this.lblNumCarte = new System.Windows.Forms.Label();
            this.panelLecteur = new System.Windows.Forms.Panel();
            this.tbCardNum = new System.Windows.Forms.TextBox();
            this.lblBiblioPr = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblNaiss = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblValid = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.empruntBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btRetards = new System.Windows.Forms.Button();
            this.LblOverdueN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmpruntsN = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.lblTotalN = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panelLecteur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empruntBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumCarte
            // 
            this.lblNumCarte.AutoSize = true;
            this.lblNumCarte.Location = new System.Drawing.Point(10, 9);
            this.lblNumCarte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumCarte.Name = "lblNumCarte";
            this.lblNumCarte.Size = new System.Drawing.Size(70, 13);
            this.lblNumCarte.TabIndex = 1;
            this.lblNumCarte.Text = "N° de carte : ";
            // 
            // panelLecteur
            // 
            this.panelLecteur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLecteur.Controls.Add(this.tbCardNum);
            this.panelLecteur.Controls.Add(this.lblBiblioPr);
            this.panelLecteur.Controls.Add(this.tbFirstName);
            this.panelLecteur.Controls.Add(this.tbLastName);
            this.panelLecteur.Controls.Add(this.lblNaiss);
            this.panelLecteur.Controls.Add(this.lblType);
            this.panelLecteur.Controls.Add(this.lblValid);
            this.panelLecteur.Controls.Add(this.lblPrenom);
            this.panelLecteur.Controls.Add(this.lblNom);
            this.panelLecteur.Controls.Add(this.lblNumCarte);
            this.panelLecteur.Location = new System.Drawing.Point(9, 44);
            this.panelLecteur.Margin = new System.Windows.Forms.Padding(2);
            this.panelLecteur.Name = "panelLecteur";
            this.panelLecteur.Size = new System.Drawing.Size(406, 123);
            this.panelLecteur.TabIndex = 2;
            // 
            // tbCardNum
            // 
            //this.tbCardNum.Location = new System.Drawing.Point(80, 9);
            //this.tbCardNum.Margin = new System.Windows.Forms.Padding(2);
            //this.tbCardNum.Name = "tbCardNum";
            //this.tbCardNum.Size = new System.Drawing.Size(66, 20);
            //this.tbCardNum.TabIndex = 16;
            //this.tbCardNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCardNum_KeyPress);
            //this.tbCardNum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCardNum_KeyUp);
            // 
            // lblBiblioPr
            // 
            this.lblBiblioPr.AutoSize = true;
            this.lblBiblioPr.Location = new System.Drawing.Point(10, 100);
            this.lblBiblioPr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBiblioPr.Name = "lblBiblioPr";
            this.lblBiblioPr.Size = new System.Drawing.Size(123, 13);
            this.lblBiblioPr.TabIndex = 14;
            this.lblBiblioPr.Text = "Bibliothèque Principale : ";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(270, 34);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(116, 20);
            this.tbFirstName.TabIndex = 13;
            this.tbFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(269, 9);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(116, 20);
            this.tbLastName.TabIndex = 12;
            this.tbLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // lblNaiss
            // 
            this.lblNaiss.AutoSize = true;
            this.lblNaiss.Location = new System.Drawing.Point(214, 62);
            this.lblNaiss.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNaiss.Name = "lblNaiss";
            this.lblNaiss.Size = new System.Drawing.Size(105, 13);
            this.lblNaiss.TabIndex = 6;
            this.lblNaiss.Text = "Date de naissance : ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(10, 62);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 13);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Type : ";
            // 
            // lblValid
            // 
            this.lblValid.AutoSize = true;
            this.lblValid.Location = new System.Drawing.Point(10, 37);
            this.lblValid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(50, 13);
            this.lblValid.TabIndex = 4;
            this.lblValid.Text = "Validité : ";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(214, 37);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(52, 13);
            this.lblPrenom.TabIndex = 3;
            this.lblPrenom.Text = "Prénom : ";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(214, 9);
            this.lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(38, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom : ";
            // 
            // empruntBindingSource
            // 
            this.empruntBindingSource.DataSource = typeof(ClientLibrairie.ServiceReference.Emprunt);
            // 
            // btRetards
            // 
            this.btRetards.Location = new System.Drawing.Point(314, 180);
            this.btRetards.Margin = new System.Windows.Forms.Padding(2);
            this.btRetards.Name = "btRetards";
            this.btRetards.Size = new System.Drawing.Size(56, 19);
            this.btRetards.TabIndex = 3;
            this.btRetards.Text = "Retards";
            this.btRetards.UseVisualStyleBackColor = true;
            // 
            // LblOverdueN
            // 
            this.LblOverdueN.AutoSize = true;
            this.LblOverdueN.Location = new System.Drawing.Point(381, 184);
            this.LblOverdueN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblOverdueN.Name = "LblOverdueN";
            this.LblOverdueN.Size = new System.Drawing.Size(13, 13);
            this.LblOverdueN.TabIndex = 4;
            this.LblOverdueN.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Emprunts";
            // 
            // lblEmpruntsN
            // 
            this.lblEmpruntsN.AutoSize = true;
            this.lblEmpruntsN.Location = new System.Drawing.Point(64, 184);
            this.lblEmpruntsN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpruntsN.Name = "lblEmpruntsN";
            this.lblEmpruntsN.Size = new System.Drawing.Size(13, 13);
            this.lblEmpruntsN.TabIndex = 6;
            this.lblEmpruntsN.Text = "--";
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(20, 212);
            this.tbInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.Size = new System.Drawing.Size(374, 20);
            this.tbInfo.TabIndex = 7;
            // 
            // lblTotalN
            // 
            this.lblTotalN.AutoSize = true;
            this.lblTotalN.Location = new System.Drawing.Point(161, 184);
            this.lblTotalN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalN.Name = "lblTotalN";
            this.lblTotalN.Size = new System.Drawing.Size(13, 13);
            this.lblTotalN.TabIndex = 9;
            this.lblTotalN.Text = "--";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(106, 184);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total € : ";
            // 
            // FormLect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 275);
            this.Controls.Add(this.lblTotalN);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.lblEmpruntsN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblOverdueN);
            this.Controls.Add(this.btRetards);
            this.Controls.Add(this.panelLecteur);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLect";
            this.Text = "Vos données";
            this.Load += new System.EventHandler(this.FormLect_Load);
            this.panelLecteur.ResumeLayout(false);
            this.panelLecteur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empruntBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumCarte;
        private System.Windows.Forms.Panel panelLecteur;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblNaiss;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblValid;
        private System.Windows.Forms.Button btRetards;
        private System.Windows.Forms.Label LblOverdueN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmpruntsN;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Label lblTotalN;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblBiblioPr;
        private System.Windows.Forms.TextBox tbCardNum;
        private System.Windows.Forms.BindingSource empruntBindingSource;
    }
}