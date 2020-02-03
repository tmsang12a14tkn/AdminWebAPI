using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class OrderSourceTypes
    {
        public OrderSourceTypes()
        {
            OrderSources = new HashSet<OrderSources>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<OrderSources> OrderSources { get; set; }
    }
}
