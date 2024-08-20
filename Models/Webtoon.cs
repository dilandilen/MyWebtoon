using MyWebtoon.Models;
using System;
using System.Collections.Generic;

namespace MyWebtoon.Models
{
    public class Webtoon
    {
        public int WebtoonId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } // Örn: Drama, Komedi, Aksiyon
        public string Status { get; set; } // Örn: Devam ediyor, Tamamlandı
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<Chapter> Chapters { get; set; }
    }
}
