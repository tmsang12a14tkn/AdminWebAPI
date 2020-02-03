using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class Religions
    {
        public Religions()
        {
            Persons = new HashSet<Persons>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public virtual ICollection<Persons> Persons { get; set; }
    }
}
