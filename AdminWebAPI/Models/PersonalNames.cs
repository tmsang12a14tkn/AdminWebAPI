using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class PersonalNames
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }
        public int PersonId { get; set; }
        public int TypeId { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public bool IsPrimary { get; set; }
        public string FullName { get; set; }

        public virtual Persons Person { get; set; }
        public virtual PersonalNameTypes Type { get; set; }
    }
}
