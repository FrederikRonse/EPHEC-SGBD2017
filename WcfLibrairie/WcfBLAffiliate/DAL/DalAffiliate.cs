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
        public static void GetAffiliateById(int affiliateId, ref vAffiliate AffToFill)
        {
            throw new NotImplementedException();
            //using (SqlConnection connection = UtilsDAL.GetConnection())
            //{
            //    StringBuilder sLog = new StringBuilder();
            //    try
            //    {
            //        using (SqlCommand command = new SqlCommand("SchAdmin.GetAffiliateByCardNum", connection))
            //        {
            //            Affiliate affTemp = new Affiliate();
            //            SqlParameter param1 = new SqlParameter("@number", affiliateId);
            //            command.CommandType = CommandType.StoredProcedure;
            //            command.Parameters.Add(param1);
            //            sLog.Append("Open");
            //            connection.Open();
            //            SqlDataReader dtReader = command.ExecuteReader();
            //            sLog.Append("Read");
            //            while (dtReader.Read())
            //            {
            //                affTemp.CardNum = dtReader.GetInt32(0);
            //                if (!dtReader.IsDBNull(1)) affTemp.CardValidity = dtReader.GetDateTime(1);   
            //               // else affTemp.CardValidity = default(DateTime); 
            //                affTemp.MainLibraryId = dtReader.GetInt32(2);
            //                affTemp.FirstName = dtReader.GetString(3);
            //                affTemp.LastName = dtReader.GetString(4);
            //                if (!dtReader.IsDBNull(5)) affTemp.BirthDate = dtReader.GetDateTime(5);
            //            }
            //            AffToFill = affTemp;
            //        }
            //    }
            //    catch (SqlException sqlEx)
            //    {
            //        sqlEx.Data.Add("Log", sLog);
            //        int DefaultSqlError = 6; //"Erreur SQL non traitée !" L'exception sera relancée.
            //        switch (sqlEx.Number)
            //        {
            //            case 4060:
            //                throw new EL.CstmError(1, sqlEx); //"Mauvaise base de données"
            //            case 18456:
            //                throw new EL.CstmError(2, sqlEx); //"Mauvais mot de passe"
            //            default:
            //                throw new EL.CstmError(DefaultSqlError, sqlEx); //"Erreur SQL non traitée !" L'exception sera relancée.
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        int DefaultError = 7; //"Problème à la récupération des données !"
            //        throw new EL.CstmError(DefaultError, ex);
            //    }
            //}
        }
        /// <summary>
        /// Récupère un lecteur par ses prénoms et noms.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="AffToFill"></param>
        public static void GetAffiliateByName(string firstName, string lastName, ref vAffiliate AffToFill)
        {
            throw new NotImplementedException();
            //using (SqlConnection connection = UtilsDAL.GetConnection())
            //{
            //    StringBuilder sLog = new StringBuilder();
            //    try
            //    {
            //        using (SqlCommand command = new SqlCommand("SchAdmin.GetAffiliateByName", connection))
            //        {
            //            Affiliate affTemp = new Affiliate();
            //            SqlParameter param1 = new SqlParameter("@firstName", firstName);
            //            SqlParameter param2 = new SqlParameter("@lastName", lastName);
            //            command.CommandType = CommandType.StoredProcedure;
            //            command.Parameters.Add(param1);
            //            command.Parameters.Add(param2);
            //            sLog.Append("Open");
            //            connection.Open();
            //            SqlDataReader dtReader = command.ExecuteReader();
            //            sLog.Append("Read");
            //            while (dtReader.Read())
            //            {
            //                affTemp.CardNum = dtReader.GetInt32(0);
            //                if (!dtReader.IsDBNull(1)) affTemp.CardValidity = dtReader.GetDateTime(1);
            //                // else affTemp.CardValidity = default(DateTime); 
            //                affTemp.MainLibraryId = dtReader.GetInt32(2);
            //                affTemp.FirstName = dtReader.GetString(3);
            //                affTemp.LastName = dtReader.GetString(4);
            //                if (!dtReader.IsDBNull(5)) affTemp.BirthDate = dtReader.GetDateTime(5);
            //            }
            //            AffToFill = affTemp;
            //        }
            //    }
            //    catch (SqlException sqlEx)
            //    {
            //        sqlEx.Data.Add("Log", sLog);
            //        int DefaultSqlError = 6; //"Erreur SQL non traitée !" L'exception sera relancée.
            //        switch (sqlEx.Number)
            //        {
            //            case 4060:
            //                throw new EL.CstmError(1, sqlEx); //"Mauvaise base de données"
            //            case 18456:
            //                throw new EL.CstmError(2, sqlEx); //"Mauvais mot de passe"
            //            default:
            //                throw new EL.CstmError(DefaultSqlError, sqlEx); //"Erreur SQL non traitée !" L'exception sera relancée.
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        int DefaultError = 7; //"Problème à la récupération des données!"
            //        throw new EL.CstmError(DefaultError, ex);
            //    }
            //}
        }
    }
}
