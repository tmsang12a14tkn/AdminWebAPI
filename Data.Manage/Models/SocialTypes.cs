using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class SocialTypes
    {
        public SocialTypes()
        {
            AgencyContactSocials = new HashSet<AgencyContactSocials>();
            ContactSocials = new HashSet<ContactSocials>();
            Persons = new HashSet<Persons>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public ICollection<AgencyContactSocials> AgencyContactSocials { get; set; }
        public ICollection<ContactSocials> ContactSocials { get; set; }
        public ICollection<Persons> Persons { get; set; }
    }
}
