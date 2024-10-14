using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class TestMajor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Major",
                columns: table => new
                {
                    MajorID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MajorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Major", x => x.MajorID);
                    table.ForeignKey(
                        name: "FK_Major_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecializeMajor",
                columns: table => new
                {
                    SpecializeMajorID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SpecializeMajorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MajorID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecializeMajor", x => x.SpecializeMajorID);
                    table.ForeignKey(
                        name: "FK_SpecializeMajor_Major_MajorID",
                        column: x => x.MajorID,
                        principalTable: "Major",
                        principalColumn: "MajorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55485c63-8025-4a17-9934-a8a80957d843", "AQAAAAEAACcQAAAAEGeUOt+vqmcb495bWdAskCw5soCamUc9c5EVVDTw87zK3I/yC5MwkCPKzTRqNdlBlQ==", "b9b4e9a6-2b32-4400-997d-2b863dd073c5" });

            migrationBuilder.InsertData(
                table: "Major",
                columns: new[] { "MajorID", "CampusId", "MajorName" },
                values: new object[,]
                {
                    { "A", "Hanoi", "Ngôn ngữ" },
                    { "B", "Hanoi", "Làm đẹp" },
                    { "E", "Hanoi", "Công nghệ thông tin" },
                    { "O", "Hanoi", "Ngành khác" },
                    { "S", "Hanoi", "Quản trị kinh doanh" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Major_CampusId",
                table: "Major",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecializeMajor_MajorID",
                table: "SpecializeMajor",
                column: "MajorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpecializeMajor");

            migrationBuilder.DropTable(
                name: "Major");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9498aa02-ae27-4078-889b-79ed400ecd25", "AQAAAAEAACcQAAAAEJ/SLQcQFYXDhF4j8hHwOp408nKbVrZwJwQjbvPJ5aQBj7WBGkp8kp1AeMWLo1D1ZA==", "cfb81a92-b34c-4d12-96bd-84cc055b1277" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "207ff729-ffa7-4108-8d9d-668a9f9b71df");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "10c58917-d941-41bf-b67a-fdc4afb04c0f");
        }
    }
}
