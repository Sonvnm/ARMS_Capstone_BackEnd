using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class AddSupplier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.SupplierId);
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "531356ec-f04f-4185-a247-1b6daaf25158", "AQAAAAEAACcQAAAAEPwUiTJFsHSSrnot1hMdhbcCSX6PeWMc6Dv1oGGVqrdy/qAnpdZ1lLNIkzPhAOPxHQ==", "d6641349-d552-4989-844c-b53fbfc1ea4e" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "b4701c64-6dbb-4c73-b2a2-6ebacf0cfe8d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "23601acb-4477-4d1a-b594-694eceb0e056");

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "SupplierId", "Img", "SupplierName" },
                values: new object[,]
                {
                    { 1, "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Supplier%2FFptSoftware.png?alt=media&token=552c0a51-fdea-4795-acd7-fd10fe5cb45f", "Fpt Software" },
                    { 2, "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Supplier%2FVNPT.png?alt=media&token=96d1f135-015a-4c8c-a8a3-dbd283cbd345", "Tập đoàn bưu chính viễn thông" },
                    { 3, "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Supplier%2FBase.vn.png?alt=media&token=be9f0ae0-8704-4cf5-b20c-d344d7d9ea3c", "Base.vn" },
                    { 4, "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Supplier%2FUniMedia.png?alt=media&token=8b223dea-5076-485c-95c8-467c39568c88", "UniMedia" },
                    { 5, "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Supplier%2FAvepoint.png?alt=media&token=ebbbdabb-d411-4a6b-a57b-a16b1c144a8c", "Avepoint Việt Nam" },
                    { 6, "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Supplier%2FCMC.jpg?alt=media&token=e37589d5-9907-44fd-abac-a1ace3537f27", "CMC" },
                    { 7, "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Supplier%2FKaopiz.png?alt=media&token=b9d29e81-712e-4b78-b8c3-2d74144347f3", "Kaopiz" },
                    { 8, "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Supplier%2FViettel.png?alt=media&token=3493a983-26d0-4c41-967e-341c3cfcc269", "Viettel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa9a6b06-1756-4e85-bf18-536580558f50", "AQAAAAEAACcQAAAAEHPXWoKitclqpwtmL6BPfULJvWxwd6VtxPLN4nL1yk4C7hSjJI+hp7x054qfmyIQ4g==", "37454b97-331a-4332-af72-854ee61947d8" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "14166a33-0366-42f7-a214-24da50b85dfd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "f06517c9-3902-4e6a-9df5-8aff09b3b79f");
        }
    }
}
