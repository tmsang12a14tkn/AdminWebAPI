using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class AgencyDeliveries
    {
        public int Id { get; set; }
        public int? PickupTypeId { get; set; }
        public int AgencyId { get; set; }
        public int? AgencyDiscountCustomerTypeId { get; set; }
        public string Note { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Agencies Agency { get; set; }
        public AgencyDiscountCustomerTypes AgencyDiscountCustomerType { get; set; }
        public PickupTypes PickupType { get; set; }
    }
}
