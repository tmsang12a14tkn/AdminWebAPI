using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class PrivatePromotionCodes
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int MaxUseCode { get; set; }
        public int CurrentUseCode { get; set; }
        public bool IsInfinityUse { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsInfinityTime { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CodeComment { get; set; }
        public bool IsDeleted { get; set; }
        public int PrivatePromotionId { get; set; }
        public bool Status { get; set; }

        public virtual PrivatePromotions PrivatePromotion { get; set; }
    }
}
