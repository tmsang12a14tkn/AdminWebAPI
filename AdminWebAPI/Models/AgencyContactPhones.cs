using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class AgencyContactPhones
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsPrimary { get; set; }
        public int TypeId { get; set; }
        public int AgencyContactInfoId { get; set; }

        public virtual AgencyContactInfos AgencyContactInfo { get; set; }
        public virtual PhoneTypes Type { get; set; }
    }
}
