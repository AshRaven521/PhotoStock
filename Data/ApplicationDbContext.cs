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
    }
}