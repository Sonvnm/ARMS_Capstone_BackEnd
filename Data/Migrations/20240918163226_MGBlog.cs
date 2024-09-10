using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGBlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad2c21f9-a50f-4997-931e-90de827ed9ad", "AQAAAAEAACcQAAAAEEnUNCZ26LOjGswBKKjcYm98r3Tcep5ZlpHW4roR5spYgIz3IfknYin046DQl49lgQ==", "cb73d87a-7416-453f-ae84-92a603612a5e" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "fc0447d9-3f35-43c9-b0b3-ec5c02d3cd6b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "ff3c4368-64ec-4ccc-8913-8b6c142d4a67");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adeeec1a-11f8-4d1a-a374-92bc8ba2cddb", "AQAAAAEAACcQAAAAEOB86fkmwQ3p7n+/Gyu32OJh6lVOEepUKKHqvQF0n9eRCnOHMmVYZUM0iQM5hHebSA==", "b758761a-c48f-4778-b474-091cc4d0e2ca" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "13fdf6f0-e172-4f0b-a91a-536e5a8fac9a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "2e15a977-4962-4b08-9941-23b40f4747d4");
        }
    }
}
