using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class DrinkToppings
    {
        public int DrinkId { get; set; }
        public int ToppingId { get; set; }
        public bool IsPrimary { get; set; }
        public int PriceForExtra { get; set; }
        public int PriceForSale { get; set; }

        public virtual Drinks Drink { get; set; }
        public virtual Toppings Topping { get; set; }
    }
}
