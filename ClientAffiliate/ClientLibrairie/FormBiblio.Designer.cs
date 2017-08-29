namespace ClientLibrairie
{
    partial class FormBiblio
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
            this.labelSearch = new System.Windows.Forms.Label();
            this.tbTitleSearch = new System.Windows.Forms.TextBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.panelAddItem = new System.Windows.Forms.Panel();
            this.btAddAction = new System.Windows.Forms.Button();
            this.panelRadioButton = new System.Windows.Forms.Panel();
            this.rbEmprunt = new System.Windows.Forms.RadioButton();
            this.rbWish = new System.Windows.Forms.RadioButton();
            this.lblSearchTitle = new System.Windows.Forms.Label();
            this.lblSearchIsbn = new System.Windows.Forms.Label();
            this.tbIsbnSearch = new System.Windows.Forms.TextBox();
            this.labelDGV = new System.Windows.Forms.Label();
            this.panelVolumeInfo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.dgvBiblioInfo = new System.Windows.Forms.DataGridView();
            this.comboBoxLibChoice = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelAddItem.SuspendLayout();
            this.panelRadioButton.SuspendLayout();
            this.panelVolumeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiblioInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(12, 15);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(121, 13);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Rechercher un volume :";
            // 
            // tbTitleSearch
            // 
            this.tbTitleSearch.Location = new System.Drawing.Point(66, 54);
            this.tbTitleSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbTitleSearch.Name = "tbTitleSearch";
            this.tbTitleSearch.Size = new System.Drawing.Size(353, 20);
            this.tbTitleSearch.TabIndex = 1;
            this.tbTitleSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbTitleSearch_KeyUp);
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(15, 385);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(2);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(406, 259);
            this.dgvItems.TabIndex = 4;
            this.dgvItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvItems_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxMessage);
            this.panel1.Controls.Add(this.panelAddItem);
            this.panel1.Controls.Add(this.lblSearchTitle);
            this.panel1.Controls.Add(this.lblSearchIsbn);
            this.panel1.Controls.Add(this.tbIsbnSearch);
            this.panel1.Controls.Add(this.labelDGV);
            this.panel1.Controls.Add(this.dgvItems);
            this.panel1.Controls.Add(this.tbTitleSearch);
            this.panel1.Controls.Add(this.labelSearch);
            this.panel1.Controls.Add(this.panelVolumeInfo);
            this.panel1.Location = new System.Drawing.Point(32, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 656);
            this.panel1.TabIndex = 6;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxMessage.Location = new System.Drawing.Point(17, 195);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(404, 20);
            this.textBoxMessage.TabIndex = 16;
            // 
            // panelAddItem
            // 
            this.panelAddItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddItem.Controls.Add(this.btAddAction);
            this.panelAddItem.Controls.Add(this.panelRadioButton);
            this.panelAddItem.Location = new System.Drawing.Point(17, 125);
            this.panelAddItem.Margin = new System.Windows.Forms.Padding(2);
            this.panelAddItem.Name = "panelAddItem";
            this.panelAddItem.Size = new System.Drawing.Size(404, 56);
            this.panelAddItem.TabIndex = 11;
            // 
            // btAddAction
            // 
            this.btAddAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddAction.Location = new System.Drawing.Point(142, 5);
            this.btAddAction.Margin = new System.Windows.Forms.Padding(2);
            this.btAddAction.Name = "btAddAction";
            this.btAddAction.Size = new System.Drawing.Size(159, 44);
            this.btAddAction.TabIndex = 10;
            this.btAddAction.Text = "Ajouter";
            this.btAddAction.UseVisualStyleBackColor = true;
            this.btAddAction.Click += new System.EventHandler(this.btAddAction_Click);
            // 
            // panelRadioButton
            // 
            this.panelRadioButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRadioButton.Controls.Add(this.rbEmprunt);
            this.panelRadioButton.Controls.Add(this.rbWish);
            this.panelRadioButton.Location = new System.Drawing.Point(2, 2);
            this.panelRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.panelRadioButton.Name = "panelRadioButton";
            this.panelRadioButton.Size = new System.Drawing.Size(116, 50);
            this.panelRadioButton.TabIndex = 12;
            // 
            // rbEmprunt
            // 
            this.rbEmprunt.AutoSize = true;
            this.rbEmprunt.Location = new System.Drawing.Point(2, 29);
            this.rbEmprunt.Margin = new System.Windows.Forms.Padding(2);
            this.rbEmprunt.Name = "rbEmprunt";
            this.rbEmprunt.Size = new System.Drawing.Size(64, 17);
            this.rbEmprunt.TabIndex = 1;
            this.rbEmprunt.TabStop = true;
            this.rbEmprunt.Text = "&Emprunt";
            this.rbEmprunt.UseVisualStyleBackColor = true;
            this.rbEmprunt.CheckedChanged += new System.EventHandler(this.RadioBtn_CheckedChanged);
            // 
            // rbWish
            // 
            this.rbWish.AutoSize = true;
            this.rbWish.Location = new System.Drawing.Point(2, -1);
            this.rbWish.Margin = new System.Windows.Forms.Padding(2);
            this.rbWish.Name = "rbWish";
            this.rbWish.Size = new System.Drawing.Size(65, 17);
            this.rbWish.TabIndex = 0;
            this.rbWish.TabStop = true;
            this.rbWish.Text = "&WishList";
            this.rbWish.UseVisualStyleBackColor = true;
            this.rbWish.CheckedChanged += new System.EventHandler(this.RadioBtn_CheckedChanged);
            // 
            // lblSearchTitle
            // 
            this.lblSearchTitle.AutoSize = true;
            this.lblSearchTitle.Location = new System.Drawing.Point(23, 58);
            this.lblSearchTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchTitle.Name = "lblSearchTitle";
            this.lblSearchTitle.Size = new System.Drawing.Size(37, 13);
            this.lblSearchTitle.TabIndex = 9;
            this.lblSearchTitle.Text = "Titre : ";
            // 
            // lblSearchIsbn
            // 
            this.lblSearchIsbn.AutoSize = true;
            this.lblSearchIsbn.Location = new System.Drawing.Point(23, 35);
            this.lblSearchIsbn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchIsbn.Name = "lblSearchIsbn";
            this.lblSearchIsbn.Size = new System.Drawing.Size(41, 13);
            this.lblSearchIsbn.TabIndex = 8;
            this.lblSearchIsbn.Text = "ISBN : ";
            // 
            // tbIsbnSearch
            // 
            this.tbIsbnSearch.Location = new System.Drawing.Point(66, 31);
            this.tbIsbnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbIsbnSearch.Name = "tbIsbnSearch";
            this.tbIsbnSearch.Size = new System.Drawing.Size(100, 20);
            this.tbIsbnSearch.TabIndex = 6;
            this.tbIsbnSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIsbnSearch_KeyPress);
            this.tbIsbnSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbIsbnSearch_KeyUp);
            // 
            // labelDGV
            // 
            this.labelDGV.AutoSize = true;
            this.labelDGV.Location = new System.Drawing.Point(12, 370);
            this.labelDGV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDGV.Name = "labelDGV";
            this.labelDGV.Size = new System.Drawing.Size(13, 13);
            this.labelDGV.TabIndex = 5;
            this.labelDGV.Text = " :";
            // 
            // panelVolumeInfo
            // 
            this.panelVolumeInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVolumeInfo.Controls.Add(this.pictureBox1);
            this.panelVolumeInfo.Controls.Add(this.panel2);
            this.panelVolumeInfo.Location = new System.Drawing.Point(14, 228);
            this.panelVolumeInfo.Margin = new System.Windows.Forms.Padding(2);
            this.panelVolumeInfo.Name = "panelVolumeInfo";
            this.panelVolumeInfo.Size = new System.Drawing.Size(407, 140);
            this.panelVolumeInfo.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(256, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 134);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.lblIsbn);
            this.panel2.Controls.Add(this.lblAuthor);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 134);
            this.panel2.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Gentium Book Basic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(2, 28);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.MaximumSize = new System.Drawing.Size(248, 89);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(135, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Titre de l\'ouvrage";
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(6, 7);
            this.lblIsbn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(41, 13);
            this.lblIsbn.TabIndex = 2;
            this.lblIsbn.Text = "ISBN : ";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(2, 95);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuthor.MaximumSize = new System.Drawing.Size(244, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(47, 13);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Auteur : ";
            // 
            // dgvBiblioInfo
            // 
            this.dgvBiblioInfo.AllowUserToAddRows = false;
            this.dgvBiblioInfo.AllowUserToDeleteRows = false;
            this.dgvBiblioInfo.AllowUserToOrderColumns = true;
            this.dgvBiblioInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgvBiblioInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvBiblioInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBiblioInfo.Location = new System.Drawing.Point(32, 10);
            this.dgvBiblioInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBiblioInfo.Name = "dgvBiblioInfo";
            this.dgvBiblioInfo.ReadOnly = true;
            this.dgvBiblioInfo.RowTemplate.Height = 24;
            this.dgvBiblioInfo.Size = new System.Drawing.Size(225, 42);
            this.dgvBiblioInfo.TabIndex = 4;
            // 
            // comboBoxLibChoice
            // 
            this.comboBoxLibChoice.AllowDrop = true;
            this.comboBoxLibChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLibChoice.FormattingEnabled = true;
            this.comboBoxLibChoice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxLibChoice.Location = new System.Drawing.Point(32, 57);
            this.comboBoxLibChoice.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxLibChoice.Name = "comboBoxLibChoice";
            this.comboBoxLibChoice.Size = new System.Drawing.Size(213, 21);
            this.comboBoxLibChoice.TabIndex = 9;
            this.comboBoxLibChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxLibChoice_SelectedIndexChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "\"\"";
            this.openFileDialog.InitialDirectory = "C:\\Users\\Murad\\documents\\Exam SGBD 2016-17\\Images\\";
            this.openFileDialog.Title = "Choisissez une couverture";
            // 
            // FormBiblio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 785);
            this.Controls.Add(this.comboBoxLibChoice);
            this.Controls.Add(this.dgvBiblioInfo);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBiblio";
            this.Text = "Gestion des ouvrages";
            this.Load += new System.EventHandler(this.FormBiblio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAddItem.ResumeLayout(false);
            this.panelRadioButton.ResumeLayout(false);
            this.panelRadioButton.PerformLayout();
            this.panelVolumeInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiblioInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox tbTitleSearch;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvBiblioInfo;
        private System.Windows.Forms.TextBox tbIsbnSearch;
        private System.Windows.Forms.Panel panelVolumeInfo;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearchTitle;
        private System.Windows.Forms.Label lblSearchIsbn;
        private System.Windows.Forms.ComboBox comboBoxLibChoice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelAddItem;
        private System.Windows.Forms.Panel panelRadioButton;
        private System.Windows.Forms.RadioButton rbEmprunt;
        private System.Windows.Forms.RadioButton rbWish;
        private System.Windows.Forms.Button btAddAction;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDGV;
    }
}