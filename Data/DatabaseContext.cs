using InventryManageMent.Models;
using Microsoft.EntityFrameworkCore;

namespace InventryManageMent.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<InventoryItem> InventoryItems { get; set; }

        public DbSet<User> User { get; set; }
    }
}
