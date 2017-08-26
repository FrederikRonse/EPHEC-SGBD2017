using System;

namespace BusinessObjects
{
    public class Emprunt
    {
        public int Id { get; set; }
        public int CardNum { get; set; }
        public int ItemId { get; set; }
        public string ItemCode { get; set; }
        public int LibraryId { get; set; }
        public string LibraryName { get; set; }
        public string TarifName { get; set; }
        public string VolumeTitle { get; set; }
        public DateTime StartDate { get; set; }
        public int Duration { get; set; }
        public DateTime ReturnDte { get; set; }
        public decimal Fee { get; set; }
        public decimal DailyPenalty { get; set; }
        public  DateTime LastModified { get; set; }
    }
}

