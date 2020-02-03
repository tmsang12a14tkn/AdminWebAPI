using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
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

        public virtual BankAccountTypes BankAccountType { get; set; }
        public virtual Persons Person { get; set; }
        public virtual ICollection<BankCards> BankCards { get; set; }
    }
}
