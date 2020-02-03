using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class Toppings
    {
        public Toppings()
        {
            DrinkToppings = new HashSet<DrinkToppings>();
            OrderDetailToppings = new HashSet<OrderDetailToppings>();
            PrivatePromotionDrinkToppings = new HashSet<PrivatePromotionDrinkToppings>();
            PromotionDrinkToppings = new HashSet<PromotionDrinkToppings>();
            ToppingPhotos = new HashSet<ToppingPhotos>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string EnglishName { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public bool IsShared { get; set; }
        public string OtherName { get; set; }
        public int Quota { get; set; }
        public int? UnitId { get; set; }
        public int Position { get; set; }
        public bool OutOfStock { get; set; }
        public DateTime? OutOfStockFrom { get; set; }
        public DateTime? OutOfStockTo { get; set; }
        public int QuickCreateIndex { get; set; }

        public ToppingCategories Category { get; set; }
        public DrinkUnits Unit { get; set; }
        public ICollection<DrinkToppings> DrinkToppings { get; set; }
        public ICollection<OrderDetailToppings> OrderDetailToppings { get; set; }
        public ICollection<PrivatePromotionDrinkToppings> PrivatePromotionDrinkToppings { get; set; }
        public ICollection<PromotionDrinkToppings> PromotionDrinkToppings { get; set; }
        public ICollection<ToppingPhotos> ToppingPhotos { get; set; }
    }
}
