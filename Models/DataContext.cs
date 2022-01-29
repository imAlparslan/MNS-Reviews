using Microsoft.EntityFrameworkCore;

namespace MNS_Reviews.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> option) : base(option) { }
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test2");
        }
        */

        public DbSet<Deneme> denemes { get; set; }
        public DbSet<Movie> movies { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<Review> reviews { get; set; }
        public DbSet<Serie> series { get; set; }
        public DbSet<Trailer> trailers { get; set; }

        public DbSet<User> users { get; set; }

        public DbSet<Comment> comments { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().ToTable("Movie");
            modelBuilder.Entity<Review>().ToTable("Review");
            modelBuilder.Entity<Serie>().ToTable("Serie");
            modelBuilder.Entity<Trailer>().ToTable("Trailer");
            modelBuilder.Entity<Comment>().ToTable("Comments");
        }

    }
}