using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class PersonCustomerSourceTypes
    {
        public PersonCustomerSourceTypes()
        {
            Persons = new HashSet<Persons>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public ICollection<Persons> Persons { get; set; }
    }
}
