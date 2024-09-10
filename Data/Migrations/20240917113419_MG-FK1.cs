using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGFK1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25b47674-eaa9-4381-9e54-688cb520bfcd", "AQAAAAEAACcQAAAAELUsKSpjHIc8eeBEQVkekYDY5SIDqVFcxFLvr9cg5+XWDR/Dl2pl+ht/ANbLk0u73g==", "51e8a8e8-8b34-4ff7-bea1-e8cc667b6987" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "9805ab6a-7a1d-47cf-a3c8-ed366bf128e4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "8d6d6a3a-9e30-481f-9bea-b94757357556");

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogins_Account_UserId",
                table: "UserLogins",
                column: "UserId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserLogins_Account_UserId",
                table: "UserLogins");

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
    }
}
