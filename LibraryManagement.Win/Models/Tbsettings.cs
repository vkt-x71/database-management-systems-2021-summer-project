using System;
using System.Collections.Generic;

namespace LibraryManagement.Win.Models
{
    public partial class Tbsettings
    {
        public int Id { get; set; }
        public int ReadDayLimit { get; set; }
        public string LibraryName { get; set; }
        public int PublicationCount { get; set; }
        public int MagazineCount { get; set; }
        public int BookCount { get; set; }
        public int WriterCount { get; set; }
    }
}
