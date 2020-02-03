using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class AgencyCares
    {
        public int Id { get; set; }
        public int AgencyId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual Agencies Agency { get; set; }
        public virtual Persons Employee { get; set; }
    }
}
