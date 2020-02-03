using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class PrivatePromotionDrinks
    {
        public PrivatePromotionDrinks()
        {
            PrivatePromotionDrinkToppings = new HashSet<PrivatePromotionDrinkToppings>();
        }

        public int Id { get; set; }
        public int DrinkId { get; set; }
        public int DrinkSizeId { get; set; }
        public string DrinkSizeName { get; set; }
        public int Quantity { get; set; }
        public int PrivatePromotionId { get; set; }

        public virtual Drinks Drink { get; set; }
        public virtual PrivatePromotionDrinkSettings PrivatePromotion { get; set; }
        public virtual ICollection<PrivatePromotionDrinkToppings> PrivatePromotionDrinkToppings { get; set; }
    }
}
