using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGFK3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9498aa02-ae27-4078-889b-79ed400ecd25", "AQAAAAEAACcQAAAAEJ/SLQcQFYXDhF4j8hHwOp408nKbVrZwJwQjbvPJ5aQBj7WBGkp8kp1AeMWLo1D1ZA==", "cfb81a92-b34c-4d12-96bd-84cc055b1277" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "207ff729-ffa7-4108-8d9d-668a9f9b71df");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "10c58917-d941-41bf-b67a-fdc4afb04c0f");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaims_Account_RoleId",
                table: "RoleClaims",
                column: "RoleId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaims_Account_UserId",
                table: "UserClaims",
                column: "UserId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaims_Account_RoleId",
                table: "RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClaims_Account_UserId",
                table: "UserClaims");

            migrationBuilder.DropIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims");

            migrationBuilder.DropIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed5d5be0-2f74-4607-a8c3-d2c5b600e1a4", "AQAAAAEAACcQAAAAED++AwAoxcIRCfvs84Wneo207Uwhsbcywi0uAc69podcGL+eLPVKnWNMEJtK1x+k2g==", "3fe5f59c-4810-41e9-a96d-6b440731ad0f" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "3695a7ab-ff14-4f24-ae4a-3bc1e2304b76");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "f30586da-2377-4ed9-8bba-9abc4f338f59");
        }
    }
}
