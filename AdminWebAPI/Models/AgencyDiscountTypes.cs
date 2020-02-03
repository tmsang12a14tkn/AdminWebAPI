using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class AgencyDiscountTypes
    {
        public AgencyDiscountTypes()
        {
            AgencyPayments = new HashSet<AgencyPayments>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public virtual ICollection<AgencyPayments> AgencyPayments { get; set; }
    }
}
