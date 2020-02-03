using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class VehicleInfos
    {
        public VehicleInfos()
        {
            VehiclePhotos = new HashSet<VehiclePhotos>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string VehicleType { get; set; }
        public string Manufacturer { get; set; }
        public string CylinderCapacity { get; set; }
        public string FrameCode { get; set; }
        public string MachineCode { get; set; }
        public string Status { get; set; }
        public string Owner { get; set; }
        public bool IsPrimary { get; set; }
        public string Note { get; set; }
        public int PersonId { get; set; }

        public Persons Person { get; set; }
        public ICollection<VehiclePhotos> VehiclePhotos { get; set; }
    }
}
