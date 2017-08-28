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
            this.btAddMenu = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.labelDGV = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.listBoxAuthor = new System.Windows.Forms.ListBox();
            this.btAddAuthor = new System.Windows.Forms.Button();
            this.tbCoverPath = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.btAddAction = new System.Windows.Forms.Button();
            this.btCover = new System.Windows.Forms.Button();
            this.panelRadioButton = new System.Windows.Forms.Panel();
            this.rbAddItem = new System.Windows.Forms.RadioButton();
            this.rbAddVolume = new System.Windows.Forms.RadioButton();
            this.panelAddItem = new System.Windows.Forms.Panel();
            this.dateTimePickerItem = new System.Windows.Forms.DateTimePicker();
            this.tbItemCode = new System.Windows.Forms.TextBox();
            this.labelAddLoc = new System.Windows.Forms.Label();
            this.labelAddLibId = new System.Windows.Forms.Label();
            this.labelAddCode = new System.Windows.Forms.Label();
            this.labelAddDate = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblSearchAuthor = new System.Windows.Forms.Label();
            this.lblSearchTitle = new System.Windows.Forms.Label();
            this.lblSearchIsbn = new System.Windows.Forms.Label();
            this.panelVolumeInfo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbIsbnSearch = new System.Windows.Forms.TextBox();
            this.dgvBiblioInfo = new System.Windows.Forms.DataGridView();
            this.comboBoxLibChoice = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelRadioButton.SuspendLayout();
            this.panelAddItem.SuspendLayout();
            this.panelVolumeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiblioInfo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(16, 18);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(159, 17);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Rechercher un volume :";
            // 
            // tbTitleSearch
            // 
            this.tbTitleSearch.Location = new System.Drawing.Point(88, 67);
            this.tbTitleSearch.Name = "tbTitleSearch";
            this.tbTitleSearch.Size = new System.Drawing.Size(469, 22);
            this.tbTitleSearch.TabIndex = 1;
            this.tbTitleSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbTitleSearch_KeyUp);
            // 
            // btAddMenu
            // 
            this.btAddMenu.Location = new System.Drawing.Point(345, 12);
            this.btAddMenu.Name = "btAddMenu";
            this.btAddMenu.Size = new System.Drawing.Size(217, 23);
            this.btAddMenu.TabIndex = 2;
            this.btAddMenu.Text = "Ajouter un volume / Exemplaire";
            this.btAddMenu.UseVisualStyleBackColor = true;
            this.btAddMenu.Click += new System.EventHandler(this.btAddVolume_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(20, 551);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(542, 241);
            this.dgvItems.TabIndex = 4;
            this.dgvItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvItems_MouseDoubleClick);
            // 
            // labelDGV
            // 
            this.labelDGV.AutoSize = true;
            this.labelDGV.Location = new System.Drawing.Point(17, 531);
            this.labelDGV.Name = "labelDGV";
            this.labelDGV.Size = new System.Drawing.Size(16, 17);
            this.labelDGV.TabIndex = 5;
            this.labelDGV.Text = " :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxMessage);
            this.panel1.Controls.Add(this.listBoxAuthor);
            this.panel1.Controls.Add(this.btAddAuthor);
            this.panel1.Controls.Add(this.tbCoverPath);
            this.panel1.Controls.Add(this.tbLastName);
            this.panel1.Controls.Add(this.btAddAction);
            this.panel1.Controls.Add(this.btCover);
            this.panel1.Controls.Add(this.panelRadioButton);
            this.panel1.Controls.Add(this.panelAddItem);
            this.panel1.Controls.Add(this.tbFirstName);
            this.panel1.Controls.Add(this.lblSearchAuthor);
            this.panel1.Controls.Add(this.lblSearchTitle);
            this.panel1.Controls.Add(this.lblSearchIsbn);
            this.panel1.Controls.Add(this.tbIsbnSearch);
            this.panel1.Controls.Add(this.btAddMenu);
            this.panel1.Controls.Add(this.labelDGV);
            this.panel1.Controls.Add(this.dgvItems);
            this.panel1.Controls.Add(this.tbTitleSearch);
            this.panel1.Controls.Add(this.labelSearch);
            this.panel1.Controls.Add(this.panelVolumeInfo);
            this.panel1.Location = new System.Drawing.Point(43, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 807);
            this.panel1.TabIndex = 6;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxMessage.Location = new System.Drawing.Point(19, 304);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(538, 22);
            this.textBoxMessage.TabIndex = 16;
            // 
            // listBoxAuthor
            // 
            this.listBoxAuthor.FormattingEnabled = true;
            this.listBoxAuthor.ItemHeight = 16;
            this.listBoxAuthor.Location = new System.Drawing.Point(88, 127);
            this.listBoxAuthor.Name = "listBoxAuthor";
            this.listBoxAuthor.Size = new System.Drawing.Size(465, 36);
            this.listBoxAuthor.TabIndex = 15;
            this.listBoxAuthor.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBoxAuthor_Format);
            this.listBoxAuthor.DoubleClick += new System.EventHandler(this.listBoxAuthor_DoubleClick);
            // 
            // btAddAuthor
            // 
            this.btAddAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddAuthor.Location = new System.Drawing.Point(504, 97);
            this.btAddAuthor.Name = "btAddAuthor";
            this.btAddAuthor.Size = new System.Drawing.Size(49, 23);
            this.btAddAuthor.TabIndex = 14;
            this.btAddAuthor.Text = "+";
            this.btAddAuthor.UseVisualStyleBackColor = true;
            this.btAddAuthor.Click += new System.EventHandler(this.btAddAuthor_Click);
            // 
            // tbCoverPath
            // 
            this.tbCoverPath.Location = new System.Drawing.Point(138, 173);
            this.tbCoverPath.Name = "tbCoverPath";
            this.tbCoverPath.Size = new System.Drawing.Size(422, 22);
            this.tbCoverPath.TabIndex = 13;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(299, 98);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(199, 22);
            this.tbLastName.TabIndex = 13;
            this.tbLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAuthorName_KeyPress);
            // 
            // btAddAction
            // 
            this.btAddAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddAction.Location = new System.Drawing.Point(243, 275);
            this.btAddAction.Name = "btAddAction";
            this.btAddAction.Size = new System.Drawing.Size(91, 23);
            this.btAddAction.TabIndex = 10;
            this.btAddAction.Text = "Ajouter";
            this.btAddAction.UseVisualStyleBackColor = true;
            this.btAddAction.Click += new System.EventHandler(this.btAddAction_Click);
            // 
            // btCover
            // 
            this.btCover.Location = new System.Drawing.Point(34, 172);
            this.btCover.Name = "btCover";
            this.btCover.Size = new System.Drawing.Size(89, 23);
            this.btCover.TabIndex = 10;
            this.btCover.Text = "Couverture";
            this.btCover.UseVisualStyleBackColor = true;
            // 
            // panelRadioButton
            // 
            this.panelRadioButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRadioButton.Controls.Add(this.rbAddItem);
            this.panelRadioButton.Controls.Add(this.rbAddVolume);
            this.panelRadioButton.Location = new System.Drawing.Point(345, 38);
            this.panelRadioButton.Name = "panelRadioButton";
            this.panelRadioButton.Size = new System.Drawing.Size(212, 22);
            this.panelRadioButton.TabIndex = 12;
            // 
            // rbAddItem
            // 
            this.rbAddItem.AutoSize = true;
            this.rbAddItem.Location = new System.Drawing.Point(109, -1);
            this.rbAddItem.Name = "rbAddItem";
            this.rbAddItem.Size = new System.Drawing.Size(98, 21);
            this.rbAddItem.TabIndex = 1;
            this.rbAddItem.TabStop = true;
            this.rbAddItem.Text = "&Exemplaire";
            this.rbAddItem.UseVisualStyleBackColor = true;
            // 
            // rbAddVolume
            // 
            this.rbAddVolume.AutoSize = true;
            this.rbAddVolume.Location = new System.Drawing.Point(3, -1);
            this.rbAddVolume.Name = "rbAddVolume";
            this.rbAddVolume.Size = new System.Drawing.Size(76, 21);
            this.rbAddVolume.TabIndex = 0;
            this.rbAddVolume.TabStop = true;
            this.rbAddVolume.Text = "&Volume";
            this.rbAddVolume.UseVisualStyleBackColor = true;
            this.rbAddVolume.CheckedChanged += new System.EventHandler(this.rbAddVolume_CheckedChanged);
            // 
            // panelAddItem
            // 
            this.panelAddItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddItem.Controls.Add(this.dateTimePickerItem);
            this.panelAddItem.Controls.Add(this.tbItemCode);
            this.panelAddItem.Controls.Add(this.labelAddLoc);
            this.panelAddItem.Controls.Add(this.labelAddLibId);
            this.panelAddItem.Controls.Add(this.labelAddCode);
            this.panelAddItem.Controls.Add(this.labelAddDate);
            this.panelAddItem.Location = new System.Drawing.Point(19, 201);
            this.panelAddItem.Name = "panelAddItem";
            this.panelAddItem.Size = new System.Drawing.Size(538, 68);
            this.panelAddItem.TabIndex = 11;
            // 
            // dateTimePickerItem
            // 
            this.dateTimePickerItem.Location = new System.Drawing.Point(111, 41);
            this.dateTimePickerItem.Name = "dateTimePickerItem";
            this.dateTimePickerItem.Size = new System.Drawing.Size(204, 22);
            this.dateTimePickerItem.TabIndex = 17;
            // 
            // tbItemCode
            // 
            this.tbItemCode.Location = new System.Drawing.Point(152, 9);
            this.tbItemCode.Name = "tbItemCode";
            this.tbItemCode.Size = new System.Drawing.Size(96, 22);
            this.tbItemCode.TabIndex = 13;
            // 
            // labelAddLoc
            // 
            this.labelAddLoc.AutoSize = true;
            this.labelAddLoc.Location = new System.Drawing.Point(327, 12);
            this.labelAddLoc.Name = "labelAddLoc";
            this.labelAddLoc.Size = new System.Drawing.Size(139, 17);
            this.labelAddLoc.TabIndex = 15;
            this.labelAddLoc.Text = "Localisation de l\'item";
            // 
            // labelAddLibId
            // 
            this.labelAddLibId.AutoSize = true;
            this.labelAddLibId.Location = new System.Drawing.Point(327, 41);
            this.labelAddLibId.Name = "labelAddLibId";
            this.labelAddLibId.Size = new System.Drawing.Size(90, 17);
            this.labelAddLibId.TabIndex = 14;
            this.labelAddLibId.Text = "Bibliotheque ";
            // 
            // labelAddCode
            // 
            this.labelAddCode.AutoSize = true;
            this.labelAddCode.Location = new System.Drawing.Point(4, 12);
            this.labelAddCode.Name = "labelAddCode";
            this.labelAddCode.Size = new System.Drawing.Size(151, 17);
            this.labelAddCode.TabIndex = 13;
            this.labelAddCode.Text = "Code de l\'exemplaire : ";
            // 
            // labelAddDate
            // 
            this.labelAddDate.AutoSize = true;
            this.labelAddDate.Location = new System.Drawing.Point(4, 41);
            this.labelAddDate.Name = "labelAddDate";
            this.labelAddDate.Size = new System.Drawing.Size(100, 17);
            this.labelAddDate.TabIndex = 12;
            this.labelAddDate.Text = "Date d\'achat : ";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(88, 98);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(194, 22);
            this.tbFirstName.TabIndex = 10;
            this.tbFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAuthorName_KeyPress);
            // 
            // lblSearchAuthor
            // 
            this.lblSearchAuthor.AutoSize = true;
            this.lblSearchAuthor.Location = new System.Drawing.Point(31, 101);
            this.lblSearchAuthor.Name = "lblSearchAuthor";
            this.lblSearchAuthor.Size = new System.Drawing.Size(62, 17);
            this.lblSearchAuthor.TabIndex = 4;
            this.lblSearchAuthor.Text = "Auteur : ";
            // 
            // lblSearchTitle
            // 
            this.lblSearchTitle.AutoSize = true;
            this.lblSearchTitle.Location = new System.Drawing.Point(31, 72);
            this.lblSearchTitle.Name = "lblSearchTitle";
            this.lblSearchTitle.Size = new System.Drawing.Size(49, 17);
            this.lblSearchTitle.TabIndex = 9;
            this.lblSearchTitle.Text = "Titre : ";
            // 
            // lblSearchIsbn
            // 
            this.lblSearchIsbn.AutoSize = true;
            this.lblSearchIsbn.Location = new System.Drawing.Point(31, 43);
            this.lblSearchIsbn.Name = "lblSearchIsbn";
            this.lblSearchIsbn.Size = new System.Drawing.Size(51, 17);
            this.lblSearchIsbn.TabIndex = 8;
            this.lblSearchIsbn.Text = "ISBN : ";
            // 
            // panelVolumeInfo
            // 
            this.panelVolumeInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVolumeInfo.Controls.Add(this.pictureBox1);
            this.panelVolumeInfo.Controls.Add(this.panel2);
            this.panelVolumeInfo.Location = new System.Drawing.Point(19, 345);
            this.panelVolumeInfo.Name = "panelVolumeInfo";
            this.panelVolumeInfo.Size = new System.Drawing.Size(542, 172);
            this.panelVolumeInfo.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(342, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 164);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(8, 9);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(51, 17);
            this.lblIsbn.TabIndex = 2;
            this.lblIsbn.Text = "ISBN : ";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(3, 117);
            this.lblAuthor.MaximumSize = new System.Drawing.Size(325, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(62, 17);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Auteur : ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Gentium Book Basic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(2, 35);
            this.lblTitle.MaximumSize = new System.Drawing.Size(330, 110);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Titre de l\'ouvrage";
            // 
            // tbIsbnSearch
            // 
            this.tbIsbnSearch.Location = new System.Drawing.Point(88, 38);
            this.tbIsbnSearch.Name = "tbIsbnSearch";
            this.tbIsbnSearch.Size = new System.Drawing.Size(132, 22);
            this.tbIsbnSearch.TabIndex = 6;
            this.tbIsbnSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIsbnSearch_KeyPress);
            this.tbIsbnSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbIsbnSearch_KeyUp);
            // 
            // dgvBiblioInfo
            // 
            this.dgvBiblioInfo.AllowUserToAddRows = false;
            this.dgvBiblioInfo.AllowUserToDeleteRows = false;
            this.dgvBiblioInfo.AllowUserToOrderColumns = true;
            this.dgvBiblioInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgvBiblioInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvBiblioInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBiblioInfo.Location = new System.Drawing.Point(43, 12);
            this.dgvBiblioInfo.Name = "dgvBiblioInfo";
            this.dgvBiblioInfo.ReadOnly = true;
            this.dgvBiblioInfo.RowTemplate.Height = 24;
            this.dgvBiblioInfo.Size = new System.Drawing.Size(300, 52);
            this.dgvBiblioInfo.TabIndex = 4;
            // 
            // comboBoxLibChoice
            // 
            this.comboBoxLibChoice.AllowDrop = true;
            this.comboBoxLibChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLibChoice.FormattingEnabled = true;
            this.comboBoxLibChoice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxLibChoice.Location = new System.Drawing.Point(43, 70);
            this.comboBoxLibChoice.Name = "comboBoxLibChoice";
            this.comboBoxLibChoice.Size = new System.Drawing.Size(283, 24);
            this.comboBoxLibChoice.TabIndex = 9;
            this.comboBoxLibChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxLibChoice_SelectedIndexChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "\"\"";
            this.openFileDialog.InitialDirectory = "C:\\Users\\Murad\\documents\\Exam SGBD 2016-17\\Images\\";
            this.openFileDialog.Title = "Choisissez une couverture";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.lblIsbn);
            this.panel2.Controls.Add(this.lblAuthor);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 164);
            this.panel2.TabIndex = 4;
            // 
            // FormBiblio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 966);
            this.Controls.Add(this.comboBoxLibChoice);
            this.Controls.Add(this.dgvBiblioInfo);
            this.Controls.Add(this.panel1);
            this.Name = "FormBiblio";
            this.Text = "Gestion des ouvrages";
            this.Load += new System.EventHandler(this.FormBiblio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelRadioButton.ResumeLayout(false);
            this.panelRadioButton.PerformLayout();
            this.panelAddItem.ResumeLayout(false);
            this.panelAddItem.PerformLayout();
            this.panelVolumeInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiblioInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox tbTitleSearch;
        private System.Windows.Forms.Button btAddMenu;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Label labelDGV;
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
        private System.Windows.Forms.Label labelAddLoc;
        private System.Windows.Forms.Label labelAddLibId;
        private System.Windows.Forms.Label labelAddCode;
        private System.Windows.Forms.Label labelAddDate;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblSearchAuthor;
        private System.Windows.Forms.Panel panelRadioButton;
        private System.Windows.Forms.RadioButton rbAddItem;
        private System.Windows.Forms.RadioButton rbAddVolume;
        private System.Windows.Forms.Button btAddAction;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox tbCoverPath;
        private System.Windows.Forms.Button btCover;
        private System.Windows.Forms.DateTimePicker dateTimePickerItem;
        private System.Windows.Forms.TextBox tbItemCode;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Button btAddAuthor;
        private System.Windows.Forms.ListBox listBoxAuthor;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Panel panel2;
    }
}