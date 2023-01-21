using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WeekProject.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("BookCon")
        {

        }

        //Table Mapping
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}