using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class NotifyPopups
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public bool IsAllowOrder { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? StartDate { get; set; }
        public bool IsActive { get; set; }
    }
}
