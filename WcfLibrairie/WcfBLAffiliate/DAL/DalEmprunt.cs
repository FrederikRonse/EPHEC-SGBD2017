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
    public static class DalEmprunt
    {
        /// <summary>
        /// retourne les emprunts du lecteur.
        /// Sous forme de datatable. A SUPPRIMER?
        /// </summary>
        /// <param name="cardNum"></param>
        /// <param name="emprunts"></param>
        public static void GetEmpruntsByCardNum(int cardNum, bool SelectClosed, ref DataTable emprunts)
        {
            using (SqlConnection connection = UtilsDAL.GetConnection())
            {
                StringBuilder sLog = new StringBuilder();
                try
                {
                    using (SqlCommand command = new SqlCommand("[SchAdmin].[GetEmpruntById]", connection))
                    {
                        DataTable dataTemp = new DataTable();
                        SqlParameter param1 = new SqlParameter("@Id", cardNum);
                        SqlParameter param2 = new SqlParameter("@SelectClosed", SelectClosed);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(param1);
                        command.Parameters.Add(param2);
                        SqlDataAdapter datadapt = new SqlDataAdapter(command);
                        sLog.Append("Open");
                        connection.Open();
                        sLog.Append("Fill");
                        datadapt.Fill(dataTemp);
                        emprunts = dataTemp;
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

        /// <summary>
        /// retourne les emprunts du lecteur.
        /// Sous forme de liste d'objets Emprunt.
        /// </summary>
        /// <param name="cardNum"></param>
        /// <param name="listToReturn"></param>
        public static void GetEmpruntsByCardNum(int cardNum, bool SelectClosed, ref List<Emprunt> listToReturn)
        {
            StringBuilder sLog = new StringBuilder();

            listToReturn.Clear();
            using (ExamSGBD2017Entities dbEntity = new ExamSGBD2017Entities())
            {
                try
                {
                    foreach (GetEmpruntByAffiliate_Result vEmprunt in dbEntity.GetEmpruntByAffiliate(cardNum, SelectClosed)) //vEmpruntDetail
                    {
                        Emprunt convertedEmprunt = new Emprunt();

                        convertedEmprunt.Id = vEmprunt.IdEmprunt;
                        convertedEmprunt.CardNum = vEmprunt.CardNum;
                        convertedEmprunt.LibraryId = vEmprunt.Library_Id;
                        convertedEmprunt.LibraryName = vEmprunt.NameLibrary;
                        convertedEmprunt.VolumeTitle = vEmprunt.Title;
                        convertedEmprunt.ItemCode = vEmprunt.Code;
                        convertedEmprunt.ItemId = vEmprunt.Item_Id;
                        convertedEmprunt.TarifName = vEmprunt.NameTarif;
                        convertedEmprunt.Fee = vEmprunt.Fee;
                        convertedEmprunt.DailyPenalty = vEmprunt.DailyPenalty;
                        convertedEmprunt.Duration = vEmprunt.Duration;
                        convertedEmprunt.StartDate = vEmprunt.StartDate;
                        convertedEmprunt.ReturnDte = vEmprunt.ReturnDate ?? DateTime.Now;
                        convertedEmprunt.LastModified = vEmprunt.LastModified ?? DateTime.Now;
                        //   convertedEmprunt.Isbn = vEmprunt.;
                        //   convertedEmprunt.Cover = vEmprunt.;
                        //   convertedEmprunt.Authors = DalAuthor.GetAllAuthorsNames(vEmprunt.);

                        listToReturn.Add((convertedEmprunt));
                    }
                }
                catch (Exception ex)
                {
                    int DefaultError = 7; //"Problème à la récupération des données !"
                    throw new EL.CstmError(DefaultError, ex);
                }
            }
        }
        //TODO FAIRE RETARDS du lecteur (+ RETARDS PAR LIBS?)
        /// <summary>
        /// Retourne tous les retards d'une librairie.
        /// </summary>
        /// <param name="LibId"></param>
        /// <param name="listToReturn"></param>
        public static void GetRetardsByLib(int LibId, ref List<Emprunt> listToReturn) //ref List<vEmpruntDetail>
        {
            throw new NotImplementedException();
            //StringBuilder sLog = new StringBuilder();

            //listToReturn.Clear();
            //using (ExamSGBD2017Entities dbEntity = new ExamSGBD2017Entities())
            //{
            //    try
            //    {
            //        foreach (GetEmpruntByAffiliate_Result vEmprunt in dbEntity.GetEmpruntByAffiliate(cardNum, SelectClosed)) //vEmpruntDetail
            //        {
            //            Emprunt convertedEmprunt = new Emprunt();

            //            convertedEmprunt.Id = vEmprunt.IdEmprunt;
            //            convertedEmprunt.CardNum = vEmprunt.CardNum;
            //            convertedEmprunt.LibraryId = vEmprunt.Library_Id;
            //            convertedEmprunt.LibraryName = vEmprunt.NameLibrary;
            //            convertedEmprunt.VolumeTitle = vEmprunt.Title;
            //            convertedEmprunt.ItemCode = vEmprunt.Code;
            //            convertedEmprunt.ItemId = vEmprunt.Item_Id;
            //            convertedEmprunt.TarifName = vEmprunt.NameTarif;
            //            convertedEmprunt.Fee = vEmprunt.Fee;
            //            convertedEmprunt.DailyPenalty = vEmprunt.DailyPenalty;
            //            convertedEmprunt.Duration = vEmprunt.Duration;
            //            convertedEmprunt.StartDate = vEmprunt.StartDate;
            //            convertedEmprunt.ReturnDte = vEmprunt.ReturnDate ?? DateTime.Now;
            //            convertedEmprunt.LastModified = vEmprunt.LastModified ?? DateTime.Now;
            //            //   convertedEmprunt.Isbn = vEmprunt.;
            //            //   convertedEmprunt.Cover = vEmprunt.;
            //            //   convertedEmprunt.Authors = DalAuthor.GetAllAuthorsNames(vEmprunt.);

            //            listToReturn.Add((convertedEmprunt));
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        int DefaultError = 7; //"Problème à la récupération des données !"
            //        throw new EL.CstmError(DefaultError, ex);
            //    }
            //}
        }


        // A SUPPRIMER ?
        /// <summary>
        /// Retourne un emprunt par le code de l'exemplaire emprunté.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="EmpruntToReturn"></param>
        public static void GetEmpruntByCode(string code, bool SelectClosed, ref vEmpruntDetail EmpruntToReturn)
        {
            throw new NotImplementedException();
            //using (SqlConnection connection = UtilsDAL.GetConnection())
            //{
            //    StringBuilder sLog = new StringBuilder();
            //    try
            //    {
            //        using (SqlCommand command = new SqlCommand("SchAdmin.GetEmpruntByCode", connection))
            //        {
            //            Emprunt emprunt = new Emprunt();
            //            SqlParameter param1 = new SqlParameter("@Code", code);
            //            SqlParameter param2 = new SqlParameter("@SelectClosed", SelectClosed);
            //            command.CommandType = CommandType.StoredProcedure;
            //            command.Parameters.Add(param1);
            //            command.Parameters.Add(param2);
            //            sLog.Append("Open");
            //            connection.Open();
            //            SqlDataReader dtReader = command.ExecuteReader();
            //            sLog.Append("Read");
            //            while (dtReader.Read())
            //            {
            //                emprunt.Id = dtReader.GetInt32(0);
            //                emprunt.CardNum = (int)dtReader["CardNum"];
            //                emprunt.ItemId = (int)dtReader["Item_Id"];
            //                emprunt.ItemCode = dtReader["Code"].ToString();
            //                emprunt.LibraryId = (int)dtReader["Library_Id"];
            //                emprunt.LibraryName = dtReader["NameLibrary"].ToString();
            //                emprunt.TarifName = dtReader["NameTarif"].ToString();
            //                emprunt.VolumeTitle = dtReader["Title"].ToString();
            //                emprunt.StartDate = (DateTime)dtReader["StartDate"];
            //                emprunt.Duration = int.Parse(dtReader["Duration"].ToString());
            //                if (dtReader["ReturnDate"] != DBNull.Value) emprunt.ReturnDte = (DateTime)dtReader["ReturnDate"];
            //                emprunt.Fee = (decimal)dtReader["Fee"];
            //                emprunt.DailyPenalty = (decimal)dtReader["DailyPenalty"];
            //                emprunt.LastModified = (DateTime)dtReader["LastModified"];
            //            }
            //            EmpruntToReturn = emprunt;
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
    }
}


