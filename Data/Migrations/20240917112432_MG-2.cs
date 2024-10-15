using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MG2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "703ab747-eda0-43f0-91df-06b6c6ad347c", "AQAAAAEAACcQAAAAEHbAcm5omvuQPVhOIfGLkqH6ruT/H8u1edu1Eu97Zc9sCT1VQECL/LjPx7sswhSEdA==", "653959d7-9a94-4d3c-8e8f-febe0727d489" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "ce4d6278-7d19-47e4-a972-af964aac1444");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "92cb876a-3f64-4e72-8f74-d3dfb5bc5ca1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb8b1367-7ffa-47f7-a4b7-e47321ce6e3a", "AQAAAAEAACcQAAAAECYo4lsEVJSnoACG07qFS+LTND+ISOWTZMfyuKV0hJI3s4s2JvgNFpyHfVWgRtEOcg==", "508202d0-9c80-4625-9465-9198704a216e" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "72617e88-07de-4516-b4fc-c623e7e14ec2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "21ac515e-b1f5-44e0-b79f-5fbad808d9a8");
        }
    }
}
