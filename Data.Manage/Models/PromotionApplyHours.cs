using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class PromotionApplyHours
    {
        public int Id { get; set; }
        public int PromotionId { get; set; }
        public TimeSpan From { get; set; }
        public TimeSpan To { get; set; }

        public Promotions Promotion { get; set; }
    }
}
