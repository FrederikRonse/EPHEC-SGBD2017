using System;


namespace BusinessObjects
{
    public class Affiliate
    {
        public int CardNum { get; set; }
        public DateTime? CardValidity { get; set; }
        public int MainLibraryId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
