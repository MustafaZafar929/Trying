using Microsoft.EntityFrameworkCore;

namespace Trying.Models
{
    public class AccountDbContext : DbContext
    {
        public AccountDbContext(DbContextOptions<AccountDbContext> options) : base(options)
        {

        }

        public DbSet<Account> Accounts { get; set; } // DbSet for Account entity

        public DbSet<BioData> BioData { get; set; } // DbSet for BioData entity
    }
}


//using Microsoft.EntityFrameworkCore;

//public class AccountDbContext : DbContext
//{
//    public AccountDbContext(DbContextOptions<AccountDbContext> options) : base(options)
//    {
//    }

//    public DbSet<Account> Accounts { get; set; }
//    public DbSet<BioData> BioData { get; set; }

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        modelBuilder.Entity<BioData>()
//            .HasOne(b => b.User)
//            .WithMany(a => a.BioData)
//            .HasForeignKey(b => b.UserId);
//    }
//}

