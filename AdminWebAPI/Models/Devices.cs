using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class Devices
    {
        public int Id { get; set; }
        public string PushEndpoint { get; set; }
        public string PushP256dh { get; set; }
        public string PushAuth { get; set; }
    }
}
