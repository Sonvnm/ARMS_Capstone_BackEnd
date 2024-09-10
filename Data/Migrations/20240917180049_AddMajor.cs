using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class AddMajor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55485c63-8025-4a17-9934-a8a80957d843", "AQAAAAEAACcQAAAAEGeUOt+vqmcb495bWdAskCw5soCamUc9c5EVVDTw87zK3I/yC5MwkCPKzTRqNdlBlQ==", "b9b4e9a6-2b32-4400-997d-2b863dd073c5" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "03abcbab-e222-4258-b620-d0fbe9e54e6f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "5756bec9-733d-4b39-9acb-be251d2b827d");
        }
    }
}
