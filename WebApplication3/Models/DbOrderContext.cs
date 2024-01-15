using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models
{
    public class DbOrderContext : DbContext
    {
        public DbOrderContext(DbContextOptions<DbOrderContext> options) : base(options)
        {
            
        }

        public DbSet<DbOrder> Order { get; set; }
    }
}
