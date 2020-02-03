using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class Provinces
    {
        public Provinces()
        {
            AgencyContactAddresses = new HashSet<AgencyContactAddresses>();
            ContactAddresses = new HashSet<ContactAddresses>();
            DistrictPlaces = new HashSet<DistrictPlaces>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<AgencyContactAddresses> AgencyContactAddresses { get; set; }
        public ICollection<ContactAddresses> ContactAddresses { get; set; }
        public ICollection<DistrictPlaces> DistrictPlaces { get; set; }
    }
}
