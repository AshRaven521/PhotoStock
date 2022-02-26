using Microsoft.EntityFrameworkCore;
using PhotoStock.Models;

namespace PhotoStock.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Text> Texts { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Photo>().HasOne(b => b.Author).WithOne(p => p.Photo).HasForeignKey<Photo>(a => a.AuthorForeignKey);
            builder.Entity<Text>().HasOne(p => p.Author).WithOne().HasForeignKey<Text>(a => a.AuthorForeignKey);
        }
    }
}