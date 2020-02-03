using System;
using System.Collections.Generic;

namespace Data.Manage.Models
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

        public ICollection<AgencyBankCards> AgencyBankCards { get; set; }
        public ICollection<BankCards> BankCards { get; set; }
    }
}
