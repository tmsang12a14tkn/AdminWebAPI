using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class PersonalNationality
    {
        public int PersonId { get; set; }
        public int NationalityId { get; set; }
        public string From { get; set; }
        public string To { get; set; }

        public Nationalities Nationality { get; set; }
        public Persons Person { get; set; }
    }
}
