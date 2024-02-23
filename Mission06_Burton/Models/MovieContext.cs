using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Mission06_Burton.Models;

namespace Mission06_Burton.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base (options) 
        { 
        }

        public DbSet<AddMovie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(

                new Category { CategoryID = 1, CategoryName = "Action"},
                new Category { CategoryID = 1, CategoryName = "Romance" },
                new Category { CategoryID = 1, CategoryName = "Comedy" },
                new Category { CategoryID = 1, CategoryName = "Thriller" },
                new Category { CategoryID = 1, CategoryName = "Musical" },
                new Category { CategoryID = 1, CategoryName = "Documentary" }

            );
        }
    }
}
