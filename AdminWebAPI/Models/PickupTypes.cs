using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class PickupTypes
    {
        public PickupTypes()
        {
            AgencyDeliveries = new HashSet<AgencyDeliveries>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public virtual ICollection<AgencyDeliveries> AgencyDeliveries { get; set; }
    }
}
