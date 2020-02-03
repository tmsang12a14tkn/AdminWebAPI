using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class PromotionDrinks
    {
        public PromotionDrinks()
        {
            PromotionDrinkToppings = new HashSet<PromotionDrinkToppings>();
        }

        public int Id { get; set; }
        public int DrinkId { get; set; }
        public int DrinkSizeId { get; set; }
        public string DrinkSizeName { get; set; }
        public int PromotionId { get; set; }
        public int Quantity { get; set; }

        public Drinks Drink { get; set; }
        public PromotionDrinkSettings Promotion { get; set; }
        public ICollection<PromotionDrinkToppings> PromotionDrinkToppings { get; set; }
    }
}
