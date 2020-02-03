using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
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

        public virtual ICollection<AgencyContactSocials> AgencyContactSocials { get; set; }
        public virtual ICollection<ContactSocials> ContactSocials { get; set; }
        public virtual ICollection<Persons> Persons { get; set; }
    }
}
