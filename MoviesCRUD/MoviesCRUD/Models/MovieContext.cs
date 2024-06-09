using System.Data.Entity;

namespace MoviesCRUD.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base("name=MoviesDBConnectionString") { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Category> MoviesCategories { get; set; } 
        public DbSet<MovieReview> MovieReviews { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure relationships
            modelBuilder.Entity<Movie>()
                .HasRequired(m => m.Category) 
                .WithMany()
                .HasForeignKey(m => m.MovieCategoryID);

            modelBuilder.Entity<Movie>()
                .HasRequired(m => m.Review) 
                .WithRequiredPrincipal(r => r.Movie);

            modelBuilder.Entity<Director>()
                .HasRequired(d => d.Nationality) 
                .WithMany()
                .HasForeignKey(d => d.NationalityID);
        }
    }
}
