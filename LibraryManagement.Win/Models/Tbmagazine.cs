using NpgsqlTypes;
using System;
using System.Collections.Generic;

namespace LibraryManagement.Win.Models
{
    public partial class Tbmagazine
    {
        public int Id { get; set; }
        public int PublicationId { get; set; }
        public int Period { get; set; }
        public int Number { get; set; }
        public DateTime PublishDate { get; set; }

        public virtual Tbpublication Publication { get; set; }
    }
}
