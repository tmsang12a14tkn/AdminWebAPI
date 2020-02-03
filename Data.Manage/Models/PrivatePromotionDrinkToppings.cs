using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class PrivatePromotionDrinkToppings
    {
        public int Id { get; set; }
        public int ToppingId { get; set; }
        public int Quantity { get; set; }
        public int PrivatePromotionDrinkId { get; set; }

        public PrivatePromotionDrinks PrivatePromotionDrink { get; set; }
        public Toppings Topping { get; set; }
    }
}
