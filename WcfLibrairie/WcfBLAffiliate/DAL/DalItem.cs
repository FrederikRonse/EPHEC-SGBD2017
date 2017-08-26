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
    public static class DalItem
    {
        public static void InsertItem(Item itemToInsert)
        {
            using (SqlConnection connection = UtilsDAL.GetConnection())
            {
                StringBuilder sLog = new StringBuilder();

                SqlParameter param1 = new SqlParameter("@Code", itemToInsert.Code);
                SqlParameter param2 = new SqlParameter("@LibraryId", itemToInsert.LibraryId);
                SqlParameter param3 = new SqlParameter("@VolumeId", itemToInsert.VolumeId);
                SqlParameter param4 = new SqlParameter("@BuyDate", itemToInsert.BuyDate);
                SqlParameter param5;
                if (itemToInsert.Localisation == null)
                {       param5 = new SqlParameter("@Localisation", itemToInsert.LibraryId.ToString()); }
                else    param5 = new SqlParameter("@Localisation", itemToInsert.Localisation);
                SqlParameter[] parameters = { param1, param2, param3, param4, param5};
                try
                {
                    using (SqlCommand command = new SqlCommand("SchAdmin.InsertItem", connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddRange(parameters);
                        sLog.Append("Open");
                        connection.Open();
                        sLog.Append("ExecuteNonQuery");
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 1) throw new EL.CstmError(3);  // nbre de lignes affectées erroné
                    }
                }
                catch (SqlException sqlEx)
                {
                    sqlEx.Data.Add("Log", sLog);
                    int DefaultSqlError = 6; //"Erreur SQL non traitée !" L'exception sera relancée.
                    switch (sqlEx.Number)
                    {
                        case 2601:
                            goto case 2627;
                        case 2627:
                            throw new EL.CstmError(5, sqlEx);   //Cet enregistrement existe déjà ! violation d'unicité d'index.
                        case 4060:
                            throw new EL.CstmError(1, sqlEx); //"Mauvaise base de données"
                        case 18456:
                            throw new EL.CstmError(2, sqlEx); //"Mauvais mot de passe"
                        default:
                            throw new EL.CstmError(DefaultSqlError, sqlEx); //"Erreur SQL non traitée !" L'exception sera relancée.
                    }
                }
                catch (Exception ex)
                {
                    int DefaultError = 12; //" Un problème est survenu à l'ajout du volume ou de son / ses auteur(s) !".
                    throw new EL.CstmError(DefaultError, ex);
                }
            }
        }
    }
}
