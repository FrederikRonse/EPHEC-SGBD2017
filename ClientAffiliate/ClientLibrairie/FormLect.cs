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

using ClientLibrairie.ServiceReference;

namespace ClientLibrairie
{
    public partial class FormLect : Form
    {
        private MainForm _parentForm;

        private Affiliate _affiliate;

        public FormLect(MainForm parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _affiliate = _parentForm._CurrentAffiliate;
        }


        private void FormLect_Load(object sender, EventArgs e)
        {
            SetAffiliate();
        }
       
        /// <summary>
        /// rempli les champs de l'affilié.
        /// </summary>
        private void SetAffiliate()
        {
            tbCardNum.Text = _affiliate.CardNum.ToString();
            tbFirstName.ReadOnly = true;
            tbFirstName.Text = _affiliate.FirstName.ToString();
            tbLastName.ReadOnly = true;
            tbLastName.Text = _affiliate.LastName.ToString();
            lblBiblioPr.Text = "Bibliothèque principale :  " + _parentForm._libraries.Find(l => l.Id == _affiliate.MainLibraryId).Name;
            if (_affiliate.BirthDate != default(DateTime))
            {
                DateTime date = (DateTime)_affiliate.BirthDate;
                lblNaiss.Text = "Date de naissance :  " + date.ToShortDateString();
            }
            LockNames(true);

        }



        #region non utilisé

        /// <summary>
        /// Récupère un lecteur d'après son ID.
        /// </summary>
        /// <param name="id"></param>
        private void GetAffiliate(int id)
        {
            ServiceReference.AffiliateServiceClient sClient = new ServiceReference.AffiliateServiceClient();
            try
            {
                ServiceReference.Affiliate lecteur = sClient.GetAffiliateById(id);

                if (lecteur.CardNum != 0)
                {
                    _affiliate = lecteur;
                    SetAffiliate();
                }
                else
                {
                    MessageBox.Show(string.Format("Le numéro de carte {0}\n n'a rien retourné !", id.ToString()), "Désolé",
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

        /// <summary>
        /// Récupère un lecteur d'après son nom et prénom.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        private void GetAffiliate(string firstName, string lastName)
        {
            ServiceReference.AffiliateServiceClient sClient = new ServiceReference.AffiliateServiceClient();
            try
            {
                ServiceReference.Affiliate lecteur = sClient.GetAffiliateByName(firstName, lastName);

                if (lecteur.CardNum != 0)
                {
                    _affiliate = lecteur;
                    SetAffiliate();
                }
                else
                {
                    MessageBox.Show(string.Format("la combinaison du prénom \"{0}\" et nom \"{1}\" n'a rien retourné !", firstName, lastName), "Désolé",
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


        /// <summary>
        /// (dé)bloque et vide les textboxes des noms.
        /// </summary>
        /// <param name="lockNames"></param>
        private void LockNames(bool lockNames)
        {
            if (lockNames == false)
            {
                tbFirstName.ReadOnly = false;
                tbFirstName.Text = string.Empty;
                tbLastName.ReadOnly = false;
                tbLastName.Text = string.Empty;
                tbCardNum.Text = string.Empty;
            }
            else
            {
                tbFirstName.ReadOnly = true;
                tbLastName.ReadOnly = true;
            }
        }

        /// <summary>
        /// Formatage des messages (ajouts réussis,...) pour le textbox d'info.
        /// </summary>
        /// <param name="message"></param>
        private void SetMessage(string message)
        {
            tbInfo.Text = string.Format("     " + (DateTime.Now.ToString() + "  :  " + message));
        }

        /// <summary>
        /// Vérifie la validité des caractères du n° de carte.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbCardNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                return;
            e.Handled = true;
        }

        /// <summary>
        /// Vérifie la validité des caractères entrés dans les champs 
        /// Nom et Prénom.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)
                                || char.IsWhiteSpace(e.KeyChar)
                                || char.Equals(e.KeyChar, "'")
                                || char.Equals(e.KeyChar, "-")
                                || char.IsControl(e.KeyChar))
                return;
            e.Handled = true;
        }


        /// <summary>
        /// Vérifie la validité des caractères entrés dans le champ de code.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                return;
            e.Handled = true;
        }
        #endregion non utilisé
    }
}
