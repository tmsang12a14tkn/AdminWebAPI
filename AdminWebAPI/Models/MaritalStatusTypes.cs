using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class MaritalStatusTypes
    {
        public MaritalStatusTypes()
        {
            MaritalStatuses = new HashSet<MaritalStatuses>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public virtual ICollection<MaritalStatuses> MaritalStatuses { get; set; }
    }
}
