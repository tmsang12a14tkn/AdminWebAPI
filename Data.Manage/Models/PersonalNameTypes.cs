using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class PersonalNameTypes
    {
        public PersonalNameTypes()
        {
            PersonalNames = new HashSet<PersonalNames>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public ICollection<PersonalNames> PersonalNames { get; set; }
    }
}
