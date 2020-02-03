using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class BusinessAreas
    {
        public BusinessAreas()
        {
            InverseParent = new HashSet<BusinessAreas>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public double Coefficient { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public virtual BusinessAreas Parent { get; set; }
        public virtual ICollection<BusinessAreas> InverseParent { get; set; }
    }
}
