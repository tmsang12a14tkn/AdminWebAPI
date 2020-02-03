using System;
using System.Collections.Generic;

namespace Data.Manage.Models
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

        public Departments Department { get; set; }
        public ICollection<PersonEmployeeWorkings> PersonEmployeeWorkings { get; set; }
    }
}
