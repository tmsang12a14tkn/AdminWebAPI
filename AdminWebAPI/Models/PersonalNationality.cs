using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class PersonalNationality
    {
        public int PersonId { get; set; }
        public int NationalityId { get; set; }
        public string From { get; set; }
        public string To { get; set; }

        public virtual Nationalities Nationality { get; set; }
        public virtual Persons Person { get; set; }
    }
}
