using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class AgencyContactPhones
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsPrimary { get; set; }
        public int TypeId { get; set; }
        public int AgencyContactInfoId { get; set; }

        public AgencyContactInfos AgencyContactInfo { get; set; }
        public PhoneTypes Type { get; set; }
    }
}
