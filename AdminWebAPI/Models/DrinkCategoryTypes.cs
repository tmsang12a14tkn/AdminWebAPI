using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class DrinkCategoryTypes
    {
        public DrinkCategoryTypes()
        {
            DrinkCategories = new HashSet<DrinkCategories>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DrinkCategories> DrinkCategories { get; set; }
    }
}
