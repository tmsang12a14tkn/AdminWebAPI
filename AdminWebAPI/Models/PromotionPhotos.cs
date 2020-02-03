using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class PromotionPhotos
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string PhysicalPath { get; set; }
        public bool IsPrimary { get; set; }
        public int PromotionId { get; set; }

        public virtual Promotions Promotion { get; set; }
    }
}
