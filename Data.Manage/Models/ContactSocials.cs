﻿using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class ContactSocials
    {
        public int Id { get; set; }
        public string Account { get; set; }
        public bool IsPrimary { get; set; }
        public int TypeId { get; set; }
        public int ContactInfoId { get; set; }

        public ContactInfos ContactInfo { get; set; }
        public SocialTypes Type { get; set; }
    }
}
