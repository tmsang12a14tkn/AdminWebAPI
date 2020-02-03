using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class Districts
    {
        public Districts()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }

        public virtual Cities City { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
