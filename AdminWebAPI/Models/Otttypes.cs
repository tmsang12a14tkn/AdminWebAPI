using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class Otttypes
    {
        public Otttypes()
        {
            AgencyContactOtts = new HashSet<AgencyContactOtts>();
            ContactOtts = new HashSet<ContactOtts>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public virtual ICollection<AgencyContactOtts> AgencyContactOtts { get; set; }
        public virtual ICollection<ContactOtts> ContactOtts { get; set; }
    }
}
