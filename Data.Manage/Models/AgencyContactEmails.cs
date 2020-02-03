using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class AgencyContactEmails
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int TypeId { get; set; }
        public int AgencyContactInfoId { get; set; }
        public bool IsPrimary { get; set; }

        public AgencyContactInfos AgencyContactInfo { get; set; }
        public EmailTypes Type { get; set; }
    }
}
