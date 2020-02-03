using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class DrinkCategoryPhotos
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string PhysicalPath { get; set; }
        public bool IsPrimary { get; set; }
        public int DrinkCategoryId { get; set; }

        public virtual DrinkCategories DrinkCategory { get; set; }
    }
}
