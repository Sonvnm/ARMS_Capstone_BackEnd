using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGStudentProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("471c576c-e106-4ca1-9c08-022ce171f507"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("4ab7f3b3-9cd9-4c3b-a8a0-4dcf8b1ed9bb"));

            migrationBuilder.AddColumn<int>(
                name: "SPId",
                table: "Account",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StudentProfile",
                columns: table => new
                {
                    SpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: true),
                    Nation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitizenIentificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CIDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CIAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ward = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecificAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailStudent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneStudent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullnameParents = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneParents = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Major = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearOfGraduation = table.Column<int>(type: "int", nullable: true),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecipientResults = table.Column<bool>(type: "bit", nullable: true),
                    PermanentAddress = table.Column<bool>(type: "bit", nullable: true),
                    AddressRecipientResults = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgCitizenIdentification1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgCitizenIdentification2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgDiploma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAcademicTranscript1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAcademicTranscript2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAcademicTranscript3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAcademicTranscript4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAcademicTranscript5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfDiploma = table.Column<int>(type: "int", nullable: false),
                    TypeOfTranscript = table.Column<int>(type: "int", nullable: true),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentProfile", x => x.SpId);
                    table.ForeignKey(
                        name: "FK_StudentProfile_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentProfile_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b21a2d8a-19df-427f-bfc9-79a916f203f7", "AQAAAAEAACcQAAAAEO5w1zN+Rrs24i4GL1m1OgzQ5fVrPBnOLl2tmspX2BEhtzi2lZ2TlZq8HtRekJZOLg==", "94694689-e620-4a24-a75f-191ae95face1" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 5, 48, 50, 739, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 5, 48, 50, 739, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 5, 48, 50, 739, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 5, 48, 50, 739, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 5, 48, 50, 739, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 5, 48, 50, 739, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 5, 48, 50, 739, DateTimeKind.Local).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 5, 48, 50, 739, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 5, 48, 50, 739, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "e9f75b6b-5075-40d8-8817-91a36b1e5d61");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "b852c219-4b95-4c3f-97fa-6e315d213377");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("206773fc-3803-47eb-8839-81bcaaa8d35f"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("89994961-43ed-4b10-8435-fcbaa64c9f48"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentProfile_AccountId",
                table: "StudentProfile",
                column: "AccountId",
                unique: true,
                filter: "[AccountId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_StudentProfile_CampusId",
                table: "StudentProfile",
                column: "CampusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentProfile");

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("206773fc-3803-47eb-8839-81bcaaa8d35f"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("89994961-43ed-4b10-8435-fcbaa64c9f48"));

            migrationBuilder.DropColumn(
                name: "SPId",
                table: "Account");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b80e7dc8-c335-45e1-9e10-56c21eec83ac", "AQAAAAEAACcQAAAAELqvsMRwtdCZYZBNoM+U0xJUSDS3gczUQb330fa/eVnJ5IE50WiXzJqsdyNPAgabJA==", "063e4843-948c-41f0-a180-57d19d318310" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 9, 22, 58, 22, 746, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 9, 22, 58, 22, 746, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 9, 22, 58, 22, 746, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 9, 22, 58, 22, 746, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 9, 22, 58, 22, 746, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 9, 22, 58, 22, 746, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 9, 22, 58, 22, 746, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 9, 22, 58, 22, 746, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 9, 22, 58, 22, 746, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "e0f0230f-803b-460d-bc0b-1cd1dd3521d8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "4c1a14bc-07c5-4677-8e2f-0c708b26dacc");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("471c576c-e106-4ca1-9c08-022ce171f507"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("4ab7f3b3-9cd9-4c3b-a8a0-4dcf8b1ed9bb"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });
        }
    }
}
