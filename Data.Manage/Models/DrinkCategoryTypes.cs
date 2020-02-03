using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class DrinkCategoryTypes
    {
        public DrinkCategoryTypes()
        {
            DrinkCategories = new HashSet<DrinkCategories>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<DrinkCategories> DrinkCategories { get; set; }
    }
}
