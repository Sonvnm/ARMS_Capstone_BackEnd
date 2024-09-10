using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class UpdateStudentConsultation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "StudentConsultation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a82d0a4-a13c-4feb-9dc6-1adb31334d15", "AQAAAAEAACcQAAAAEAs06y1prirFXjpKf0+Hq/yD7nsMpOihwp6NbesjgAcaYLVze++Sd5mu+U58jB1TVQ==", "98870d48-99bb-4bcd-beae-a690c35ebfca" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "5ac84db9-d112-42f3-b02b-d49d07992fdf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "b43b4df2-0c2e-42d7-ab26-f35caba8035a");

            migrationBuilder.UpdateData(
                table: "StudentConsultation",
                keyColumn: "SCId",
                keyValue: 1,
                column: "PhoneNumber",
                value: "0123456789");

            migrationBuilder.UpdateData(
                table: "StudentConsultation",
                keyColumn: "SCId",
                keyValue: 2,
                column: "PhoneNumber",
                value: "0123456789");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "StudentConsultation");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b1275a1-26f7-4060-ac20-cbc8ae97711c", "AQAAAAEAACcQAAAAEK3/BRBV8eUTJjX+u7ckCLwn6rFF49maIc12Ywdmlag2gWKT4y5di+zAqLE24Vz/og==", "99db37b4-cf08-433c-aa64-15501ecad6ed" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "f05bf5a4-947f-40e0-86fe-cae9105023cc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "a07041de-2c4a-41b1-842b-7893aaa06176");
        }
    }
}
