using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class DrinkToppingCategories
    {
        public int DrinkId { get; set; }
        public int ToppingCategoryId { get; set; }
        public int? Min { get; set; }
        public int? Max { get; set; }

        public Drinks Drink { get; set; }
        public ToppingCategories ToppingCategory { get; set; }
    }
}
