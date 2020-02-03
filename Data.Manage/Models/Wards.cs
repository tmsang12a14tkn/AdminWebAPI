using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class Wards
    {
        public Wards()
        {
            AgencyContactAddresses = new HashSet<AgencyContactAddresses>();
            ContactAddresses = new HashSet<ContactAddresses>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int DistrictPlaceId { get; set; }

        public DistrictPlaces DistrictPlace { get; set; }
        public ICollection<AgencyContactAddresses> AgencyContactAddresses { get; set; }
        public ICollection<ContactAddresses> ContactAddresses { get; set; }
    }
}
