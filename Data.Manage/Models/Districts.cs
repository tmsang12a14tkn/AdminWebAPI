using System;
using System.Collections.Generic;

namespace Data.Manage.Models
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

        public Cities City { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
