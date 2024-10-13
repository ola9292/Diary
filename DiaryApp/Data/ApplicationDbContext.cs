using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry { 
                    Id=1, 
                    Title="Went Hiking", 
                    Content="Went hiking with joe",
                    Created= DateTime.Now
                },
                new DiaryEntry
                {
                    Id = 2,
                    Title = "Went shopping",
                    Content = "Went shopping with joe",
                    Created = DateTime.Now
                },
                new DiaryEntry
                {
                    Id = 3,
                    Title = "Went swimming",
                    Content = "Went swimming with joe",
                    Created = DateTime.Now
                }
                );
        }
    }
}
