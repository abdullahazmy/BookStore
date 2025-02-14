using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Models
{
    public class BookStoreDbContext : IdentityDbContext
    {
        public BookStoreDbContext()
        {
        }

        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Catalog> Catalogs { get; set; }
        public virtual DbSet<Author> Authors { get; set; }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }

        public virtual DbSet<Admin> Admins { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OrderDetails>(o =>
            {
                o.HasKey(od => new { od.OrderId, od.BookId });
                //o.HasOne(od => od.Order)
                //    .WithMany(o => o.OrderDetails)
                //    .HasForeignKey(od => od.OrderId);
                //o.HasOne(od => od.Book)
                //    .WithMany(b => b.OrderDetails)
                //    .HasForeignKey(od => od.BookId);
            });

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "Customer",
                    NormalizedName = "CUSTOMER"
                }
            );

        }

    }
}
