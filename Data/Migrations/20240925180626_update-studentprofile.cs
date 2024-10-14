using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class updatestudentprofile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Diploma",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "Major2",
                table: "StudentProfile");

            migrationBuilder.RenameColumn(
                name: "SpecializeMajor2",
                table: "StudentProfile",
                newName: "ImgDiploma");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneStudent",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullnameParents",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EmailStudent",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ARId",
                table: "StudentProfile",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiplomaId",
                table: "StudentProfile",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImgAcademicTranscript1",
                table: "StudentProfile",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImgAcademicTranscript2",
                table: "StudentProfile",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImgAcademicTranscript3",
                table: "StudentProfile",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImgAcademicTranscript4",
                table: "StudentProfile",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImgAcademicTranscript5",
                table: "StudentProfile",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_StudentProfile_ARId",
                table: "StudentProfile",
                column: "ARId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentProfile_DiplomaId",
                table: "StudentProfile",
                column: "DiplomaId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentProfile_TypeAcademicRecord_ARId",
                table: "StudentProfile",
                column: "ARId",
                principalTable: "TypeAcademicRecord",
                principalColumn: "ARId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentProfile_TypeOfDiploma_DiplomaId",
                table: "StudentProfile",
                column: "DiplomaId",
                principalTable: "TypeOfDiploma",
                principalColumn: "DiplomaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentProfile_TypeAcademicRecord_ARId",
                table: "StudentProfile");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentProfile_TypeOfDiploma_DiplomaId",
                table: "StudentProfile");

            migrationBuilder.DropIndex(
                name: "IX_StudentProfile_ARId",
                table: "StudentProfile");

            migrationBuilder.DropIndex(
                name: "IX_StudentProfile_DiplomaId",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "ARId",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "DiplomaId",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "ImgAcademicTranscript1",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "ImgAcademicTranscript2",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "ImgAcademicTranscript3",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "ImgAcademicTranscript4",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "ImgAcademicTranscript5",
                table: "StudentProfile");

            migrationBuilder.RenameColumn(
                name: "ImgDiploma",
                table: "StudentProfile",
                newName: "SpecializeMajor2");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneStudent",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullnameParents",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailStudent",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Diploma",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Major2",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57801493-adbe-4ab7-9633-13f109a96c77", "AQAAAAEAACcQAAAAEJRNLrV+xGkNPfCyghxBUuFSodhH3vwomJ4rKvCARtwDszxkr9zsobJzHCONE9a6LA==", "da1820e0-2ab3-468c-8dcb-c623c860a0b0" });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5157), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5158), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5159), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5160), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5161), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5162), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5163), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5165), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5165), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5168), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5170), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 12,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5171), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 13,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5172), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 14,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5173), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 15,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5174), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "3cb1200c-8814-458e-b03f-420417da6ee7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "1f57ab74-e87b-469c-910b-5e79c3b92d32");
        }
    }
}
