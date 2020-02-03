using AdminWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminWebAPI.Entities
{
    public class UpdateOrderCustomerEnt
    {
        public int? agencyType { get; set; }
        public int? id { get; set; }
        public List<Orders> orders { get; set; }

    }
}
