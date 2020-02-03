using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class PromotionDrinkToppings
    {
        public int Id { get; set; }
        public int ToppingId { get; set; }
        public int Quantity { get; set; }
        public int PromotionDrinkId { get; set; }

        public virtual PromotionDrinks PromotionDrink { get; set; }
        public virtual Toppings Topping { get; set; }
    }
}
