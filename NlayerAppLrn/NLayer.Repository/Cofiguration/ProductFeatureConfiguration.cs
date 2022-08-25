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
    public class ProductFeatureConfiguration : IEntityTypeConfiguration<ProductFeature>
    {
     public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasKey(x => x.Id);// bahsedilen değişkenin pirimary key olarak kabul eder
            builder.Property(x => x.Id).UseIdentityColumn(1,1);//default olarak 1 er 1 er keyi atırır
            builder.HasOne(x => x.Product).WithOne(x => x.ProductFeature).HasForeignKey<ProductFeature>(x => x.ProductId);
        }
    }
}
