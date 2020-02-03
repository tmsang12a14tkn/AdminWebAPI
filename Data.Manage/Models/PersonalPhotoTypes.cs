using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class PersonalPhotoTypes
    {
        public PersonalPhotoTypes()
        {
            PersonalPhotos = new HashSet<PersonalPhotos>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public ICollection<PersonalPhotos> PersonalPhotos { get; set; }
    }
}
