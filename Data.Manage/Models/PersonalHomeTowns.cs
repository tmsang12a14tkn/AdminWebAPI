using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class PersonalHomeTowns
    {
        public int PersonId { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public string MoreInfo { get; set; }

        public Persons Person { get; set; }
    }
}
