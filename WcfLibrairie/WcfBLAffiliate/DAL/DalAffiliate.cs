using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BusinessObjects;

namespace WcfBLAffiliate
{
    public static class DalAffiliate


    {/// <summary>
     /// Récupère un lecteur d'après son Id.
     /// </summary>
     /// <param name="affiliateId"></param>
     /// <param name="AffToFill"></param>
        public static void GetAffiliateById(int affiliateId, ref Affiliate AffToFill)
        {
            StringBuilder sLog = new StringBuilder();

            using (ExamSGBD2017Entities dbEntity = new ExamSGBD2017Entities())
            {
                try
                {
                    Affiliate convertedAff = new Affiliate();
                    var vAff = dbEntity.GetAffiliateByCardNum(affiliateId).FirstOrDefault();

                    convertedAff.CardNum = vAff.CardNum;
                    convertedAff.CardValidity = vAff.Validity;
                    convertedAff.MainLibraryId = vAff.MainLibrary_Id;
                    convertedAff.LastName = vAff.LastName;
                    convertedAff.FirstName = vAff.FirstName;
                    convertedAff.BirthDate = vAff.BirthDate;

                    AffToFill = convertedAff;
                }
                catch (Exception ex)
                {
                    int DefaultError = 7; //"Problème à la récupération des données !"
                    throw new EL.CstmError(DefaultError, ex);
                }
            }
        }

        /// <summary>
        /// Récupère un lecteur par ses prénoms et noms.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="AffToFill"></param>
        public static void GetAffiliateByName(string firstName, string lastName, ref Affiliate AffToFill)
        {
            StringBuilder sLog = new StringBuilder();

            using (ExamSGBD2017Entities dbEntity = new ExamSGBD2017Entities())
            {
                try
                {
                    Affiliate convertedAff = new Affiliate();
                    var vAff = dbEntity.GetAffiliateByName(firstName, lastName).FirstOrDefault();

                    convertedAff.CardNum = vAff.CardNum;
                    convertedAff.CardValidity = vAff.Validity;
                    convertedAff.MainLibraryId = vAff.MainLibrary_Id;
                    convertedAff.LastName = vAff.LastName;
                    convertedAff.FirstName = vAff.FirstName;
                    convertedAff.BirthDate = vAff.BirthDate;

                    AffToFill = convertedAff;
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
