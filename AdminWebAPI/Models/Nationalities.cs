using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class Nationalities
    {
        public Nationalities()
        {
            AgencyContactAddresses = new HashSet<AgencyContactAddresses>();
            ContactAddresses = new HashSet<ContactAddresses>();
            PersonalNationality = new HashSet<PersonalNationality>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public virtual ICollection<AgencyContactAddresses> AgencyContactAddresses { get; set; }
        public virtual ICollection<ContactAddresses> ContactAddresses { get; set; }
        public virtual ICollection<PersonalNationality> PersonalNationality { get; set; }
    }
}
