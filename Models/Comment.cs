using System;

namespace MyWebtoon.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int UserId { get; set; }
        public int ChapterId { get; set; }
        public string Content { get; set; }
        public DateTime CommentDate { get; set; }

        public AppUser User { get; set; }
        public Chapter Chapter { get; set; }
    }
}
