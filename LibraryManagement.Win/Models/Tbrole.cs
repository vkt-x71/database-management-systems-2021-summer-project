using System;
using System.Collections.Generic;

namespace LibraryManagement.Win.Models
{
    public partial class Tbrole
    {
        public Tbrole()
        {
            Tbmanager = new HashSet<Tbmanager>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Add { get; set; }
        public bool Edit { get; set; }
        public bool Delete { get; set; }
        public bool BookGive { get; set; }
        public bool BookReturn { get; set; }

        public virtual ICollection<Tbmanager> Tbmanager { get; set; }
    }
}
