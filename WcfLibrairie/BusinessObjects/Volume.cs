using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public class Volume
    {
        public int? Id { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public List<Author> Authors { get; set; }
        public string Cover { get; set; }
    }
}
