using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class PrivatePromotionDrinkSettings
    {
        public PrivatePromotionDrinkSettings()
        {
            PrivatePromotionDrinks = new HashSet<PrivatePromotionDrinks>();
        }

        public int PrivatePromotionId { get; set; }
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
        public int FixedFreeDrinkQuantity { get; set; }
        public int FreeDrinkOrderPrice { get; set; }

        public PrivatePromotions PrivatePromotion { get; set; }
        public ICollection<PrivatePromotionDrinks> PrivatePromotionDrinks { get; set; }
    }
}
