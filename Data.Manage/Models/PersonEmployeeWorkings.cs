using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class PersonEmployeeWorkings
    {
        public int Id { get; set; }
        public int DepartmentPositionId { get; set; }
        public int DepartmentId { get; set; }
        public DateTime? PositionBeginDate { get; set; }
        public DateTime? PositionEndDate { get; set; }
        public DateTime? TrialWorkBeginDate { get; set; }
        public DateTime? WorkBeginDate { get; set; }
        public bool IsMainPosition { get; set; }
        public bool IsWorking { get; set; }
        public int PersonId { get; set; }

        public Departments Department { get; set; }
        public DepartmentPositions DepartmentPosition { get; set; }
        public Persons Person { get; set; }
    }
}
