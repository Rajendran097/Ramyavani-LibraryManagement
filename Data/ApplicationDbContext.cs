﻿using LibraryManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace LibraryManagement.Data
{



    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Author> Authors { get; set; }

        public DbSet<Category> Categorys { get; set; }


        public DbSet<Book> Books { get; set; }
        

    }
}


