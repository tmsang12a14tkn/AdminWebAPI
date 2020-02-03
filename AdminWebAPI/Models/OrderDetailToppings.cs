using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class OrderDetailToppings
    {
        public int OrderDetailId { get; set; }
        public int ToppingId { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string ToppingName { get; set; }

        public virtual OrderDetails OrderDetail { get; set; }
        public virtual Toppings Topping { get; set; }
    }
}
