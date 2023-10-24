using System;
using Microsoft.EntityFrameworkCore;
using Pasca_Andrei_Alexandru_Lab2.Models;

namespace Pasca_Andrei_Alexandru_Lab2.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Author>().ToTable("Author");
            modelBuilder.Entity<Book>().ToTable("Book")
                .HasOne(b => b.Author)
                .WithMany()
                .HasForeignKey(b => b.AuthorID);
            modelBuilder.Entity<Order>()
                .Property(o => o.OrderDate);
        }

    }
}
