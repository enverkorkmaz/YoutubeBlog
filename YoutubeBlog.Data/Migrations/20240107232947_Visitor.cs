using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoutubeBlog.Data.Migrations
{
    public partial class Visitor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("297bcccb-4b9e-426c-af84-25f625a31ab1"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("617b59ef-173d-4880-94f8-0ad3a82286e6"));

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAgent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleVisitors",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleVisitors", x => new { x.ArticleId, x.VisitorId });
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Visitors_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount", "ısDeleted" },
                values: new object[,]
                {
                    { new Guid("5a60a8ed-7cab-4d2c-89ee-058ee99d8f4f"), new Guid("7fe1427a-6079-4699-a48f-8e52be0b41a9"), "Ormanda dolaşan küçük tavşan, rengarenk çiçekleri keşfetti. Masmavi gökyüzü altında sevinçle zıplayan tavşan, kuş cıvıltıları arasında kayboldu. Doğanın gizemine şahit olan tavşan, içsel huzur buldu.", "Admin Test", new DateTime(2024, 1, 8, 2, 29, 47, 170, DateTimeKind.Local).AddTicks(7782), null, null, new Guid("cb071202-b4b4-4b2d-b86b-a8a4441617bd"), null, null, "ASP.NET CORE DENEME MAKALESİ 1", new Guid("89051764-0baf-4754-bd6f-507ebfb3c2d5"), 15, false },
                    { new Guid("c7b6d04e-4c0a-441d-b20d-4ec77ca1f379"), new Guid("742851e4-12aa-49bf-b967-a3939d275173"), "Ormanda dolaşan küçük tavşan, rengarenk çiçekleri keşfetti. Masmavi gökyüzü altında sevinçle zıplayan tavşan, kuş cıvıltıları arasında kayboldu. Doğanın gizemine şahit olan tavşan, içsel huzur buldu.", "Admin Test", new DateTime(2024, 1, 8, 2, 29, 47, 170, DateTimeKind.Local).AddTicks(7789), null, null, new Guid("f640303d-9f3b-442c-bdfd-070a2f7fe5eb"), null, null, "ASP.NET CORE DENEME MAKALESİ 2", new Guid("80a87e05-eb55-4e5e-b26e-673c3b842cb6"), 15, false }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("20e01782-4364-4ce0-9f8f-da46ed8569d4"),
                column: "ConcurrencyStamp",
                value: "fd36e935-663e-4ead-b9a6-b29d4649bc91");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2a22df52-e2d9-4716-a19b-0972e201c99e"),
                column: "ConcurrencyStamp",
                value: "187a1ea3-acd6-4c36-a455-ce505e55ee82");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6bd5f88a-77e4-41a8-821d-7fe50fe4ba41"),
                column: "ConcurrencyStamp",
                value: "105b5f9e-3058-4960-a0c3-0215dfad9b1f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("80a87e05-eb55-4e5e-b26e-673c3b842cb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e482b57e-2545-4a08-abd5-eae6de02809e", "AQAAAAEAACcQAAAAEAu/Wxh5MpC5Yx+FhSXzyEy6jjCfH2Tr4FrSU1HUKWi30sJ+TlzKKhG3imOVIfUnig==", "8cf85e1c-c9c3-49d7-b2fc-0c81dfb49f33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89051764-0baf-4754-bd6f-507ebfb3c2d5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30e1e8fc-8174-4e18-8ae1-9d396257ef7e", "AQAAAAEAACcQAAAAECK7awoij9NRDVMxApi5Pc8WXwrGX+gA3R6cY2isgCmUFCLMZpcQSKTxo3AGPpFSKw==", "fcf25dfc-9643-418d-8252-9b3a9fe744ef" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("742851e4-12aa-49bf-b967-a3939d275173"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 8, 2, 29, 47, 171, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7fe1427a-6079-4699-a48f-8e52be0b41a9"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 8, 2, 29, 47, 171, DateTimeKind.Local).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cb071202-b4b4-4b2d-b86b-a8a4441617bd"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 8, 2, 29, 47, 171, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f640303d-9f3b-442c-bdfd-070a2f7fe5eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 8, 2, 29, 47, 171, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.CreateIndex(
                name: "IX_ArticleVisitors_VisitorId",
                table: "ArticleVisitors",
                column: "VisitorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleVisitors");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5a60a8ed-7cab-4d2c-89ee-058ee99d8f4f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c7b6d04e-4c0a-441d-b20d-4ec77ca1f379"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount", "ısDeleted" },
                values: new object[,]
                {
                    { new Guid("297bcccb-4b9e-426c-af84-25f625a31ab1"), new Guid("742851e4-12aa-49bf-b967-a3939d275173"), "Ormanda dolaşan küçük tavşan, rengarenk çiçekleri keşfetti. Masmavi gökyüzü altında sevinçle zıplayan tavşan, kuş cıvıltıları arasında kayboldu. Doğanın gizemine şahit olan tavşan, içsel huzur buldu.", "Admin Test", new DateTime(2023, 12, 22, 23, 50, 55, 969, DateTimeKind.Local).AddTicks(1379), null, null, new Guid("f640303d-9f3b-442c-bdfd-070a2f7fe5eb"), null, null, "ASP.NET CORE DENEME MAKALESİ 2", new Guid("80a87e05-eb55-4e5e-b26e-673c3b842cb6"), 15, false },
                    { new Guid("617b59ef-173d-4880-94f8-0ad3a82286e6"), new Guid("7fe1427a-6079-4699-a48f-8e52be0b41a9"), "Ormanda dolaşan küçük tavşan, rengarenk çiçekleri keşfetti. Masmavi gökyüzü altında sevinçle zıplayan tavşan, kuş cıvıltıları arasında kayboldu. Doğanın gizemine şahit olan tavşan, içsel huzur buldu.", "Admin Test", new DateTime(2023, 12, 22, 23, 50, 55, 969, DateTimeKind.Local).AddTicks(1370), null, null, new Guid("cb071202-b4b4-4b2d-b86b-a8a4441617bd"), null, null, "ASP.NET CORE DENEME MAKALESİ 1", new Guid("89051764-0baf-4754-bd6f-507ebfb3c2d5"), 15, false }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("20e01782-4364-4ce0-9f8f-da46ed8569d4"),
                column: "ConcurrencyStamp",
                value: "3d5a3fb5-3d02-492a-94f5-9a701a8e0369");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2a22df52-e2d9-4716-a19b-0972e201c99e"),
                column: "ConcurrencyStamp",
                value: "ce343df5-51f7-46c5-8a7d-dff3fc82b24e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6bd5f88a-77e4-41a8-821d-7fe50fe4ba41"),
                column: "ConcurrencyStamp",
                value: "72863e8a-ffc1-434a-b7c1-114407104a06");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("80a87e05-eb55-4e5e-b26e-673c3b842cb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33b73133-07fd-4682-b62a-e7fcb7cac659", "AQAAAAEAACcQAAAAENKMksB/CrFLHqQFJNNZ+M0bCfgARMsLfBsORADbsnF9FiTWwXEQdReNTO/s0eXZGQ==", "a9595b4c-46d7-4f59-ba4a-bfea2a91cb06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89051764-0baf-4754-bd6f-507ebfb3c2d5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ef9222f-7408-43e1-a81b-a38cc2e5b36f", "AQAAAAEAACcQAAAAEEGw0hXruy9nhBno2qj8ypzXO6RzEgvJglbGKFjW0mHMa61dh0VELT3wjHs6BTywHQ==", "5ac8f682-8039-4b61-a5a3-aac5bf5e0488" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("742851e4-12aa-49bf-b967-a3939d275173"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 22, 23, 50, 55, 969, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7fe1427a-6079-4699-a48f-8e52be0b41a9"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 22, 23, 50, 55, 969, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cb071202-b4b4-4b2d-b86b-a8a4441617bd"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 22, 23, 50, 55, 969, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f640303d-9f3b-442c-bdfd-070a2f7fe5eb"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 22, 23, 50, 55, 969, DateTimeKind.Local).AddTicks(2035));
        }
    }
}
