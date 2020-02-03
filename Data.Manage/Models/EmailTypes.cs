using System;
using System.Collections.Generic;

namespace Data.Manage.Models
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

        public ICollection<AgencyContactEmails> AgencyContactEmails { get; set; }
        public ICollection<ContactEmails> ContactEmails { get; set; }
    }
}
