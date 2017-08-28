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
    public static class DalAuthor
    {

        public static List<Author> GetAllAuthorsNames(string isbn)
        {
            StringBuilder sLog = new StringBuilder();

            List<Author> listToReturn = new List<Author>();
            using (ExamSGBD2017Entities dbEntity = new ExamSGBD2017Entities())
            {
                try
                {
                    foreach (var author in dbEntity.GetAuthorByVolumeIsbn(isbn).ToList())
                    {
                        Author convertedAuthor = new Author();

                        convertedAuthor.PersId = author.Pers_Id;
                        convertedAuthor.FirstName = author.FirstName;
                        convertedAuthor.LastName = author.LastName;

                        listToReturn.Add((convertedAuthor));
                    }
                    return listToReturn;
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
