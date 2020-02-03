using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class AgencyGroups
    {
        public AgencyGroups()
        {
            Agencies = new HashSet<Agencies>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public virtual ICollection<Agencies> Agencies { get; set; }
    }
}
