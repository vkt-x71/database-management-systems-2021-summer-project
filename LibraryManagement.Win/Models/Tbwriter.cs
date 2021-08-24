using System;
using System.Collections.Generic;

namespace LibraryManagement.Win.Models
{
    public partial class Tbwriter
    {
        public Tbwriter()
        {
            Tbbookwriter = new HashSet<Tbbookwriter>();
        }

        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Biography { get; set; }

        public virtual Tbperson Person { get; set; }
        public virtual ICollection<Tbbookwriter> Tbbookwriter { get; set; }
    }
}
