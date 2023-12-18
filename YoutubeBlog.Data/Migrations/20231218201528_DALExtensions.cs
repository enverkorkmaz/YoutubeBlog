using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoutubeBlog.Data.Migrations
{
    public partial class DALExtensions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("48591e74-7727-4571-af8a-d49849e13ee2"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7d633841-3bc2-4058-a72b-c3ae543d637c"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "ViewCount", "ısDeleted" },
                values: new object[,]
                {
                    { new Guid("204ff876-8e93-44b2-929e-11125511e6a4"), new Guid("742851e4-12aa-49bf-b967-a3939d275173"), "Ormanda dolaşan küçük tavşan, rengarenk çiçekleri keşfetti. Masmavi gökyüzü altında sevinçle zıplayan tavşan, kuş cıvıltıları arasında kayboldu. Doğanın gizemine şahit olan tavşan, içsel huzur buldu.", "Admin Test", new DateTime(2023, 12, 18, 23, 15, 27, 991, DateTimeKind.Local).AddTicks(3265), null, null, new Guid("f640303d-9f3b-442c-bdfd-070a2f7fe5eb"), null, null, "ASP.NET CORE DENEME MAKALESİ 2", 15, false },
                    { new Guid("99a6ad01-9350-4afe-ac0c-30869b48d6ae"), new Guid("7fe1427a-6079-4699-a48f-8e52be0b41a9"), "Ormanda dolaşan küçük tavşan, rengarenk çiçekleri keşfetti. Masmavi gökyüzü altında sevinçle zıplayan tavşan, kuş cıvıltıları arasında kayboldu. Doğanın gizemine şahit olan tavşan, içsel huzur buldu.", "Admin Test", new DateTime(2023, 12, 18, 23, 15, 27, 991, DateTimeKind.Local).AddTicks(3244), null, null, new Guid("cb071202-b4b4-4b2d-b86b-a8a4441617bd"), null, null, "ASP.NET CORE DENEME MAKALESİ 1", 15, false }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("742851e4-12aa-49bf-b967-a3939d275173"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 18, 23, 15, 27, 991, DateTimeKind.Local).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7fe1427a-6079-4699-a48f-8e52be0b41a9"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 18, 23, 15, 27, 991, DateTimeKind.Local).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cb071202-b4b4-4b2d-b86b-a8a4441617bd"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 18, 23, 15, 27, 991, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f640303d-9f3b-442c-bdfd-070a2f7fe5eb"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 18, 23, 15, 27, 991, DateTimeKind.Local).AddTicks(3723));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("204ff876-8e93-44b2-929e-11125511e6a4"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("99a6ad01-9350-4afe-ac0c-30869b48d6ae"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "ViewCount", "ısDeleted" },
                values: new object[,]
                {
                    { new Guid("48591e74-7727-4571-af8a-d49849e13ee2"), new Guid("742851e4-12aa-49bf-b967-a3939d275173"), "Ormanda dolaşan küçük tavşan, rengarenk çiçekleri keşfetti. Masmavi gökyüzü altında sevinçle zıplayan tavşan, kuş cıvıltıları arasında kayboldu. Doğanın gizemine şahit olan tavşan, içsel huzur buldu.", "Admin Test", new DateTime(2023, 12, 17, 22, 32, 56, 109, DateTimeKind.Local).AddTicks(6744), null, null, new Guid("f640303d-9f3b-442c-bdfd-070a2f7fe5eb"), null, null, "ASP.NET CORE DENEME MAKALESİ 2", 15, false },
                    { new Guid("7d633841-3bc2-4058-a72b-c3ae543d637c"), new Guid("7fe1427a-6079-4699-a48f-8e52be0b41a9"), "Ormanda dolaşan küçük tavşan, rengarenk çiçekleri keşfetti. Masmavi gökyüzü altında sevinçle zıplayan tavşan, kuş cıvıltıları arasında kayboldu. Doğanın gizemine şahit olan tavşan, içsel huzur buldu.", "Admin Test", new DateTime(2023, 12, 17, 22, 32, 56, 109, DateTimeKind.Local).AddTicks(6728), null, null, new Guid("cb071202-b4b4-4b2d-b86b-a8a4441617bd"), null, null, "ASP.NET CORE DENEME MAKALESİ 1", 15, false }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("742851e4-12aa-49bf-b967-a3939d275173"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 22, 32, 56, 109, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7fe1427a-6079-4699-a48f-8e52be0b41a9"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 22, 32, 56, 109, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cb071202-b4b4-4b2d-b86b-a8a4441617bd"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 22, 32, 56, 109, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f640303d-9f3b-442c-bdfd-070a2f7fe5eb"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 22, 32, 56, 109, DateTimeKind.Local).AddTicks(7038));
        }
    }
}
