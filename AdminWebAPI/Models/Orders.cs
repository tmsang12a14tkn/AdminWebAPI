using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int OrderId { get; set; }
        public string AddressLine { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime OrderPlaced { get; set; }
        public int OrderTotal { get; set; }
        public string PhoneNumber { get; set; }
        public string Code { get; set; }
        public string MiddleName { get; set; }
        public int Status { get; set; }
        public string CardCode { get; set; }
        public string CustomerNote { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeNote { get; set; }
        public DateTime OrderDeliveried { get; set; }
        public string SocialNetwork { get; set; }
        public string StatusNote { get; set; }
        public string PromotionCode { get; set; }
        public int PromotionDiscountValue { get; set; }
        public int ShipFee { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
        public int PromotionDiscountType { get; set; }
        public bool IsDeliveryNow { get; set; }
        public int DiscountAmount { get; set; }
        public int Distance { get; set; }
        public int? DistrictId { get; set; }
        public bool IsAutoDiscount { get; set; }
        public bool IsAutoShipFee { get; set; }
        public bool IsAutoSurcharge { get; set; }
        public int SurchargeAmount { get; set; }
        public int BaseDrinkCount { get; set; }
        public int DiscountDrinkCount { get; set; }
        public int FreeDrinkCount { get; set; }
        public int? AgencyId { get; set; }
        public int? CustomerId { get; set; }
        public int OrderCustomerType { get; set; }
        public int? OrderSourceId { get; set; }

        public virtual Agencies Agency { get; set; }
        public virtual Persons Customer { get; set; }
        public virtual Districts District { get; set; }
        public virtual OrderSources OrderSource { get; set; }
        public virtual OrderDeliveries OrderDeliveries { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
