using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGAdmissionTimeupdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdmissionInformation");

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("6832d500-a44a-4cac-8070-b522800caacf"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("98b1e579-1ea0-4313-94e8-f9aa77791fe5"));

            migrationBuilder.CreateTable(
                name: "AdmissionTime",
                columns: table => new
                {
                    AIId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdmissionInformationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    StartRegister = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndRegister = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartAdmission = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndAdmission = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmissionTime", x => x.AIId);
                    table.ForeignKey(
                        name: "FK_AdmissionTime_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId");
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b63cb69-d4bf-4c44-a273-773e21adbabd", "AQAAAAEAACcQAAAAENGZQzQ9ZRMBNS94Q+H3KHQLMwtfFIDk4kRpMsaFux5aKR52wQHRESCWlZx5lnA/kg==", "576b0d44-775b-4da9-97c0-1fd3d8439d66" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17b28d8f-6537-4b8e-9207-7fdabf85f8da", "AQAAAAEAACcQAAAAEBtJ4eO8374fVBSpbwlbxbu1+CgcScaqD7SyAdTRz1BSEZnMpRm/JglUVxyf56n6hw==", "41eee518-aac5-4b11-ba01-0ec8cdb4d1e7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c59f17d-2643-41f4-8be0-3cd2b9a00448", "AQAAAAEAACcQAAAAEOMOB0+cplooHv36ZSbjpVK9beuAJH2y9Y65imwYbssqrMEAEMTpgofquKpCBp2dkg==", "55438370-220c-4557-8d08-ee9c7e540eee" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6d8a5d3-a67b-44de-b0cf-09cb3cde788d", "AQAAAAEAACcQAAAAEBbRklwsFerrBz4iz6piMxgcCaS+8nUYwPMs2wUDMItJppU2Wx/BLfW55Djz7FsQeg==", "249cfd74-3043-441b-96b3-34df3fedbbf5" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 1, 6, 42, 601, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 1, 6, 42, 601, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 1, 6, 42, 601, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 1, 6, 42, 601, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 1, 6, 42, 601, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 1, 6, 42, 601, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 1, 6, 42, 601, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 1, 6, 42, 601, DateTimeKind.Local).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 1, 6, 42, 601, DateTimeKind.Local).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "c67cc82f-4898-467c-a6e8-c7462903ccb1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "2bdec43d-7ead-424d-b670-3e2a39982a3f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "5aca13fb-8f33-4a7a-9d1d-d15d6d3077cd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "e88a3bf5-f461-46cd-8207-d524f6bccb38");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "d7746b2b-04d3-4f77-852a-ab22bfc8ea88");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("9f300283-09d6-443e-9020-2b192d6c70ca"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("db74e973-ee1d-4516-9b34-d9e5e1bcb841"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionTime_CampusId",
                table: "AdmissionTime",
                column: "CampusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdmissionTime");

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("9f300283-09d6-443e-9020-2b192d6c70ca"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("db74e973-ee1d-4516-9b34-d9e5e1bcb841"));

            migrationBuilder.CreateTable(
                name: "AdmissionInformation",
                columns: table => new
                {
                    AIId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AdmissionInformationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndAdmission = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndRegister = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartAdmission = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartRegister = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmissionInformation", x => x.AIId);
                    table.ForeignKey(
                        name: "FK_AdmissionInformation_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId");
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1527f7f7-293e-46da-bdab-19ef138329e6", "AQAAAAEAACcQAAAAECNgSrUFhMJ+8ihr/5079HSexk26Icxb0u/Z60cWuB6ugCQsPl0Coi5mjMD9WkMevQ==", "f8c23856-e741-43be-856a-1721486435d4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9121b087-265d-4faa-b350-d68f5e7332dd", "AQAAAAEAACcQAAAAEBxxw2qzr9OLeUs0pklldCAItxOMyYRPHzIw1/AshP0kBzjzd92tTJlK624ImmaDjg==", "5ac82e18-b0ba-434f-b1b1-918054b9bb3e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b15d2b5d-99c0-4ee5-990a-008c134dc58e", "AQAAAAEAACcQAAAAEBtt4oX0Md/fUyNSlWcAZHcJ3h7myLflSHK1JEz4v2P40pRxdHMSy4jNDoGeKk2iFA==", "9748172a-0706-4b1f-b962-e0e67c9f9a5d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb54db15-ee9e-4e94-857e-0b8e5c4477a7", "AQAAAAEAACcQAAAAEHOtzEVtkwTphE9VYfRaU7Lms2VGwULJ//EprL0xhtKsmJz7O7qZz+UqvnTtMiZ79w==", "a1378278-f980-4ed4-8bcf-af0d4283ffce" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 0, 41, 51, 377, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 0, 41, 51, 377, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 0, 41, 51, 377, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 0, 41, 51, 377, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 0, 41, 51, 377, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 0, 41, 51, 377, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 0, 41, 51, 377, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 0, 41, 51, 377, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 0, 41, 51, 377, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "292638b1-43ca-4bd3-bf70-9fc10a3cae4e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "5c07f51a-ada3-488e-a9ad-e8fa417984df");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "d6138436-2819-4778-aee2-7b6f4fad9314");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "7ea0d1c2-828b-45cd-817f-365e2f00b9a5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "f50eae76-8cf0-4ee6-8923-c5d967f03763");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("6832d500-a44a-4cac-8070-b522800caacf"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("98b1e579-1ea0-4313-94e8-f9aa77791fe5"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionInformation_CampusId",
                table: "AdmissionInformation",
                column: "CampusId");
        }
    }
}
