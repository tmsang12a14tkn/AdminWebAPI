using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class Departments
    {
        public Departments()
        {
            DepartmentPositions = new HashSet<DepartmentPositions>();
            PersonEmployeeWorkings = new HashSet<PersonEmployeeWorkings>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int CompanyId { get; set; }

        public virtual Companies Company { get; set; }
        public virtual ICollection<DepartmentPositions> DepartmentPositions { get; set; }
        public virtual ICollection<PersonEmployeeWorkings> PersonEmployeeWorkings { get; set; }
    }
}
