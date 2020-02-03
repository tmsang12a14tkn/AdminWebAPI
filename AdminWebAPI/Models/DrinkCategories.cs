using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class DrinkCategories
    {
        public DrinkCategories()
        {
            CategoryIceOption = new HashSet<CategoryIceOption>();
            CategorySugarOption = new HashSet<CategorySugarOption>();
            DrinkCategoryPhotos = new HashSet<DrinkCategoryPhotos>();
            Drinks = new HashSet<Drinks>();
            InverseParent = new HashSet<DrinkCategories>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string EnglishName { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public int TypeId { get; set; }
        public int Position { get; set; }

        public virtual DrinkCategories Parent { get; set; }
        public virtual DrinkCategoryTypes Type { get; set; }
        public virtual ICollection<CategoryIceOption> CategoryIceOption { get; set; }
        public virtual ICollection<CategorySugarOption> CategorySugarOption { get; set; }
        public virtual ICollection<DrinkCategoryPhotos> DrinkCategoryPhotos { get; set; }
        public virtual ICollection<Drinks> Drinks { get; set; }
        public virtual ICollection<DrinkCategories> InverseParent { get; set; }
    }
}
