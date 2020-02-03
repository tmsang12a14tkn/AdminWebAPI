using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class PrivatePromotionDrinkToppings
    {
        public int Id { get; set; }
        public int ToppingId { get; set; }
        public int Quantity { get; set; }
        public int PrivatePromotionDrinkId { get; set; }

        public virtual PrivatePromotionDrinks PrivatePromotionDrink { get; set; }
        public virtual Toppings Topping { get; set; }
    }
}
