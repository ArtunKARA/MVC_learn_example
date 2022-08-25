using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LrnEFCoreCodeFirst.DAL
{
    public class AppDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DbContextInitalizer.Build();
            optionsBuilder.UseSqlServer(DbContextInitalizer.Configuration.GetConnectionString("SqlCon"));
        }
    }
}
