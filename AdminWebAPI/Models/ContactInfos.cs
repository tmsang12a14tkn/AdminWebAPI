using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class ContactInfos
    {
        public ContactInfos()
        {
            ContactAddresses = new HashSet<ContactAddresses>();
            ContactEmails = new HashSet<ContactEmails>();
            ContactOtts = new HashSet<ContactOtts>();
            ContactPhones = new HashSet<ContactPhones>();
            ContactSocials = new HashSet<ContactSocials>();
        }

        public int Id { get; set; }
        public string RelativeInfo { get; set; }

        public virtual Persons IdNavigation { get; set; }
        public virtual ICollection<ContactAddresses> ContactAddresses { get; set; }
        public virtual ICollection<ContactEmails> ContactEmails { get; set; }
        public virtual ICollection<ContactOtts> ContactOtts { get; set; }
        public virtual ICollection<ContactPhones> ContactPhones { get; set; }
        public virtual ICollection<ContactSocials> ContactSocials { get; set; }
    }
}
