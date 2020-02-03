using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class AgencyGroups
    {
        public AgencyGroups()
        {
            Agencies = new HashSet<Agencies>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public ICollection<Agencies> Agencies { get; set; }
    }
}
