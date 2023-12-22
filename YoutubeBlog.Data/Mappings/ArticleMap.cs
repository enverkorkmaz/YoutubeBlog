using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "ASP.NET CORE DENEME MAKALESİ 1",
                Content = "Ormanda dolaşan küçük tavşan, rengarenk çiçekleri keşfetti. Masmavi gökyüzü altında sevinçle zıplayan tavşan, kuş cıvıltıları arasında kayboldu. Doğanın gizemine şahit olan tavşan, içsel huzur buldu.",
                ViewCount = 15,
                CategoryId = Guid.Parse("7FE1427A-6079-4699-A48F-8E52BE0B41A9"),
                ImageId = Guid.Parse("CB071202-B4B4-4B2D-B86B-A8A4441617BD"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                UserId = Guid.Parse("89051764-0BAF-4754-BD6F-507EBFB3C2D5")

            }, new Article
            {
                Id = Guid.NewGuid(),
                Title = "ASP.NET CORE DENEME MAKALESİ 2",
                Content = "Ormanda dolaşan küçük tavşan, rengarenk çiçekleri keşfetti. Masmavi gökyüzü altında sevinçle zıplayan tavşan, kuş cıvıltıları arasında kayboldu. Doğanın gizemine şahit olan tavşan, içsel huzur buldu.",
                ViewCount = 15,
                CategoryId = Guid.Parse("742851E4-12AA-49BF-B967-A3939D275173"),
                ImageId = Guid.Parse("F640303D-9F3B-442C-BDFD-070A2F7FE5EB"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                UserId = Guid.Parse("80A87E05-EB55-4E5E-B26E-673C3B842CB6")
            }
            );
        }
    }
}
