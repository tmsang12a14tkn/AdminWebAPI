using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class VehiclePhotos
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int VehicleInfoId { get; set; }

        public VehicleInfos VehicleInfo { get; set; }
    }
}
