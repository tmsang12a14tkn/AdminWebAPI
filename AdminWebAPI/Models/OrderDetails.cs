using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class OrderDetails
    {
        public OrderDetails()
        {
            OrderDetailToppings = new HashSet<OrderDetailToppings>();
        }

        public int OrderDetailId { get; set; }
        public int Amount { get; set; }
        public int DrinkId { get; set; }
        public int OrderId { get; set; }
        public int Price { get; set; }
        public string DrinkSize { get; set; }
        public string IceOption { get; set; }
        public string SugarOption { get; set; }
        public int Quantity { get; set; }
        public string DrinkName { get; set; }
        public int DrinkSizeId { get; set; }
        public int FullPrice { get; set; }
        public bool IsPromoDiscount { get; set; }
        public string Note { get; set; }
        public bool IsFreeDrink { get; set; }
        public int DiscountMoneyValue { get; set; }
        public int DiscountPercentValue { get; set; }
        public string DiscountReason { get; set; }
        public int DiscountType { get; set; }
        public int? FreeDrinkReasonId { get; set; }
        public bool IsNewDrink { get; set; }

        public virtual FreeDrinkReasons FreeDrinkReason { get; set; }
        public virtual Orders Order { get; set; }
        public virtual ICollection<OrderDetailToppings> OrderDetailToppings { get; set; }
    }
}
