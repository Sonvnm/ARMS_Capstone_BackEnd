using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGadmission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MajorCode",
                table: "SpecializeMajor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Target",
                table: "Major",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AdmissionPlan",
                columns: table => new
                {
                    AdmissionPlanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalTarget = table.Column<int>(type: "int", nullable: false),
                    Prioritize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearAdmission = table.Column<int>(type: "int", nullable: true),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmissionPlan", x => x.AdmissionPlanID);
                    table.ForeignKey(
                        name: "FK_AdmissionPlan_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId");
                });

            migrationBuilder.CreateTable(
                name: "AdmissionTime",
                columns: table => new
                {
                    AdmissionTimeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdmissionTimeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdmissionPlanID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmissionTime", x => x.AdmissionTimeID);
                    table.ForeignKey(
                        name: "FK_AdmissionTime_AdmissionPlan_AdmissionPlanID",
                        column: x => x.AdmissionPlanID,
                        principalTable: "AdmissionPlan",
                        principalColumn: "AdmissionPlanID");
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8fc643b-4f8c-4aa1-8014-5b9f3ccee423", "AQAAAAEAACcQAAAAEBpo8U7G+BrENq4Md06HteiotywD8cO+XiltDQkYQr1GvMrgHRvg6E1pYs+PSOVGZw==", "46c81469-362a-4363-b156-6c76c7c99b77" });

            migrationBuilder.InsertData(
                table: "AdmissionPlan",
                columns: new[] { "AdmissionPlanID", "CampusId", "Prioritize", "TotalTarget", "YearAdmission" },
                values: new object[,]
                {
                    { 1, "Hanoi", "", 2000, 2024 },
                    { 2, "Danang", "", 2000, 2024 },
                    { 3, "Cantho", "", 2000, 2024 },
                    { 4, "HCM", "", 2000, 2024 },
                    { 5, "Thanhhoa", "", 2000, 2024 }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 6, 52, 432, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 6, 52, 432, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 6, 52, 432, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 6, 52, 432, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 6, 52, 432, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 6, 52, 432, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 6, 52, 432, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 6, 52, 432, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 6, 52, 432, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 20, 17, 6, 52, 432, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 20, 17, 6, 52, 432, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 20, 17, 6, 52, 432, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "3226794d-6ffd-43f9-9ffc-65cb63d5c0ce");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "ed067301-08a6-4e2e-b0ea-b22eb25268d6");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "AO",
                column: "MajorCode",
                value: "71490");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "BS",
                column: "MajorCode",
                value: "71490");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "BT",
                column: "MajorCode",
                value: "71490");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "EA",
                column: "MajorCode",
                value: "7220201");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "FO",
                column: "MajorCode",
                value: "71490");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "GE",
                column: "MajorCode",
                value: "7480201");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "HM",
                column: "MajorCode",
                value: "7340101");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "JA",
                column: "MajorCode",
                value: "7220209");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "KA",
                column: "MajorCode",
                value: "7220210");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "ME",
                column: "MajorCode",
                value: "7480201");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "RM",
                column: "MajorCode",
                value: "7340101");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "SM",
                column: "MajorCode",
                value: "7340101");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "SO",
                column: "MajorCode",
                value: "71490");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "TE",
                column: "MajorCode",
                value: "7480201");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "WE",
                column: "MajorCode",
                value: "7480201");

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionPlan_CampusId",
                table: "AdmissionPlan",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionTime_AdmissionPlanID",
                table: "AdmissionTime",
                column: "AdmissionPlanID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdmissionTime");

            migrationBuilder.DropTable(
                name: "AdmissionPlan");

            migrationBuilder.DropColumn(
                name: "MajorCode",
                table: "SpecializeMajor");

            migrationBuilder.DropColumn(
                name: "Target",
                table: "Major");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b8802c3-bba6-4b14-9eec-8c4626e5a60f", "AQAAAAEAACcQAAAAEDZWepffONJFU4w/qklMncKkl6NV7EEroNmK+R6cqlWeo2uH9HjiPQpkJb7ajZpQgw==", "e72f1495-a4d8-4e65-8f6d-50892ebb433b" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 13, 55, 13, 409, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 13, 55, 13, 409, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 13, 55, 13, 409, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 13, 55, 13, 409, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 13, 55, 13, 409, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 13, 55, 13, 409, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 13, 55, 13, 409, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 13, 55, 13, 409, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 13, 55, 13, 409, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 19, 13, 55, 13, 409, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 19, 13, 55, 13, 409, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 19, 13, 55, 13, 409, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "d2d75bf0-8ead-4e14-90d0-2f1fdb41cf49");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "98f8a8ff-0962-4ca8-bbe1-6a94c7fad0a1");
        }
    }
}
