using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGUpdatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("1ba9a6e2-9399-4755-b6ec-2e8d573814a0"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("f7e5208e-1b32-4181-8085-810f469a9ea4"));

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

            migrationBuilder.InsertData(
                table: "MajorAdmission",
                columns: new[] { "AdmissionTimeId", "MajorID", "Status", "SubjectGroupsJson", "Target", "TotalScore", "TotalScoreAcademic" },
                values: new object[,]
                {
                    { 31, "HAO", true, "[0,1]", 200, 24m, 24m },
                    { 31, "HBS", true, "[0,1]", 200, 24m, 24m },
                    { 31, "HBT", true, "[0,1]", 200, 24m, 24m },
                    { 31, "HEA", true, "[0,1]", 200, 24m, 24m },
                    { 31, "HFO", false, "[0,1]", 200, 24m, 24m },
                    { 31, "HGE", true, "[0,1]", 200, 24m, 24m },
                    { 31, "HHM", true, "[0,1]", 200, 24m, 24m },
                    { 31, "HJA", true, "[0,1]", 200, 24m, 24m },
                    { 31, "HKA", true, "[0,1]", 200, 24m, 24m },
                    { 31, "HME", true, "[0,1]", 200, 24m, 24m },
                    { 31, "HRM", true, "[0,1]", 200, 24m, 24m },
                    { 31, "HSM", true, "[0,1]", 200, 24m, 24m },
                    { 31, "HSO", true, "[0,1]", 200, 24m, 24m },
                    { 31, "HTE", true, "[0,1]", 200, 24m, 24m },
                    { 31, "HWE", true, "[0,1]", 200, 24m, 24m }
                });

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

            migrationBuilder.InsertData(
                table: "TypeAdmission",
                columns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma", "TypeOfTranscript" },
                values: new object[,]
                {
                    { 31, "HGE", 3, 0 },
                    { 31, "HGE", 4, null },
                    { 31, "HME", 1, null },
                    { 31, "HME", 2, null },
                    { 31, "HWE", 2, null },
                    { 31, "HWE", 3, 1 },
                    { 31, "HWE", 4, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID" },
                keyValues: new object[] { 31, "HAO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID" },
                keyValues: new object[] { 31, "HBS" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID" },
                keyValues: new object[] { 31, "HBT" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID" },
                keyValues: new object[] { 31, "HEA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID" },
                keyValues: new object[] { 31, "HFO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID" },
                keyValues: new object[] { 31, "HHM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID" },
                keyValues: new object[] { 31, "HJA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID" },
                keyValues: new object[] { 31, "HKA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID" },
                keyValues: new object[] { 31, "HRM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID" },
                keyValues: new object[] { 31, "HSM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID" },
                keyValues: new object[] { 31, "HSO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID" },
                keyValues: new object[] { 31, "HTE" });

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("297edd0e-e189-4fe2-bebd-511605ccadeb"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("eb83dd37-30f7-482f-a91a-2cc6d4b783af"));

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HGE", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HGE", 4 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HME", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HME", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HWE", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HWE", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HWE", 4 });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID" },
                keyValues: new object[] { 31, "HGE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID" },
                keyValues: new object[] { 31, "HME" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID" },
                keyValues: new object[] { 31, "HWE" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cfcc348-d005-4b60-b4ec-52b33c79989d", "AQAAAAEAACcQAAAAEAmB45FPA4AwQeKJMOdfY6RQm3PSDFRyzlLaV8VZvk8cD/1zHp7hCm2Beon0ikcN2Q==", "4d94a0c9-3b9a-456d-be3c-defa8cee9d00" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41ed53b8-236d-4b45-b376-f60dcdfb1a64", "AQAAAAEAACcQAAAAEOOKjDs0yzwUQuRB49aJsZ05o5feCtiQiacNmvcmyNeml4OhdcXuMp9zNeqyb4KH3Q==", "5910b125-e753-4720-944e-10e81c4d329d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9ed3234-b44c-4fdd-8277-4b06ffe7bf8d", "AQAAAAEAACcQAAAAEPeD7SboLTxfxL3i93Cscgq5sxSzi/co7Rn5Si4D4WnCz+IK9APQ0vj+K9attYBSIw==", "0b86bc7d-a043-4ed7-b6eb-2421b39d5d78" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "281042ce-7326-4d39-b153-6ec699644bf9", "AQAAAAEAACcQAAAAEMtws3rVFCNh52+oQsVVGZIqoBIXVRYnOm1xLfc7myuMQecTWSStnivfHnW0ndi01w==", "1965f002-a01c-46e1-bc5a-edcce1319572" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2acee46c-7fd6-4454-8974-4572e642123c", "AQAAAAEAACcQAAAAELCFsAvhkCjBReL6XMCtVv+SCX3NEnZHluriu8+a4kC5qbEXgYz7KdRRNmpTH9b4IQ==", "fd2c61bf-15a4-46dd-9e47-c30b6bd61981" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 12, 2, 22, 25, 57, 867, DateTimeKind.Local).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "fcfa1855-941e-4c95-9274-9df7c4462362");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "7dca336c-dc19-488a-aaec-feb1dcf00d3d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "7fe7e95f-f610-4bfc-a5b8-377cf4a90f1c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "689576bf-06a0-42fb-af37-5376ce777d00");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "391a5344-4a75-4166-9d3d-02f20f8f21f7");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "CreateBy", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("1ba9a6e2-9399-4755-b6ec-2e8d573814a0"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("f7e5208e-1b32-4181-8085-810f469a9ea4"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });
        }
    }
}
