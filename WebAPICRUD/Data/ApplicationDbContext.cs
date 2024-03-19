using Microsoft.EntityFrameworkCore;
using WebAPICRUD.Models;

namespace WebAPICRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Product> Products { get; set; }    
    }
}
