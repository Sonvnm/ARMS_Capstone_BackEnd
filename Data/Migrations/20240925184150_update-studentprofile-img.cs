using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class updatestudentprofileimg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4aa1328a-2c88-4d12-b09f-9aaaa3fead21", "AQAAAAEAACcQAAAAEMNEQvESLjAtoMh/7gz3nLBrlk9S573/rS73TMpBJZICJxKfsOUfQDcbLm5WS1cZIQ==", "7d1b5f98-b233-4755-8f05-4f3de71deded" });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4500), new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4502), new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4501) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4503), new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4503) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4505), new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4506), new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4508), new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4507) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4509), new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4511), new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4512), new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4512) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4513), new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4513) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4515), new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4514) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 12,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4516), new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4516) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 13,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4518), new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 14,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4519), new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4519) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 15,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4521), new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 19, 1, 565, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "e3ecb579-b5be-4913-9c22-f2af3518d815");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "c6bc4181-f3bc-4487-aff5-b35e2fb0c92f");
        }
    }
}
