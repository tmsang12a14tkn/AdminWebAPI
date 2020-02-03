using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class CommissionFormulas
    {
        public int Id { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int NewCusCommissionType { get; set; }
        public double NewCusCommissionValue { get; set; }
        public int OldCusCommissionType { get; set; }
        public double OldCusCommissionValue { get; set; }
        public int AreaCommissionType { get; set; }
        public double AreaCommissionValue { get; set; }
        public int AllCommissionType { get; set; }
        public double AllCommissionValue { get; set; }
    }
}
