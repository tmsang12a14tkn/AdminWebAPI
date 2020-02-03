using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class PromotionDrinkSettings
    {
        public PromotionDrinkSettings()
        {
            PromotionDrinks = new HashSet<PromotionDrinks>();
        }

        public int PromotionId { get; set; }
        public int PromotionGiftType { get; set; }
        public bool ConditionMinMoney { get; set; }
        public int ConditionMinMoneyValue { get; set; }
        public bool ConditionMinDrink { get; set; }
        public int ConditionMinDrinkValue { get; set; }
        public bool ConditionTopping { get; set; }
        public bool ConditionWithTopping { get; set; }
        public int PromotionDrinkQuantity { get; set; }
        public bool ApplyOneTimeOrRepeat { get; set; }
        public bool PromotionForm { get; set; }
        public bool PromotionDrinkRandom { get; set; }
        public int PromotionDrinkBuyQuantity { get; set; }
        public int PromotionDrinkGiveQuantity { get; set; }

        public virtual Promotions Promotion { get; set; }
        public virtual ICollection<PromotionDrinks> PromotionDrinks { get; set; }
    }
}
