using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class Companies
    {
        public Companies()
        {
            Departments = new HashSet<Departments>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Departments> Departments { get; set; }
    }
}
