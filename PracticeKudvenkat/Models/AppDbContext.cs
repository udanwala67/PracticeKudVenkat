using Microsoft.EntityFrameworkCore;

namespace PracticeKudvenkat.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
        public DbSet<Employee> employees { get; set; }
    }
}
