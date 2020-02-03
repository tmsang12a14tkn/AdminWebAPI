using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class ShoppingCartItems
    {
        public int ShoppingCartItemId { get; set; }
        public int Amount { get; set; }
        public int? DrinkId { get; set; }
        public string ShoppingCartId { get; set; }

        public virtual Drinks Drink { get; set; }
    }
}
