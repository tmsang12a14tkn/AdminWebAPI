using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class VehiclePhotos
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int VehicleInfoId { get; set; }

        public virtual VehicleInfos VehicleInfo { get; set; }
    }
}
