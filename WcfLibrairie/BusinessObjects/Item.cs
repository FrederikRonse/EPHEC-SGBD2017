using System;

namespace BusinessObjects
{
    public class Item
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int LibraryId { get; set; }
        public int VolumeId { get; set; }
        public DateTime BuyDate { get; set; }
        public string Localisation { get; set; }
        public DateTime DateEmprunt { get; set; }
    }
}
