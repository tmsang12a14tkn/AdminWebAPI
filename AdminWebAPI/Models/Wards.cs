using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
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

        public virtual DistrictPlaces DistrictPlace { get; set; }
        public virtual ICollection<AgencyContactAddresses> AgencyContactAddresses { get; set; }
        public virtual ICollection<ContactAddresses> ContactAddresses { get; set; }
    }
}
