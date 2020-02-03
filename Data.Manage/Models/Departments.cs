using System;
using System.Collections.Generic;

namespace Data.Manage.Models
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

        public Companies Company { get; set; }
        public ICollection<DepartmentPositions> DepartmentPositions { get; set; }
        public ICollection<PersonEmployeeWorkings> PersonEmployeeWorkings { get; set; }
    }
}
