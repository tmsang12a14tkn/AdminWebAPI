using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class AgencyCares
    {
        public int Id { get; set; }
        public int AgencyId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Agencies Agency { get; set; }
        public Persons Employee { get; set; }
    }
}
