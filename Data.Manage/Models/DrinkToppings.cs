using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class DrinkToppings
    {
        public int DrinkId { get; set; }
        public int ToppingId { get; set; }
        public bool IsPrimary { get; set; }
        public int PriceForExtra { get; set; }
        public int PriceForSale { get; set; }

        public Drinks Drink { get; set; }
        public Toppings Topping { get; set; }
    }
}
