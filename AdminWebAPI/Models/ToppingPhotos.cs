using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class ToppingPhotos
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string PhysicalPath { get; set; }
        public bool IsPrimary { get; set; }
        public int ToppingId { get; set; }

        public virtual Toppings Topping { get; set; }
    }
}
