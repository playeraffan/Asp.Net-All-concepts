using Microsoft.EntityFrameworkCore;

namespace Web_Api.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

     public DbSet<Employee> Employees { get; set; }
    }
}
