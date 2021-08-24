using System;
using System.Collections.Generic;

namespace LibraryManagement.Win.Models
{
    public partial class Tbpublishhome
    {
        public Tbpublishhome()
        {
            Tbpublication = new HashSet<Tbpublication>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Tbpublication> Tbpublication { get; set; }
    }
}
