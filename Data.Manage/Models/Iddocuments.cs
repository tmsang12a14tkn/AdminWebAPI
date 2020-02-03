using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class Iddocuments
    {
        public int Id { get; set; }
        public int? IddocumentTypeId { get; set; }
        public string Idnumber { get; set; }
        public string ProvidedDate { get; set; }
        public string ExpriredDate { get; set; }
        public string ProvidedPlace { get; set; }
        public int PersonId { get; set; }

        public IddocumentTypes IddocumentType { get; set; }
        public Persons Person { get; set; }
    }
}
