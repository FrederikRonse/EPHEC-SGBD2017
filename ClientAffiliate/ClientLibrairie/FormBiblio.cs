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
    public partial class FormBiblio : Form
    {
        private List<ServiceReference.vLibrary> _libraries;
        private ServiceReference.vLibrary _currentLibrary;
        private ServiceReference.vVolume _currentVolume = null;
        //private List<ServiceReference.Author> _dBAuthors;
        //private List<ServiceReference.Author> _newAuthors = new List<ServiceReference.Author>();
        private bool searchMode = true;


        private BindingSource _bsCurrentLib = new BindingSource();
        private BindingSource _bsDataGridView = new BindingSource();

        public FormBiblio()
        {
            InitializeComponent();
        }

        private void FormBiblio_Load(object sender, EventArgs e)
        {
            SetAllLibraries();
            if (_libraries != null) _currentLibrary = _libraries.First();
            //SetAllAuthors();
            BindAndSet();
        }


        /// <summary>
        /// Charge toutes les librairies pour le combobox du choix de la librairie active.
        /// </summary>
        private void SetAllLibraries()
        {
            ServiceReference.AffiliateServiceClient sClient = new ServiceReference.AffiliateServiceClient();
            try
            {
                List<ServiceReference.vLibrary> libraries = sClient.GetLibraries().ToList();
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
        /// Charge la liste des auteurs déjà existants dans la DB pour choix
        /// lors d'ajout d'un volume. 
        /// </summary>
        //private void SetAllAuthors()
        //{
        //    ServiceReference.AffiliateServiceClient sClient = new ServiceReference.AffiliateServiceClient();

        //    try
        //    {
        //        List<ServiceReference.> authors = sClient.GetAllAuthorsNames().ToList();
        //        if (authors != null)
        //        {
        //            _dBAuthors = authors;
        //        }
        //        else
        //        {
        //            MessageBox.Show("La liste des auteurs n'a pas pu être récupérée !", "Une erreur est survenue",
        //                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        }
        //    }
        //    catch (System.ServiceModel.EndpointNotFoundException endpointEx)
        //    {
        //        int cstmErrorN = 9; // "End point not found! Vérifiez que le serveur est lancé."
        //        CstmError cstmError = new CstmError(cstmErrorN, endpointEx);
        //        CstmError.Display(cstmError);
        //    }
        //    catch (System.ServiceModel.FaultException<ServiceReference.CustomFault> Fault)
        //    {
        //        CstmError.Display(Fault.Message);
        //    }
        //    catch (CstmError cstmError)
        //    {
        //        CstmError.Display(cstmError);
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(string.Format("Une exception s'est produite à la récupération des données : \n {0}", e.Message),"Erreur",
        //         MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        /// <summary>
        /// Retourne un volume par son ISBN et l'assigne comme volume courant.
        /// </summary>
        /// <param name="isbn"></param>
        private void GetVolumeDetailsByIsbn(string isbn)
        {
            ServiceReference.AffiliateServiceClient sClient = new ServiceReference.AffiliateServiceClient();
            try
            {
                ServiceReference.vVolume volume = sClient.GetVolumeDetailsByIsbn(tbIsbnSearch.Text);
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
        /// Ajoute un volume à la base de données.
        /// </summary>
        /// <param name="volume"></param>
        private void AddVolume(ServiceReference.Volume volume)
        {
            ServiceReference.AffiliateServiceClient sClient = new ServiceReference.AffiliateServiceClient();

            try
            {
                sClient.AddVolume(volume);
                SetMessage("Volume ajouté !");
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
                MessageBox.Show(string.Format("Une exception s'est produite à l'ajout : \n {0}", e.Message), "Erreur",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Ajoute un exemplaire à la base de données.
        /// </summary>
        /// <param name="item"></param>
        private void AddItem(ServiceReference.Item item)
        {
            ServiceReference.AffiliateServiceClient sClient = new ServiceReference.AffiliateServiceClient();

            try
            {
                sClient.AddItem(item);
                SetMessage("Exemplaire ajouté !");
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
                MessageBox.Show(string.Format("Une exception s'est produite à l'ajout : \n {0}", e.Message), "Erreur",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Lie les differents controles aux données et les initialise.
        /// </summary>
        private void BindAndSet()
        {
            _bsCurrentLib.DataSource = null;
            _bsCurrentLib.DataSource = _currentLibrary;
            dgvBiblioInfo.DataSource = null;
            dgvBiblioInfo.DataSource = _bsCurrentLib;
            dgvBiblioInfo.Columns[0].Visible = false;
            dgvBiblioInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            _bsDataGridView.DataSource = null;
            _bsDataGridView.DataSource = _newAuthors;
            dgvItems.DataSource = null;
            dgvItems.DataSource = _bsDataGridView;
            dgvItems.ColumnHeadersVisible = false;
            dgvItems.Columns["PersId"].Visible = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            comboBoxLibChoice.DataSource = _libraries;
            comboBoxLibChoice.DisplayMember = "Name";
            comboBoxLibChoice.ValueMember = "Id";

            listBoxAuthor.DataSource = _dBAuthors;
            listBoxAuthor.ValueMember = "PersId";
            listBoxAuthor.Visible = false;
            //listViewAuthors.

            rbAddVolume.Hide();
            rbAddItem.Hide();
            btAddAction.Hide();
            pictureBox1.ImageLocation = @"C:\Users\Murad\documents\Exam SGBD 2016-17\Images\book-cover_template.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            SetVolInfoBox(true);

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
                lblTitle.Text = string.Format("Titre : " );
                lblAuthor.Text = string.Format("Auteur(s) : " );
                lblIsbn.Text = string.Format("ISBN : " );
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
                tbFirstName.Text = string.Empty;
                tbLastName.Text = string.Empty;
                tbIsbnSearch.Text = _currentVolume.Isbn;
            }
            else
            {
                tbTitleSearch.Text = string.Empty;
                tbFirstName.Text = string.Empty;
                tbLastName.Text = string.Empty;
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
            textBoxMessage.Text = string.Format("     "+(DateTime.Now.ToString() + "  :  " + message));
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
        /// En mode "recherche", lance la recherche d'un volume d'après son ISBN
        /// lorsque l'utilisateur relache la touche enter.
        /// Vérifie chaque touches relachées.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbIsbnSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (searchMode = true && e.KeyCode == Keys.Enter && CheckInputStrg.Check(CheckInputStrg.InputType.Isbn, tbIsbnSearch.Text) == true)
            {
                GetVolumeDetailsByIsbn(tbIsbnSearch.Text);
            }
        }

        /// <summary>
        /// En mode "recherche",recherche un ouvrage d'après son titre.
        /// Eventuellement parmis une liste de plusieurs retours.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbTitleSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (searchMode = true && e.KeyCode == Keys.Enter && CheckInputStrg.Check(CheckInputStrg.InputType.Title, tbTitleSearch.Text) == true)
            {

                GetVolumeDetailsByTitle(tbTitleSearch.Text);
            }
        }

        /// <summary>
        /// Switch entre le mode recherche de volume
        /// et autoriser l'ajout de volumes ou d'exemplaires.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAddVolume_Click(object sender, EventArgs e)
        {
            if (searchMode == true)
            {
                searchMode = false;
                btAddMenu.BackColor = Color.Gray;
                labelSearch.Hide();
                btAddAction.Show();
                rbAddVolume.Show();
                rbAddItem.Enabled = false;
                rbAddItem.Show();
                btAddAuthor.Enabled = false;
                listBoxAuthor.Visible = true;

                if (_currentVolume != null)
                {
                    SetVolSrchInfos(true);
                    rbAddItem.Enabled = true;
                    rbAddItem.Select();
                    listBoxAuthor.Visible = false;
                }
                else
                {
                    rbAddVolume.Select();
                }
            }
            else
            {
                searchMode = true;
                SetVolSrchInfos(true);
                btAddMenu.BackColor = Color.LightGray;
                labelSearch.Show();
                btAddAction.Hide();
                rbAddVolume.Hide();
                rbAddItem.Hide();
                btAddAction.Enabled = true;
                btAddAuthor.Enabled = true;
                listBoxAuthor.Visible = false;
                _newAuthors.Clear();
                _bsDataGridView.ResetBindings(false);
            }
        }

        /// <summary>
        /// Prépare l'ajout d'un volume ou d'un exemplaire, selon le choix de l'utilisateur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbAddVolume_CheckedChanged(object sender, EventArgs e)
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
                            case "rbAddVolume":
                                // Mise en forme visuelle.
                                panelAddItem.BorderStyle = BorderStyle.None;
                                panelAddItem.Hide();
                                listBoxAuthor.Visible = true;
                                SetVolSrchInfos(false);

                                tbIsbnSearch.ReadOnly = false;
                                tbTitleSearch.ReadOnly = false;
                                tbFirstName.ReadOnly = false;
                                tbLastName.ReadOnly = false;
                                tbCoverPath.ReadOnly = false;

                                break;

                            case "rbAddItem":
                                // Mise en forme visuelle.
                                panelAddItem.BorderStyle = BorderStyle.FixedSingle;
                                panelAddItem.Show();
                                listBoxAuthor.Visible = false;

                                tbItemCode.ReadOnly = true;
                                tbCoverPath.ReadOnly = true;
                                dateTimePickerItem.Hide();

                                //Logique 
                                if (_currentVolume != null)
                                {
                                    SetVolSrchInfos(true);
                                    //(Ne devrait pas arriver, sécurité).
                                    //Si les infos affichéees sont celles du volume en cours, on 
                                    //locke les textboxes Volume, sinon on propose de sauver le volume actuel.
                                    if (tbIsbnSearch.Text == _currentVolume.Isbn
                                        && tbTitleSearch.Text == _currentVolume.Title)
                                    {
                                        // Lock le volume
                                        tbIsbnSearch.ReadOnly = true;
                                        tbTitleSearch.ReadOnly = true;
                                        tbFirstName.ReadOnly = true;
                                        tbLastName.ReadOnly = true;
                                        //Unlock l'item
                                        tbItemCode.ReadOnly = false;
                                        dateTimePickerItem.Show();
                                    }
                                    // Ou on propose de sauver le volume actuel.
                                    else
                                    {
                                        DialogResult dr = MessageBox.Show(" Choisisez un volume avant de créer un exemplaire !\n" +
                                                 "Voulez vous créer un volume sur base des données rentrées ?", "Warning", MessageBoxButtons.YesNo);
                                        if (dr == DialogResult.Yes)
                                        {// test et save
                                            if (
                                            CheckInputStrg.Check(CheckInputStrg.InputType.Isbn, tbIsbnSearch.Text) == true &&
                                            CheckInputStrg.Check(CheckInputStrg.InputType.Title, tbTitleSearch.Text) == true &&
                                            _newAuthors != null
                                            )
                                            {
                                                ServiceReference.Volume newVolume = new ServiceReference.Volume();
                                                newVolume.Isbn = tbIsbnSearch.Text;
                                                newVolume.Title = tbTitleSearch.Text;
                                                newVolume.Authors = _newAuthors.ToArray<ServiceReference.Author>();
                                                newVolume.Cover = tbCoverPath.Text;
                                                AddVolume(newVolume);
                                            }
                                            this.Close();
                                        }
                                        else if (dr == DialogResult.No)
                                        {
                                            this.Close();
                                            searchMode = true;
                                            _currentVolume = null;
                                            SetVolSrchInfos(true);
                                            SetVolInfoBox(true);
                                        }
                                    }
                                }
                                break;

                            default:
                                break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Créé un volume ou un item et appelle la méthode d'ajout.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAddAction_Click(object sender, EventArgs e)
        {   // Si ajout de volume.
            if (rbAddVolume.Checked == true)
            {
                // test et save
                if (
                CheckInputStrg.Check(CheckInputStrg.InputType.Isbn, tbIsbnSearch.Text) == true &&
                CheckInputStrg.Check(CheckInputStrg.InputType.Title, tbTitleSearch.Text) == true &&
                _newAuthors != null
                )
                {
                    ServiceReference.Volume newVolume = new ServiceReference.Volume();
                    newVolume.Isbn = tbIsbnSearch.Text;
                    newVolume.Title = tbTitleSearch.Text;
                    newVolume.Authors = _newAuthors.ToArray<ServiceReference.Author>();
                    newVolume.Cover = tbCoverPath.Text;
                    AddVolume(newVolume);
                    _newAuthors.Clear();
                    _bsDataGridView.ResetBindings(false);// Sinon ne mets pas l'affichage à jour.
                    GetVolumeDetailsByIsbn(newVolume.Isbn); //Pour rafraîchir et avoir l'Id.
                    SetVolInfoBox(true);
                }
            }
            // Si ajout d'exemplaire.
            // test et save
            if (
                CheckInputStrg.Check(CheckInputStrg.InputType.ItemCode, tbItemCode.Text) == true &&
                _currentVolume != null &&
                _currentLibrary != null
                )
            {
                ServiceReference.Item newItem = new ServiceReference.Item();
                newItem.Code = tbItemCode.Text;
                newItem.LibraryId = _currentLibrary.Id;
                newItem.VolumeId = (Int32)_currentVolume.Id;
                newItem.BuyDate = dateTimePickerItem.Value;
                AddItem(newItem);
                //      GetVolumeDetailsByIsbn(_currentVolume.Isbn);
            }
            else
                MessageBox.Show("Veuillez remplir les champs !", "Informations manquantes",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }


        /// <summary>
        /// Rajoute un auteur à la liste provisoire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAddAuthor_Click(object sender, EventArgs e)
        {
            if
                (
            CheckInputStrg.Check(CheckInputStrg.InputType.Name, tbFirstName.Text) == true &&
            CheckInputStrg.Check(CheckInputStrg.InputType.Name, tbLastName.Text)
                )
            {
                ServiceReference.Author newAuthor = new ServiceReference.Author();
                newAuthor.FirstName = tbFirstName.Text;
                newAuthor.LastName = tbLastName.Text;
                _newAuthors.Add(newAuthor);
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
        /// <summary>
        /// Ajoute l'auteur à la liste des auteurs du nouveau volume. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxAuthor_DoubleClick(object sender, EventArgs e)
        {
            if (!_newAuthors.Contains((ServiceReference.Author)listBoxAuthor.SelectedItem))
                _newAuthors.Add((ServiceReference.Author)listBoxAuthor.SelectedItem);
            _bsDataGridView.ResetBindings(false); // Sinon ne mets pas l'affichage à jour.
        }

        /// <summary>
        /// Supprime l'auteur de la liste des auteurs du nouveau volume.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ServiceReference.Author authorToRemove = _newAuthors.SingleOrDefault(a => a.PersId == (int)dgvItems.SelectedRows[0].Cells["PersId"].Value);
            if (authorToRemove != null)
            {
                _newAuthors.Remove(authorToRemove);
                _bsDataGridView.ResetBindings(false);// Sinon ne mets pas l'affichage à jour.
            }
        }
    }
}
