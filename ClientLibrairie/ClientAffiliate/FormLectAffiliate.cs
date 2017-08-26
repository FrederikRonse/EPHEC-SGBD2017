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
using static ClientLibrairie.CheckInputStrg;
using ClientAffiliate.ServiceReference1;

namespace ClientLibrairie
{
    public partial class FormLect : Form
    {
        private List<vLibrary> _libraries;
        private vLibrary _currentLibrary;

        private vAffiliate _affiliate;
        private List<EmpruntXtd> _emprunts = new List<EmpruntXtd>();
        private List<vVolume> _allVolumes = new List<vVolume>();
        private BindingSource _bsDgvEmprunts = new BindingSource();


        /// <summary>
        /// Classe étendant le BO "Emprunt" pour plus de facilité.
        /// </summary>
        public class EmpruntXtd : vEmpruntDetail
        {
            public EmpruntXtd() { }
            public EmpruntXtd(vEmpruntDetail empruntToConvert)
            {
                //this.IdEmprunt = empruntToConvert.Id;
                //this.CardNum = empruntToConvert.CardNum;
                //this.ItemId = empruntToConvert.ItemId;
                //this.ItemCode = empruntToConvert.ItemCode;
                //this.LibraryId = empruntToConvert.LibraryId;
                //this.LibraryName = empruntToConvert.LibraryName;
                //this.TarifName = empruntToConvert.TarifName;
                //this.VolumeTitle = empruntToConvert.VolumeTitle;
                //this.StartDate = empruntToConvert.StartDate;
                //this.Duration = empruntToConvert.Duration;
                //this.ReturnDte = empruntToConvert.ReturnDte;
                //this.Fee = empruntToConvert.Fee;
                //this.DailyPenalty = empruntToConvert.DailyPenalty;
                //this.LastModified = empruntToConvert.LastModified;
            }

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

        public FormLect()
        {
            InitializeComponent();
        }


        private void FormLect_Load(object sender, EventArgs e)
        {
            SetAllLibraries();
            if (_libraries != null) _currentLibrary = _libraries.First();
            comboBoxLibChoice.DataSource = _libraries;
            comboBoxLibChoice.DisplayMember = "Name";
            comboBoxLibChoice.ValueMember = "Id";
        }
        /// <summary>
        /// Charge toutes les librairies pour le choix de la librairie active.
        /// </summary>
        private void SetAllLibraries()
        {
            AffiliateServiceClient sClient = new AffiliateServiceClient();
            try
            {
                List<vLibrary> libraries = sClient.GetLibraries().ToList();
                if (libraries.Count() >= 1) _libraries = libraries;
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
            catch (System.ServiceModel.FaultException<ClientAffiliate.ServiceReference1.CustomFault> Fault)
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
        /// Charge les emprunts et initialise les controls pour un lecteur.
        /// </summary>
        /// <param name="id"></param>
        private void SetAffiliate()
        {
            tbCardNum.Text = _affiliate.CardNum.ToString();
            tbFirstName.ReadOnly = true;
            tbFirstName.Text = _affiliate.FirstName.ToString();
            tbLastName.ReadOnly = true;
            tbLastName.Text = _affiliate.LastName.ToString();
            lblBiblioPr.Text = "Bibliothèque principale :  " + _libraries.Find(l => l.IdLibrary == _affiliate.MainLibrary_Id).NameLibrary;
            if (_affiliate.BirthDate != default(DateTime))
            {
                DateTime date = (DateTime)_affiliate.BirthDate;
                lblNaiss.Text = "Date de naissance :  " + date.ToShortDateString();
            }
            LockNames(true);

        }

        /// <summary>
        /// Récupère un lecteur d'après son ID.
        /// </summary>
        /// <param name="id"></param>
        private void GetAffiliate(int id)
        {
            AffiliateServiceClient sClient = new AffiliateServiceClient();
            try
            {
                vAffiliate lecteur = sClient.GetAffiliateById(id);

                if (lecteur.CardNum != 0)
                {
                    _affiliate = lecteur;
                    SetAffiliate();
                    GetAllVolumes();
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
            catch (System.ServiceModel.FaultException<ClientAffiliate.ServiceReference1.CustomFault>Fault)
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
            AffiliateServiceClient sClient = new AffiliateServiceClient();
            try
            {
                vAffiliate lecteur = sClient.GetAffiliateByName(firstName, lastName);

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
            catch (System.ServiceModel.FaultException<ClientAffiliate.ServiceReference1.CustomFault> Fault)
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

        private void GetAllVolumes()
        {
            AffiliateServiceClient sClient = new AffiliateServiceClient();
            try
            {
                List<vVolume> volumes = sClient.GetAllVolumes().ToList();
                if (volumes.Count() >= 1)
                {
                    _allVolumes = volumes;

                    _bsDgvEmprunts.DataSource = null;
                    _bsDgvEmprunts.DataSource = _allVolumes;
                    dgvEmprunts.DataSource = _bsDgvEmprunts;
                }
            }
            catch (System.ServiceModel.EndpointNotFoundException endpointEx)
            {
                int cstmErrorN = 9; // "End point not found! Vérifiez que le serveur est lancé."
                CstmError cstmError = new CstmError(cstmErrorN, endpointEx);
                CstmError.Display(cstmError);
            }
            catch (System.ServiceModel.FaultException<ClientAffiliate.ServiceReference1.CustomFault> Fault)
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
        /// Récupère la liste des emprunts de l'affilié.
        /// </summary>
        /// <param name="affilateId"></param>
        private void GetEmprunts(int affilateId)
        {
            AffiliateServiceClient sClient = new AffiliateServiceClient();
            try
            {
                List<vEmpruntDetail> emprunts = sClient.GetEmpruntsByAffiliate(affilateId).ToList();
                if (emprunts.Count() >= 1)
                {
                    foreach (vEmpruntDetail baseEmprunt in emprunts)
                    {
                        EmpruntXtd newEmprunt = new EmpruntXtd(baseEmprunt);
                        _emprunts.Add(newEmprunt);
                    }

                    _bsDgvEmprunts.DataSource = null;
                    _bsDgvEmprunts.DataSource = _emprunts;
                    dgvEmprunts.DataSource = _bsDgvEmprunts;
                }
            }
            catch (System.ServiceModel.EndpointNotFoundException endpointEx)
            {
                int cstmErrorN = 9; // "End point not found! Vérifiez que le serveur est lancé."
                CstmError cstmError = new CstmError(cstmErrorN, endpointEx);
                CstmError.Display(cstmError);
            }
            catch (System.ServiceModel.FaultException<ClientAffiliate.ServiceReference1.CustomFault> Fault)
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
        /// Remplace la liste d'emprunts par un emprunt
        /// selon le code de l'exemplaire.
        /// </summary>
        /// <param name="code"></param>
        private void GetEmpruntbyCode(string code)
        {
            AffiliateServiceClient sClient = new AffiliateServiceClient();
            try
            {
                vEmpruntDetail baseEmprunt = sClient.GetEmpruntByCode(code);
                if (baseEmprunt.IdEmprunt != 0)
                {
                    EmpruntXtd newEmprunt = new EmpruntXtd(baseEmprunt);
                    _emprunts.Clear();
                    _emprunts.Add(newEmprunt);

                    _bsDgvEmprunts.DataSource = null;
                    _bsDgvEmprunts.DataSource = _emprunts;
                    dgvEmprunts.DataSource = _bsDgvEmprunts;
                }
                else
                {
                    MessageBox.Show(string.Format("Le code d'exemplaire {0}\n n'a rien retourné !", code.ToString()), "Désolé",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (System.ServiceModel.EndpointNotFoundException endpointEx)
            {
                int cstmErrorN = 9; // "End point not found! Vérifiez que le serveur est lancé."
                CstmError cstmError = new CstmError(cstmErrorN, endpointEx);
                CstmError.Display(cstmError);
            }
            catch (System.ServiceModel.FaultException<ClientAffiliate.ServiceReference1.CustomFault> Fault)
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
                dgvEmprunts.Rows.Clear(); 
                                          
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
        /// Affichage de la form des détails.
        /// </summary>
        /// <param name="IdEmprunt"></param>
        private void ShowDetails(int IdEmprunt)
        {
            FormDetails formDetails = new FormDetails(_emprunts.Find(e => e.IdEmprunt == IdEmprunt));
            formDetails.Show();
        }


        /// <summary>
        /// Récupère un lecteur par ses prénom et nom.
        /// </summary>
        /// <param name="sender"></param> Bouton "Rechercher"
        /// <param name="e"></param>
        private void SearchByName(object sender, EventArgs e)
        {
            if (tbFirstName.ReadOnly == true) LockNames(false);
            else
            {

                if (CheckInputStrg.Check(InputType.Name, tbFirstName.Text)
                    && CheckInputStrg.Check(InputType.Name, tbLastName.Text) == true)
                    GetAffiliate(tbFirstName.Text, tbLastName.Text);
                else
                {
                    if (CheckInputStrg.Check(InputType.Name, tbFirstName.Text) != true)
                        MessageBox.Show("Entre 3 et 20 caractères. lettres, un espace ou \" ' \" ou \"-\".", "Prénom incorrect ou manquant !",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                        MessageBox.Show("Entre 3 et 20 caractères. lettres, un espace ou \" ' \" ou \"-\".", "Nom incorrect ou manquant !",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
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
        /// Lance la recherche d'un lecteur et de ses emprunts d'après son Id
        /// si "Enter" est actionné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbCardNum_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (CheckInputStrg.Check(InputType.CardNum, tbCardNum.Text) == true)
                {
                    GetAffiliate(int.Parse(tbCardNum.Text));
                    if (_affiliate!=null)
                    GetEmprunts(_affiliate.CardNum);
                }
                else
                    MessageBox.Show("Veuillez donner un numéro de lecteur valide !", "Informations manquantes ou incorrectes",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Choix de la librairie principale.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxLibChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentLibrary = _libraries.Find(l => l == comboBoxLibChoice.SelectedItem);
        }

        /// <summary>
        /// Appelle l'affichage de la form des détails.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEmprunts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmprunts.SelectedRows != null)
            {
                ShowDetails((int)dgvEmprunts.SelectedRows[0].Cells["Id"].Value);
            }
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
        /// <summary>
        /// Charge un emprunt et le lecteur correspondant
        /// par le code de l'exemplaire emprunté.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (CheckInputStrg.Check(InputType.ItemCode, textBoxCode.Text) == true)
                {
                    GetEmpruntbyCode(textBoxCode.Text);
                    textBoxCode.Clear();
                    if (_emprunts.Count != 0) GetAffiliate(_emprunts[0].CardNum);
                }
                else
                    MessageBox.Show("Veuillez entrer un code d'exemplaire valide !", "Informations manquantes / incorrectes",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
