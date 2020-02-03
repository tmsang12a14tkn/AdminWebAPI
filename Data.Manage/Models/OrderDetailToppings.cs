using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class OrderDetailToppings
    {
        public int OrderDetailId { get; set; }
        public int ToppingId { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string ToppingName { get; set; }

        public OrderDetails OrderDetail { get; set; }
        public Toppings Topping { get; set; }
    }
}
