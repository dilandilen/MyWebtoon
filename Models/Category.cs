﻿using System.Collections.Generic;

namespace MyWebtoon.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Webtoon> Webtoons { get; set; }
    }
}
