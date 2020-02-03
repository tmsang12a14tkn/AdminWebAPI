using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class AddressTypes
    {
        public AddressTypes()
        {
            AgencyContactAddresses = new HashSet<AgencyContactAddresses>();
            ContactAddresses = new HashSet<ContactAddresses>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public ICollection<AgencyContactAddresses> AgencyContactAddresses { get; set; }
        public ICollection<ContactAddresses> ContactAddresses { get; set; }
    }
}
