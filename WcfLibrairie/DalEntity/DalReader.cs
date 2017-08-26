using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DALEntity
{
    public static class DalReader
    {
        public static DataTable GetReaderById(int lectId)
        {
            SqlDataAdapter datadapt = new SqlDataAdapter();

            using (SqlConnection connection = UtilsDAL.GetConnection())
            {
                StringBuilder sLog = new StringBuilder();
                try
                {
                    using (SqlCommand command = new SqlCommand("SchAdmin.GetReaderById", connection))
                    {
                        DataTable dataToReturn = new DataTable();
                        command.CommandType = CommandType.StoredProcedure;
                        sLog.Append("Open");
                        connection.Open();
                        datadapt.SelectCommand = command;
                        sLog.Append("Fill");
                        datadapt.Fill(dataToReturn);
                        return dataToReturn;
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
                    int DefaultError = 7; //"Problème à la récupération des données par la DAL !"
                    throw new EL.CstmError(DefaultError, ex);
                }
            }

        }
    }
}
