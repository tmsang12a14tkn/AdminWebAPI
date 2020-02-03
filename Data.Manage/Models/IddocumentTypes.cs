using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class IddocumentTypes
    {
        public IddocumentTypes()
        {
            Iddocuments = new HashSet<Iddocuments>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public ICollection<Iddocuments> Iddocuments { get; set; }
    }
}
