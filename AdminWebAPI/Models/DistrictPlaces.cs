using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
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

        public virtual Provinces Province { get; set; }
        public virtual ICollection<AgencyContactAddresses> AgencyContactAddresses { get; set; }
        public virtual ICollection<ContactAddresses> ContactAddresses { get; set; }
        public virtual ICollection<Wards> Wards { get; set; }
    }
}
