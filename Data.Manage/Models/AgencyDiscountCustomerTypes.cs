using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class AgencyDiscountCustomerTypes
    {
        public AgencyDiscountCustomerTypes()
        {
            AgencyDeliveries = new HashSet<AgencyDeliveries>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public ICollection<AgencyDeliveries> AgencyDeliveries { get; set; }
    }
}
