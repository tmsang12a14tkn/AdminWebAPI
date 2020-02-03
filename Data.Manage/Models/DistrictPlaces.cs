using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class DistrictPlaces
    {
        public DistrictPlaces()
        {
            AgencyContactAddresses = new HashSet<AgencyContactAddresses>();
            ContactAddresses = new HashSet<ContactAddresses>();
            Wards = new HashSet<Wards>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ProvinceId { get; set; }

        public Provinces Province { get; set; }
        public ICollection<AgencyContactAddresses> AgencyContactAddresses { get; set; }
        public ICollection<ContactAddresses> ContactAddresses { get; set; }
        public ICollection<Wards> Wards { get; set; }
    }
}
