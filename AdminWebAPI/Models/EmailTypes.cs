using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class EmailTypes
    {
        public EmailTypes()
        {
            AgencyContactEmails = new HashSet<AgencyContactEmails>();
            ContactEmails = new HashSet<ContactEmails>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public virtual ICollection<AgencyContactEmails> AgencyContactEmails { get; set; }
        public virtual ICollection<ContactEmails> ContactEmails { get; set; }
    }
}
