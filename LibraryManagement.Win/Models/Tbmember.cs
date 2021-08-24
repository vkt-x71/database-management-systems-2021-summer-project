using NpgsqlTypes;
using System;
using System.Collections.Generic;

namespace LibraryManagement.Win.Models
{
    public partial class Tbmember
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool IsActive { get; set; }

        public virtual Tbperson Person { get; set; }
    }
}
