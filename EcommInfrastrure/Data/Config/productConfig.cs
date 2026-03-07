using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommCore.Entites.product;
namespace EcommInfrastrure.Data.Config
{
    public class productConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.price).HasColumnType("decimal(18,2)");
            builder.HasData(
                new Product
                {
                    id = 1,
                    Name = "Product 1",
                    Description = "Description for Product 1",
                    price = 10.99m,
                    CategoryId = 1
                }
            );


        }
    }
}
