﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practive_shop.Models
{
    public class Pie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnail { get; set; }
        public bool IsPieOfTheWeek { get; set; }
        public bool IsInStock { get; set; }

    }
}
