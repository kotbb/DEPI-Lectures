using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Day3.Models;

namespace Day3.DbContexts
{
    internal class BookstoreDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=BookstoreDB; Trusted_Connection=True; TrustServerCertificate=True;");
        }
        public DbSet <Book> Books { get; set; }
        public DbSet <Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(D =>
            {
                D.Property(b => b.Title)
                 .IsRequired()
                 .HasMaxLength(150);

                D.Property(b => b.Price)
                 .HasColumnType("decimal(8,2)");

                D.Property(b => b.PublishedDate)
                 .IsRequired(false);
            });
        }
    }
}
