﻿using Microsoft.EntityFrameworkCore;
using System;

namespace NetCoreCodeMazePart2WorkingWithData.Models
{
    public class NetCoreCodeMazePart2WorkingWithDataContext : DbContext
    {
        public NetCoreCodeMazePart2WorkingWithDataContext (DbContextOptions<NetCoreCodeMazePart2WorkingWithDataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 1,
                Title = "Book1",
                Genre = "Genre1",
                Price = 20,
                PublishDate = new DateTime(2012, 4, 23)
            }, new Book
            {
                Id = 2,
                Title = "Book2",
                Genre = "Genre2",
                Price = 30,
                PublishDate = new DateTime(2008, 6, 13)
            });
        }

        public DbSet<Book> Book { get; set; }
    }
}
