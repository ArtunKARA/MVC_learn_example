using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LrnEFCoreCodeFirst.DAL
{
    public class DbContextInitalizer
    {
        public static IConfigurationRoot Configuration;
        public static void Build()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                     
            Configuration = builder.Build();
            
            
        }

    }
}
