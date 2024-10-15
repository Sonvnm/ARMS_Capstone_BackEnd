using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class AddStudentConsultation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentConsultation",
                columns: table => new
                {
                    SCId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkFB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    DateReceive = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProcessDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SpecializeMajorID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentConsultation", x => x.SCId);
                    table.ForeignKey(
                        name: "FK_StudentConsultation_Account_UserID",
                        column: x => x.UserID,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentConsultation_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId");
                    table.ForeignKey(
                        name: "FK_StudentConsultation_SpecializeMajor_SpecializeMajorID",
                        column: x => x.SpecializeMajorID,
                        principalTable: "SpecializeMajor",
                        principalColumn: "SpecializeMajorID");
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b1275a1-26f7-4060-ac20-cbc8ae97711c", "AQAAAAEAACcQAAAAEK3/BRBV8eUTJjX+u7ckCLwn6rFF49maIc12Ywdmlag2gWKT4y5di+zAqLE24Vz/og==", "99db37b4-cf08-433c-aa64-15501ecad6ed" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "f05bf5a4-947f-40e0-86fe-cae9105023cc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "a07041de-2c4a-41b1-842b-7893aaa06176");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "SCId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "ProcessDate", "SpecializeMajorID", "Status", "UserID" },
                values: new object[,]
                {
                    { 1, "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", null, "ME", false, null },
                    { 2, "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", null, "ME", false, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentConsultation_CampusId",
                table: "StudentConsultation",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentConsultation_SpecializeMajorID",
                table: "StudentConsultation",
                column: "SpecializeMajorID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentConsultation_UserID",
                table: "StudentConsultation",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentConsultation");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "531356ec-f04f-4185-a247-1b6daaf25158", "AQAAAAEAACcQAAAAEPwUiTJFsHSSrnot1hMdhbcCSX6PeWMc6Dv1oGGVqrdy/qAnpdZ1lLNIkzPhAOPxHQ==", "d6641349-d552-4989-844c-b53fbfc1ea4e" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "b4701c64-6dbb-4c73-b2a2-6ebacf0cfe8d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "23601acb-4477-4d1a-b594-694eceb0e056");
        }
    }
}
