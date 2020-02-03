using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class ToppingCategories
    {
        public ToppingCategories()
        {
            DrinkToppingCategories = new HashSet<DrinkToppingCategories>();
            InverseParent = new HashSet<ToppingCategories>();
            Toppings = new HashSet<Toppings>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string EnglishName { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public int Position { get; set; }

        public ToppingCategories Parent { get; set; }
        public ICollection<DrinkToppingCategories> DrinkToppingCategories { get; set; }
        public ICollection<ToppingCategories> InverseParent { get; set; }
        public ICollection<Toppings> Toppings { get; set; }
    }
}
