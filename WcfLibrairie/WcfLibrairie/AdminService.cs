using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessObjects;
using System.Data;
using EL;
using System.Threading.Tasks;
using System.Transactions;
using WcfBLAffiliate;

namespace WcfLibrairie
{
    public class AdminService : IadminService
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
                userChecked = DAL.UtilsDAL.Check(login, password);
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
            //catch (Exception ex)
            //{
            //    if (ex.GetType() != typeof(CstmError))
            //    {
            //        int DefaultError = 8; //"Une erreur est survenue au niveau du serveur !".
            //        throw new CstmError(DefaultError, ex);
            //    }
            //    else
            //    {// si c'est une custom error, on remonte juste.
            //        throw ex;
            //    }
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
                DAL.DalAffiliate.GetAffiliateById(lectId, ref affToReturn);
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
                DAL.DalAffiliate.GetAffiliateByName(FirstName, lastName, ref affToReturn);
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
        public List<Emprunt> GetEmpruntsByAffiliate(int lectId)
        {
            List<Emprunt> listToReturn = new List<Emprunt>();
            try
            {
                DAL.DalEmprunt.GetEmpruntsByCardNum(lectId, false, ref listToReturn);
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
        public Emprunt GetEmpruntByCode(string code)
        {
            Emprunt EmpruntToReturn = new Emprunt();
            try
            {
                DAL.DalEmprunt.GetEmpruntByCode(code, false, ref EmpruntToReturn);
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

        public List<Item> GetItemsByVolume(int VolumeId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Reourne la liste de toutes les librairies.
        /// </summary>
        /// <returns></returns>
        public List<Library> GetLibraries()
        {
            List<Library> listToReturn = new List<Library>();
            try
            {
                DataTable temp = DAL.DalLibrary.GetAllLibraries();
                if (temp != null)
                {
                    if (temp.Rows.Count != 0)
                    {
                        foreach (DataRowView row in temp.DefaultView)
                        {
                            Library library = new Library();
                            library.Id = (int)row["IdLibrary"];
                            library.Name = row["NameLibrary"].ToString();
                            library.Code = row["CodeIdLibrary"].ToString();
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

        /// <summary>
        /// Retourne les retards d'une librairie.
        /// la date n'est pas utilisée.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="libId"></param>
        /// <returns></returns>
        public List<Emprunt> GetRetards(DateTime date, int libId)
        {

            List<Emprunt> listToReturn = new List<Emprunt>();
            try
            {
                DAL.DalEmprunt.GetRetardsByLib(libId, ref listToReturn);
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
                Volume volTemp = new Volume();
                DAL.DalVolume.GetVolumeById(volumeId, ref volTemp);
                VolToReturn = volTemp;
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
                DAL.DalVolume.GetVolumeByIsbn(isbn, ref volumeToReturn);
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
                DAL.DalVolume.GetVolumeByTitle(titleLike, ref volumeToReturn);
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

        /// <summary>
        /// Retourne tous les auteurs (pour choix dans GUI).
        /// </summary>
        /// <returns></returns>
        public List<Author> GetAllAuthorsNames()
        {
            List<Author> listToReturn = new List<Author>();
            try
            {
                DataTable dataTable = new DataTable();
                DAL.DalAuthor.GetAllAuthorsNames(ref dataTable);

                if (dataTable.Rows.Count != 0)
                {
                    foreach (DataRowView row in dataTable.DefaultView)
                    {
                        Author author = new Author();
                        author.PersId = (int)row["Id"];
                        author.FirstName = row["FirstName"].ToString();
                        author.LastName = row["LastName"].ToString();
                        listToReturn.Add(author);
                    }
                }
                return listToReturn;
            }
            catch (CstmError ex)
            {
                throw new FaultException<CustomFault>(new CustomFault(" Un problème est survenu à la récupération des données !"), new FaultReason(ex.GetMsg));
            }
            catch (Exception ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Une erreur est survenue au niveau du serveur !"));
            }
        }

        /// <summary>
        /// Crée dans un premier temps un volume puis y associe le(s) auteur(s).
        /// </summary>
        /// <param name="volumeToAdd"></param>
        public void AddVolume(Volume volumeToAdd)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())

                {
                    DAL.DalVolume.InsertVolume(volumeToAdd);
                    DAL.DalVolume.LinkAuthorsToVol(volumeToAdd);
                    scope.Complete();
                }
            }
            catch (TransactionAbortedException ex)
            {
                throw new FaultException<CustomFault>(new CustomFault(" Un problème est survenu à l'ajout !"), new FaultReason("Transaction avortée!"));
            }
            catch (CstmError ex)
            {
                throw new FaultException<CustomFault>(new CustomFault(ex.GetMsg), new FaultReason(ex.GetMsg));
            }
            catch (Exception ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Une erreur est survenue au niveau du serveur !"));
            }
        }

        public void UpdateVolume(Volume volumeToUpdate)
        {
            throw new NotImplementedException();
        }
        public void DeleteVolume(Volume volumeToDelete)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Rajoute un exemplaire.
        /// </summary>
        /// <param name="itemToAdd"></param>
        public void AddItem(Item itemToAdd)
        {
            try
            {
                DAL.DalItem.InsertItem(itemToAdd);
            }
            catch (CstmError ex)
            {
                throw new FaultException<CustomFault>(new CustomFault(" Un problème est survenu à l'insertion des données !"), new FaultReason(ex.GetMsg));
            }
            catch (Exception ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Une erreur est survenue au niveau du serveur !"));
            }
        }
        public void UpdateItem(Item itemToUpdate)
        {
            throw new NotImplementedException();
        }
        public void DeleteItem(Item itemToDelete)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Clôture un emprunt.
        /// </summary>
        /// <param name="EmruntToClose"></param>
        public void CloseEmprunt(int EmpruntToCloseID, DateTime LastModified)
        {
            try
            {
                DAL.DalEmprunt.CloseEmprunt(EmpruntToCloseID, LastModified);
            }
            catch (CstmError ex)
            {
                throw new FaultException<CustomFault>(new CustomFault(" Un problème est survenu à la modification des données !"), new FaultReason(ex.GetMsg));
            }
            catch (Exception ex)
            {
                throw new FaultException<CustomFault>(new CustomFault("Une erreur est survenue au niveau du serveur !"));
            }
        }
    }
}

//public CompositeType GetDataUsingDataContract(CompositeType composite)
//{
//    if (composite == null)
//    {
//        throw new ArgumentNullException("composite");
//    }
//    if (composite.BoolValue)
//    {
//        composite.StringValue += "Suffix";
//    }
//    return composite;
//}