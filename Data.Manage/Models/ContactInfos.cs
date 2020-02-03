using System;
using System.Collections.Generic;

namespace Data.Manage.Models
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

        public Persons IdNavigation { get; set; }
        public ICollection<ContactAddresses> ContactAddresses { get; set; }
        public ICollection<ContactEmails> ContactEmails { get; set; }
        public ICollection<ContactOtts> ContactOtts { get; set; }
        public ICollection<ContactPhones> ContactPhones { get; set; }
        public ICollection<ContactSocials> ContactSocials { get; set; }
    }
}
