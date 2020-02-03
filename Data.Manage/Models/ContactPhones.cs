using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class ContactPhones : BaseEntity
    {
        public string PhoneNumber { get; set; }
        public bool IsPrimary { get; set; }
        public int TypeId { get; set; }
        public int ContactInfoId { get; set; }

        public ContactInfos ContactInfo { get; set; }
        public PhoneTypes Type { get; set; }
    }
}
