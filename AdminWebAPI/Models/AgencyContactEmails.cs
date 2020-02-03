using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class AgencyContactEmails
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int TypeId { get; set; }
        public int AgencyContactInfoId { get; set; }
        public bool IsPrimary { get; set; }

        public virtual AgencyContactInfos AgencyContactInfo { get; set; }
        public virtual EmailTypes Type { get; set; }
    }
}
