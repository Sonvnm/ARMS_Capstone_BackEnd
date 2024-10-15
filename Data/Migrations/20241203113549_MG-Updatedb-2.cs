using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGUpdatedb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("38ff3d10-369a-4153-a030-2e43bc742b15"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("47bf4751-21c0-40a2-8c09-3a9d62ffd9c8"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95aa0fa7-e8cf-439b-9794-003056f55c44", "AQAAAAEAACcQAAAAEFv3/KdcVJSIPwmfujjL/u7y6DRIfg/eSltsHQXInsqcL7z/0UhaXt7tDUDnzQOmLw==", "415f3790-eb44-478b-ab87-693196530ec8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e651fda-e6e1-44d7-b043-6ac44f70e42b", "AQAAAAEAACcQAAAAEO/wbpFzIGHZ2Tx0Y44UTceaxXRTA4AMI36fMtwIIYakzW4pS4fd88lodAKBaGZSew==", "4ee091b3-4d72-4779-b6da-c3c992a495dd" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12ade52e-bb3e-4a86-a59d-770cfbde1bcb", "AQAAAAEAACcQAAAAEJOBfvM2AEOudfOjVEJwAFNestomIcYA5d0Lwwjpt0HGUeXL7MXZVQV0PVezP1vO4w==", "70332796-6b8a-42f4-b748-22ef183a4aca" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e14d481-9d77-4bcc-9ce8-54828f5db9df", "AQAAAAEAACcQAAAAEMzIl6XBhH3wQWNR7aehLyO7JT3MXaHj0knCzNZ4RWKDsyILEc5oO5C28bwMG1cfLA==", "dd7c3d19-15d2-4d90-996c-00a70ae4f0a1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8605f994-40be-471b-bf67-a2b76de10574", "AQAAAAEAACcQAAAAEHo34eZ/LEXzfV1A1Ply/cx64n9V9ryoPU3+u2aTJQe9MM+f8ZbvxtbkodAIyDlfXw==", "9e6fa093-ca89-4f28-9ff2-4926c7c67af5" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 12, 3, 18, 35, 47, 586, DateTimeKind.Local).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "88ddeb95-4e2b-472b-a2ec-e24e7c5ba5a9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "426a2511-7e02-42d5-88b1-55a1dcf7a886");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "63abd731-5031-46f0-9420-07ba437f927a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "85df8a98-6e49-4e2c-9f08-49a4b0c80852");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "0e6dc3a5-f6cc-40dd-8838-b1f4d5bf38e8");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "CreateBy", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("08bb7db2-ce67-46cd-b745-2eb667a9484c"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("217bb2b0-e306-43fa-a5cb-f724cf9fcb7d"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.InsertData(
                table: "TypeAdmission",
                columns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma", "TypeOfTranscript" },
                values: new object[,]
                {
                    { 31, "HAO", 1, null },
                    { 31, "HAO", 2, null },
                    { 31, "HAO", 3, 1 },
                    { 31, "HBS", 1, null },
                    { 31, "HBS", 2, null },
                    { 31, "HBS", 3, 1 },
                    { 31, "HBT", 1, null },
                    { 31, "HBT", 2, null },
                    { 31, "HBT", 3, 1 },
                    { 31, "HEA", 1, null },
                    { 31, "HEA", 2, null },
                    { 31, "HEA", 3, 2 },
                    { 31, "HFO", 1, null },
                    { 31, "HFO", 2, null },
                    { 31, "HFO", 3, 1 },
                    { 31, "HHM", 1, null },
                    { 31, "HHM", 2, null }
                });

            migrationBuilder.InsertData(
                table: "TypeAdmission",
                columns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma", "TypeOfTranscript" },
                values: new object[,]
                {
                    { 31, "HHM", 3, 1 },
                    { 31, "HJA", 1, null },
                    { 31, "HJA", 2, null },
                    { 31, "HJA", 3, 4 },
                    { 31, "HKA", 1, null },
                    { 31, "HKA", 2, null },
                    { 31, "HKA", 3, 1 },
                    { 31, "HRM", 1, null },
                    { 31, "HRM", 2, null },
                    { 31, "HRM", 3, 1 },
                    { 31, "HSM", 1, null },
                    { 31, "HSM", 2, null },
                    { 31, "HSM", 3, 1 },
                    { 31, "HSO", 1, null },
                    { 31, "HSO", 2, null },
                    { 31, "HSO", 3, 1 },
                    { 31, "HTE", 0, null },
                    { 31, "HTE", 2, null },
                    { 31, "HTE", 3, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("08bb7db2-ce67-46cd-b745-2eb667a9484c"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("217bb2b0-e306-43fa-a5cb-f724cf9fcb7d"));

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HAO", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HAO", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HAO", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HBS", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HBS", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HBS", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HBT", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HBT", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HBT", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HEA", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HEA", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HEA", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HFO", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HFO", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HFO", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HHM", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HHM", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HHM", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HJA", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HJA", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HJA", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HKA", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HKA", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HKA", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HRM", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HRM", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HRM", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HSM", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HSM", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HSM", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HSO", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HSO", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HSO", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HTE", 0 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HTE", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionTimeId", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 31, "HTE", 3 });

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
    }
}
