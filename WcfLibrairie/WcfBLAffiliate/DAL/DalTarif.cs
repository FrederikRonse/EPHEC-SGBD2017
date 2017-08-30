using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BusinessObjects;

namespace WcfBLAffiliate
{
    public static class DalTarif
    {
 
        /// <summary>
        /// retourne les tarifs d'une librairie.
        /// </summary>
        /// <param name="libId"></param>
        /// <param name="listToReturn"></param>
        public static void GetTarifByLib(int libId, ref List<Tarif> listToReturn)
        {
            StringBuilder sLog = new StringBuilder();

            listToReturn.Clear();
            using (ExamSGBD2017Entities dbEntity = new ExamSGBD2017Entities())
            {
                try
                {
                    foreach (GetTarifByLibId_Result _vTarif in dbEntity.GetTarifByLibId(libId)) 
                    {
                        Tarif _tarif = new Tarif();

                        _tarif.Id = _vTarif.Id;
                        _tarif.DailyPenalty = _vTarif.DailyPenalty;
                        _tarif.Duration = _vTarif.Duration;
                        _tarif.Fee = _vTarif.Fee;
                        _tarif.LibraryId = _vTarif.Library_Id;
                        _tarif.Name = _vTarif.Name;
                        _tarif.Year = _vTarif.Year;

                        listToReturn.Add((_tarif));
                    }
                }
                catch (Exception ex)
                {
                    int DefaultError = 7; //"Problème à la récupération des données !"
                    throw new EL.CstmError(DefaultError, ex);
                }
            }
        }

    }
}


