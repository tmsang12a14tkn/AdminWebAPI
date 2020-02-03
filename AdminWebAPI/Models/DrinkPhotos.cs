using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class DrinkPhotos
    {
        public int Id { get; set; }
        public int DrinkId { get; set; }
        public bool IsPrimary { get; set; }
        public string PhysicalPath { get; set; }
        public string Url { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Drinks Drink { get; set; }
    }
}
