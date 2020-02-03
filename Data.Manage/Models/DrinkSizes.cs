using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class DrinkSizes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsActive { get; set; }
        public int Price { get; set; }
        public int DrinkId { get; set; }
        public float Quota { get; set; }
        public int? UnitId { get; set; }
        public bool IsShowOrder { get; set; }
        public int Order { get; set; }

        public Drinks Drink { get; set; }
        public DrinkUnits Unit { get; set; }
    }
}
