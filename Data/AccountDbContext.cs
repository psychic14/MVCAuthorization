using Microsoft.EntityFrameworkCore;
using MVCAuthorization.Models;

namespace MVCAuthorization.Data
{
    public class AccountDbContext : DbContext
    {
        public AccountDbContext(DbContextOptions<AccountDbContext> options) : base(options)
        { 
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().ToTable("table_Member");
            modelBuilder.Entity<Member>().HasKey(u => u.Id);
            modelBuilder.Entity<Member>().Property(u=>u.UserId).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Member>().Property(u=>u.Password).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Member>().Property(u => u.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Member>().Property(u=>u.Email).HasMaxLength(50).IsRequired();

        }
    }
}
