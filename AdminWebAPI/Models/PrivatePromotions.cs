using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class PrivatePromotions
    {
        public PrivatePromotions()
        {
            PrivatePromotionCodes = new HashSet<PrivatePromotionCodes>();
            PrivatePromotionPhotos = new HashSet<PrivatePromotionPhotos>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool ApplyWithOther { get; set; }
        public int ApplyTimeType { get; set; }
        public int ApplyFor { get; set; }
        public int ApplyRule { get; set; }
        public int DiscountType { get; set; }
        public int DiscountValue { get; set; }
        public bool IsActive { get; set; }

        public virtual PrivatePromotionDrinkSettings PrivatePromotionDrinkSettings { get; set; }
        public virtual ICollection<PrivatePromotionCodes> PrivatePromotionCodes { get; set; }
        public virtual ICollection<PrivatePromotionPhotos> PrivatePromotionPhotos { get; set; }
    }
}
