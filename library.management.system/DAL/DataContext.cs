using library.management.system.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net;

namespace library.management.system.DAL
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
         : base(options)
        {
        }
        public virtual DbSet<Book> book { get; set; }
    }
}
