using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("7FE1427A-6079-4699-A48F-8E52BE0B41A9"),
                Name = "ASP.NET Core",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                ısDeleted = false
            },
             new Category
             {
                 Id = Guid.Parse("742851E4-12AA-49BF-B967-A3939D275173"),
                 Name = "ASP.NET31",
                 CreatedBy = "Admin Test",
                 CreatedDate = DateTime.Now,
                 ısDeleted = false
             }
            );




        }
    }
}
