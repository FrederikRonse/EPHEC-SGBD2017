using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace EL
{
    public class CstmError : ApplicationException
    {
        private int _errNum;
        private Exception _e;

        // Constructeur recevant le numéro d'erreur à déclancher
        // et une éventuelle exception remontée (pour relancer une exception sql non traitée,...).
        public CstmError(int numErr, Exception e = null)
        {
            _errNum = numErr;
            _e = e;
        }

        public new Exception InnerException
        {
            get
            {
                return _e;
            }
        }
        /// <summary>
        /// Renvoie le numéro d'erreur.
        /// </summary>
        /// <returns>numéro d'erreur</returns>
        public int GetNum
        {
            get
            {
                return _errNum;
            }
        }
        public string GetLog
        {
            private set
            {

            }
            get
            {
                string returnStr = "";
                if (_e.Data.Contains("Log"))
                {
                    returnStr = string.Format("\n Log : \n{0}", _e.Data["Log"].ToString());
                }
                return returnStr;
            }
        }
        /// <summary>
        /// Renvoie le message d'erreur en fonction du numéro entré en paramètre du constructeur.
        /// </summary>
        /// <returns>message d'erreur</returns>
        public string GetMsg
        {
            get
            {
                string sMessage;
                switch (_errNum)
                {
                    case 0:
                        sMessage = String.Format("Exception sans traitement particulier ! \n {0} \n {1}", _e.Message, _e.TargetSite);
                        break;
                    case 1:
                        sMessage = "Mauvaise base de données !";
                        break;
                    case 2:
                        sMessage = "Mauvais mot de passe !";
                        break;
                    case 3:
                        sMessage = "nbre de lignes affectées lors de l'opération sql erronné !";
                        break;
                    case 4:
                        sMessage = "pas de ConnectionString disponible !";
                        break;
                    case 5:
                        sMessage = "Erreur SQL : violation d'unicité d'index !";
                        break;
                    case 6:
                        sMessage = "Erreur SQL non traitée !";
                        if (_e != null) throw _e;
                        break;
                    case 7:
                        sMessage = "Problème à la récupération des données par la DAL !";
                        break;
                    case 8:
                        sMessage = "Une erreur est survenue dans la business layer !";
                        break;
                    case 9:
                        sMessage = " End point not found! Vérifiez que le serveur est lancé.";
                        break;
                    case 10:
                        sMessage = " Problème à la récupération des données !";
                        break;
                    case 11:
                        sMessage = " Aucun résultat ne correspond à cette recherche !";
                        break;
                    case 12:
                        sMessage = " !";
                        break;
                    case 13:
                        sMessage = " !";
                        break;
                    case 14:
                        sMessage = " !";
                        break;
                    case 15:
                        sMessage = " !";
                        break;
                    case 16:
                        sMessage = " !";
                        break;
                    case 17:
                        sMessage = " !";
                        break;
                    case 18:
                        sMessage = " !";
                        break;

                    default:
                        sMessage = String.Format("Pas de message d'erreur adapté ! \n {0} \n {1}", _e.Message, _e.TargetSite);
                        break;
                }
                return sMessage;
            }
        }
        /// <summary>
        /// Centralise la création des fenêtres de dialogue suite à la levée d'une exception dans le programme.
        /// </summary>
        /// <param name="e"></param>
        public static void Display(CstmError e)
        {
            string message = e.GetMsg;
            if (e.Data.Contains("Log"))
            {
                string log = string.Format("\n Log : \n{0}", e.Data["Log"].ToString());
                message += log;
            }
            MessageBox.Show(message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        /// <summary>
        /// Affiche un message et un titre(pour customfault).
        /// </summary>
        /// <param name="faultMessage"></param>
        /// <param name="header"></param>
        public static void Display( string faultMessage, string header="Attention !")
        {
            MessageBox.Show(faultMessage, header, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}

