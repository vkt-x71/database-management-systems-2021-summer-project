using System;
using System.Collections.Generic;

namespace LibraryManagement.Win.Models
{
    public partial class Tbbook
    {
        public Tbbook()
        {
            Tbbookwriter = new HashSet<Tbbookwriter>();
        }

        public int Id { get; set; }
        public int PublicationId { get; set; }
        public string CoverText { get; set; }

        public virtual Tbpublication Publication { get; set; }
        public virtual ICollection<Tbbookwriter> Tbbookwriter { get; set; }
    }
}
