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
    public static class DalLibrary
    {
        /// <summary>
        /// Retourne la liste de toutes les librairies.
        /// </summary>
        /// <param name="listToReturn"></param>
        public static void GetAllLibraries(ref List<Library> listToReturn)
        {
            StringBuilder sLog = new StringBuilder();

            listToReturn.Clear();
            using (ExamSGBD2017Entities dbEntity = new ExamSGBD2017Entities())
            {
                try
                {
                    foreach (GetLibraries_Result vlib in dbEntity.GetLibraries().ToList())
                    {
                        Library convertedLib = new Library();

                        convertedLib.Id = vlib.IdLibrary;
                        convertedLib.Code = vlib.CodeIdLibrary;
                        convertedLib.Name = vlib.NameLibrary;

                        listToReturn.Add((convertedLib));
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
