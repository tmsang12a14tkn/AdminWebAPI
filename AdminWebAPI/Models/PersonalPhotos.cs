using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class PersonalPhotos
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string Url { get; set; }
        public int PersonId { get; set; }
        public bool IsPrimary { get; set; }

        public virtual Persons Person { get; set; }
        public virtual PersonalPhotoTypes Type { get; set; }
    }
}
