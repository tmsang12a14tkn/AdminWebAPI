using Data.Manage.Models;
using System.Collections.Generic;

namespace Data.Manage.Entities
{
    public class UpdateOrderCustomerEnt
    {
        public int? agencyType { get; set; }
        public int? id { get; set; }
        public List<Orders> orders { get; set; }

    }
}
