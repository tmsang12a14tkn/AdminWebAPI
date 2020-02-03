using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class ControllerActionPermissions
    {
        public int ControllerActionId { get; set; }
        public string RoleId { get; set; }

        public virtual ControllerActions ControllerAction { get; set; }
        //public virtual AspNetRoles Role { get; set; }
    }
}
