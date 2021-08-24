using System;
using System.Collections.Generic;

namespace LibraryManagement.Win.Models
{
    public partial class Tbperson
    {
        public Tbperson()
        {
            Tbaction = new HashSet<Tbaction>();
            Tbmanager = new HashSet<Tbmanager>();
            Tbmember = new HashSet<Tbmember>();
            Tbpenalty = new HashSet<Tbpenalty>();
            Tbwriter = new HashSet<Tbwriter>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual ICollection<Tbaction> Tbaction { get; set; }
        public virtual ICollection<Tbmanager> Tbmanager { get; set; }
        public virtual ICollection<Tbmember> Tbmember { get; set; }
        public virtual ICollection<Tbpenalty> Tbpenalty { get; set; }
        public virtual ICollection<Tbwriter> Tbwriter { get; set; }
    }
}
