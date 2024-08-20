using MyWebtoon.Models;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace MyWebtoon.Models
{
    public class Chapter
    {
        public int ChapterId { get; set; }
        public int WebtoonId { get; set; }
        public string Title { get; set; }
        public int ChapterNumber { get; set; }
        public string Content { get; set; } // HTML veya metin olarak
        public DateTime UploadDate { get; set; }
        public int EditorId { get; set; }
        public int TranslatorId { get; set; }
        public int ProofreaderId { get; set; }

        public Webtoon Webtoon { get; set; }
        public AppUser Editor { get; set; }
        public AppUser Translator { get; set; }
        public AppUser Proofreader { get; set; }

        public ICollection<Image> Images { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Like> Likes { get; set; }
    }
}
