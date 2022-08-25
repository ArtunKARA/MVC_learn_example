using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Cofiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);//bahsedilen değişkenin pirimary key olarak kabul eder
            builder.Property(x=> x.Id).UseIdentityColumn(); ;//default olarak 1 er 1 er keyi atırır
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);//name değişkenini gerkli kıklar daha sonra bu değişkeni de max 200 karakter olacak şekilde sınırlar
            builder.Property(x => x.Stock).IsRequired();//Stock değişkenini gerkli kıklar
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2)");//Price değişkenini gerkli kıklar ve tipin,n decimal yaapar
            builder.ToTable("Products");//tablonun adını belirler
            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryID);//kategory product bağlağlanır (category.proct) şeklinde id lokasyonu
        }
    }
}
