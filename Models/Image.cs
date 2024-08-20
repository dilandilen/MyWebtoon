namespace MyWebtoon.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public int ChapterId { get; set; }
        public string ImageUrl { get; set; }
        public int Order { get; set; }

        public Chapter Chapter { get; set; }
    }
}
