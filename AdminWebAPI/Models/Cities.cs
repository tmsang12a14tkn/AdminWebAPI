using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
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

        public virtual ICollection<Districts> Districts { get; set; }
    }
}
