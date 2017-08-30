using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientLibrairie.ServiceReference;
using Utilities;
using EL;


namespace ClientLibrairie
{
    public partial class FormEmprunts : Form
    {
        MainForm _parentForm;
        private List<Library> _libraries;
        private List<Emprunt> _emprunts = new List<Emprunt>();
      //  private List<DAL.EmpruntXtd> _emprunts = new List<DAL.EmpruntXtd>();

        private BindingSource _bsDataGridView = new BindingSource();

        public FormEmprunts(MainForm parentForm)
        {
            InitializeComponent();

            _parentForm = parentForm;
        }

        private void FormRetards_Load(object sender, EventArgs e)
        {
            _emprunts = _parentForm._emprunts ?? _emprunts;
            SetandBind();
        }

        private void SetandBind()
        {
            if (_parentForm._libraries != null) _libraries = _parentForm._libraries;
            comboBoxLibChoice.DataSource = _libraries;
            comboBoxLibChoice.DisplayMember = "Name";
            comboBoxLibChoice.ValueMember = "Id";

            dataGridView1.AutoSize = true;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _emprunts;// _bsDataGridView;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            SetMessage(string.Format("Vos emprunts, {0} .",_parentForm._CurrentAffiliate.FirstName));
        }

        /// <summary>
        /// Formate les messages affichés.
        /// </summary>
        /// <param name="message"></param>
        private void SetMessage(string message)
        {
            tbInfo.Text = string.Format("     " + (DateTime.Now.ToString() + "  :  " + message));
        }


        /// <summary>
        /// Retourne les retards .
        /// </summary>
        /// <param name="libId"></param>
        /// <param name="referenceDate"></param>
        private void GetRetardsAff(int afffID) //, DateTime referenceDate = default(DateTime
        {
       //     if (referenceDate == default(DateTime)) referenceDate = DateTime.Now.Date;
            _emprunts = DAL.GetRetards(afffID);
        }

        /// <summary>
        /// Change la librairie dont les retards sont récupérés.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxLibChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ServiceReference.Library currentLibrary = _libraries.Find(l => l == comboBoxLibChoice.SelectedItem);
            //GetRetardsByLib(currentLibrary.Id);
        }

        /// <summary>
        /// Assigne la datasource du DGV.
        /// pour retards.
        /// </summary>
        private void SetDgvRetards()
        {
            _bsDataGridView.DataSource = null;
            _bsDataGridView.DataSource = _emprunts;
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
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            _bsDataGridView.ResetBindings(false);
        }

        private void btRetards_Click(object sender, EventArgs e)
        {
            GetRetardsAff(_parentForm._CurrentAffiliate.CardNum);
            SetandBind();
        }
    }
}
