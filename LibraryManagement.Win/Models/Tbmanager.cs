using System;
using System.Collections.Generic;

namespace LibraryManagement.Win.Models
{
    public partial class Tbmanager
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }

        public virtual Tbperson Person { get; set; }
        public virtual Tbrole Role { get; set; }
    }
}
