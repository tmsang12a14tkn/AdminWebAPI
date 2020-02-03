using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class BankCards
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public int? BankCardTypeId { get; set; }
        public int PersonBankId { get; set; }

        public BankCardTypes BankCardType { get; set; }
        public PersonBanks PersonBank { get; set; }
    }
}
