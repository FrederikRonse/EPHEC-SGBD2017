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
        /// Retourne 
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
}
