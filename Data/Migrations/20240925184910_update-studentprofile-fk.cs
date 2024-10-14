using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class updatestudentprofilefk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImgAcademicTranscript5",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ImgAcademicTranscript4",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ImgAcademicTranscript3",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ImgAcademicTranscript2",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ImgAcademicTranscript1",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a321151-b326-4ab1-a314-76375aba7661", "AQAAAAEAACcQAAAAEOoIo0QVkYZSN3nW2vfbLYo1TSVDWRUoruzwu/29cTHlobs2FnphqfNh6TjgSw/siQ==", "4dabcb87-ac58-4c43-85b0-75d36f4604c3" });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(50), new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(52), new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(52) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(53), new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(53) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(54), new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(54) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(55), new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(56), new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(57), new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(58), new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(58) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(59), new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(60), new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(61), new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 12,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(62), new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 13,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(63), new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 14,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(64), new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 15,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(65), new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(64) });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 49, 9, 643, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 49, 9, 643, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 49, 9, 643, DateTimeKind.Local).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 49, 9, 643, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 49, 9, 643, DateTimeKind.Local).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 49, 9, 643, DateTimeKind.Local).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 49, 9, 643, DateTimeKind.Local).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 49, 9, 643, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 49, 9, 643, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 49, 9, 644, DateTimeKind.Local).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "7dea32a5-1006-4ec3-b3c5-f92c4db45cb5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "30738035-66cc-48e1-85a6-9abb6a7ba559");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ImgAcademicTranscript5",
                table: "StudentProfile",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ImgAcademicTranscript4",
                table: "StudentProfile",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ImgAcademicTranscript3",
                table: "StudentProfile",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ImgAcademicTranscript2",
                table: "StudentProfile",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ImgAcademicTranscript1",
                table: "StudentProfile",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9e18095-167a-4688-afbe-09072f5c3772", "AQAAAAEAACcQAAAAEC7uJbx1VvHDfn1nZbOFXzUxI0OSsphS7e5zGfSb1daqPmlfue72LmVcm+Bd+DK43w==", "c5ff0db8-c926-4369-8072-6dea46e93b24" });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7015), new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7016), new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7017), new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7017) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7018), new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7019), new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7020), new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7021), new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7023), new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7024), new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7026), new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7027), new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 12,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7029), new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 13,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7030), new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 14,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7031), new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 15,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7032), new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 41, 49, 84, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "cda389ba-461b-4cbe-b756-932463f41828");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "2551ca12-da87-4d38-b23d-4fd1dc01c513");
        }
    }
}
