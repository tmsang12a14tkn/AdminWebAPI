using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
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

        public virtual Agencies Agency { get; set; }
        public virtual AgencyDiscountCustomerTypes AgencyDiscountCustomerType { get; set; }
        public virtual PickupTypes PickupType { get; set; }
    }
}
