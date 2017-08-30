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
        public static void GetItemsByVOlume(int volumeId, ref List<Item> listToReturn)
        {
            StringBuilder sLog = new StringBuilder();

            listToReturn.Clear();
            using (ExamSGBD2017Entities dbEntity = new ExamSGBD2017Entities())
            {
                try
                {
                    foreach (GetItemByVol_Result vItem in dbEntity.GetItemByVol(volumeId)) //vEmpruntDetail
                    {
                        Item itemToReturn = new Item();
                        itemToReturn.Id = vItem.Id;
                        itemToReturn.LibraryId = vItem.Library_Id;
                        itemToReturn.VolumeId = vItem.Volume_Id;
                        itemToReturn.Code = vItem.Code;
                        itemToReturn.BuyDate = (DateTime)vItem.BuyDate;
                        itemToReturn.Localisation = vItem.Localisation;

                        listToReturn.Add((itemToReturn));
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
