using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class CurrencyTypes
    {
        public CurrencyTypes()
        {
            AgencyPayments = new HashSet<AgencyPayments>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public ICollection<AgencyPayments> AgencyPayments { get; set; }
    }
}
