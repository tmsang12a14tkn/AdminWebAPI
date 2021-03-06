﻿using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class CategoryIceOption
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsActive { get; set; }
        public int DrinkCategoryId { get; set; }

        public DrinkCategories DrinkCategory { get; set; }
    }
}
