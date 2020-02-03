using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class FreeDrinkReasons
    {
        public FreeDrinkReasons()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
