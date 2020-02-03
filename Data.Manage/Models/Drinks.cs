using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class Drinks : BaseEntity
    {
        public Drinks()
        {
            DrinkPhotos = new HashSet<DrinkPhotos>();
            DrinkSizes = new HashSet<DrinkSizes>();
            DrinkToppingCategories = new HashSet<DrinkToppingCategories>();
            DrinkToppings = new HashSet<DrinkToppings>();
            IceOptions = new HashSet<IceOptions>();
            PrivatePromotionDrinks = new HashSet<PrivatePromotionDrinks>();
            PromotionDrinks = new HashSet<PromotionDrinks>();
            ShoppingCartItems = new HashSet<ShoppingCartItems>();
            SugarOptions = new HashSet<SugarOptions>();
        }
        public int CategoryId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Barcode { get; set; }
        public bool IsCombo { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsOpen { get; set; }
        public bool IsShared { get; set; }
        public bool IsSuggested { get; set; }
        public bool Reenter { get; set; }
        public bool DisplayIceOption { get; set; }
        public bool DisplaySizeOption { get; set; }
        public bool DisplaySugarOption { get; set; }
        public bool RequireIceOption { get; set; }
        public bool RequireSizeOption { get; set; }
        public bool RequireSugarOption { get; set; }
        public string EnglishName { get; set; }
        public int Position { get; set; }
        public bool OutOfStock { get; set; }
        public DateTime? OutOfStockFrom { get; set; }
        public DateTime? OutOfStockTo { get; set; }
        public bool IsNew { get; set; }
        public int NewOrderSort { get; set; }

        public DrinkCategories Category { get; set; }
        public ICollection<DrinkPhotos> DrinkPhotos { get; set; }
        public ICollection<DrinkSizes> DrinkSizes { get; set; }
        public ICollection<DrinkToppingCategories> DrinkToppingCategories { get; set; }
        public ICollection<DrinkToppings> DrinkToppings { get; set; }
        public ICollection<IceOptions> IceOptions { get; set; }
        public ICollection<PrivatePromotionDrinks> PrivatePromotionDrinks { get; set; }
        public ICollection<PromotionDrinks> PromotionDrinks { get; set; }
        public ICollection<ShoppingCartItems> ShoppingCartItems { get; set; }
        public ICollection<SugarOptions> SugarOptions { get; set; }
    }
}
