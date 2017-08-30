using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Data;
using ClientLibrairie.ServiceReference;
using EL;

namespace ClientLibrairie
{
 
    
    /// <summary>
    /// Regroupe les transferts de données vers et depuis le WCF.
    /// pour plus de clarté dans les Froms.
    /// </summary>
    static internal class DAL
    {
     
        /// <summary>
        /// Retourne tous les volumes.
        /// </summary>
        /// <returns></returns>
        internal static List<Volume> GetAllVolumes()
        {
            List<Volume> _volumes = new List<Volume>();
            try
            {
                using (AffiliateServiceClient _sClient = new AffiliateServiceClient())
                {
                    _volumes = _sClient.GetAllVolumes().ToList();
                }
            }
            catch (System.ServiceModel.EndpointNotFoundException endpointEx)
            {
                int cstmErrorN = 9; // "End point not found! Vérifiez que le serveur est lancé."
                CstmError.Display(new CstmError(cstmErrorN, endpointEx));
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
                CstmError.Display(new CstmError(7, e)); //Un problème est survenu à la récupération des données !
            }
            return _volumes;
        }

        /// <summary>
        /// Retourne tous les emprunts d'un affilié.
        /// </summary>
        /// <param name="cardNum"></param>
        /// <returns></returns>
        internal static List<Emprunt> GetEmprunts(int cardNum)
        {
            List<Emprunt> _emprunts = new List<Emprunt>();
            try
            {
                using (AffiliateServiceClient _sClient = new AffiliateServiceClient())
                {
                    _emprunts = _sClient.GetEmpruntsByAffiliate(cardNum).ToList();
                }
            }
            catch (System.ServiceModel.EndpointNotFoundException endpointEx)
            {
                int cstmErrorN = 9; // "End point not found! Vérifiez que le serveur est lancé."
                CstmError.Display(new CstmError(cstmErrorN, endpointEx));
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
                CstmError.Display(new CstmError(7, e)); //Un problème est survenu à la récupération des données !
            }
            return _emprunts;
        }

        /// <summary>
        /// Retourne la liste des exemplaires d'un livre.
        /// </summary>
        /// <param name="volumeId"></param>
        internal static List<Item> GetItems( int volumeId)
        {
            List<Item> _items = new List<Item>();
            try
            {
                using (AffiliateServiceClient _sClient = new AffiliateServiceClient())
                {
                    _items = _sClient.GetItemsByVolume((int)volumeId).ToList();
                }
            }
            catch (System.ServiceModel.EndpointNotFoundException endpointEx)
            {
                int cstmErrorN = 9; // "End point not found! Vérifiez que le serveur est lancé."
                CstmError.Display(new CstmError(cstmErrorN, endpointEx));
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
                CstmError.Display(new CstmError(7,e)); //Un problème est survenu à la récupération des données !
            }
            return _items;
        }
        /// <summary>
        /// Retourne le tarif d'une bibliothèque (ne prend que le premier).
        /// </summary>
        /// <param name="idLib"></param>
        /// <returns></returns>
        internal static Tarif getTarif(int idLib)
        {
            Tarif _tarifToReturn = new Tarif();
            try
            {
                using (AffiliateServiceClient _sClient = new AffiliateServiceClient())
                {
                    _tarifToReturn = _sClient.GetTarifsByLib(idLib)[0];
                }
            }
            catch (System.ServiceModel.EndpointNotFoundException endpointEx)
            {
                int cstmErrorN = 9; // "End point not found! Vérifiez que le serveur est lancé."
                CstmError.Display(new CstmError(cstmErrorN, endpointEx));
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
                CstmError.Display(new CstmError(7, e)); //Un problème est survenu à la récupération des données !
            }
            return _tarifToReturn;
        }

        //PAS BON, VERSION ADMIN (par bibliothèque)
        /// <summary>
        /// Récupère les retards.
        /// (par bibliothèque)
        /// </summary>
        /// <param name="libId"></param>
        /// <param name="referenceDate"></param>
        /// <returns></returns>
        internal static List<Emprunt> GetRetards(int libId, DateTime referenceDate = default(DateTime) )
        {
            List<Emprunt> _Retards = new List<Emprunt>();
            try
            {
                using (AffiliateServiceClient _sClient = new AffiliateServiceClient())
                {
                    _Retards = _sClient.GetRetards(referenceDate, libId).ToList();
                }
            }
            catch (System.ServiceModel.EndpointNotFoundException endpointEx)
            {
                int cstmErrorN = 9; // "End point not found! Vérifiez que le serveur est lancé."
                CstmError.Display(new CstmError(cstmErrorN, endpointEx));
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
                CstmError.Display(new CstmError(7, e)); //Un problème est survenu à la récupération des données !
            }
            return _Retards;
        }

        /// <summary>
        /// Crée un emprunt.
        /// (date début crée dans db).
        /// </summary>
        /// <param name="cardNum"></param>
        /// <param name="item_Id"></param>
        /// <param name="tarif_Id"></param>
        internal static void StartEmprunt(int cardNum, int item_Id, int tarif_Id)
        {
            try
            {
                using (AffiliateServiceClient _sClient = new AffiliateServiceClient())
                {
                    _sClient.StartEmprunt( cardNum,  item_Id,  tarif_Id);
                }
            }
            catch (System.ServiceModel.EndpointNotFoundException endpointEx)
            {
                int cstmErrorN = 9; // "End point not found! Vérifiez que le serveur est lancé."
                CstmError.Display(new CstmError(cstmErrorN, endpointEx));
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
                CstmError.Display(new CstmError(12, e)); // "erreur à l'ajout..."
            }
        }

        /// <summary>
        /// Ajout d'une "réservation".
        /// </summary>
        /// <param name="cardNum"></param>
        /// <param name="volume_Id"></param>
        internal static void AddToWishList(int cardNum,int volume_Id)
        {
            try
            {
                using (AffiliateServiceClient _sClient = new AffiliateServiceClient())
                {
                    _sClient.AddWishListItem(cardNum, volume_Id);
                }
            }
            catch (System.ServiceModel.EndpointNotFoundException endpointEx)
            {
                int cstmErrorN = 9; // "End point not found! Vérifiez que le serveur est lancé."
                CstmError.Display(new CstmError(cstmErrorN, endpointEx));
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
                CstmError.Display(new CstmError(12, e)); // "erreur à l'ajout..."
            }
        }
    }


    /// <summary>
    /// Classe étendant le BO "Emprunt" pour plus de facilité.
    /// </summary>
    public class EmpruntXtd : Emprunt
    {
        public EmpruntXtd() { }
        public EmpruntXtd(ServiceReference.Emprunt empruntToConvert)
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

}
