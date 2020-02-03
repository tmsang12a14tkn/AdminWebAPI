using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Manage.Entities
{
    public class ChartCategoryInfoEnt
    {
        public List<DateTime> labelDatesDT { get; set; }
        public List<string> labelDates { get; set; }
        public List<ChartDataEnt> chartDatas { get; set; }
        public ChartCategoryInfoEnt()
        {
            labelDatesDT = new List<DateTime>();
            labelDates = new List<string>();
            chartDatas = new List<ChartDataEnt>();
        }
    }
}
