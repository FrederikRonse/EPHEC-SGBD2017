using System;

namespace BusinessObjects
{
    public class Tarif
    {
        public int Id { get; set; }
        public int LibraryId { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Duration { get; set; }
        public decimal Fee { get; set; }
        public decimal DailyPenalty { get; set; }

        public static implicit operator Tarif(WishListItem v)
        {
            throw new NotImplementedException();
        }
    }
}
