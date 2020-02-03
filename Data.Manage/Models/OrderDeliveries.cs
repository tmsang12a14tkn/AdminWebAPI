using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class OrderDeliveries
    {
        public int OrderId { get; set; }
        public DateTime? AcceptedTime { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public int Partner { get; set; }
        public float PartnerDistance { get; set; }
        public int PartnerShipFee { get; set; }
        public int? DeliveryPartnerId { get; set; }

        public DeliveryPartners DeliveryPartner { get; set; }
        public Orders Order { get; set; }
    }
}
