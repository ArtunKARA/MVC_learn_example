using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Cofiguration
{
    public class CategoryConfiguration: IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);//bahsedilen değişkenin pirimary key olarak kabul eder
            builder.Property(x => x.Id).UseIdentityColumn();//default olarak 1 er 1 er keyi atırır
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);//name değişkenini gerkli kıklar daha sonra bu değişkeni de max 50 karakter olacak şekilde sınırlar
            builder.ToTable("Categories");//tablonun adını belirler
        }
    }
}
