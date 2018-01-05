using Books.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Books.Web.DataContexts
{
    public class BooksDb : DbContext
    {
        public BooksDb()
            : base("LocalConnection")
        {

        }

        public DbSet<Book> Books { get; set; }

    }
}