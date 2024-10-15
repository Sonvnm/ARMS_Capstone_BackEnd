using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGUpdatedb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("297edd0e-e189-4fe2-bebd-511605ccadeb"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("eb83dd37-30f7-482f-a91a-2cc6d4b783af"));

            migrationBuilder.DropColumn(
                name: "Status",
                table: "AdmissionInformation");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5662b3d6-c9d3-48cd-a3dc-1f68abd76e69", "AQAAAAEAACcQAAAAEDxxmz7xWiN8yNTerAGPgTcWmNzLtI5fwJCEPJ20WTERlbSOLjxSZ66hheAIf5kMbA==", "357055f6-a25c-43d5-af33-3b8fb476becf" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae8ba81f-1d99-4446-ada3-517915b0c759", "AQAAAAEAACcQAAAAEFJ0OraFDzRyssBIHxk5ACckrNCH7gL9yc1rtUOcuwlMgh8z4ajodMXGgMeSz8Layw==", "16003273-fa01-46b5-8286-e70b6d188930" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d668f936-2562-49b6-9e0f-0df52feb6608", "AQAAAAEAACcQAAAAEERNcuksjv2O565SBvOJWNR/u99abAncYrMOCio8yDaf53ZRafhZW09DUTj169sZnw==", "74b5c0dc-3b58-4cd9-8c6e-3fa6e3464ccc" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c27712d9-d21a-4775-95cc-197b4ac66089", "AQAAAAEAACcQAAAAENqjCE1eN8TsDtN+cSynbsiRtPw8qgpbLx7cjrOdlXyQbPNPcyuVVLMEavlCFAVbPA==", "bae21ca3-6d52-43ee-8ed2-038aa32f9c04" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31c5611e-5dee-48a6-8487-735e40765740", "AQAAAAEAACcQAAAAEGTaColmEOpECkJ1UR1JmF0v0Ze5HnB/lm2spxPifPEMmzMnfZVugDfZkF/ZNVr1Hg==", "5116bffc-5078-4302-9904-3cf49b08e78d" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 12, 3, 1, 7, 58, 597, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "ce4d473f-758d-44f8-ae62-4e5d10a610dd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "ef8a41d3-7157-456c-bbc8-01bad08b1b83");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "0d7343d7-bdd9-4203-b47e-fef82bc933f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "7088639b-8aaf-4d64-bba5-a39ffb9b7de4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "89cc3ed3-39d5-444f-974b-b71a61ebf032");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "CreateBy", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("38ff3d10-369a-4153-a030-2e43bc742b15"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("47bf4751-21c0-40a2-8c09-3a9d62ffd9c8"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("38ff3d10-369a-4153-a030-2e43bc742b15"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("47bf4751-21c0-40a2-8c09-3a9d62ffd9c8"));

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "AdmissionInformation",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43228199-f44a-4a2a-8337-91b54fac56d9", "AQAAAAEAACcQAAAAEFzyEmM7kY5Tnly1cpL3nFpTCTvu9c/KOLxFr2kTFOEUldqkjlxcHDhG8U8ESeybjg==", "8f2fbbff-57ee-4d25-baf4-3144dcdea14c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91deef10-e808-4e62-8c88-ae2adfc632d2", "AQAAAAEAACcQAAAAECMy2yTU/B8f/TP5+EVFMPSCcVwRMvd/JBcltHF7UPuFpWZjmXGKVAj7OgXelsw2FQ==", "0f1a1eb1-8a9d-4892-8032-91b730e0da57" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9484d89b-5ecd-4e88-a4aa-d7d29d065baa", "AQAAAAEAACcQAAAAEFYdBLgJm9Bax9QApjX38k3pYakswQ+3Urs/yyMIwbBDB7QLuyU/1oYU4cuD0+DWQw==", "a52dfea8-01e9-48e7-bba7-b3f3217f5a4d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af4cb0f0-c875-4ad8-a4a4-1ed413cc97b0", "AQAAAAEAACcQAAAAEE21sklsN5uB7iGUk5Fm1KYH2djnAyTn3hbdh65irL4cAUaiGNND5jChT+rp2GU1Lw==", "3309656f-c62b-4651-a4a5-67ac61aabd94" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a133a77-b105-4c61-9911-1aec95260136", "AQAAAAEAACcQAAAAEPne2TpqAQM/YGCtnAF2V7qvfUW2OmRJxnWncIm4XE35y3zcSwJAiNFih8uooacHSA==", "fbd83bf7-a29a-41e9-a5b8-eec0e5cc8795" });

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 1,
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 2,
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 3,
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 4,
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 5,
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 6,
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 7,
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 8,
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 9,
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 10,
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 11,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 12,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 13,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 14,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 15,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 12, 2, 22, 39, 21, 125, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "c4b96b3f-5b24-4766-bd2c-597a6d654c4a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "e8f21537-73ab-473b-baf0-250f77f2cce9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "753029be-f666-416e-af70-2ea6715b63a4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "2c88e1ec-22b0-42c6-9dc0-c08b1a4a54de");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "0a9a0d1c-47e2-4921-a285-4c7d7eb7597a");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "CreateBy", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("297edd0e-e189-4fe2-bebd-511605ccadeb"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("eb83dd37-30f7-482f-a91a-2cc6d4b783af"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });
        }
    }
}
