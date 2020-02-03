using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
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

        public virtual ICollection<AgencyBanks> AgencyBanks { get; set; }
        public virtual ICollection<PersonBanks> PersonBanks { get; set; }
    }
}
