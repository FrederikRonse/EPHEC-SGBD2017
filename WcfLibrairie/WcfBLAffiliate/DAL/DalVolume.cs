﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BusinessObjects;

namespace WcfBLAffiliate
{
    public static class DalVolume
    {
        public static void GetAllVolumes(ref List<Volume> listToReturn)
        {
            StringBuilder sLog = new StringBuilder();

            listToReturn.Clear();
            using (ExamSGBD2017Entities dbEntity = new ExamSGBD2017Entities())
            {
                try
                {
                    foreach (var vvolume in dbEntity.vVolumes)
                    {
                        Volume convertedVol = new Volume();

                        convertedVol.Id = vvolume.Id;
                        convertedVol.Isbn = vvolume.Isbn;
                        convertedVol.Title = vvolume.Title;
                        convertedVol.Cover = vvolume.Cover;
                        convertedVol.Authors = DalAuthor.GetAllAuthorsNames(vvolume.Isbn);

                        listToReturn.Add((convertedVol));
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
        /// Retourne un volume par son ID.
        /// </summary>
        /// <param name="VolumeId"></param>
        /// <param name="VolToFill"></param>
        public static void GetVolumeById(int VolumeId, ref Volume VolToFill)
        {
            StringBuilder sLog = new StringBuilder();

            using (ExamSGBD2017Entities dbEntity = new ExamSGBD2017Entities())
            {
                try
                {
                    Volume convertedVol = new Volume();
                    var vvolume = dbEntity.GetVolumeById(VolumeId).FirstOrDefault();

                    convertedVol.Id = vvolume.Id;
                    convertedVol.Isbn = vvolume.Isbn;
                    convertedVol.Title = vvolume.Title;
                    convertedVol.Cover = vvolume.Cover;
                    convertedVol.Authors = DalAuthor.GetAllAuthorsNames(vvolume.Isbn);

                    VolToFill = convertedVol;
                }

                catch (Exception ex)
                {
                    int DefaultError = 7; //"Problème à la récupération des données !"
                    throw new EL.CstmError(DefaultError, ex);
                }
            }
        }

        /// <summary>
        /// Retourne un volume par son ISBN.
        /// </summary>
        /// <param name="VolumeIsbn"></param>
        /// <param name="VolToFill"></param>
        public static void GetVolumeByIsbn(string VolumeIsbn, ref Volume VolToFill)
        {
            StringBuilder sLog = new StringBuilder();

            using (ExamSGBD2017Entities dbEntity = new ExamSGBD2017Entities())
            {
                try
                {
                    Volume convertedVol = new Volume();
                    var vvolume = dbEntity.GetVolumeByIsbn(VolumeIsbn).FirstOrDefault();

                    convertedVol.Id = vvolume.Id;
                    convertedVol.Isbn = vvolume.Isbn;
                    convertedVol.Title = vvolume.Title;
                    convertedVol.Cover = vvolume.Cover;
                    convertedVol.Authors = DalAuthor.GetAllAuthorsNames(vvolume.Isbn);

                    VolToFill = convertedVol;
                }
                catch (Exception ex)
                {
                    int DefaultError = 7; //"Problème à la récupération des données !"
                    throw new EL.CstmError(DefaultError, ex);
                }
            }
        }

        /// <summary>
        /// Retourne le premier volume dont le titre s'approche
        /// du string de recherche.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="VolToFill"></param>
        public static void GetVolumeByTitle(string title, ref Volume VolToFill)
        {
            StringBuilder sLog = new StringBuilder();

            using (ExamSGBD2017Entities dbEntity = new ExamSGBD2017Entities())
            {
                try
                {
                    Volume convertedVol = new Volume();
                    var vvolume = dbEntity.GetVolumeByTitle(title).FirstOrDefault();

                    convertedVol.Id = vvolume.Id;
                    convertedVol.Isbn = vvolume.Isbn;
                    convertedVol.Title = vvolume.Title;
                    convertedVol.Cover = vvolume.Cover;
                    convertedVol.Authors = DalAuthor.GetAllAuthorsNames(vvolume.Isbn);

                    VolToFill = convertedVol;
                }
                catch (Exception ex)
                {
                    int DefaultError = 7; //"Problème à la récupération des données !"
                    throw new EL.CstmError(DefaultError, ex);
                }
            }
        }

        ///// <summary>
        ///// Récupère les auteurs correspondants au volume.
        ///// </summary>
        ///// <param name="VolumeIsbn"></param>
        ///// <returns></returns>
        //public static DataTable GetVolumeAuthors(string VolumeIsbn)
        //{
        //    throw new NotImplementedException();
        //    DataTable dataToReturn = null;
        //    SqlDataAdapter datadapt = new SqlDataAdapter();

        //    using (SqlConnection connection = UtilsDAL.GetConnection())
        //    {
        //        StringBuilder sLog = new StringBuilder();
        //        try
        //        {
        //            using (SqlCommand command = new SqlCommand("SchAdmin.GetAuthorByVolumeIsbn", connection))
        //            {
        //                DataTable dataTemp = new DataTable();
        //                SqlParameter param1 = new SqlParameter("@VolumeIsbn", VolumeIsbn);
        //                command.CommandType = CommandType.StoredProcedure;
        //                command.Parameters.Add(param1);
        //                sLog.Append("Open");
        //                connection.Open();
        //                datadapt.SelectCommand = command;
        //                sLog.Append("Fill");
        //                datadapt.Fill(dataTemp);
        //                dataToReturn = dataTemp;
        //            }
        //        }
        //        catch (SqlException sqlEx)
        //        {
        //            sqlEx.Data.Add("Log", sLog);
        //            int DefaultSqlError = 6; //"Erreur SQL non traitée !" L'exception sera relancée.
        //            switch (sqlEx.Number)
        //            {
        //                case 4060:
        //                    throw new EL.CstmError(1, sqlEx); //"Mauvaise base de données"
        //                case 18456:
        //                    throw new EL.CstmError(2, sqlEx); //"Mauvais mot de passe"
        //                default:
        //                    throw new EL.CstmError(DefaultSqlError, sqlEx); //"Erreur SQL non traitée !" L'exception sera relancée.
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            int DefaultError = 7; //"Problème à la récupération des données par la DAL !"
        //            throw new EL.CstmError(DefaultError, ex);
        //        }
        //    }
        //    return dataToReturn;
        //}

        ///// <summary>
        ///// Insert les auteurs correspondants à un volume (à mettre dans une transaction).
        ///// </summary>
        ///// <param name="volumeToLnk"></param>
        //public static void LinkAuthorsToVol(Volume volumeToLnk)
        //{
        //    throw new NotImplementedException();
        //    using (SqlConnection connection = UtilsDAL.GetConnection())
        //    {
        //        StringBuilder sLog = new StringBuilder();
        //        foreach (Author author in volumeToLnk.Authors)
        //        {
        //            try
        //            {
        //                using (SqlCommand command = new SqlCommand("SchAdmin.linkAuthorToVolume", connection))
        //                {

        //                    command.CommandType = CommandType.StoredProcedure;
        //                    command.Parameters.Add(new SqlParameter("@AuthorId", author.PersId));
        //                    command.Parameters.Add(new SqlParameter("@VolumeIsbn", volumeToLnk.Isbn));
        //                    sLog.Append("Open");
        //                    connection.Open();
        //                    sLog.Append("ExecuteNonQuery");
        //                    int rowsAffected = command.ExecuteNonQuery();
        //                    if (rowsAffected > 1) throw new EL.CstmError(3);  // nbre de lignes affectées erroné
        //                }
        //            }
        //            catch (SqlException sqlEx)
        //            {
        //                sqlEx.Data.Add("Log", sLog);
        //                int DefaultSqlError = 6; //"Erreur SQL non traitée !" L'exception sera relancée.
        //                switch (sqlEx.Number)
        //                {
        //                    case 2601:
        //                        goto case 2627;
        //                    case 2627:
        //                        throw new EL.CstmError(5, sqlEx);   //Cet enregistrement existe déjà ! violation d'unicité d'index.
        //                    case 4060:
        //                        throw new EL.CstmError(1, sqlEx); //"Mauvaise base de données"
        //                    case 18456:
        //                        throw new EL.CstmError(2, sqlEx); //"Mauvais mot de passe"
        //                    default:
        //                        throw new EL.CstmError(DefaultSqlError, sqlEx); //"Erreur SQL non traitée !" L'exception sera relancée.
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                int DefaultError = 12; //" Un problème est survenu à l'ajout du volume ou de son / ses auteur(s) !".
        //                throw new EL.CstmError(DefaultError, ex);
        //            }
        //        }
        //    }
        //}
        ///// <summary>
        ///// Insert un volume (sans les auteurs ! Doit être inclus dans une transaction).
        ///// </summary>
        ///// <param name="volumeToIns"></param>
        //public static void InsertVolume(Volume volumeToIns)
        //{
        //    throw new NotImplementedException();
        //    using (SqlConnection connection = UtilsDAL.GetConnection())
        //    {
        //        StringBuilder sLog = new StringBuilder();

        //        SqlParameter param1 = new SqlParameter("@Isbn", volumeToIns.Isbn);
        //        SqlParameter param2 = new SqlParameter("@Title", volumeToIns.Title);
        //        SqlParameter param3 = new SqlParameter("@Cover", volumeToIns.Cover);
        //        SqlParameter[] parameters = { param1, param2, param3 };
        //        try
        //        {
        //            using (SqlCommand command = new SqlCommand("SchAdmin.InsertVolume", connection))
        //            {

        //                command.CommandType = CommandType.StoredProcedure;
        //                command.Parameters.AddRange(parameters);
        //                sLog.Append("Open");
        //                connection.Open();
        //                sLog.Append("ExecuteNonQuery");
        //                int rowsAffected = command.ExecuteNonQuery();
        //                if (rowsAffected > 1) throw new EL.CstmError(3);  // nbre de lignes affectées erroné
        //            }
        //        }
        //        catch (SqlException sqlEx)
        //        {
        //            sqlEx.Data.Add("Log", sLog);
        //            int DefaultSqlError = 6; //"Erreur SQL non traitée !" L'exception sera relancée.
        //            switch (sqlEx.Number)
        //            {
        //                case 2601:
        //                    goto case 2627;
        //                case 2627:
        //                    throw new EL.CstmError(5, sqlEx);   //Cet enregistrement existe déjà ! violation d'unicité d'index.
        //                case 4060:
        //                    throw new EL.CstmError(1, sqlEx); //"Mauvaise base de données"
        //                case 18456:
        //                    throw new EL.CstmError(2, sqlEx); //"Mauvais mot de passe"
        //                default:
        //                    throw new EL.CstmError(DefaultSqlError, sqlEx); //"Erreur SQL non traitée !" L'exception sera relancée.
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            int DefaultError = 12; //" Un problème est survenu à l'ajout du volume ou de son / ses auteur(s) !".
        //            throw new EL.CstmError(DefaultError, ex);
        //        }
        //    }
        //}
    }
}
