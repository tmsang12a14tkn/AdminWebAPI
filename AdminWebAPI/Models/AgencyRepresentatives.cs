using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class AgencyRepresentatives
    {
        public int PersonId { get; set; }
        public int AgencyId { get; set; }
        public bool IsMainContact { get; set; }

        public virtual Agencies Agency { get; set; }
        public virtual Persons Person { get; set; }
    }
}
