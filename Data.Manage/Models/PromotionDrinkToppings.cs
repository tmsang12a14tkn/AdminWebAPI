using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class PromotionDrinkToppings
    {
        public int Id { get; set; }
        public int ToppingId { get; set; }
        public int Quantity { get; set; }
        public int PromotionDrinkId { get; set; }

        public PromotionDrinks PromotionDrink { get; set; }
        public Toppings Topping { get; set; }
    }
}
