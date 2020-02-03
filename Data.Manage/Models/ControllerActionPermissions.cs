using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class ControllerActionPermissions
    {
        public int ControllerActionId { get; set; }
        public string RoleId { get; set; }

        public ControllerActions ControllerAction { get; set; }
        //public AspNetRoles Role { get; set; }
    }
}
