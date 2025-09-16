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
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().ToTable("table_Member");
            modelBuilder.Entity<Member>().HasKey(u => u.Id);
            modelBuilder.Entity<Member>().Property(u=>u.UserId).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Member>().Property(u=>u.Password).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Member>().Property(u => u.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Member>().Property(u=>u.Email).HasMaxLength(50).IsRequired().HasColumnName("Email");

            modelBuilder.Entity<Order>().ToTable("table_Order");
            modelBuilder.Entity<Order>().HasKey(u => u.Id);
            modelBuilder.Entity<Order>().Property(u => u.OrderGuid).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Order>().Property(u => u.UserId).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Order>().Property(u => u.Receiver).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Order>().Property(u => u.Email).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Order>().Property(u => u.Address).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Order>().Property(u => u.Date).HasMaxLength(50).IsRequired();

            modelBuilder.Entity<OrderDetail>().ToTable("table_OrderDetail");
            modelBuilder.Entity<OrderDetail>().HasKey(u => u.Id);
            modelBuilder.Entity<OrderDetail>().Property(u => u.OrderGuid).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<OrderDetail>().Property(u => u.UserId).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<OrderDetail>().Property(u => u.ProductId).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<OrderDetail>().Property(u => u.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<OrderDetail>().Property(u => u.Price).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<OrderDetail>().Property(u => u.Quantity).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<OrderDetail>().Property(u => u.IsApproved).HasMaxLength(50).IsRequired();

            modelBuilder.Entity<Product>().ToTable("table_Product");
            modelBuilder.Entity<Product>().HasKey(u => u.Id);
            modelBuilder.Entity<Product>().Property(u => u.ProductId).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Product>().Property(u => u.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Product>().Property(u => u.Price).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Product>().Property(u => u.Image).HasMaxLength(50).IsRequired();
        }
    }
}
