using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BusinessObjects;

namespace DAL
{
    public static class DalAuthor
    {
        public static void GetAllAuthorsNames(ref DataTable tableToFill)
        {
            SqlDataAdapter datadapt = new SqlDataAdapter();

            using (SqlConnection connection = UtilsDAL.GetConnection())
            {
                StringBuilder sLog = new StringBuilder();
                try
                {
                    using (SqlCommand command = new SqlCommand("[SchAdmin].[GetAllAuthors]", connection))
                    {
                        DataTable dataTemp = new DataTable();
                        command.CommandType = CommandType.StoredProcedure;
                        sLog.Append("Open");
                        connection.Open();
                        datadapt.SelectCommand = command;
                        sLog.Append("Fill");
                        datadapt.Fill(dataTemp);
                        tableToFill = dataTemp;
                    }
                }
                catch (SqlException sqlEx)
                {
                    sqlEx.Data.Add("Log", sLog);
                    int DefaultSqlError = 6; //"Erreur SQL non traitée !" L'exception sera relancée.
                    switch (sqlEx.Number)
                    {
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
                    int DefaultError = 7; //"Problème à la récupération des données !"
                    throw new EL.CstmError(DefaultError, ex);
                }
            }
        }

    }
}
