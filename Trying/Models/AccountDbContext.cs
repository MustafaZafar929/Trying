using Microsoft.EntityFrameworkCore;

namespace Trying.Models
{
    public class AccountDbContext : DbContext
    {
        public AccountDbContext(DbContextOptions<AccountDbContext> options) : base(options)

        {

        }

        public DbSet<Account> accounts { get; set; }
        
    }
}
