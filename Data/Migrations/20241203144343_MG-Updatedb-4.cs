using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGUpdatedb4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("1e7cc01e-a549-4097-9e87-0aa9b1ba9eb8"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("4aece7ee-bda9-4cc1-a44a-b2792169a624"));

            migrationBuilder.AddColumn<int>(
                name: "Admissions",
                table: "AdmissionInformation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5eaa938-3d47-4a78-a333-8d5747a5fd68", "AQAAAAEAACcQAAAAEJYYVvY38+OD6/Gmr74ynoVrU7oXtU8RTsN//v5i/DfOeTcM/OzPaebiA6LnwR0rKg==", "305f0ebc-289f-46f6-bc62-56719c311cb8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb09af49-e7e8-4617-883c-c96f7d44fb64", "AQAAAAEAACcQAAAAEDHBfBCzxItZcnKIziL495MBaUnn+cbLm9KsJASwu7yq4sj+IhoP2a/aATbJcPt66w==", "803a41eb-4506-4e52-bcf0-d7884f411bb5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c9be63a-f154-4665-8e03-93fee1f4de40", "AQAAAAEAACcQAAAAEC+jObBBS5TOfgqjCtpx7UAW5cRmN/WZ18iy8x6wqCFeMlqR/St7VgqMrwWJqj1Pvg==", "fad1475c-d596-4b1b-853e-3ec9e07dcf4b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9580fed7-e9d7-498d-ab8b-4a72bfd3a0f5", "AQAAAAEAACcQAAAAEPhKmYYC1oyRIzBeWxqGUwuFpRjLbmXWVv7PdySJVZuConwF/38xV15LLgM0Wipa6A==", "5bf72e66-f7f1-44b1-a7d3-325f19680d07" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31983ad7-33fd-428b-b05c-94f3f4683309", "AQAAAAEAACcQAAAAEEoj1iJiCMPvlU64nyErnfjhx5utOx3miHw8eU2nju9RMTgoggUrdXVswXBjcfkl8A==", "20c19c28-4741-49e6-b18d-aebfc053c7db" });

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 1,
                column: "Admissions",
                value: 2);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 2,
                column: "Admissions",
                value: 2);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 3,
                column: "Admissions",
                value: 2);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 4,
                column: "Admissions",
                value: 2);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 5,
                column: "Admissions",
                value: 2);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 6,
                column: "Admissions",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 7,
                column: "Admissions",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 8,
                column: "Admissions",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 9,
                column: "Admissions",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 10,
                column: "Admissions",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 11,
                column: "Admissions",
                value: 3);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 12,
                column: "Admissions",
                value: 3);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 13,
                column: "Admissions",
                value: 3);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 14,
                column: "Admissions",
                value: 3);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 15,
                column: "Admissions",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "feb43562-9bdf-4816-9656-01e0f2f80ab8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "ac6e20fb-3910-4865-9ad7-20a4d3f8e306");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "dbf9f083-41d1-4d9c-afc3-71840171c9f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "bb1bcab2-908c-48d1-a872-7089d07bcbc5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "90a66d1c-d087-41d7-957a-0e669b24fe23");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "CreateBy", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("0adbc540-f58a-4ae3-bc54-00c1a5fb0cd0"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("af2e014d-0e1a-4f94-862f-41ebc3de3727"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("0adbc540-f58a-4ae3-bc54-00c1a5fb0cd0"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("af2e014d-0e1a-4f94-862f-41ebc3de3727"));

            migrationBuilder.DropColumn(
                name: "Admissions",
                table: "AdmissionInformation");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c479b975-544a-43a6-adfa-f9f13c646e26", "AQAAAAEAACcQAAAAELnbRFCAvvsKh6J61nY1MYbPwZB0fWTdzkYhLT7QBd+4WRcL4R7Mr/6d0fFBniCQxA==", "ed96d7ee-e175-44da-b348-503c605f39ed" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e931f2c-4ffb-424e-a759-f7b5916474c4", "AQAAAAEAACcQAAAAEN6OukOjXihJeChELDK/Lf+KMOMhVrtpnrtNumpoNBviM0msq9d/ECc0B+duqrFb0g==", "dfdd5820-cda1-4bba-8c49-5fe29becaf3c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "096aacb1-2b48-4eaf-8fb5-cd47db1bd68f", "AQAAAAEAACcQAAAAEN+kNGBARCgBEturbLkSb0J+V44/hG28ptz9Uq/O0WyFcm9dxnaKD/neJPH2pj+8cw==", "97c89b93-8881-417b-8c21-9eaccb4a2d5a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d2a6210-22f2-46c2-bc46-e019a71ab563", "AQAAAAEAACcQAAAAELbA+/wAnOEhaPdbHb4QXlLhBWZ3vuGZMsk2JRJl1FddEtVmk4eu6ZOXljC7SpRb2w==", "ba3c3f8f-89f3-43db-bbdc-cced7ef96657" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c8b7eda-970d-48f4-9be9-9d67357bef37", "AQAAAAEAACcQAAAAELo7tz0Cl1ZoxSLsSfDqS/VvdfwzarZeU91o8wYE65QNTa1F71W0JLOOICF7CiG+tw==", "8b8f146c-ce2a-4099-a686-aa17b1ce7858" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 12, 3, 21, 36, 27, 929, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "c8101aab-e98e-4a5c-8a52-99d232110584");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "37402a49-6f7a-48d1-a4b2-6a7b3a60b4fa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "9486f6f9-89e2-40b2-8f6f-af3f981c156c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "5dea291f-1824-44c2-b510-9131280208fe");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "021a353b-1cb2-4731-a84f-f7b78fb1c86b");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "CreateBy", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("1e7cc01e-a549-4097-9e87-0aa9b1ba9eb8"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("4aece7ee-bda9-4cc1-a44a-b2792169a624"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });
        }
    }
}
