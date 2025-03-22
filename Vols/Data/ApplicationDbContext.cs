using Microsoft.EntityFrameworkCore;
using Vols.Models;

namespace Vols.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Mobile" },
                new Category { Id = 2, Name = "Laptop" }
                );
        }
    }
}
