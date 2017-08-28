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
        public vAffiliate GetAffiliateById(int lectId)
        {
            vAffiliate affToReturn = new vAffiliate();
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
        public vAffiliate GetAffiliateByName(string FirstName, string lastName)
        {
            vAffiliate affToReturn = new vAffiliate();
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
        /// Retourne la liste d'emprunts actifs d'un lecteur.
        /// </summary>
        /// <param name="lectId"></param>
        /// <returns></returns>
        public List<vEmpruntDetail> GetEmpruntsByAffiliate(int lectId)
        {
            List<vEmpruntDetail> listToReturn = new List<vEmpruntDetail>();
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
        /// Retourne un emprunt par le code de l'exemplaire emprunté.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public vEmpruntDetail GetEmpruntByCode(string code)
        {
            vEmpruntDetail EmpruntToReturn = new vEmpruntDetail();
            try
            {
                DalEmprunt.GetEmpruntByCode(code, false, ref EmpruntToReturn);
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
        public List<vLibrary> GetLibraries()
        {
            List<vLibrary> listToReturn = new List<vLibrary>();
            try
            {
                DataTable temp = DalLibrary.GetAllLibraries();
                if (temp != null)
                {
                    if (temp.Rows.Count != 0)
                    {
                        foreach (DataRowView row in temp.DefaultView)
                        {
                            vLibrary library = new vLibrary();
                            library.IdLibrary = (int)row["IdLibrary"];
                            library.NameLibrary = row["NameLibrary"].ToString();
                            library.CodeIdLibrary = row["CodeIdLibrary"].ToString();
                            listToReturn.Add(library);
                        }
                    }
                }
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

        public List<Tarif> GetTarifsByLib(int LibraryId)
        {
            throw new NotImplementedException();
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
                vVolume volTemp = new vVolume();
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
     //           DalVolume.GetVolumeByIsbn(isbn, ref volumeToReturn);
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
      //          DAL.DalVolume.GetVolumeByTitle(titleLike, ref volumeToReturn);
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

        public List<Volume> GetVolumesByTitle(string titleLike)
        {
            throw new NotImplementedException();
        }


        public List<vVolume> GetAllVolumes()
        {
            List<vVolume> listToReturn = new List<vVolume>();
                try
                {
                    DalVolume.GetAllVolumes( ref listToReturn);
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

        public List<Item> GetItemsByVolume(int VolumeId)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Retourne les retards d'une librairie.
        /// la date n'est pas utilisée.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="libId"></param>
        /// <returns></returns>
        public List<vEmpruntDetail> GetRetards(DateTime date, int libId)
        {

            List<vEmpruntDetail> listToReturn = new List<vEmpruntDetail>();
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
    }
}
