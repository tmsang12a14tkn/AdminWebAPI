using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class BankCardTypes
    {
        public BankCardTypes()
        {
            AgencyBankCards = new HashSet<AgencyBankCards>();
            BankCards = new HashSet<BankCards>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public virtual ICollection<AgencyBankCards> AgencyBankCards { get; set; }
        public virtual ICollection<BankCards> BankCards { get; set; }
    }
}
