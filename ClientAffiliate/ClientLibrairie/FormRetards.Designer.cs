namespace ClientLibrairie
{
    partial class FormRetards
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxLibChoice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.empruntFullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libraryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedRtnDteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lateDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empruntFullBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.tbInfo);
            this.panel1.Controls.Add(this.comboBoxLibChoice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 76);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxLibChoice
            // 
            this.comboBoxLibChoice.AllowDrop = true;
            this.comboBoxLibChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLibChoice.FormattingEnabled = true;
            this.comboBoxLibChoice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxLibChoice.Location = new System.Drawing.Point(117, 14);
            this.comboBoxLibChoice.Name = "comboBoxLibChoice";
            this.comboBoxLibChoice.Size = new System.Drawing.Size(250, 24);
            this.comboBoxLibChoice.TabIndex = 17;
            this.comboBoxLibChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxLibChoice_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Bibliothèque : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.itemCodeDataGridViewTextBoxColumn,
            this.volumeTitleDataGridViewTextBoxColumn,
            this.libraryNameDataGridViewTextBoxColumn,
            this.tarifNameDataGridViewTextBoxColumn,
            this.plannedRtnDteDataGridViewTextBoxColumn,
            this.lateDaysDataGridViewTextBoxColumn,
            this.toPayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.empruntFullBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 104);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1247, 634);
            this.dataGridView1.TabIndex = 1;
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(340, 49);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.Size = new System.Drawing.Size(498, 22);
            this.tbInfo.TabIndex = 8;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(1018, 36);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(157, 23);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Vider la liste";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // empruntFullBindingSource
            // 
           // this.empruntFullBindingSource.DataSource = typeof(ClientLibrairie.FormRetards.EmpruntFull);
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 66;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 86;
            // 
            // itemCodeDataGridViewTextBoxColumn
            // 
            this.itemCodeDataGridViewTextBoxColumn.DataPropertyName = "ItemCode";
            this.itemCodeDataGridViewTextBoxColumn.HeaderText = "Exemplaire";
            this.itemCodeDataGridViewTextBoxColumn.Name = "itemCodeDataGridViewTextBoxColumn";
            this.itemCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemCodeDataGridViewTextBoxColumn.Width = 106;
            // 
            // volumeTitleDataGridViewTextBoxColumn
            // 
            this.volumeTitleDataGridViewTextBoxColumn.DataPropertyName = "VolumeTitle";
            this.volumeTitleDataGridViewTextBoxColumn.HeaderText = "Titre";
            this.volumeTitleDataGridViewTextBoxColumn.Name = "volumeTitleDataGridViewTextBoxColumn";
            this.volumeTitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.volumeTitleDataGridViewTextBoxColumn.Width = 66;
            // 
            // libraryNameDataGridViewTextBoxColumn
            // 
            this.libraryNameDataGridViewTextBoxColumn.DataPropertyName = "LibraryName";
            this.libraryNameDataGridViewTextBoxColumn.HeaderText = "Librairie d\'origine";
            this.libraryNameDataGridViewTextBoxColumn.Name = "libraryNameDataGridViewTextBoxColumn";
            this.libraryNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.libraryNameDataGridViewTextBoxColumn.Width = 134;
            // 
            // tarifNameDataGridViewTextBoxColumn
            // 
            this.tarifNameDataGridViewTextBoxColumn.DataPropertyName = "TarifName";
            this.tarifNameDataGridViewTextBoxColumn.HeaderText = "Tarification";
            this.tarifNameDataGridViewTextBoxColumn.Name = "tarifNameDataGridViewTextBoxColumn";
            this.tarifNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.tarifNameDataGridViewTextBoxColumn.Width = 107;
            // 
            // plannedRtnDteDataGridViewTextBoxColumn
            // 
            this.plannedRtnDteDataGridViewTextBoxColumn.DataPropertyName = "PlannedRtnDte";
            this.plannedRtnDteDataGridViewTextBoxColumn.HeaderText = "Date de retour prévue";
            this.plannedRtnDteDataGridViewTextBoxColumn.Name = "plannedRtnDteDataGridViewTextBoxColumn";
            this.plannedRtnDteDataGridViewTextBoxColumn.ReadOnly = true;
            this.plannedRtnDteDataGridViewTextBoxColumn.Width = 162;
            // 
            // lateDaysDataGridViewTextBoxColumn
            // 
            this.lateDaysDataGridViewTextBoxColumn.DataPropertyName = "LateDays";
            this.lateDaysDataGridViewTextBoxColumn.HeaderText = "J. retards";
            this.lateDaysDataGridViewTextBoxColumn.Name = "lateDaysDataGridViewTextBoxColumn";
            this.lateDaysDataGridViewTextBoxColumn.ReadOnly = true;
            this.lateDaysDataGridViewTextBoxColumn.Width = 90;
            // 
            // toPayDataGridViewTextBoxColumn
            // 
            this.toPayDataGridViewTextBoxColumn.DataPropertyName = "ToPay";
            this.toPayDataGridViewTextBoxColumn.HeaderText = "A payer";
            this.toPayDataGridViewTextBoxColumn.Name = "toPayDataGridViewTextBoxColumn";
            this.toPayDataGridViewTextBoxColumn.ReadOnly = true;
            this.toPayDataGridViewTextBoxColumn.Width = 80;
            // 
            // FormRetards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 750);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormRetards";
            this.Text = "Retards";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empruntFullBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxLibChoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libraryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannedRtnDteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lateDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource empruntFullBindingSource;
    }
}