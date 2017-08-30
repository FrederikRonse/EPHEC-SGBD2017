using System;
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
        private List<Item> _exemplaires = null;
        private List<Emprunt> _LstPreEmprunts = null;
        private Emprunt _CurrentEmprunt = null;
        //  private FormLect.EmpruntXtd _emprunt;

        private BindingSource _bsDataGridView = new BindingSource();


        public FormDetailsEmprunt(MainForm parentForm, Affiliate currentUser, Volume volume)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _currentUser = currentUser;
        }


        private void FormDetails_Load(object sender, EventArgs e)
        {
            SetPreEmpList();
            SetDgvPreEmps();
            _CurrentEmprunt = _LstPreEmprunts.First();
            RefreshDetails();
        }

        /// <summary>
        /// Remplissage des détails.
        /// </summary>
        private void RefreshDetails()
        {
            textBoxTitle.Text = _CurrentEmprunt.VolumeTitle;
            textBoxLibrary.Text = _CurrentEmprunt.LibraryName;
            textBoxDailyPenalty.Text = _CurrentEmprunt.DailyPenalty.ToString();
            textBoxFee.Text = _CurrentEmprunt.Fee.ToString();
            textBoxTarif.Text = _CurrentEmprunt.TarifName;
        }
        /// <summary>
        /// Remplissage de la liste des exemplaires.
        /// </summary>
        private void SetDgvPreEmps()
        {
            _bsDataGridView.DataSource = null;
            _bsDataGridView.DataSource = _LstPreEmprunts;
            dgvItems.DataSource = null;
            dgvItems.DataSource = _bsDataGridView;
            dgvItems.ColumnHeadersVisible = false;
            //   dgvItems.Columns["PersId"].Visible = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }



        /// <summary>
        /// Etabli la liste des preemprunts
        /// en récupérant les exemplaires et des infos supplémentaires.
        /// </summary>
        private void SetPreEmpList()
        {
            // Récupération des exemplaires 
            List<Item> items = DAL.GetItems((int)_volume.Id).ToList();
            if (items.Count() >= 1) _exemplaires = items;
            else
            {
                int cstmErrorN = 11; //"Aucun résultat ne correspond à cette recherche !"
                CstmError.Display(new CstmError(cstmErrorN));
            }
            //Création et remplissage des preemps. 
            // Récupération des noms de bibliothèques et des tarifs correspondants.
            foreach (Item item in _exemplaires)
            {
                Emprunt preEmp = new Emprunt();
                Library empLib = _parentForm._libraries.SingleOrDefault(l => l.Id == item.LibraryId);
                Tarif empTarif = DAL.getTarif(empLib.Id);
                preEmp.LibraryName = empLib.Name.ToString();
                preEmp.TarifName = empTarif.Name;
                preEmp.Fee = empTarif.Fee;
                preEmp.DailyPenalty = empTarif.DailyPenalty;
                //      preEmp.Duration =   empTarif.Duration;
            }

        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
