using Microsoft.EntityFrameworkCore;

namespace APICHETUPROJECT.Models
{
    public class ApplicationDbContext : DbContext
    {
        // Here Inharent DbContext and go to in StartUp.cs
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Users> Users { get; set; } // Users so lets do add-Migration
    }
}