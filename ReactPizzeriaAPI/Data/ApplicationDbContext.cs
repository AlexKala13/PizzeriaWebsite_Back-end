using Microsoft.EntityFrameworkCore;
using ReactPizzeriaAPI.Model;

namespace ReactPizzeriaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<User> users => Set<User>();
    }
}
