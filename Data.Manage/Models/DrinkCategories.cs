using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class DrinkCategories : BaseEntity
    {
        public DrinkCategories()
        {
            CategoryIceOption = new HashSet<CategoryIceOption>();
            CategorySugarOption = new HashSet<CategorySugarOption>();
            DrinkCategoryPhotos = new HashSet<DrinkCategoryPhotos>();
            Drinks = new HashSet<Drinks>();
            InverseParent = new HashSet<DrinkCategories>();
        }

        public string Description { get; set; }
        public string EnglishName { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public int TypeId { get; set; }
        public int Position { get; set; }

        public DrinkCategories Parent { get; set; }
        public DrinkCategoryTypes Type { get; set; }
        public ICollection<CategoryIceOption> CategoryIceOption { get; set; }
        public ICollection<CategorySugarOption> CategorySugarOption { get; set; }
        public ICollection<DrinkCategoryPhotos> DrinkCategoryPhotos { get; set; }
        public ICollection<Drinks> Drinks { get; set; }
        public ICollection<DrinkCategories> InverseParent { get; set; }
    }
}
