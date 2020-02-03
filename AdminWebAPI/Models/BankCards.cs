using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class BankCards
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public int? BankCardTypeId { get; set; }
        public int PersonBankId { get; set; }

        public virtual BankCardTypes BankCardType { get; set; }
        public virtual PersonBanks PersonBank { get; set; }
    }
}
