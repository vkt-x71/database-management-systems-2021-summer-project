using System;
using System.Collections.Generic;

namespace LibraryManagement.Win.Models
{
    public partial class Tbpublication
    {
        public Tbpublication()
        {
            InversePublicationType = new HashSet<Tbpublication>();
            Tbaction = new HashSet<Tbaction>();
            Tbbook = new HashSet<Tbbook>();
            Tbencyclopedia = new HashSet<Tbencyclopedia>();
            Tbmagazine = new HashSet<Tbmagazine>();
        }

        public int Id { get; set; }
        public int PublishHomeId { get; set; }
        public int PublicationTypeId { get; set; }
        public string Name { get; set; }
        public string RegisterNumber { get; set; }
        public string ClassifcationNumber { get; set; }
        public int PageCount { get; set; }
        public string Isbn { get; set; }

        public virtual Tbpublication PublicationType { get; set; }
        public virtual Tbpublishhome PublishHome { get; set; }
        public virtual ICollection<Tbpublication> InversePublicationType { get; set; }
        public virtual ICollection<Tbaction> Tbaction { get; set; }
        public virtual ICollection<Tbbook> Tbbook { get; set; }
        public virtual ICollection<Tbencyclopedia> Tbencyclopedia { get; set; }
        public virtual ICollection<Tbmagazine> Tbmagazine { get; set; }
    }
}
