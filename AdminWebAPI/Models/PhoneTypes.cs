using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class PhoneTypes
    {
        public PhoneTypes()
        {
            AgencyContactPhones = new HashSet<AgencyContactPhones>();
            ContactPhones = new HashSet<ContactPhones>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public virtual ICollection<AgencyContactPhones> AgencyContactPhones { get; set; }
        public virtual ICollection<ContactPhones> ContactPhones { get; set; }
    }
}
