using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class ContactPhones
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsPrimary { get; set; }
        public int TypeId { get; set; }
        public int ContactInfoId { get; set; }

        public virtual ContactInfos ContactInfo { get; set; }
        public virtual PhoneTypes Type { get; set; }
    }
}
