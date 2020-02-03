using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
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

        public virtual Drinks Drink { get; set; }
        public virtual PromotionDrinkSettings Promotion { get; set; }
        public virtual ICollection<PromotionDrinkToppings> PromotionDrinkToppings { get; set; }
    }
}
