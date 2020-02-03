using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class PersonalDobs
    {
        public int PersonId { get; set; }
        public int TypeId { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public Persons Person { get; set; }
        public PersonalDobtypes Type { get; set; }
    }
}
