using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class FreeDrinkReasons
    {
        public FreeDrinkReasons()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
