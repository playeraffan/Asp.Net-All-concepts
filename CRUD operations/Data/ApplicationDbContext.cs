using Microsoft.EntityFrameworkCore;
using CRUD_operations.Models.Entities;

namespace CRUD_operations.Data

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        public DbSet<Students> Students { get; set; }
    }
}
