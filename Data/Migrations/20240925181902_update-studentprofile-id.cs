using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class updatestudentprofileid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentProfile",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "StudentProfile");

            migrationBuilder.AddColumn<Guid>(
                name: "SpId",
                table: "StudentProfile",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentProfile",
                table: "StudentProfile",
                column: "SpId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentProfile",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "SpId",
                table: "StudentProfile");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "StudentProfile",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentProfile",
                table: "StudentProfile",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bacf074-3205-44df-bb20-9d7964169eb1", "AQAAAAEAACcQAAAAEEtFiqEn/qw1cIn+gxNKtiVSjIrVTtzmz7SJX2U5kV50mLFR9SdtPcPwdhYLaHKkEA==", "41cc6b77-944c-49d5-92ed-fc909b9e85a9" });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3789), new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3792), new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3793), new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3794), new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3794) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3795), new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3796), new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3796) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3798), new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3799), new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3798) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3800), new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3799) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3801), new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3801) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3802), new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3802) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 12,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3803), new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3803) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 13,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3804), new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3804) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 14,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3805), new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 15,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3806), new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3806) });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 6, 25, 133, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "fbcffe14-4005-416b-aa79-dd432ca560b1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "3d430939-fc07-492f-9c0e-ac8482337e18");
        }
    }
}
