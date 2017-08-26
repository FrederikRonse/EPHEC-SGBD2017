using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WcfBLAffiliate
{   /// Classe utilitaire de vérification de l'utilisateur, création de la connection
    /// et de la (re)génération de la base de données pour l'exercice.
    public static class UtilsDAL
    {
        private static string _connectionString = null;
        //Propriétés    
        public static string UserName { get; private set; }

        /// <summary>
        /// Essaie d'établir une connection et récupère le nom de l'utilisateur connecté le cas écheant.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns>bool</returns>
        public static bool Check(string login, string password)
        {

            string dataToReturn = null;
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder["Data Source"] = Globals._sDataSource;
            builder["Initial Catalog"] = Globals._sDB;
            builder["Integrated Security"] = true;
            builder["User"] = login;  
            builder["Password"] = password;  
            _connectionString = builder.ConnectionString;
            connection.ConnectionString = _connectionString;

            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT CURRENT_USER";
                dataToReturn = (string)command.ExecuteScalar();
                connection.Close();
            }
            catch (SqlException sqlEx)
            {
                switch (sqlEx.Number)
                {
                    case 4060:
                        throw new EL.CstmError(1,sqlEx); //"Mauvaise base de données"
                    case 18456:
                        throw new EL.CstmError(2, sqlEx); //"Mauvais mot de passe"

                    default:
                        throw new EL.CstmError(6, sqlEx); //"Erreur SQL non traitée !" L'exception sera rError_Layerancée.
                }
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            UserName = dataToReturn;
            return true;
        }


        /// <summary>
        /// Retourne une connection SQL avec la chaîne de connection établie par Check().
        /// </summary>
        /// <returns></returns>
        internal static SqlConnection GetConnection()
        {
            ///
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder["Data Source"] = Globals._sDataSource;
            builder["Initial Catalog"] = Globals._sDB;
            builder["Integrated Security"] = true;
            builder["User"] = "Libadmin";
           // builder["Password"] = "password";
            _connectionString = builder.ConnectionString;
            ///

            if (_connectionString != null)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = _connectionString;
                return connection;
            }
            else throw new EL.CstmError(4); //"pas de ConnectionString disponible"
        }
    }

    public static class Extensions
    {
        public static string SafeGetString(this SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetString(colIndex);
            return string.Empty;
        }
    }
}
