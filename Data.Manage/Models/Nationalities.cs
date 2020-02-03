using System;
using System.Collections.Generic;

namespace Data.Manage.Models
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

        public ICollection<AgencyContactAddresses> AgencyContactAddresses { get; set; }
        public ICollection<ContactAddresses> ContactAddresses { get; set; }
        public ICollection<PersonalNationality> PersonalNationality { get; set; }
    }
}
