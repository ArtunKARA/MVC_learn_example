using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LrnEFCore.DataBaseFirst.DAL
{

    public class DbContextInitializer
    {
        public static IConfigurationRoot Configuration; //jason daosyasını okumak için 
        public static DbContextOptionsBuilder<AppDbContext> OptionsBuilder; //AppDbContext içinveri Tabanı için ayarlar yaparken kullanıcağımız nesne

        public static void Build()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            //builder nesensine                    //OkunacakDosyaYolu(yolun kendisi)/ JasonDosyasıEklenmesei(EklenecekJsonDosyası, DosyanınOlmaDurumu,DosyaTekrardanYüklenmesi)
            Configuration = builder.Build(); //Configuration arayüzünden veritanbanını ayarlarını inşa ediyoruz
            OptionsBuilder = new DbContextOptionsBuilder<AppDbContext>();//Nesne örneği oluşturma       
            OptionsBuilder.UseSqlServer(Configuration.GetConnectionString("SqlCon"));
            //SqlServerİçinAyarlarıKuruyoruz(ConfigurationNesnesiÜstünden.ConnectionStringlereGidilecek("GidilecekKey"))
        }
    }
}
