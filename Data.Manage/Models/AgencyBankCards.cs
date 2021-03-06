﻿using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class AgencyBankCards
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public int? BankCardTypeId { get; set; }
        public int AgencyBankId { get; set; }

        public AgencyBanks AgencyBank { get; set; }
        public BankCardTypes BankCardType { get; set; }
    }
}
