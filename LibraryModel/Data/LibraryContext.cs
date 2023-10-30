using System;
using Microsoft.EntityFrameworkCore;
using Pasca_Andrei_Alexandru_Lab2.Models;

namespace LibraryModel.Data
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
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<PublishedBook> PublishedBooks { get; set; }

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
            modelBuilder.Entity<Publisher>().ToTable("Publisher");
            modelBuilder.Entity<PublishedBook>().ToTable("PublishedBook");
            modelBuilder.Entity<PublishedBook>()
            .HasKey(c => new { c.BookID, c.PublisherID });
        }

    }
}
