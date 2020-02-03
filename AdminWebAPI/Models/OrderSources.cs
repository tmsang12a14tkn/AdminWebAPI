using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class OrderSources
    {
        public OrderSources()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int OrderSourceTypeId { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }

        public virtual OrderSourceTypes OrderSourceType { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
