using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGDataMajor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "Quynhon");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Campus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Campus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa9a6b06-1756-4e85-bf18-536580558f50", "AQAAAAEAACcQAAAAEHPXWoKitclqpwtmL6BPfULJvWxwd6VtxPLN4nL1yk4C7hSjJI+hp7x054qfmyIQ4g==", "37454b97-331a-4332-af72-854ee61947d8" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "Cantho",
                columns: new[] { "Address", "PhoneNumber" },
                values: new object[] { "Toà nhà FPT Polytechnic, đường số 22, phường Thường Thạnh,quận Cái Răng, TP Cần Thơ", "0983881100" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "Danang",
                columns: new[] { "Address", "PhoneNumber" },
                values: new object[] { "219 Nguyễn Sinh Sắc, phường Hoà Minh, quận Liên Chiểu, TP Đà Nẵng", "02363710999" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "Hanoi",
                columns: new[] { "Address", "PhoneNumber" },
                values: new object[] { "Cổng số 1, Tòa nhà FPT Polytechnic, 13 phố Trịnh Văn Bô, phường Phương Canh, quận Nam Từ Liêm, TP Hà NộiKm12 Cầu Diễn, Phường Phúc Diễn, Quận Bắc Từ Liêm, Hà Nội", "02485820808" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "HCM",
                columns: new[] { "Address", "PhoneNumber" },
                values: new object[] { "Tòa nhà QTSC9 (toà T), đường Tô Ký, phường Tân Chánh Hiệp, quận 12, TP HCM.778/B1 Nguyễn Kiệm, phường 04, quận Phú Nhuận, TP HCM", "02866866486" });

            migrationBuilder.InsertData(
                table: "Campus",
                columns: new[] { "CampusId", "Address", "CampusName", "PhoneNumber" },
                values: new object[] { "Thanhhoa", "Tòa Beta, Tổ hợp giáo dục FPT, Đại lộ Võ Nguyên Giáp, phường Quảng Thành, TP Thanh Hóa", "Thanh Hoá", "0913785213" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "14166a33-0366-42f7-a214-24da50b85dfd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "f06517c9-3902-4e6a-9df5-8aff09b3b79f");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "Thanhhoa");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Campus");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Campus");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "978d762f-f311-49a7-80a9-a1a9387d640e", "AQAAAAEAACcQAAAAEO6r3UrMezZSaLX9/xJdiN4GvspweRKH5J1yeQK4bfg4k1TW5naR5vKDVSESitLGUw==", "8ec27679-ce58-4177-aab5-e2630d6d462f" });

            migrationBuilder.InsertData(
                table: "Campus",
                columns: new[] { "CampusId", "CampusName" },
                values: new object[] { "Quynhon", "Quy Nhơn" });

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
        }
    }
}
