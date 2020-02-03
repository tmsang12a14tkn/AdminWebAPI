using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class PersonalPobs
    {
        public int PersonId { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public string MoreInfo { get; set; }

        public virtual Persons Person { get; set; }
    }
}
