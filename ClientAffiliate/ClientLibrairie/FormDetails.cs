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
    public partial class FormDetails : Form
    {
        private FormLect.EmpruntXtd _currentEmprunt = null;
        public FormDetails(FormLect.EmpruntXtd emprunt)
        {
            InitializeComponent();
            _currentEmprunt = emprunt;
        }

        private void FormDetails_Load(object sender, EventArgs e)
        {
            textBoxTitle.Text = _currentEmprunt.VolumeTitle;
            textBoxCode.Text = _currentEmprunt.ItemCode;
            textBoxLibrary.Text = _currentEmprunt.LibraryName;
            textBoxStartDate.Text = _currentEmprunt.StartDate.ToShortDateString();
            textBoxEndDate.Text = _currentEmprunt.PlannedRtnDte.ToShortDateString();
            textBoxLateDays.Text = _currentEmprunt.LateDays.ToString();
            textBoxDailyPenalty.Text = _currentEmprunt.DailyPenalty.ToString();
            textBoxToPay.Text = _currentEmprunt.ToPay.ToString();
            textBoxFee.Text = _currentEmprunt.Fee.ToString();
            textBoxTarif.Text = _currentEmprunt.TarifName;
        }
    }
}
