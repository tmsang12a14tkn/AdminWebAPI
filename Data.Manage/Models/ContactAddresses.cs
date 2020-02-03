using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class ContactAddresses : BaseEntity
    {
        public int? NationalityId { get; set; }
        public int? ProvinceId { get; set; }
        public int? DistrictPlaceId { get; set; }
        public int? WardId { get; set; }
        public string MoreInfo { get; set; }
        public bool IsPrimary { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public int? TypeId { get; set; }
        public int ContactInfoId { get; set; }

        public ContactInfos ContactInfo { get; set; }
        public DistrictPlaces DistrictPlace { get; set; }
        public Nationalities Nationality { get; set; }
        public Provinces Province { get; set; }
        public AddressTypes Type { get; set; }
        public Wards Ward { get; set; }
    }
}
