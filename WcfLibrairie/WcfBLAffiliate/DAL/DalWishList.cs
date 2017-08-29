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
    public static class DalWishList
    {

        /// <summary>
        /// Retourne les emprunts en cours du lecteur.
        /// </summary>
        /// <param name="cardNum"></param>
        /// <param name="listToReturn"></param>
        public static void GetWishListByCardNum(int cardNum, ref List<WishListItem> listToReturn)
        {
            StringBuilder sLog = new StringBuilder();

            listToReturn.Clear();
            using (ExamSGBD2017Entities dbEntity = new ExamSGBD2017Entities())
            {
                try
                {
                    foreach (GetWishlist_Result vWish in dbEntity.GetWishlist(cardNum)) //vEmpruntDetail
                    {
                        WishListItem wishListItem = new WishListItem();

                        wishListItem.Id = vWish.Id;
                        wishListItem.CardNum = vWish.CardNum;
                        wishListItem.Volume_Id = vWish.Volume_Id;
                        wishListItem.Isbn = vWish.Isbn;
                        //  wishListItem.Title = vWish. ;
                        wishListItem.Cover = vWish.Cover;

                        listToReturn.Add((wishListItem));
                    }
                }
                catch (Exception ex)
                {
                    int DefaultError = 7; //"Problème à la récupération des données !"
                    throw new EL.CstmError(DefaultError, ex);
                }
            }
        }

        public static void AddWishListItem(int cardNum, int volumeId)
        {
            StringBuilder sLog = new StringBuilder();

            try
            {
                using (ExamSGBD2017Entities dbEntity = new ExamSGBD2017Entities())
                {
                   dbEntity.InsertWish(cardNum, volumeId);
                }
            }
            catch (Exception ex)
            {
                int DefaultError = 12; //" Un problème est survenu à l'ajout !"
                throw new EL.CstmError(DefaultError, ex);
            }
        }

        public static void DeleteWishListItem(int WishId)
        {
            StringBuilder sLog = new StringBuilder();

            try
            {
                using (ExamSGBD2017Entities dbEntity = new ExamSGBD2017Entities())
                {
                    dbEntity.DeleteWishById(WishId);
                }
            }
            catch (Exception ex)
            {
                int DefaultError = 10; " Un problème est survenu à la modification des données !"
                throw new EL.CstmError(DefaultError, ex);
            }
        }

    }
}


