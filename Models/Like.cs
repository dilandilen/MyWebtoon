using System;

namespace MyWebtoon.Models
{
    public class Like
    {
        public int LikeId { get; set; }
        public int UserId { get; set; }
        public int ChapterId { get; set; }
        public DateTime LikeDate { get; set; }

        public AppUser User { get; set; }
        public Chapter Chapter { get; set; }
    }
}
