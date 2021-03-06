﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientLibrairie.ServiceReference;
using EL;

namespace ClientLibrairie
{
    public partial class FormDetailsEmprunt : Form
    {
        private MainForm _parentForm = null;
        private Affiliate _currentUser = null;
        private Volume _volume = null;
        private List<Item> _exemplaires = new List<Item>();
        private List<Emprunt> _LstPreEmprunts = new List<Emprunt>();
        private Emprunt _CurrentPreEmprunt =new Emprunt();

        private BindingSource _bsDataGridView = new BindingSource();


        public FormDetailsEmprunt(MainForm parentForm, Affiliate currentUser, Volume volume)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _currentUser = currentUser;
            _volume=volume;
        }


        private void FormDetails_Load(object sender, EventArgs e)
        {
            SetPreEmpList();
            SetDgvPreEmps();
            if (_LstPreEmprunts != null && _LstPreEmprunts.Count > 0)
            {
                _CurrentPreEmprunt = _LstPreEmprunts.First();
                RefreshDetails();
            }
        }

        /// <summary>
        /// Remplissage des détails.
        /// </summary>
        private void RefreshDetails()
        {
            textBoxTitle.Text = _CurrentPreEmprunt.VolumeTitle;
            textBoxLibrary.Text = _CurrentPreEmprunt.LibraryName;
            textBoxDailyPenalty.Text = _CurrentPreEmprunt.DailyPenalty.ToString();
            textBoxFee.Text = _CurrentPreEmprunt.Fee.ToString();
            textBoxTarif.Text = _CurrentPreEmprunt.TarifName;
            textBoxDurée.Text = _CurrentPreEmprunt.Duration.ToString();
        }
        /// <summary>
        /// Remplissage de la liste des exemplaires.
        /// </summary>
        private void SetDgvPreEmps()
        {
            _bsDataGridView.DataSource = null;
            _bsDataGridView.DataSource = _LstPreEmprunts;
            dgvItems.AutoSize = true;
            dgvItems.DataSource = null;
            dgvItems.DataSource = _bsDataGridView;
            dgvItems.ColumnHeadersVisible = false;
            //   dgvItems.Columns["PersId"].Visible = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }



        /// <summary>
        /// Etabli la liste des preemprunts
        /// en récupérant les exemplaires et des infos supplémentaires.
        /// [!] .ItemCode est utilisé pour stocker l'Id du tarif
        /// pour la méthode d'enregistrement d'un emprunt.
        /// </summary>
        private void SetPreEmpList()
        {
            // Récupération des exemplaires 
            List<Item> items = DAL.GetItems((int)_volume.Id).ToList();
            if (items.Count() >= 1) _exemplaires = items;
            else
            {
                int cstmErrorN = 15; //" Cet ouvrage n'a pas d'exemplaire !"
                CstmError.Display(new CstmError(cstmErrorN));
            }
            //Création et remplissage des preemps. 
            // Récupération des noms de bibliothèques et des tarifs correspondants.
            // .ItemCode est utilisé pour stocker l'Id du tarif pour la méthode d'enregistrement d'un emprunt.
            foreach (Item item in _exemplaires)
            {
                Emprunt preEmp = new Emprunt();
                preEmp.CardNum = _currentUser.CardNum;
                preEmp.ItemId = item.Id;
                preEmp.VolumeTitle = _volume.Title;
                preEmp.LibraryId = item.LibraryId;

                Library empLib = _parentForm._libraries.SingleOrDefault(l => l.Id == item.LibraryId);
                Tarif empTarif = DAL.getTarif(empLib.Id);
                preEmp.LibraryName = empLib.Name.ToString();
                preEmp.ItemCode = empTarif.Id.ToString(); 
                preEmp.TarifName = empTarif.Name;
                preEmp.Fee = empTarif.Fee;
                preEmp.Duration = empTarif.Duration;
               preEmp.DailyPenalty = empTarif.DailyPenalty;

                _LstPreEmprunts.Add(preEmp);
            }
        }

        /// <summary>
        /// Enregistre un emprunt.
        /// .ItemCode est utilisé pour stocker l'Id du tarif pour la méthode d'enregistrement d'un emprunt.
        /// </summary>
        private void StartEmprunt( )
        {
            int cardNum = _currentUser.CardNum;
            int item_Id = _CurrentPreEmprunt.ItemId;
            int volume_Id =(int) _volume.Id;
            int tarif_Id =int.Parse(_CurrentPreEmprunt.ItemCode);
            DAL.StartEmprunt(cardNum,  item_Id,(int)_volume.Id,  tarif_Id);
            SetMessage("Votre emprunt est enregistré");
        }


        /// <summary>
        /// Selectionne le pre-emprunt courant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            _CurrentPreEmprunt = _LstPreEmprunts.SingleOrDefault(em => em.ItemId == (int)dgvItems.SelectedRows[0].Cells["ItemId"].Value) ?? _CurrentPreEmprunt;
            _bsDataGridView.ResetBindings(false);// Sinon ne mets pas l'affichage à jour.
        }


        /// <summary>
        /// Formatage des messages (ajouts réussis,...) pour le textbox d'info.
        /// </summary>
        /// <param name="message"></param>
        private void SetMessage(string message)
        {
            textBoxMessage.Text = string.Format("     " + (DateTime.Now.ToString() + "  :  " + message));
        }

        /// <summary>
        /// Appelle la méthode d'enregistrement d'un emprunt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEmprunter_Click(object sender, EventArgs e)
        {
            StartEmprunt();
        }
    }
}
