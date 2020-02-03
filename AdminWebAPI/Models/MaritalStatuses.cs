using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class MaritalStatuses
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int PersonId { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public bool IsCurrent { get; set; }

        public virtual Persons Person { get; set; }
        public virtual MaritalStatusTypes Type { get; set; }
    }
}
