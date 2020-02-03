using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class PrivatePromotionPhotos
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string PhysicalPath { get; set; }
        public bool IsPrimary { get; set; }
        public int PrivatePromotionId { get; set; }

        public PrivatePromotions PrivatePromotion { get; set; }
    }
}
