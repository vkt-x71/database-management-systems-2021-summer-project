using NpgsqlTypes;
using System;
using System.Collections.Generic;

namespace LibraryManagement.Win.Models
{
    public partial class Tbaction
    {
        public Tbaction()
        {
            Tbpenalty = new HashSet<Tbpenalty>();
        }

        public int Id { get; set; }
        public int PersonId { get; set; }
        public int PublicationId { get; set; }
        public DateTime actionTime { get; set; }
        public DateTime actionFinalTime { get; set; }
        public Nullable<DateTime> actionEndTime { get; set; }

        public virtual Tbperson Person { get; set; }
        public virtual Tbpublication Publication { get; set; }
        public virtual ICollection<Tbpenalty> Tbpenalty { get; set; }
    }
}
