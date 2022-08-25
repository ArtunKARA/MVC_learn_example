using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LrnEFCore.DataBaseFirst.DAL
{
    public class AppDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; } //Databaseden Products tablosuna eriştik Product üzwerinde işlem yapılır hale getirdik
        public AppDbContext() //Database üzerinde ayar yapmıyacaksak ise ctor
        {                
        }
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)//Database üzerinde ayarlar yapılacaksa çalışacak ctor
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DbContextInitializer.Configuration.GetConnectionString("SqlCon"));
        }
       
    }
}
