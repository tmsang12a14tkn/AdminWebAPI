using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class AgencyContactInfos
    {
        public AgencyContactInfos()
        {
            AgencyContactAddresses = new HashSet<AgencyContactAddresses>();
            AgencyContactEmails = new HashSet<AgencyContactEmails>();
            AgencyContactOtts = new HashSet<AgencyContactOtts>();
            AgencyContactPhones = new HashSet<AgencyContactPhones>();
            AgencyContactSocials = new HashSet<AgencyContactSocials>();
        }

        public int Id { get; set; }

        public Agencies IdNavigation { get; set; }
        public ICollection<AgencyContactAddresses> AgencyContactAddresses { get; set; }
        public ICollection<AgencyContactEmails> AgencyContactEmails { get; set; }
        public ICollection<AgencyContactOtts> AgencyContactOtts { get; set; }
        public ICollection<AgencyContactPhones> AgencyContactPhones { get; set; }
        public ICollection<AgencyContactSocials> AgencyContactSocials { get; set; }
    }
}
