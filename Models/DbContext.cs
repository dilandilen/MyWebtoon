using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyWebtoon.Models
{
    public class AppDbContext:IdentityDbContext<AppUser, AppRole, string>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {
        }
       public DbSet<Category>Categories { get; set; }
        public DbSet<Chapter> Chapters { get; set; }

        public DbSet<Comment> Comments { get; set; }


        public DbSet<Like>Likes { get; set; }

        public DbSet<Image> Images { get; set; }
        public DbSet<Webtoon> Webtoons { get; set; }




    }
}


     
