using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class Promotions
    {
        public Promotions()
        {
            PromotionApplyHours = new HashSet<PromotionApplyHours>();
            PromotionPhotos = new HashSet<PromotionPhotos>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PromotionCode { get; set; }
        public bool ApplyWithOther { get; set; }
        public int ApplyTimeType { get; set; }
        public DateTime? ApplyFromDate { get; set; }
        public DateTime? ApplyToDate { get; set; }
        public int? ApplyDayOfWeek { get; set; }
        public int ApplyFor { get; set; }
        public int ApplyRule { get; set; }
        public int DiscountType { get; set; }
        public int DiscountValue { get; set; }
        public bool IsActive { get; set; }
        public bool AutoPromotion { get; set; }
        public int MaxDiscountMoney { get; set; }
        public int MinMoney { get; set; }

        public PromotionDrinkSettings PromotionDrinkSettings { get; set; }
        public ICollection<PromotionApplyHours> PromotionApplyHours { get; set; }
        public ICollection<PromotionPhotos> PromotionPhotos { get; set; }
    }
}
