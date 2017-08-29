using System;

namespace BusinessObjects
{
    public class WishListItem
    {
        public int Id { get; set; }
        public int CardNum { get; set; }
        public int Volume_Id { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Cover { get; set; }
    }
}

