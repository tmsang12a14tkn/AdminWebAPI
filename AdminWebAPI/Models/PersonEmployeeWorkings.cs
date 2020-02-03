using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
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

        public virtual Departments Department { get; set; }
        public virtual DepartmentPositions DepartmentPosition { get; set; }
        public virtual Persons Person { get; set; }
    }
}
