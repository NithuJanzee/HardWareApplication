using HardWareApplication.Entity;
using Microsoft.EntityFrameworkCore;

namespace HardWareApplication.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<UserAccounts> userAccounts { get; set; }
    }
}
