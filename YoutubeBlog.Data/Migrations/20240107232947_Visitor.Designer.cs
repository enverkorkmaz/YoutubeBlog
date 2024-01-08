﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YoutubeBlog.Data.Context;

#nullable disable

namespace YoutubeBlog.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240107232947_Visitor")]
    partial class Visitor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("20e01782-4364-4ce0-9f8f-da46ed8569d4"),
                            ConcurrencyStamp = "fd36e935-663e-4ead-b9a6-b29d4649bc91",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = new Guid("2a22df52-e2d9-4716-a19b-0972e201c99e"),
                            ConcurrencyStamp = "187a1ea3-acd6-4c36-a455-ce505e55ee82",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("6bd5f88a-77e4-41a8-821d-7fe50fe4ba41"),
                            ConcurrencyStamp = "105b5f9e-3058-4960-a0c3-0215dfad9b1f",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("89051764-0baf-4754-bd6f-507ebfb3c2d5"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "30e1e8fc-8174-4e18-8ae1-9d396257ef7e",
                            Email = "superadmin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Enver",
                            ImageId = new Guid("cb071202-b4b4-4b2d-b86b-a8a4441617bd"),
                            LastName = "Korkmaz",
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                            NormalizedUserName = "SUPERADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECK7awoij9NRDVMxApi5Pc8WXwrGX+gA3R6cY2isgCmUFCLMZpcQSKTxo3AGPpFSKw==",
                            PhoneNumber = "+905418395771",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "fcf25dfc-9643-418d-8252-9b3a9fe744ef",
                            TwoFactorEnabled = false,
                            UserName = "superadmin@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("80a87e05-eb55-4e5e-b26e-673c3b842cb6"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e482b57e-2545-4a08-abd5-eae6de02809e",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            ImageId = new Guid("f640303d-9f3b-442c-bdfd-070a2f7fe5eb"),
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAu/Wxh5MpC5Yx+FhSXzyEy6jjCfH2Tr4FrSU1HUKWi30sJ+TlzKKhG3imOVIfUnig==",
                            PhoneNumber = "+905418395772",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8cf85e1c-c9c3-49d7-b2fc-0c81dfb49f33",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        });
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("89051764-0baf-4754-bd6f-507ebfb3c2d5"),
                            RoleId = new Guid("20e01782-4364-4ce0-9f8f-da46ed8569d4")
                        },
                        new
                        {
                            UserId = new Guid("80a87e05-eb55-4e5e-b26e-673c3b842cb6"),
                            RoleId = new Guid("2a22df52-e2d9-4716-a19b-0972e201c99e")
                        });
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.Property<bool>("ısDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5a60a8ed-7cab-4d2c-89ee-058ee99d8f4f"),
                            CategoryId = new Guid("7fe1427a-6079-4699-a48f-8e52be0b41a9"),
                            Content = "Ormanda dolaşan küçük tavşan, rengarenk çiçekleri keşfetti. Masmavi gökyüzü altında sevinçle zıplayan tavşan, kuş cıvıltıları arasında kayboldu. Doğanın gizemine şahit olan tavşan, içsel huzur buldu.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 1, 8, 2, 29, 47, 170, DateTimeKind.Local).AddTicks(7782),
                            ImageId = new Guid("cb071202-b4b4-4b2d-b86b-a8a4441617bd"),
                            Title = "ASP.NET CORE DENEME MAKALESİ 1",
                            UserId = new Guid("89051764-0baf-4754-bd6f-507ebfb3c2d5"),
                            ViewCount = 15,
                            ısDeleted = false
                        },
                        new
                        {
                            Id = new Guid("c7b6d04e-4c0a-441d-b20d-4ec77ca1f379"),
                            CategoryId = new Guid("742851e4-12aa-49bf-b967-a3939d275173"),
                            Content = "Ormanda dolaşan küçük tavşan, rengarenk çiçekleri keşfetti. Masmavi gökyüzü altında sevinçle zıplayan tavşan, kuş cıvıltıları arasında kayboldu. Doğanın gizemine şahit olan tavşan, içsel huzur buldu.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 1, 8, 2, 29, 47, 170, DateTimeKind.Local).AddTicks(7789),
                            ImageId = new Guid("f640303d-9f3b-442c-bdfd-070a2f7fe5eb"),
                            Title = "ASP.NET CORE DENEME MAKALESİ 2",
                            UserId = new Guid("80a87e05-eb55-4e5e-b26e-673c3b842cb6"),
                            ViewCount = 15,
                            ısDeleted = false
                        });
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.ArticleVisitor", b =>
                {
                    b.Property<Guid>("ArticleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("VisitorId")
                        .HasColumnType("int");

                    b.HasKey("ArticleId", "VisitorId");

                    b.HasIndex("VisitorId");

                    b.ToTable("ArticleVisitors");
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ısDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7fe1427a-6079-4699-a48f-8e52be0b41a9"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 1, 8, 2, 29, 47, 171, DateTimeKind.Local).AddTicks(735),
                            Name = "ASP.NET Core",
                            ısDeleted = false
                        },
                        new
                        {
                            Id = new Guid("742851e4-12aa-49bf-b967-a3939d275173"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 1, 8, 2, 29, 47, 171, DateTimeKind.Local).AddTicks(739),
                            Name = "ASP.NET31",
                            ısDeleted = false
                        });
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("ısDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cb071202-b4b4-4b2d-b86b-a8a4441617bd"),
                            CreatedBy = "admin test",
                            CreatedDate = new DateTime(2024, 1, 8, 2, 29, 47, 171, DateTimeKind.Local).AddTicks(865),
                            FileName = "images/testimage",
                            FileType = "jpg",
                            ısDeleted = false
                        },
                        new
                        {
                            Id = new Guid("f640303d-9f3b-442c-bdfd-070a2f7fe5eb"),
                            CreatedBy = "admin test",
                            CreatedDate = new DateTime(2024, 1, 8, 2, 29, 47, 171, DateTimeKind.Local).AddTicks(869),
                            FileName = "images/testoimage",
                            FileType = "jpg",
                            ısDeleted = false
                        });
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.Visitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IpAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserAgent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Visitors");
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppRoleClaim", b =>
                {
                    b.HasOne("YoutubeBlog.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppUser", b =>
                {
                    b.HasOne("YoutubeBlog.Entity.Entities.Image", "Image")
                        .WithMany("Users")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppUserClaim", b =>
                {
                    b.HasOne("YoutubeBlog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppUserLogin", b =>
                {
                    b.HasOne("YoutubeBlog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppUserRole", b =>
                {
                    b.HasOne("YoutubeBlog.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YoutubeBlog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppUserToken", b =>
                {
                    b.HasOne("YoutubeBlog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.Article", b =>
                {
                    b.HasOne("YoutubeBlog.Entity.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YoutubeBlog.Entity.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId");

                    b.HasOne("YoutubeBlog.Entity.Entities.AppUser", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");

                    b.Navigation("User");
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.ArticleVisitor", b =>
                {
                    b.HasOne("YoutubeBlog.Entity.Entities.Article", "Article")
                        .WithMany("ArticleVisitors")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YoutubeBlog.Entity.Entities.Visitor", "Visitor")
                        .WithMany("ArticleVisitors")
                        .HasForeignKey("VisitorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Visitor");
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppUser", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.Article", b =>
                {
                    b.Navigation("ArticleVisitors");
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.Image", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.Visitor", b =>
                {
                    b.Navigation("ArticleVisitors");
                });
#pragma warning restore 612, 618
        }
    }
}
