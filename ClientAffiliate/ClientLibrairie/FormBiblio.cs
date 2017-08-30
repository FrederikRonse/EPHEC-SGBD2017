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
    public partial class FormBiblio : Form
    {
        private MainForm _parentForm;
        private ServiceReference.Affiliate _user;
        private List<ServiceReference.Library> _libraries;
        private ServiceReference.Library _currentLibrary;
        private List<ServiceReference.Volume> _volumes;
        private ServiceReference.Volume _currentVolume = null;
        private bool _showVolumes = true;



        private BindingSource _bsCurrentLib = new BindingSource();
        private BindingSource _bsDataGridView = new BindingSource();

        public FormBiblio()
        {
            InitializeComponent();
        }
        public FormBiblio(MainForm parent)
        {
            InitializeComponent();
            _parentForm = parent;
            _user = _parentForm._CurrentAffiliate ?? null;
        }

        private void FormBiblio_Load(object sender, EventArgs e)
        {
            SetAllLibraries();
            if (_libraries != null) _currentLibrary = _libraries.First();
            if (_user.FirstName != null) this.Text = string.Format("Bienvenue {0} !", _user.FirstName);
            GetAllVolumes();
            BindAndSet();
            SwitchVolWish();
        }


        /// <summary>
        /// Lie les differents controles aux données et les initialise.
        /// </summary>
        private void BindAndSet()
        {
            comboBoxLibChoice.DataSource = _libraries;
            comboBoxLibChoice.DisplayMember = "Name";
            comboBoxLibChoice.ValueMember = "Id";
            _bsCurrentLib.DataSource = null;
            _bsCurrentLib.DataSource = _currentLibrary;
            dgvBiblioInfo.DataSource = null;
            dgvBiblioInfo.DataSource = _bsCurrentLib;
            dgvBiblioInfo.ColumnHeadersVisible = false;
            dgvBiblioInfo.Columns[0].Visible = false;
            dgvBiblioInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvItems.ColumnHeadersVisible = false;

            rbEmprunt.Checked = true;
            rbWish.Show();
            rbEmprunt.Show();
            btAddAction.Show();
            pictureBox1.ImageLocation = @"~\Covers\book-cover_template.jpg"; //@"C:\Users\Murad\documents\Exam SGBD 2016-17\Images\book-cover_template.jpg"
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            SetVolInfoBox(true);
        }

        /// <summary>
        /// Charge toutes les librairies pour le combobox du choix de la librairie active.
        /// </summary>
        private void SetAllLibraries()
        {
            ServiceReference.AffiliateServiceClient sClient = new ServiceReference.AffiliateServiceClient();
            try
            {
                List<ServiceReference.Library> libraries = sClient.GetLibraries().ToList();
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
        /// retorune tous les livres (juste pour cet exercice).
        /// </summary>
        private void GetAllVolumes()
        {
            try
            {
                List<Volume> volumes = DAL.GetAllVolumes().ToList();
                if (volumes.Count() >= 1) _volumes = volumes;
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
        /// Retourne un volume par son ISBN et l'assigne comme volume courant.
        /// </summary>
        /// <param name="isbn"></param>
        private void GetVolumeDetailsByIsbn(string isbn)
        {
            ServiceReference.AffiliateServiceClient sClient = new ServiceReference.AffiliateServiceClient();
            try
            {
                ServiceReference.Volume volume = sClient.GetVolumeDetailsByIsbn(tbIsbnSearch.Text);
                if (volume.Id != null)
                {
                    _currentVolume = volume;
                }
                else
                {
                    MessageBox.Show(string.Format("L'ISBN {0}\n n'a rien retourné !", tbIsbnSearch.Text), "Désolé",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                SetVolSrchInfos(true);
                SetVolInfoBox(true);
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
        /// Retourne un volume par son titre.
        /// </summary>
        /// <param name="titleLike"></param>
        private void GetVolumeDetailsByTitle(string titleLike)
        {
            ServiceReference.AffiliateServiceClient sClient = new ServiceReference.AffiliateServiceClient();
            try
            {
                ServiceReference.Volume volume = sClient.GetVolumeByTitle(tbTitleSearch.Text);
                if (volume.Id != null)
                {
                    _currentVolume = volume;
                }
                else
                {
                    MessageBox.Show(string.Format("Le titre {0}\n n'a rien retourné !", tbTitleSearch.Text), "Désolé",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                SetVolSrchInfos(true);
                SetVolInfoBox(true);
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
        /// (PAS UTILISE) Retourne une liste de volumes dont le titre 
        /// s'approche du titre recherché.
        /// </summary>
        /// <param name="title"></param>
        private void GetVolumeListByTitle(string title)
        {
            List<ServiceReference.Volume> ListVolumes;
            ServiceReference.AffiliateServiceClient sClient = new ServiceReference.AffiliateServiceClient();

            try
            {
                List<ServiceReference.Volume> volumes = sClient.GetVolumesByTitle(title).ToList();
                if (volumes != null)
                {
                    ListVolumes = volumes;
                }
                else
                {
                    MessageBox.Show("Le titre  \"{0}\"\n n'a rien retourné !", title,
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
            catch (Exception e)
            {
                MessageBox.Show(string.Format("Une exception s'est produite à la récupération des données : \n {0}", e.Message), "Erreur",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// Ajoute un livre à la Wishlist.
        /// </summary>
        /// <param name="volumeId"></param>
        private void AddToWishList()
        {
            if (_user != null && _currentVolume != null)
            {
                WishListItem wishItem = new WishListItem();
                wishItem.CardNum = _user.CardNum;
                wishItem.Volume_Id = (int)_currentVolume.Id;
                DAL.AddToWishList(wishItem.CardNum, wishItem.Volume_Id);
                SetMessage("Ce volume a été rajouté à votre liste de souhaits.");
            }
        }



        private void SwitchVolWish()
        {
            switch (_showVolumes)
            {
                case true:
                    if (_volumes != null)
                    {
                        _bsDataGridView.DataSource = null;
                        _bsDataGridView.DataSource = _volumes;
                        dgvItems.DataSource = null;
                        dgvItems.DataSource = _bsDataGridView;
                        rbWish.Visible = true;
                        labelDGV.Text = "Ouvrages en bibliothèque";
                        btSwitchView.Text = "Voir la WishList";
                        _showVolumes = false;
                    }
                    break;
                case false:
                    if (_parentForm._wishList != null)
                    {
                        _bsDataGridView.DataSource = null;
                        _bsDataGridView.DataSource = _parentForm._wishList;
                        dgvItems.DataSource = null;
                        dgvItems.DataSource = _bsDataGridView;
                        rbWish.Visible = false;
                        labelDGV.Text = "Votre WishList";
                        btSwitchView.Text = "Voir les livres";
                        rbEmprunt.Checked = true;
                        _showVolumes = true;
                    }
                    break;

            }
        }

        /// <summary>
        /// Affiche les infos du volume courant dans l'info box.
        /// </summary>
        private void SetVolInfoBox(bool display)
        {
            if (display == true && _currentVolume != null)
            {
                lblTitle.Text = string.Format("Titre : " + _currentVolume.Title);
                lblAuthor.Text = string.Format("Auteur(s) : " + SetAuthorDisplay(_currentVolume));
                lblIsbn.Text = string.Format("ISBN : " + _currentVolume.Isbn);
            }
            else
            {
                lblTitle.Text = string.Format("Titre : ");
                lblAuthor.Text = string.Format("Auteur(s) : ");
                lblIsbn.Text = string.Format("ISBN : ");
            }
        }

        /// <summary>
        /// Affiche les infos du volume courant dans les textbox de recherche.
        /// </summary>
        private void SetVolSrchInfos(bool display)
        {
            if (display == true && _currentVolume != null)
            {
                tbTitleSearch.Text = _currentVolume.Title;
                tbIsbnSearch.Text = _currentVolume.Isbn;
            }
            else
            {
                tbTitleSearch.Text = string.Empty;
                tbIsbnSearch.Text = string.Empty;
            }
        }

        /// <summary>
        /// Concatène les noms des auteurs pour l'affichage.
        /// </summary>
        /// <param name="volume"></param>
        /// <returns></returns>
        private string SetAuthorDisplay(ServiceReference.Volume volume)
        {
            if (volume.Authors != null)
            {
                string authors = null;
                foreach (ServiceReference.Author author in _currentVolume.Authors)
                {
                    authors += author.FirstName + " " + author.LastName + " ; ";
                }
                return authors;
            }
            return "";
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
        /// Etalbi la bibliothèque principale d'après le choix du combobox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxLibChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentLibrary = _libraries.Find(l => l == comboBoxLibChoice.SelectedItem);
            _bsCurrentLib.DataSource = _currentLibrary;
            dgvBiblioInfo.Refresh();
        }

        /// <summary>
        /// Lance la recherche d'un volume d'après son ISBN
        /// lorsque l'utilisateur relache la touche enter.
        /// Vérifie chaque touches relachées.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbIsbnSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && CheckInputStrg.Check(CheckInputStrg.InputType.Isbn, tbIsbnSearch.Text) == true) //searchMode = true &&
            {
                GetVolumeDetailsByIsbn(tbIsbnSearch.Text);
            }
        }

        /// <summary>
        /// Recherche un ouvrage d'après son titre.
        /// Eventuellement parmis une liste de plusieurs retours.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbTitleSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (true && e.KeyCode == Keys.Enter && CheckInputStrg.Check(CheckInputStrg.InputType.Title, tbTitleSearch.Text) == true)  //searchMode = true &&
            {

                GetVolumeDetailsByTitle(tbTitleSearch.Text);
            }
        }


        /// <summary>
        /// Mise en forme visuelle wishlist ou une réservation, selon choix utilisateur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in this.panelRadioButton.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {
                        switch (radio.Name)
                        {
                            case "rbEmprunt":
                                // Mise en forme visuelle.
                                btAddAction.Text = "Emprunter";
                                break;

                            case "rbWish":
                                // Mise en forme visuelle.
                                btAddAction.Text = "Ajouter à votre WishList";
                                break;

                            default:
                                break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Ajoute un volume dans la wishlist 
        /// ou ouvre la fenêtre de selection pour emprunt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAddAction_Click(object sender, EventArgs e)
        {
            if (_user != null && _currentVolume != null)
            {
                // Si ajout dans la wishlist.
                if (rbWish.Checked == true)
                {
                    AddToWishList();
                    _bsDataGridView.ResetBindings(false);// Sinon ne mets pas l'affichage à jour.
                                                         //GetVolumeDetailsByIsbn(_currentVolume.Isbn); //Pour rafraîchir et avoir l'Id.
                    SetVolInfoBox(true);
                }
                // Sinon, on ouvre un form pour emprunt.
                if (rbEmprunt.Checked == true)
                {
                    FormDetailsEmprunt formEmprunt = new FormDetailsEmprunt(this._parentForm, _user, _currentVolume);
                    formEmprunt.MdiParent = this._parentForm;
                    formEmprunt.Show();
                }
            }
            else
            {
                MessageBox.Show("Veuillez d'abord choisir un ouvrage !", "Informations manquantes",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btSwitchView_Click(object sender, EventArgs e)
        {
            SwitchVolWish();
        }


        /// <summary>
        /// Selectionne le volume courant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int? SlctdVolumeId = (int)dgvItems.SelectedRows[0].Cells["Id"].Value;   //     _newAuthors.SingleOrDefault(a => a.PersId == (int)dgvItems.SelectedRows[0].Cells["PersId"].Value);
            if (SlctdVolumeId != null)
            {
                _currentVolume = _volumes.FirstOrDefault(v => v.Id == SlctdVolumeId);
                SetVolInfoBox(true);
                //   _bsDataGridView.ResetBindings(false);// Sinon ne mets pas l'affichage à jour.
            }
        }


        /// <summary>
        /// Filtre les touches pressées dans le txtbox isbn 
        /// et n'accepte que les chiffres et les contrôles (backspace,..).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbIsbnSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                return;
            e.Handled = true;
        }

        /// <summary>
        /// /// Filtre les touches pressées dans le txtbox isbn 
        /// et n'accepte que les lettres, chiffres,contrôles (backspace,..), espace ou " ' " ou "-".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbAuthorName_KeyPress(object sender, KeyPressEventArgs e)
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
        /// Concatène les prénoms et noms des auteurs pour affichage.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxAuthor_Format(object sender, ListControlConvertEventArgs e)
        {
            string firstName = ((ServiceReference.Author)e.ListItem).FirstName.ToString();
            string lastName = ((ServiceReference.Author)e.ListItem).LastName.ToString();

            e.Value = lastName + " " + firstName;
        }


        #region non utilisé (pour autres forms)

        /// <summary>
        /// Ajoute l'auteur à la liste des auteurs du nouveau volume. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxAuthor_DoubleClick(object sender, EventArgs e)
        {
            //if (!_newAuthors.Contains((ServiceReference.Author)listBoxAuthor.SelectedItem))
            //    _newAuthors.Add((ServiceReference.Author)listBoxAuthor.SelectedItem);
            //_bsDataGridView.ResetBindings(false); // Sinon ne mets pas l'affichage à jour.
        }

        #endregion non utilisé (pour autres forms)


    }
}
