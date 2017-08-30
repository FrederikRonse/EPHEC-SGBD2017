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
    public partial class MainForm : Form
    {
        internal List<ServiceReference.Library> _libraries;
        internal ServiceReference.Affiliate _CurrentAffiliate;
        ///Pour test
        int userid = 1;
        public MainForm()
        {
            InitializeComponent();
            SetAllLibraries();
            GetCurrentUser(userid);  //pour tests
        }
        /// <summary>
        /// Charge toutes les librairies pour le choix de la librairie active.
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
        private void bibliothèquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBiblio formBiblio = new FormBiblio(this);
            formBiblio.MdiParent = this;
            formBiblio.Show();
        }

        /// <summary>
        /// Retourne le lecteur connecté par son id (N° de carte).
        /// </summary>
        /// <param name="cardNum"></param>
        private void GetCurrentUser(int cardNum)
        {
            ServiceReference.AffiliateServiceClient sClient = new ServiceReference.AffiliateServiceClient();
            try
            {
                ServiceReference.Affiliate user = sClient.GetAffiliateById(cardNum);
                if (user != null)
                {
                    _CurrentAffiliate = user;
                }
                else
                {
                    MessageBox.Show(string.Format("le numéro de lecteur {0}\n n'a rien retourné !", cardNum), "Désolé",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (user.FirstName != null) this.Text = string.Format("Bienvenue {0} !", user.FirstName);
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

        private void lecteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLect formlecteur = new FormLect();
            formlecteur.MdiParent = this;
            formlecteur.Show();
          }

        private void retardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRetards formRetards = new FormRetards(_libraries);
            formRetards.MdiParent = this;
            formRetards.Show();
        }
    }
    //Code prof pour google api
    //private void button1_Click(object sender, EventArgs e)
    //{
    //    string requestUrl = "https://www.googleapis.com/books/v1/volumes?q=isbn:9786054263820";

    //    HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
    //    request.Accept = "application/json";

    //    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
    //    {
    //        if (response.StatusCode != HttpStatusCode.OK)
    //            throw new Exception(String.Format(
    //            "Server error (HTTP {0}: {1}).",
    //            response.StatusCode,
    //            response.StatusDescription));
    //        else
    //        {
    //            using (Stream stream = response.GetResponseStream())
    //            {
    //                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
    //                string responseString = reader.ReadToEnd();

    //                Volumes oBooks = Newtonsoft.Json.JsonConvert.DeserializeObject<Volumes>(responseString);

    //                Volume oBook = oBooks.Items[0];

    //                Volume.VolumeInfoData oData = oBook.VolumeInfo;

    //                Console.WriteLine(oData.Title);
    //                Console.WriteLine(oData.Publisher);
    //                Console.WriteLine(oData.PublishedDate);
    //                foreach (string oAuthot in oData.Authors)
    //                {
    //                    Console.WriteLine(oAuthot);
    //                }
    //                Console.WriteLine("---------------");
    //            }

    //        }

    //    }
    //}


}
