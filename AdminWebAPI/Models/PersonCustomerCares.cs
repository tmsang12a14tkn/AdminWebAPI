using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class PersonCustomerCares
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual Persons Employee { get; set; }
        public virtual Persons Person { get; set; }
    }
}
