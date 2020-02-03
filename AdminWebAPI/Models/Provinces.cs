using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
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

        public virtual ICollection<AgencyContactAddresses> AgencyContactAddresses { get; set; }
        public virtual ICollection<ContactAddresses> ContactAddresses { get; set; }
        public virtual ICollection<DistrictPlaces> DistrictPlaces { get; set; }
    }
}
