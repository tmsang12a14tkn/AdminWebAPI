using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Manage.Entities
{
    public class ChartDataEnt
    {
        public string label { get; set; }
        public List<int> data { get; set; }
        public string backgroundColor { get; set; }
        public ChartDataEnt()
        {
            data = new List<int>();
        }
        
    }
}
