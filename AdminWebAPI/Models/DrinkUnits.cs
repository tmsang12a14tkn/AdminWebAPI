using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
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

        public virtual ICollection<DrinkSizes> DrinkSizes { get; set; }
        public virtual ICollection<IceOptions> IceOptions { get; set; }
        public virtual ICollection<SugarOptions> SugarOptions { get; set; }
        public virtual ICollection<Toppings> Toppings { get; set; }
    }
}
