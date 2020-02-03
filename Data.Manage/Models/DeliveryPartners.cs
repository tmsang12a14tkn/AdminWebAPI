using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class DeliveryPartners
    {
        public DeliveryPartners()
        {
            OrderDeliveries = new HashSet<OrderDeliveries>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<OrderDeliveries> OrderDeliveries { get; set; }
    }
}
