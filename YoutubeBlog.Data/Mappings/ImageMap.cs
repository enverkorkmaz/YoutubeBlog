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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("CB071202-B4B4-4B2D-B86B-A8A4441617BD"),
                FileName = "images/testimage",
                FileType = "jpg",
                CreatedBy = "admin test",
                CreatedDate = DateTime.Now,
                ısDeleted = false

            },
            new Image
            {
                Id = Guid.Parse("F640303D-9F3B-442C-BDFD-070A2F7FE5EB"),
                FileName = "images/testoimage",
                FileType = "jpg",
                CreatedBy = "admin test",
                CreatedDate = DateTime.Now,
                ısDeleted = false

            });
        }
    }
}
