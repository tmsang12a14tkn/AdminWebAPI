﻿using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class PersonalDobtypes
    {
        public PersonalDobtypes()
        {
            PersonalDobs = new HashSet<PersonalDobs>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public ICollection<PersonalDobs> PersonalDobs { get; set; }
    }
}
