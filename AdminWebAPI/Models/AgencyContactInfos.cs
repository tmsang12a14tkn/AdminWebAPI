using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
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

        public virtual Agencies IdNavigation { get; set; }
        public virtual ICollection<AgencyContactAddresses> AgencyContactAddresses { get; set; }
        public virtual ICollection<AgencyContactEmails> AgencyContactEmails { get; set; }
        public virtual ICollection<AgencyContactOtts> AgencyContactOtts { get; set; }
        public virtual ICollection<AgencyContactPhones> AgencyContactPhones { get; set; }
        public virtual ICollection<AgencyContactSocials> AgencyContactSocials { get; set; }
    }
}
