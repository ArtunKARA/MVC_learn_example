using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace Vidly.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Movie> Categories { get; set; }
        public DbSet<Customer> Products { get; set; }
    }
}