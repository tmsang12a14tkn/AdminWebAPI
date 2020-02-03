using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class Cities
    {
        public Cities()
        {
            Districts = new HashSet<Districts>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string MatchingNames { get; set; }

        public ICollection<Districts> Districts { get; set; }
    }
}
