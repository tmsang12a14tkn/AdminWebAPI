using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Manage
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
