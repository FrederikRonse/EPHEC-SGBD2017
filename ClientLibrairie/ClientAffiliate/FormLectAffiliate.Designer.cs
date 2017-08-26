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
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cardNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyPenaltyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpruntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastModifiedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libraryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameLibraryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTarifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelLecteur.SuspendLayout();
            this.panelEmprunts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprunts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empruntBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bibliothèque : ";
            // 
            // lblNumCarte
            // 
            this.lblNumCarte.AutoSize = true;
            this.lblNumCarte.Location = new System.Drawing.Point(13, 11);
            this.lblNumCarte.Name = "lblNumCarte";
            this.lblNumCarte.Size = new System.Drawing.Size(92, 17);
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
            this.panelLecteur.Location = new System.Drawing.Point(12, 54);
            this.panelLecteur.Name = "panelLecteur";
            this.panelLecteur.Size = new System.Drawing.Size(540, 151);
            this.panelLecteur.TabIndex = 2;
            // 
            // tbCardNum
            // 
            this.tbCardNum.Location = new System.Drawing.Point(106, 11);
            this.tbCardNum.Name = "tbCardNum";
            this.tbCardNum.Size = new System.Drawing.Size(86, 22);
            this.tbCardNum.TabIndex = 16;
            this.tbCardNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCardNum_KeyPress);
            this.tbCardNum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCardNum_KeyUp);
            // 
            // lblBiblioPr
            // 
            this.lblBiblioPr.AutoSize = true;
            this.lblBiblioPr.Location = new System.Drawing.Point(13, 123);
            this.lblBiblioPr.Name = "lblBiblioPr";
            this.lblBiblioPr.Size = new System.Drawing.Size(164, 17);
            this.lblBiblioPr.TabIndex = 14;
            this.lblBiblioPr.Text = "Bibliothèque Principale : ";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(360, 42);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(154, 22);
            this.tbFirstName.TabIndex = 13;
            this.tbFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(359, 11);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(154, 22);
            this.tbLastName.TabIndex = 12;
            this.tbLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(405, 123);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(112, 23);
            this.btSearch.TabIndex = 4;
            this.btSearch.Text = "R&echercher";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.SearchByName);
            // 
            // lblNaiss
            // 
            this.lblNaiss.AutoSize = true;
            this.lblNaiss.Location = new System.Drawing.Point(286, 76);
            this.lblNaiss.Name = "lblNaiss";
            this.lblNaiss.Size = new System.Drawing.Size(138, 17);
            this.lblNaiss.TabIndex = 6;
            this.lblNaiss.Text = "Date de naissance : ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(13, 76);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(52, 17);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Type : ";
            // 
            // lblValid
            // 
            this.lblValid.AutoSize = true;
            this.lblValid.Location = new System.Drawing.Point(13, 45);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(66, 17);
            this.lblValid.TabIndex = 4;
            this.lblValid.Text = "Validité : ";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(286, 45);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(69, 17);
            this.lblPrenom.TabIndex = 3;
            this.lblPrenom.Text = "Prénom : ";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(286, 11);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(49, 17);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom : ";
            // 
            // comboBoxLibChoice
            // 
            this.comboBoxLibChoice.AllowDrop = true;
            this.comboBoxLibChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLibChoice.FormattingEnabled = true;
            this.comboBoxLibChoice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxLibChoice.Location = new System.Drawing.Point(368, 17);
            this.comboBoxLibChoice.Name = "comboBoxLibChoice";
            this.comboBoxLibChoice.Size = new System.Drawing.Size(250, 24);
            this.comboBoxLibChoice.TabIndex = 15;
            this.comboBoxLibChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxLibChoice_SelectedIndexChanged);
            // 
            // panelEmprunts
            // 
            this.panelEmprunts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEmprunts.Controls.Add(this.dgvEmprunts);
            this.panelEmprunts.Location = new System.Drawing.Point(12, 304);
            this.panelEmprunts.Name = "panelEmprunts";
            this.panelEmprunts.Size = new System.Drawing.Size(608, 197);
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
            this.ToPay,
            this.cardNumDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.dailyPenaltyDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.feeDataGridViewTextBoxColumn,
            this.idEmpruntDataGridViewTextBoxColumn,
            this.itemIdDataGridViewTextBoxColumn,
            this.lastModifiedDataGridViewTextBoxColumn,
            this.libraryIdDataGridViewTextBoxColumn,
            this.nameLibraryDataGridViewTextBoxColumn,
            this.nameTarifDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.tarifIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn});
            this.dgvEmprunts.DataSource = this.empruntBindingSource;
            this.dgvEmprunts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmprunts.Location = new System.Drawing.Point(0, 0);
            this.dgvEmprunts.MultiSelect = false;
            this.dgvEmprunts.Name = "dgvEmprunts";
            this.dgvEmprunts.ReadOnly = true;
            this.dgvEmprunts.RowHeadersVisible = false;
            this.dgvEmprunts.RowTemplate.Height = 24;
            this.dgvEmprunts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmprunts.Size = new System.Drawing.Size(604, 193);
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
            // ToPay
            // 
            this.ToPay.DataPropertyName = "ToPay";
            this.ToPay.HeaderText = "A payer";
            this.ToPay.Name = "ToPay";
            this.ToPay.ReadOnly = true;
            // 
            // empruntBindingSource
            // 
            this.empruntBindingSource.DataSource = typeof(ClientAffiliate.ServiceReference1.vEmpruntDetail);
            // 
            // btRetards
            // 
            this.btRetards.Location = new System.Drawing.Point(418, 221);
            this.btRetards.Name = "btRetards";
            this.btRetards.Size = new System.Drawing.Size(75, 23);
            this.btRetards.TabIndex = 3;
            this.btRetards.Text = "Retards";
            this.btRetards.UseVisualStyleBackColor = true;
            // 
            // LblOverdueN
            // 
            this.LblOverdueN.AutoSize = true;
            this.LblOverdueN.Location = new System.Drawing.Point(508, 227);
            this.LblOverdueN.Name = "LblOverdueN";
            this.LblOverdueN.Size = new System.Drawing.Size(18, 17);
            this.LblOverdueN.TabIndex = 4;
            this.LblOverdueN.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Emprunts";
            // 
            // lblEmpruntsN
            // 
            this.lblEmpruntsN.AutoSize = true;
            this.lblEmpruntsN.Location = new System.Drawing.Point(86, 227);
            this.lblEmpruntsN.Name = "lblEmpruntsN";
            this.lblEmpruntsN.Size = new System.Drawing.Size(18, 17);
            this.lblEmpruntsN.TabIndex = 6;
            this.lblEmpruntsN.Text = "--";
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(29, 276);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.Size = new System.Drawing.Size(498, 22);
            this.tbInfo.TabIndex = 7;
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(227, 518);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(86, 58);
            this.btNew.TabIndex = 7;
            this.btNew.Text = "&Nouvel Emprunt";
            this.btNew.UseVisualStyleBackColor = true;
            // 
            // lblTotalN
            // 
            this.lblTotalN.AutoSize = true;
            this.lblTotalN.Location = new System.Drawing.Point(215, 227);
            this.lblTotalN.Name = "lblTotalN";
            this.lblTotalN.Size = new System.Drawing.Size(18, 17);
            this.lblTotalN.TabIndex = 9;
            this.lblTotalN.Text = "--";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(141, 227);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(64, 17);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total € : ";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(119, 17);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(86, 22);
            this.textBoxCode.TabIndex = 18;
            this.textBoxCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCode_KeyPress);
            this.textBoxCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCode_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Code Exemplaire : ";
            // 
            // cardNumDataGridViewTextBoxColumn
            // 
            this.cardNumDataGridViewTextBoxColumn.DataPropertyName = "CardNum";
            this.cardNumDataGridViewTextBoxColumn.HeaderText = "CardNum";
            this.cardNumDataGridViewTextBoxColumn.Name = "cardNumDataGridViewTextBoxColumn";
            this.cardNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dailyPenaltyDataGridViewTextBoxColumn
            // 
            this.dailyPenaltyDataGridViewTextBoxColumn.DataPropertyName = "DailyPenalty";
            this.dailyPenaltyDataGridViewTextBoxColumn.HeaderText = "DailyPenalty";
            this.dailyPenaltyDataGridViewTextBoxColumn.Name = "dailyPenaltyDataGridViewTextBoxColumn";
            this.dailyPenaltyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // feeDataGridViewTextBoxColumn
            // 
            this.feeDataGridViewTextBoxColumn.DataPropertyName = "Fee";
            this.feeDataGridViewTextBoxColumn.HeaderText = "Fee";
            this.feeDataGridViewTextBoxColumn.Name = "feeDataGridViewTextBoxColumn";
            this.feeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idEmpruntDataGridViewTextBoxColumn
            // 
            this.idEmpruntDataGridViewTextBoxColumn.DataPropertyName = "IdEmprunt";
            this.idEmpruntDataGridViewTextBoxColumn.HeaderText = "IdEmprunt";
            this.idEmpruntDataGridViewTextBoxColumn.Name = "idEmpruntDataGridViewTextBoxColumn";
            this.idEmpruntDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "Item_Id";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "Item_Id";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            this.itemIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastModifiedDataGridViewTextBoxColumn
            // 
            this.lastModifiedDataGridViewTextBoxColumn.DataPropertyName = "LastModified";
            this.lastModifiedDataGridViewTextBoxColumn.HeaderText = "LastModified";
            this.lastModifiedDataGridViewTextBoxColumn.Name = "lastModifiedDataGridViewTextBoxColumn";
            this.lastModifiedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libraryIdDataGridViewTextBoxColumn
            // 
            this.libraryIdDataGridViewTextBoxColumn.DataPropertyName = "Library_Id";
            this.libraryIdDataGridViewTextBoxColumn.HeaderText = "Library_Id";
            this.libraryIdDataGridViewTextBoxColumn.Name = "libraryIdDataGridViewTextBoxColumn";
            this.libraryIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameLibraryDataGridViewTextBoxColumn
            // 
            this.nameLibraryDataGridViewTextBoxColumn.DataPropertyName = "NameLibrary";
            this.nameLibraryDataGridViewTextBoxColumn.HeaderText = "NameLibrary";
            this.nameLibraryDataGridViewTextBoxColumn.Name = "nameLibraryDataGridViewTextBoxColumn";
            this.nameLibraryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameTarifDataGridViewTextBoxColumn
            // 
            this.nameTarifDataGridViewTextBoxColumn.DataPropertyName = "NameTarif";
            this.nameTarifDataGridViewTextBoxColumn.HeaderText = "NameTarif";
            this.nameTarifDataGridViewTextBoxColumn.Name = "nameTarifDataGridViewTextBoxColumn";
            this.nameTarifDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            this.returnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate";
            this.returnDateDataGridViewTextBoxColumn.HeaderText = "ReturnDate";
            this.returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            this.returnDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarifIdDataGridViewTextBoxColumn
            // 
            this.tarifIdDataGridViewTextBoxColumn.DataPropertyName = "Tarif_Id";
            this.tarifIdDataGridViewTextBoxColumn.HeaderText = "Tarif_Id";
            this.tarifIdDataGridViewTextBoxColumn.Name = "tarifIdDataGridViewTextBoxColumn";
            this.tarifIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormLect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 600);
            this.Controls.Add(this.textBoxCode);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyPenaltyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpruntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastModifiedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libraryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameLibraryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTarifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
    }
}