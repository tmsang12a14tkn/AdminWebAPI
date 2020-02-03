using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class DepartmentPositions
    {
        public DepartmentPositions()
        {
            PersonEmployeeWorkings = new HashSet<PersonEmployeeWorkings>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }

        public virtual Departments Department { get; set; }
        public virtual ICollection<PersonEmployeeWorkings> PersonEmployeeWorkings { get; set; }
    }
}
