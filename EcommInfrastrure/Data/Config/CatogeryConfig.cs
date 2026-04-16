using EcommCore.Entites;
using EcommCore.Entites.product;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommInfrastrure.Data.Config
{
    public class CatogeryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
           builder.Property(c => c.Name).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Id).IsRequired();
            builder.HasData(
                new Category { Id = 1, Name = "Electronics", Description = "Electronic devices and gadgets" }
               
            );
        }
    }
}
