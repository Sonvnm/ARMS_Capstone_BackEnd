using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class UpdateIntroduce2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WhyShooseUs",
                table: "IntroduceCampus",
                newName: "WhyChooseUs");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5abc50bf-7f25-444a-a085-31adfaeba3a5", "AQAAAAEAACcQAAAAEOOaElqbdmKb1Vki/yCsdzIB3t2jtgNkSKIh8RqUtSMxFA8Ho8zYwfUuforwb0roiw==", "8eda7233-0574-4e43-8a6e-3f710c72db57" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "e6030753-cfee-4008-9e4a-6665885dffb5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "c27cabde-dcb3-470a-9bf6-1d0bdf4721d3");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WhyChooseUs",
                table: "IntroduceCampus",
                newName: "WhyShooseUs");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2119f0df-94df-4352-8036-97335f309921", "AQAAAAEAACcQAAAAEBkk2NNzNaj3eV4hRgkbc8YQUoUJ1jT+Guaew1QQmyppIgsvr3dUCm4ZS/Uk8GyEig==", "ff0492d8-576b-4207-9a1a-a53f005bfe34" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "43b61dbc-e32b-4e87-8c3b-6e82df3b64fc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "58f0726f-dd12-40a0-a71d-43d831156819");
        }
    }
}
