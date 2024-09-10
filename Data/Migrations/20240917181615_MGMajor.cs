using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGMajor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "978d762f-f311-49a7-80a9-a1a9387d640e", "AQAAAAEAACcQAAAAEO6r3UrMezZSaLX9/xJdiN4GvspweRKH5J1yeQK4bfg4k1TW5naR5vKDVSESitLGUw==", "8ec27679-ce58-4177-aab5-e2630d6d462f" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "7a05da36-6635-4936-bce2-0a57d7e2b0a8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "2a3bff2b-3c63-498a-8e55-589d6231802a");

            migrationBuilder.InsertData(
                table: "SpecializeMajor",
                columns: new[] { "SpecializeMajorID", "MajorID", "SpecializeMajorName" },
                values: new object[,]
                {
                    { "AO", "O", "Kiểm toán" },
                    { "BS", "B", "Chăm sóc da và massage" },
                    { "BT", "B", "Phum xăm thẩm mỹ" },
                    { "EA", "A", "Ngôn ngữ anh" },
                    { "FO", "O", "Kỹ thuật chế biến món ăn" },
                    { "GE", "E", "Lập trình game" },
                    { "HM", "S", "Quản trị khách sạn" },
                    { "JA", "A", "Ngôn ngữ nhật" },
                    { "KA", "A", "Ngôn ngữ hàn" },
                    { "ME", "E", "Lập trình mobile" },
                    { "RM", "S", "Quản trị nhà hàng" },
                    { "SM", "S", "Marketing" },
                    { "SO", "O", "Thư ký văn phòng" },
                    { "TE", "E", "Kiểm thử" },
                    { "WE", "E", "Lập trình web" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "AO");

            migrationBuilder.DeleteData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "BS");

            migrationBuilder.DeleteData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "BT");

            migrationBuilder.DeleteData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "EA");

            migrationBuilder.DeleteData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "FO");

            migrationBuilder.DeleteData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "GE");

            migrationBuilder.DeleteData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "HM");

            migrationBuilder.DeleteData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "JA");

            migrationBuilder.DeleteData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "KA");

            migrationBuilder.DeleteData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "ME");

            migrationBuilder.DeleteData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "RM");

            migrationBuilder.DeleteData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "SM");

            migrationBuilder.DeleteData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "SO");

            migrationBuilder.DeleteData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "TE");

            migrationBuilder.DeleteData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "WE");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef9b23ce-e9d7-4200-8536-2ff36460ce90", "AQAAAAEAACcQAAAAEKCcBE79AQjh3yHbnLcfAW/78Y9sZ9CR8y+Y84+9X2iuz52GAj8dRU/kPPVvnj/wzg==", "024183f0-79cd-48b1-8f9f-7a81f3ef089c" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "275cddbc-5b94-4900-b243-6deadebcc359");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "2891ced1-3375-42e8-aaa4-c32c426b4fb8");
        }
    }
}
