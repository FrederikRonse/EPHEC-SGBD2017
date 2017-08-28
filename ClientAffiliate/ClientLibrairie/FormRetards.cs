using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EL;


namespace ClientLibrairie
{
    public partial class FormRetards : Form
    {
        private List<ServiceReference.Library> _libraries;
        private List<EmpruntFull> _retards = new List<EmpruntFull>();

        private BindingSource _bsDataGridView = new BindingSource();

        /// <summary>
        /// Classe étendant le BO "Emprunt" pour plus de facilité.
        /// </summary>
        public class EmpruntFull : ServiceReference.Emprunt
        {
            public EmpruntFull() { }
            public EmpruntFull(ServiceReference.Emprunt empruntToConvert)
            {
                this.Id = empruntToConvert.Id;
                this.CardNum = empruntToConvert.CardNum;
                this.ItemId = empruntToConvert.ItemId;
                this.ItemCode = empruntToConvert.ItemCode;
                this.LibraryId = empruntToConvert.LibraryId;
                this.LibraryName = empruntToConvert.LibraryName;
                this.TarifName = empruntToConvert.TarifName;
                this.VolumeTitle = empruntToConvert.VolumeTitle;
                this.StartDate = empruntToConvert.StartDate;
                this.Duration = empruntToConvert.Duration;
                this.ReturnDte = empruntToConvert.ReturnDte;
                this.Fee = empruntToConvert.Fee;
                this.DailyPenalty = empruntToConvert.DailyPenalty;
                this.LastModified = empruntToConvert.LastModified;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime PlannedRtnDte
            {
                get
                {
                    return StartDate.AddDays(Duration);
                }
            }

            public int LateDays
            {
                get
                {
                    int compRslt = DateTime.Compare(DateTime.Today, PlannedRtnDte);

                    if (compRslt < 0)
                    {
                        return -1;
                    }
                    if (compRslt == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        int daysDiff = new int();
                        for (DateTime i = PlannedRtnDte; i < DateTime.Today; i = i.AddDays(1))
                        {
                            if (i.DayOfWeek != DayOfWeek.Sunday)
                            {
                                daysDiff++;
                            }
                        }
                        return daysDiff;
                    }
                }
            }

            public decimal ToPay
            {
                get
                {
                    if (LateDays < 0) return 0;
                    if (LateDays <= 0) return Fee;
                    else return (Fee + LateDays * DailyPenalty);
                }
            }
        }

        public FormRetards()
        {
            InitializeComponent();
        }
        public FormRetards(List<ServiceReference.Library> libraries)
        {
            InitializeComponent();
            if (libraries != null) _libraries = libraries;
            comboBoxLibChoice.DataSource = _libraries;
            comboBoxLibChoice.DisplayMember = "Name";
            comboBoxLibChoice.ValueMember = "Id";

            _bsDataGridView.DataSource = null;
            _bsDataGridView.DataSource = _retards;
        }
        /// <summary>
        /// Retourne les retards d'une librairie
        /// </summary>
        /// <param name="libId"></param>
        /// <param name="referenceDate"></param>
        private void GetRetardsByLib(int libId, DateTime referenceDate = default(DateTime))
        {
            ServiceReference.AffiliateServiceClient sClient = new ServiceReference.AffiliateServiceClient();
            if (referenceDate == default(DateTime)) referenceDate = DateTime.Now.Date;
            try
            {
                List<ServiceReference.Emprunt> retards = sClient.GetRetards(referenceDate, libId).ToList();
                if (retards.Count() >= 1)
                {
                    foreach (ServiceReference.Emprunt baseEmprunt in retards)
                    {
                        EmpruntFull newEmprunt = new EmpruntFull(baseEmprunt);
                        SetNames(ref newEmprunt);
                        _retards.Add(newEmprunt);
                    }
                    _bsDataGridView.DataSource = null;
                    _bsDataGridView.DataSource = _retards;
                    dataGridView1.DataSource = _bsDataGridView;
                    SetMessage(string.Format("Retards de la {0} ajoutés.", _libraries.Find(l => l == comboBoxLibChoice.SelectedItem).Name));
                }
                else
                {
                    int cstmErrorN = 11; //"Aucun résultat ne correspond à cette recherche !"
                    throw new CstmError(cstmErrorN);
                }
            }
            catch (System.ServiceModel.EndpointNotFoundException endpointEx)
            {
                int cstmErrorN = 9; // "End point not found! Vérifiez que le serveur est lancé."
                CstmError cstmError = new CstmError(cstmErrorN, endpointEx);
                CstmError.Display(cstmError);
            }
            catch (System.ServiceModel.FaultException<ServiceReference.CustomFault> Fault)
            {
                CstmError.Display(Fault.Message);
            }
            catch (CstmError cstmError)
            {
                CstmError.Display(cstmError);
            }
            catch (Exception e)
            {
                MessageBox.Show("Une exception s'est produite à la récupération des données !", "Erreur",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Assigne les nom et prénom d'un lecteur à un retard (empruntfull).
        /// </summary>
        /// <param name="retard"></param>
        private void SetNames(ref EmpruntFull retard)
        {
            ServiceReference.Affiliate affiliate = new ServiceReference.Affiliate();
            ServiceReference.AffiliateServiceClient sClient = new ServiceReference.AffiliateServiceClient();
            try
            {
                ServiceReference.Affiliate lecteur = sClient.GetAffiliateById(retard.CardNum);

                if (lecteur.CardNum != 0)
                {
                    retard.FirstName = lecteur.FirstName;
                    retard.LastName = lecteur.LastName;
                }
                else
                {
                    MessageBox.Show(string.Format("Une erreur s'est produite en récupérant le lecteur \n pour le retard de {0} !", retard.VolumeTitle), "Désolé",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (System.ServiceModel.EndpointNotFoundException endpointEx)
            {
                int cstmErrorN = 9; // "End point not found! Vérifiez que le serveur est lancé."
                CstmError cstmError = new CstmError(cstmErrorN, endpointEx);
                CstmError.Display(cstmError);
            }
            catch (System.ServiceModel.FaultException<ServiceReference.CustomFault> Fault)
            {
                CstmError.Display(Fault.Message);
            }
            catch (CstmError cstmError)
            {
                CstmError.Display(cstmError);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Une exception s'est produite à la récupération des données : \n {0}", ex.Message), "Attention",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
