using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class ControllerActions
    {
        public ControllerActions()
        {
            ControllerActionPermissions = new HashSet<ControllerActionPermissions>();
        }

        public int Id { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string Params { get; set; }
        public string MenuGroup { get; set; }
        public string Site { get; set; }
        public string Description { get; set; }
        public bool? IsShow { get; set; }

        public virtual ICollection<ControllerActionPermissions> ControllerActionPermissions { get; set; }
    }
}
