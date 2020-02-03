using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class PersonBanks
    {
        public PersonBanks()
        {
            BankCards = new HashSet<BankCards>();
        }

        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
        public string AccountName { get; set; }
        public string SwiftCode { get; set; }
        public string BankBranch { get; set; }
        public int? BankAccountTypeId { get; set; }
        public int PersonId { get; set; }

        public BankAccountTypes BankAccountType { get; set; }
        public Persons Person { get; set; }
        public ICollection<BankCards> BankCards { get; set; }
    }
}
