using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class DrinkUnits
    {
        public DrinkUnits()
        {
            DrinkSizes = new HashSet<DrinkSizes>();
            IceOptions = new HashSet<IceOptions>();
            SugarOptions = new HashSet<SugarOptions>();
            Toppings = new HashSet<Toppings>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<DrinkSizes> DrinkSizes { get; set; }
        public ICollection<IceOptions> IceOptions { get; set; }
        public ICollection<SugarOptions> SugarOptions { get; set; }
        public ICollection<Toppings> Toppings { get; set; }
    }
}
