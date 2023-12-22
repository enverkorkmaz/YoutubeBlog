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
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");
            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("89051764-0BAF-4754-BD6F-507EBFB3C2D5"),
                RoleId = Guid.Parse("20E01782-4364-4CE0-9F8F-DA46ED8569D4")
            },
            new AppUserRole
            {
                UserId = Guid.Parse("80A87E05-EB55-4E5E-B26E-673C3B842CB6"),
                RoleId= Guid.Parse("2A22DF52-E2D9-4716-A19B-0972E201C99E")
            }
            );;
        }
    }
}
