using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class PromotionApplyHours
    {
        public int Id { get; set; }
        public int PromotionId { get; set; }
        public TimeSpan From { get; set; }
        public TimeSpan To { get; set; }

        public virtual Promotions Promotion { get; set; }
    }
}
