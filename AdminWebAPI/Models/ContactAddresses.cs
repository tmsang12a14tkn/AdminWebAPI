using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class ContactAddresses
    {
        public int Id { get; set; }
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

        public virtual ContactInfos ContactInfo { get; set; }
        public virtual DistrictPlaces DistrictPlace { get; set; }
        public virtual Nationalities Nationality { get; set; }
        public virtual Provinces Province { get; set; }
        public virtual AddressTypes Type { get; set; }
        public virtual Wards Ward { get; set; }
    }
}
