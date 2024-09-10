using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class UpdateIntroduce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IntroduceCampus_Campus_CampusId",
                table: "IntroduceCampus");

            migrationBuilder.DropIndex(
                name: "IX_IntroduceCampus_CampusId",
                table: "IntroduceCampus");

            migrationBuilder.AlterColumn<string>(
                name: "CampusId",
                table: "IntroduceCampus",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "IntroduceId",
                table: "Campus",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Campus_IntroduceId",
                table: "Campus",
                column: "IntroduceId",
                unique: true,
                filter: "[IntroduceId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Campus_IntroduceCampus_IntroduceId",
                table: "Campus",
                column: "IntroduceId",
                principalTable: "IntroduceCampus",
                principalColumn: "IntroduceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campus_IntroduceCampus_IntroduceId",
                table: "Campus");

            migrationBuilder.DropIndex(
                name: "IX_Campus_IntroduceId",
                table: "Campus");

            migrationBuilder.DropColumn(
                name: "IntroduceId",
                table: "Campus");

            migrationBuilder.AlterColumn<string>(
                name: "CampusId",
                table: "IntroduceCampus",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c271be5-1050-49a0-9e6d-db917bbb108d", "AQAAAAEAACcQAAAAEORzh4mbmQEBbdkOFoNXQqpez+fqfqwmC1EsrCtAQOQQOcc5ZrdKBEmEqPPu6nenBw==", "e836bb0f-5149-475a-b23c-f6cfd2467b6d" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "acb59990-e60a-4ebd-bb26-c5e229f062b4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "97e4715a-211e-4051-b4dd-1def6d9ba7f6");

            migrationBuilder.CreateIndex(
                name: "IX_IntroduceCampus_CampusId",
                table: "IntroduceCampus",
                column: "CampusId");

            migrationBuilder.AddForeignKey(
                name: "FK_IntroduceCampus_Campus_CampusId",
                table: "IntroduceCampus",
                column: "CampusId",
                principalTable: "Campus",
                principalColumn: "CampusId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
