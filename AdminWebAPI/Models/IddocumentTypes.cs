using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class IddocumentTypes
    {
        public IddocumentTypes()
        {
            Iddocuments = new HashSet<Iddocuments>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public virtual ICollection<Iddocuments> Iddocuments { get; set; }
    }
}
