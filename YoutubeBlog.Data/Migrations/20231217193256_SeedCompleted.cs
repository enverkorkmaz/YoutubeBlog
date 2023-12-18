using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoutubeBlog.Data.Migrations
{
    public partial class SeedCompleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "ısDeleted" },
                values: new object[,]
                {
                    { new Guid("742851e4-12aa-49bf-b967-a3939d275173"), "Admin Test", new DateTime(2023, 12, 17, 22, 32, 56, 109, DateTimeKind.Local).AddTicks(6931), null, null, null, null, "ASP.NET31", false },
                    { new Guid("7fe1427a-6079-4699-a48f-8e52be0b41a9"), "Admin Test", new DateTime(2023, 12, 17, 22, 32, 56, 109, DateTimeKind.Local).AddTicks(6928), null, null, null, null, "ASP.NET Core", false }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "ModifiedBy", "ModifiedDate", "ısDeleted" },
                values: new object[,]
                {
                    { new Guid("cb071202-b4b4-4b2d-b86b-a8a4441617bd"), "admin test", new DateTime(2023, 12, 17, 22, 32, 56, 109, DateTimeKind.Local).AddTicks(7035), null, null, "images/testimage", "jpg", null, null, false },
                    { new Guid("f640303d-9f3b-442c-bdfd-070a2f7fe5eb"), "admin test", new DateTime(2023, 12, 17, 22, 32, 56, 109, DateTimeKind.Local).AddTicks(7038), null, null, "images/testoimage", "jpg", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "ViewCount", "ısDeleted" },
                values: new object[] { new Guid("48591e74-7727-4571-af8a-d49849e13ee2"), new Guid("742851e4-12aa-49bf-b967-a3939d275173"), "Ormanda dolaşan küçük tavşan, rengarenk çiçekleri keşfetti. Masmavi gökyüzü altında sevinçle zıplayan tavşan, kuş cıvıltıları arasında kayboldu. Doğanın gizemine şahit olan tavşan, içsel huzur buldu.", "Admin Test", new DateTime(2023, 12, 17, 22, 32, 56, 109, DateTimeKind.Local).AddTicks(6744), null, null, new Guid("f640303d-9f3b-442c-bdfd-070a2f7fe5eb"), null, null, "ASP.NET CORE DENEME MAKALESİ 2", 15, false });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "ViewCount", "ısDeleted" },
                values: new object[] { new Guid("7d633841-3bc2-4058-a72b-c3ae543d637c"), new Guid("7fe1427a-6079-4699-a48f-8e52be0b41a9"), "Ormanda dolaşan küçük tavşan, rengarenk çiçekleri keşfetti. Masmavi gökyüzü altında sevinçle zıplayan tavşan, kuş cıvıltıları arasında kayboldu. Doğanın gizemine şahit olan tavşan, içsel huzur buldu.", "Admin Test", new DateTime(2023, 12, 17, 22, 32, 56, 109, DateTimeKind.Local).AddTicks(6728), null, null, new Guid("cb071202-b4b4-4b2d-b86b-a8a4441617bd"), null, null, "ASP.NET CORE DENEME MAKALESİ 1", 15, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("48591e74-7727-4571-af8a-d49849e13ee2"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7d633841-3bc2-4058-a72b-c3ae543d637c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("742851e4-12aa-49bf-b967-a3939d275173"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7fe1427a-6079-4699-a48f-8e52be0b41a9"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cb071202-b4b4-4b2d-b86b-a8a4441617bd"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f640303d-9f3b-442c-bdfd-070a2f7fe5eb"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
