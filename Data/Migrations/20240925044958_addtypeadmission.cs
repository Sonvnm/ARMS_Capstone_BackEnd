using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class addtypeadmission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "SpecializeMajor");

            migrationBuilder.AddColumn<string>(
                name: "ARId",
                table: "TypeOfDiploma",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TypeAcademicRecord",
                columns: table => new
                {
                    ARId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ARName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeAcademicRecord", x => x.ARId);
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2b66003-69ed-4cf5-a4a9-f1e8852c851a", "AQAAAAEAACcQAAAAEOR+2VnK20q7yF/zQLxiKnC6KD1wiPnzC+5Qayh+4yCeP+Y+z8P9JWuzEObo3HHc4w==", "410fef20-7e62-48f7-83c5-9cbb5631f262" });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9232), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9234), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9233) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9235), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9236), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9235) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9237), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9237), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9238), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9239), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9240), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9241), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9242), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 12,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9243), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 13,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9244), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 14,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9245), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 15,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9245), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "bf663c1e-4608-4ea1-84bd-9463f5440646");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "63986db4-f1eb-42b4-b0c7-1cb89fa83499");

            migrationBuilder.InsertData(
                table: "TypeAcademicRecord",
                columns: new[] { "ARId", "ARName" },
                values: new object[,]
                {
                    { "Xet_1nam", "Xét học bạ năm 12" },
                    { "Xet_3ky", "Xét học bạ 3 kỳ" },
                    { "Xet_3nam", "Xét học bạ 3 năm" },
                    { "Xet_5ky", "Xét học bạ 5 kỳ" },
                    { "Xet_lop10_lop11_Hk1_12", "Xét học bạ lớp 10, lớp 11, HK1 lớp 12" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TypeOfDiploma_ARId",
                table: "TypeOfDiploma",
                column: "ARId");

            migrationBuilder.AddForeignKey(
                name: "FK_TypeOfDiploma_TypeAcademicRecord_ARId",
                table: "TypeOfDiploma",
                column: "ARId",
                principalTable: "TypeAcademicRecord",
                principalColumn: "ARId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TypeOfDiploma_TypeAcademicRecord_ARId",
                table: "TypeOfDiploma");

            migrationBuilder.DropTable(
                name: "TypeAcademicRecord");

            migrationBuilder.DropIndex(
                name: "IX_TypeOfDiploma_ARId",
                table: "TypeOfDiploma");

            migrationBuilder.DropColumn(
                name: "ARId",
                table: "TypeOfDiploma");

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "SpecializeMajor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "192c146b-db29-401b-9e7e-aa05cb6c64c3", "AQAAAAEAACcQAAAAEOjF15dM/NUcsjqsZhVhX+sg1v8upeH6EXo0RF5SFnkp8kMd35ZBw3KJFzTz/GovPA==", "887629b5-47ff-4501-8ebf-b35a763a4b9b" });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4941), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4943), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4944), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4944), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4944) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4945), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4946), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4947), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4948), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4948) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4949), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4950), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4951), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 12,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4951), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4951) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 13,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4952), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 14,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4953), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 15,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4954), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "1e31e0cc-7fbd-4f20-baf7-fc08b3ea9812");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "8db44d5c-c0c4-414b-ae1d-600c28cc5b53");
        }
    }
}
