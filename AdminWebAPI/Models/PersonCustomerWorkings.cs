using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class PersonCustomerWorkings
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Company { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsMainPosition { get; set; }
        public bool IsWorking { get; set; }
        public int PersonId { get; set; }

        public virtual Persons Person { get; set; }
    }
}
