using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessObjects;
using EL;
using System.Threading.Tasks;
using System.Data;
//using System.Transactions;

namespace WcfBLAffiliate
{
    public class AffiliateService : IAffiliateService
    {


      

        /// <summary>
        /// Relicat du système d'identification.
        /// Utilisé pour établir la connection avec la BD.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool CheckIn(string login, string password)
        {
            bool userChecked = false;
            try
            {
                userChecked = UtilsDAL.Check(login, password);
                return userChecked;
            }
            catch (CstmError ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Un problème est survenu à l'authentification !"), new FaultReason(ex.GetMsg));
            }
            catch (Exception ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Une erreur est survenue au niveau du serveur !"));
            }
        }

        #region Opérations "Get"

        /// <summary>
        /// Renvoie la liste de toutes les librairies.
        /// </summary>
        /// <returns></returns>
        public List<Library> GetLibraries()
        {
            List<Library> listToReturn = new List<Library>();
            try
            {
                List<Library> newList = new List<Library>();
                DalLibrary.GetAllLibraries(ref newList);
                //if (listToReturn != null)
                //{
                //    if (listToReturn.Count != 0)
                //    {
                return listToReturn;
            }
            catch (CstmError ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Un problème est survenu à la récupération des données !"), new FaultReason(ex.GetMsg));
            }
            catch (Exception ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Une erreur est survenue au niveau du serveur !"));
            }
        }


        /// <summary>
        /// Retourne un lecteur par son Id.
        /// </summary>
        /// <param name="lectId"></param>
        /// <returns></returns>
        public Affiliate GetAffiliateById(int lectId)
        {
            Affiliate affToReturn = new Affiliate();
            try
            {
                DalAffiliate.GetAffiliateById(lectId, ref affToReturn);
                return affToReturn;
            }
            catch (CstmError ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Un problème est survenu à la récupération des données !"), new FaultReason(ex.GetMsg));
            }
            catch (Exception ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Une erreur est survenue au niveau du serveur !"));
            }
        }

        /// <summary>
        /// Retourne un lecteur par ses prénom et nom.
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public Affiliate GetAffiliateByName(string FirstName, string lastName)
        {
            Affiliate affToReturn = new Affiliate();
            try
            {
                DalAffiliate.GetAffiliateByName(FirstName, lastName, ref affToReturn);
                return affToReturn;
            }
            catch (CstmError ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Un problème est survenu à la récupération des données !"), new FaultReason(ex.GetMsg));
            }
            catch (Exception ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Une erreur est survenue au niveau du serveur !"));
            }
        }


        /// <summary>
        /// Retourne les livres souhaités (wishlist) du lecteur.
        /// </summary>
        /// <param name="cardNum"></param>
        /// <returns></returns>
        public List<WishListItem> GetWishListByCardNum(int cardNum)
        {
            List<WishListItem> listToReturn = new List<WishListItem>();
            try
            {
                DalWishList.GetWishListByCardNum(cardNum, ref listToReturn);
                return listToReturn;
            }
            catch (CstmError ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Un problème est survenu à la récupération des données !"), new FaultReason(ex.GetMsg));
            }
            catch (Exception ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Une erreur est survenue au niveau du serveur !"));
            }
        }


        /// <summary>
        /// Retourne la liste d'emprunts actifs d'un lecteur.
        /// </summary>
        /// <param name="lectId"></param>
        /// <returns></returns>
        public List<Emprunt> GetEmpruntsByAffiliate(int lectId)
        {
            List<Emprunt> listToReturn = new List<Emprunt>();
            try
            {
                DalEmprunt.GetEmpruntsByCardNum(lectId, false, ref listToReturn);
                return listToReturn;
            }
            catch (CstmError ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Un problème est survenu à la récupération des données !"), new FaultReason(ex.GetMsg));
            }
            catch (Exception ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Une erreur est survenue au niveau du serveur !"));
            }
        }

        /// <summary>
        /// Retourne les retards d'une librairie.
        /// la date n'est pas utilisée.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="libId"></param>
        /// <returns></returns>
        public List<Emprunt> GetRetards(DateTime date, int libId) //List<vEmpruntDetail>
        {
            List<Emprunt> listToReturn = new List<Emprunt>();
            try
            {
                DalEmprunt.GetRetardsByLib(libId, ref listToReturn);
                return listToReturn;
            }
            catch (CstmError ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Un problème est survenu à la récupération des données !"), new FaultReason(ex.GetMsg));
            }
            catch (Exception ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Une erreur est survenue au niveau du serveur !"));
            }
        }

        /// <summary>
        /// Retourne un emprunt par le code de l'exemplaire emprunté. [PAS UTILISE]
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public Emprunt GetEmpruntByCode(string code)
        {
            Emprunt EmpruntToReturn = new Emprunt();
            try
            {
                //       DalEmprunt.GetEmpruntByCode(code, false, ref EmpruntToReturn);
                return EmpruntToReturn;
            }
            catch (CstmError ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Un problème est survenu à la récupération des données !"), new FaultReason(ex.GetMsg));
            }
            catch (Exception ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Une erreur est survenue au niveau du serveur !"));
            }
        }


        /// <summary>
        /// Renvoie la liste de tous les livres.
        /// </summary>
        /// <returns></returns>
        public List<Volume> GetAllVolumes()
        {
            List<Volume> listToReturn = new List<Volume>();
            try
            {
                DalVolume.GetAllVolumes(ref listToReturn);
                return listToReturn;
            }
            catch (CstmError ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Un problème est survenu à la récupération des données !"), new FaultReason(ex.GetMsg));
            }
            catch (Exception ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Une erreur est survenue au niveau du serveur !"));
            }
        }

        /// <summary>
        /// Retourne un volume par son ID.
        /// </summary>
        /// <param name="volumeId"></param>
        /// <returns></returns>
        public Volume GetVolumeDetails(int volumeId)
        {

            Volume VolToReturn = null;
            try
            {
                Volume volTemp = new Volume();
                DalVolume.GetVolumeById(volumeId, ref volTemp);
                //VolToReturn.Authors = vol
                //VolToReturn = volTemp;
                return VolToReturn;
            }
            catch (CstmError ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Un problème est survenu à la récupération des données !"), new FaultReason(ex.GetMsg));
            }
            catch (Exception ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Une erreur est survenue au niveau du serveur !"));
            }
        }
        /// <summary>
        /// Retourne un volume d'après son ISBN.
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns></returns>
        public Volume GetVolumeDetailsByIsbn(string isbn)
        {
            Volume volumeToReturn = new Volume();
            try
            {
                DalVolume.GetVolumeByIsbn(isbn, ref volumeToReturn);
                return volumeToReturn;
            }
            catch (CstmError ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Un problème est survenu à la récupération des données !"), new FaultReason(ex.GetMsg));
            }
            catch (Exception ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Une erreur est survenue au niveau du serveur !"));
            }
        }
        /// <summary>
        /// Retourne le premier volume dont le titre s'approche
        /// du string de recherche.
        /// </summary>
        /// <param name="titleLike"></param>
        /// <returns></returns>
        public Volume GetVolumeByTitle(string titleLike)
        {
            Volume volumeToReturn = new Volume();
            try
            {
                DalVolume.GetVolumeByTitle(titleLike, ref volumeToReturn);
                return volumeToReturn;
            }
            catch (CstmError ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Un problème est survenu à la récupération des données !"), new FaultReason(ex.GetMsg));
            }
            catch (Exception ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Une erreur est survenue au niveau du serveur !"));
            }
        }

        #endregion Opérations "Get"

        #region Opérations "Set"

        public void AddWishListItem(int cardNum, int volumeId)
        {
            try
            {
                DalWishList.AddWishListItem(cardNum, volumeId);
            }
            catch (CstmError ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Un problème est survenu à l'ajout du volume souhaité !"), new FaultReason(ex.GetMsg));
            }
            catch (Exception ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Une erreur est survenue au niveau du serveur !"));
            }
        }

        public void DeleteWishListItem(int wishId)
        {
            try
            {
                DalWishList.DeleteWishListItem(wishId);
            }
            catch (CstmError ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Un problème est survenu à la suppression des données !"), new FaultReason(ex.GetMsg));
            }
            catch (Exception ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Une erreur est survenue au niveau du serveur !"));
            }
        }

        /// <summary>
        /// Insère un nouvel emprunt.
        /// La date de départ est crée dans la base de données.
        /// </summary>
        /// <param name="CardNum"></param>
        /// <param name="Item_Id"></param>
        /// <param name="Tarif_Id"></param>
        public void StartEmprunt(int cardNum,int item_Id,int tarif_Id)
        {
            try
            {
                DalEmprunt.InsertEmprunt(cardNum,  item_Id,  tarif_Id);
            }
            catch (CstmError ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Un problème est survenu à l'enregistrement de l'emprunt !"), new FaultReason(ex.GetMsg));
            }
            catch (Exception ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Une erreur est survenue au niveau du serveur !"));
            }
        }

        #endregion Opérations "Set"


        #region A Supprimer?

        // A SUPPRIMER?
        public List<Volume> GetVolumesByTitle(string titleLike)
        {
            throw new NotImplementedException();
        }

        // A SUPPRIMER?
        public List<Tarif> GetTarifsByLib(int LibraryId)
        {
            throw new NotImplementedException();
        }
        // A SUPPRIMER ?
        public List<Item> GetItemsByVolume(int VolumeId)
        {
            throw new NotImplementedException();
        }

        #endregion A Supprimer?
    }
}
