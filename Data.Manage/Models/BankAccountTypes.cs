using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class BankAccountTypes
    {
        public BankAccountTypes()
        {
            AgencyBanks = new HashSet<AgencyBanks>();
            PersonBanks = new HashSet<PersonBanks>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public ICollection<AgencyBanks> AgencyBanks { get; set; }
        public ICollection<PersonBanks> PersonBanks { get; set; }
    }
}
