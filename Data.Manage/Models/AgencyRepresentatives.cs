using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class AgencyRepresentatives
    {
        public int PersonId { get; set; }
        public int AgencyId { get; set; }
        public bool IsMainContact { get; set; }

        public Agencies Agency { get; set; }
        public Persons Person { get; set; }
    }
}
