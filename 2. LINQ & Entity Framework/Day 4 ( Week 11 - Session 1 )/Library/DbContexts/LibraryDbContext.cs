using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.DbContexts
{
    internal class LibraryDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<Loan> Loans { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=LibraryDB; Trusted_Connection=True; TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Loan>(D =>
            {
                D.HasKey(l => new { l.Id });

                D.HasOne(l => l.Book)
                 .WithMany(b => b.Loans)
                 .HasForeignKey(l => l.BookId);

                D.HasOne(l => l.Borrower)
                 .WithMany(b => b.Loans)
                 .HasForeignKey(l => l.BorrowerId);
            });
        }
    }
}
