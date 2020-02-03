using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class OrderSources : BaseEntity
    {
        public OrderSources()
        {
            Orders = new HashSet<Orders>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int OrderSourceTypeId { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }

        public OrderSourceTypes OrderSourceType { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
