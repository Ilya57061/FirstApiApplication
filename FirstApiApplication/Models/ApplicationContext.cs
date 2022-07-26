using Microsoft.EntityFrameworkCore;

namespace FirstApiApplication.Models
{
    public class ApplicationContext:DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Company> Сompanies { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(new Company { Id = 1, Name = "Company1" });
            modelBuilder.Entity<User>().HasData(new User {Id=1, Name="User1", CompanyId=1 });
        }
        
    }
}
