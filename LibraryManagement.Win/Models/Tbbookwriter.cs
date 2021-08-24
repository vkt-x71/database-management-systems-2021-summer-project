using System;
using System.Collections.Generic;

namespace LibraryManagement.Win.Models
{
    public partial class Tbbookwriter
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int WriterId { get; set; }

        public virtual Tbbook Book { get; set; }
        public virtual Tbwriter Writer { get; set; }
    }
}
