using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class Idcards
    {
        public int Id { get; set; }
        public string Idnumber { get; set; }
        public string ProvidedDate { get; set; }
        public string ExpriredDate { get; set; }
        public string ProvidedPlace { get; set; }
        public int PersonId { get; set; }

        public virtual Persons Person { get; set; }
    }
}
