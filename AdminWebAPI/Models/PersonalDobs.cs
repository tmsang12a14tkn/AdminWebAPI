using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class PersonalDobs
    {
        public int PersonId { get; set; }
        public int TypeId { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public virtual Persons Person { get; set; }
        public virtual PersonalDobtypes Type { get; set; }
    }
}
