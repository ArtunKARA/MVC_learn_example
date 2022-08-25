using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Cofiguration.Seed
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id=1,
                CategoryID=1,
                Name="Kalem1",
                Price=100,
                Stock=20,
                CreatedDate=DateTime.Now
            }, new Product
            {
                Id = 2,
                CategoryID = 1,
                Name = "Kalem2",
                Price = 100,
                Stock = 30,
                CreatedDate = DateTime.Now
            }, new Product
            {
                Id = 3,
                CategoryID = 1,
                Name = "Kalem3",
                Price = 130,
                Stock = 40,
                CreatedDate = DateTime.Now
            }, new Product
            {
                Id = 1,
                CategoryID = 2,
                Name = "Kitap1",
                Price = 1223,
                Stock = 1234,
                CreatedDate = DateTime.Now
            }, new Product
            {
                Id = 1,
                CategoryID = 2,
                Name = "Kitap2",
                Price = 135,
                Stock = 4430,
                CreatedDate = DateTime.Now
            }




            );

        }
    }
}
