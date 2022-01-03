using Microsoft.EntityFrameworkCore;

namespace EFCoreMigrations.Model
{
    public class ApplicationDbContext : DbContext
    {
        const string connectionString = "Data Source=migrationsTest.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test");
            optionsBuilder.UseSqlite(connectionString);
        }

        public DbSet<Blog> Blogs { get; private set; }
    }
}
