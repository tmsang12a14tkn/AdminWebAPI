using System;
using System.Collections.Generic;

namespace Data.Manage.Models
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

        public ICollection<AgencyContactPhones> AgencyContactPhones { get; set; }
        public ICollection<ContactPhones> ContactPhones { get; set; }
    }
}
