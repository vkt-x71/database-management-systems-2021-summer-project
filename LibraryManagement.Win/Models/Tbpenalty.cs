using NpgsqlTypes;
using System;
using System.Collections.Generic;

namespace LibraryManagement.Win.Models
{
    public partial class Tbpenalty
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int ActionId { get; set; }
        public DateTime PenaltyTime { get; set; }
        public DateTime PenaltyEndTime { get; set; }

        public virtual Tbaction Action { get; set; }
        public virtual Tbperson Person { get; set; }
    }
}
