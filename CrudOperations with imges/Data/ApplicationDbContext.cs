using CrudHoor.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudHoor.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base (options)
            {
        
        }

            public DbSet<User> Users { get; set; }
    }
    
}
