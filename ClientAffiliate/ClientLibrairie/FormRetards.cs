using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientLibrairie.ServiceReference;
using EL;


namespace ClientLibrairie
{
    public partial class FormRetards : Form
    {
        MainForm _parentForm;
        private List<Library> _libraries;
        private List<Emprunt> _retards = new List<Emprunt>();
      //  private List<DAL.EmpruntXtd> _emprunts = new List<DAL.EmpruntXtd>();

        private BindingSource _bsDataGridView = new BindingSource();

        public FormRetards(MainForm parentForm)
        {
            InitializeComponent();

            _parentForm = parentForm;

            if (_parentForm._libraries != null) _libraries = _parentForm._libraries;
            comboBoxLibChoice.DataSource = _libraries;
            comboBoxLibChoice.DisplayMember = "Name";
            comboBoxLibChoice.ValueMember = "Id";

            _bsDataGridView.DataSource = null;
            // _bsDataGridView.DataSource = _retards;
        }

        /// <summary>
        /// Retourne les retards d'une librairie
        /// </summary>
        /// <param name="libId"></param>
        /// <param name="referenceDate"></param>
        private void GetRetardsByLib(int libId, DateTime referenceDate = default(DateTime))
        {
            if (referenceDate == default(DateTime)) referenceDate = DateTime.Now.Date;
            _retards = DAL.GetRetards(libId, referenceDate);
        }

        private void SetMessage(string message)
        {
            tbInfo.Text = string.Format("     " + (DateTime.Now.ToString() + "  :  " + message));
        }
        /// <summary>
        /// Change la librairie dont les retards sont récupérés.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxLibChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceReference.Library currentLibrary = _libraries.Find(l => l == comboBoxLibChoice.SelectedItem);
            GetRetardsByLib(currentLibrary.Id);
        }

        /// <summary>
        /// Assigne la datasource du DGV.
        /// pour retards.
        /// </summary>
        private void SetDgvRetards()
        {
            _bsDataGridView.DataSource = null;
            _bsDataGridView.DataSource = _retards;
            dataGridView1.DataSource = _bsDataGridView;
            SetMessage(string.Format("Retards de la {0} ajoutés.", _libraries.Find(l => l == comboBoxLibChoice.SelectedItem).Name));
        }

        /// <summary>
        /// Vide les retards.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            _retards.Clear();
            _bsDataGridView.ResetBindings(false);
        }
    }
}
