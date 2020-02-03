using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class DrinkToppingCategories
    {
        public int DrinkId { get; set; }
        public int ToppingCategoryId { get; set; }
        public int? Min { get; set; }
        public int? Max { get; set; }

        public virtual Drinks Drink { get; set; }
        public virtual ToppingCategories ToppingCategory { get; set; }
    }
}
