using Library.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data.DBContexts
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Reader> Readers { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Book>().HasData(new Book { Id = 1, Title = "Microsoft Azure Essentials", Author = "Scott Duffy", Version = 1 });
        //    modelBuilder.Entity<Reader>().HasData(new Reader { Id = 1, Name = "John Doe", BookId = 1 });
        //    base.OnModelCreating(modelBuilder);
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Source=C:\\sqlitedemo.db");
    }
}
