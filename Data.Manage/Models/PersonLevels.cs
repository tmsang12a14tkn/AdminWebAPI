using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class PersonLevels
    {
        public PersonLevels()
        {
            Persons = new HashSet<Persons>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Points { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        public ICollection<Persons> Persons { get; set; }
    }
}
