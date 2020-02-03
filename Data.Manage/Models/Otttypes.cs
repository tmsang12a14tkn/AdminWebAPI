using System;
using System.Collections.Generic;

namespace Data.Manage.Models
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

        public ICollection<AgencyContactOtts> AgencyContactOtts { get; set; }
        public ICollection<ContactOtts> ContactOtts { get; set; }
    }
}
