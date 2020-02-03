using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class PersonalPhotoTypes
    {
        public PersonalPhotoTypes()
        {
            PersonalPhotos = new HashSet<PersonalPhotos>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public virtual ICollection<PersonalPhotos> PersonalPhotos { get; set; }
    }
}
