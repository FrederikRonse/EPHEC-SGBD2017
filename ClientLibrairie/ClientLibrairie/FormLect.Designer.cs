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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumCarte = new System.Windows.Forms.Label();
            this.panelLecteur = new System.Windows.Forms.Panel();
            this.tbCardNum = new System.Windows.Forms.TextBox();
            this.lblBiblioPr = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.lblNaiss = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblValid = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.comboBoxLibChoice = new System.Windows.Forms.ComboBox();
            this.panelEmprunts = new System.Windows.Forms.Panel();
            this.dgvEmprunts = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empruntBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btRetards = new System.Windows.Forms.Button();
            this.LblOverdueN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmpruntsN = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.btNew = new System.Windows.Forms.Button();
            this.lblTotalN = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btRestitution = new System.Windows.Forms.Button();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLecteur.SuspendLayout();
            this.panelEmprunts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprunts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empruntBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bibliothèque : ";
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
            this.panelLecteur.Controls.Add(this.btSearch);
            this.panelLecteur.Controls.Add(this.lblNaiss);
            this.panelLecteur.Controls.Add(this.lblType);
            this.panelLecteur.Controls.Add(this.lblValid);
            this.panelLecteur.Controls.Add(this.lblPrenom);
            this.panelLecteur.Controls.Add(this.lblNom);
            this.panelLecteur.Controls.Add(this.lblNumCarte);
            this.panelLecteur.Location = new System.Drawing.Point(9, 44);
            this.panelLecteur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLecteur.Name = "panelLecteur";
            this.panelLecteur.Size = new System.Drawing.Size(406, 123);
            this.panelLecteur.TabIndex = 2;
            // 
            // tbCardNum
            // 
            this.tbCardNum.Location = new System.Drawing.Point(80, 9);
            this.tbCardNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCardNum.Name = "tbCardNum";
            this.tbCardNum.Size = new System.Drawing.Size(66, 20);
            this.tbCardNum.TabIndex = 16;
            this.tbCardNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCardNum_KeyPress);
            this.tbCardNum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCardNum_KeyUp);
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
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(116, 20);
            this.tbFirstName.TabIndex = 13;
            this.tbFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(269, 9);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(116, 20);
            this.tbLastName.TabIndex = 12;
            this.tbLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(304, 100);
            this.btSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(84, 19);
            this.btSearch.TabIndex = 4;
            this.btSearch.Text = "R&echercher";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.SearchByName);
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
            // comboBoxLibChoice
            // 
            this.comboBoxLibChoice.AllowDrop = true;
            this.comboBoxLibChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLibChoice.FormattingEnabled = true;
            this.comboBoxLibChoice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxLibChoice.Location = new System.Drawing.Point(276, 14);
            this.comboBoxLibChoice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxLibChoice.Name = "comboBoxLibChoice";
            this.comboBoxLibChoice.Size = new System.Drawing.Size(188, 21);
            this.comboBoxLibChoice.TabIndex = 15;
            this.comboBoxLibChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxLibChoice_SelectedIndexChanged);
            // 
            // panelEmprunts
            // 
            this.panelEmprunts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEmprunts.Controls.Add(this.dgvEmprunts);
            this.panelEmprunts.Location = new System.Drawing.Point(9, 247);
            this.panelEmprunts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelEmprunts.Name = "panelEmprunts";
            this.panelEmprunts.Size = new System.Drawing.Size(457, 161);
            this.panelEmprunts.TabIndex = 2;
            // 
            // dgvEmprunts
            // 
            this.dgvEmprunts.AllowUserToAddRows = false;
            this.dgvEmprunts.AllowUserToDeleteRows = false;
            this.dgvEmprunts.AllowUserToResizeRows = false;
            this.dgvEmprunts.AutoGenerateColumns = false;
            this.dgvEmprunts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEmprunts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprunts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.volumeTitleDataGridViewTextBoxColumn,
            this.itemCodeDataGridViewTextBoxColumn,
            this.ToPay});
            this.dgvEmprunts.DataSource = this.empruntBindingSource;
            this.dgvEmprunts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmprunts.Location = new System.Drawing.Point(0, 0);
            this.dgvEmprunts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEmprunts.MultiSelect = false;
            this.dgvEmprunts.Name = "dgvEmprunts";
            this.dgvEmprunts.ReadOnly = true;
            this.dgvEmprunts.RowHeadersVisible = false;
            this.dgvEmprunts.RowTemplate.Height = 24;
            this.dgvEmprunts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmprunts.Size = new System.Drawing.Size(453, 157);
            this.dgvEmprunts.TabIndex = 0;
            this.dgvEmprunts.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmprunts_CellContentDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // volumeTitleDataGridViewTextBoxColumn
            // 
            this.volumeTitleDataGridViewTextBoxColumn.DataPropertyName = "VolumeTitle";
            this.volumeTitleDataGridViewTextBoxColumn.HeaderText = "Titre";
            this.volumeTitleDataGridViewTextBoxColumn.Name = "volumeTitleDataGridViewTextBoxColumn";
            this.volumeTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemCodeDataGridViewTextBoxColumn
            // 
            this.itemCodeDataGridViewTextBoxColumn.DataPropertyName = "ItemCode";
            this.itemCodeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.itemCodeDataGridViewTextBoxColumn.Name = "itemCodeDataGridViewTextBoxColumn";
            this.itemCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ToPay
            // 
            this.ToPay.DataPropertyName = "ToPay";
            this.ToPay.HeaderText = "A payer";
            this.ToPay.Name = "ToPay";
            this.ToPay.ReadOnly = true;
            // 
            // empruntBindingSource
            // 
            this.empruntBindingSource.DataSource = typeof(ClientLibrairie.ServiceReference.Emprunt);
            // 
            // btRetards
            // 
            this.btRetards.Location = new System.Drawing.Point(314, 180);
            this.btRetards.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.tbInfo.Location = new System.Drawing.Point(22, 224);
            this.tbInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.Size = new System.Drawing.Size(374, 20);
            this.tbInfo.TabIndex = 7;
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(400, 422);
            this.btNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(64, 47);
            this.btNew.TabIndex = 7;
            this.btNew.Text = "&Nouvel Emprunt";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Visible = false;
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
            // btRestitution
            // 
            this.btRestitution.Location = new System.Drawing.Point(193, 422);
            this.btRestitution.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btRestitution.Name = "btRestitution";
            this.btRestitution.Size = new System.Drawing.Size(83, 47);
            this.btRestitution.TabIndex = 10;
            this.btRestitution.Text = "&Restitution";
            this.btRestitution.UseVisualStyleBackColor = true;
            this.btRestitution.Click += new System.EventHandler(this.btRestitution_Click);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(89, 14);
            this.textBoxCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(66, 20);
            this.textBoxCode.TabIndex = 18;
            this.textBoxCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCode_KeyPress);
            this.textBoxCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCode_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Code Exemplaire : ";
            // 
            // FormLect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 488);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.btRestitution);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxLibChoice);
            this.Controls.Add(this.lblTotalN);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.lblEmpruntsN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblOverdueN);
            this.Controls.Add(this.btRetards);
            this.Controls.Add(this.panelEmprunts);
            this.Controls.Add(this.panelLecteur);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormLect";
            this.Text = "Gestion Lecteurs";
            this.Load += new System.EventHandler(this.FormLect_Load);
            this.panelLecteur.ResumeLayout(false);
            this.panelLecteur.PerformLayout();
            this.panelEmprunts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprunts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empruntBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumCarte;
        private System.Windows.Forms.Panel panelLecteur;
        private System.Windows.Forms.Panel panelEmprunts;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblNaiss;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblValid;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.DataGridView dgvEmprunts;
        private System.Windows.Forms.Button btRetards;
        private System.Windows.Forms.Label LblOverdueN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmpruntsN;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Label lblTotalN;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btRestitution;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblBiblioPr;
        private System.Windows.Forms.ComboBox comboBoxLibChoice;
        private System.Windows.Forms.TextBox tbCardNum;
        private System.Windows.Forms.BindingSource empruntBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToPay;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label label3;
    }
}