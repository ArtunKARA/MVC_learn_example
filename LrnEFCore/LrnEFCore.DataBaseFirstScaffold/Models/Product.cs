﻿using System;
using System.Collections.Generic;

namespace LrnEFCore.DataBaseFirstScaffold.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public int? Stock { get; set; }
    }
}
