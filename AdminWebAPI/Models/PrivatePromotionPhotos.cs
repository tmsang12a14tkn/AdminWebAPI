using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class PrivatePromotionPhotos
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string PhysicalPath { get; set; }
        public bool IsPrimary { get; set; }
        public int PrivatePromotionId { get; set; }

        public virtual PrivatePromotions PrivatePromotion { get; set; }
    }
}
