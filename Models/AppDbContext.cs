using Microsoft.EntityFrameworkCore;

namespace buffteks.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = buffteks.db;");
        }
    }
}