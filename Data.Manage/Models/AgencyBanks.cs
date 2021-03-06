﻿using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class AgencyBanks
    {
        public AgencyBanks()
        {
            AgencyBankCards = new HashSet<AgencyBankCards>();
        }

        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
        public string AccountName { get; set; }
        public string SwiftCode { get; set; }
        public string BankBranch { get; set; }
        public int? BankAccountTypeId { get; set; }
        public int AgencyId { get; set; }

        public Agencies Agency { get; set; }
        public BankAccountTypes BankAccountType { get; set; }
        public ICollection<AgencyBankCards> AgencyBankCards { get; set; }
    }
}
