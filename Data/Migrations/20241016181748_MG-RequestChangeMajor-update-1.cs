using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGRequestChangeMajorupdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("094948ad-ed56-4886-baea-a8479efa865f"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("a6024aeb-6929-4b2d-9965-2ec999d4fd90"));

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "RequestChangeMajor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d181be20-bc11-4216-a091-6ba78f1972a4", "AQAAAAEAACcQAAAAEDC97V2DMx7Mf7e0JuPWTyJ34KtgDh+N/533w7ZrN4VJvbwXr7N3p7/YZKqGvCFnow==", "808a27f0-fe95-4fe2-81ff-8fe65ce552b0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce20b7b0-5109-41ed-99f8-4b95047289b4", "AQAAAAEAACcQAAAAEJNcAYSIZt0V1Gu19xuJM+5VKPE/AXcHAcNBgE6jOGcse2nIEQJxSmtvJ9kKTfHm5Q==", "99aebe87-aa3e-4c57-9149-fee0c52ba445" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d969dca-89b4-45be-804f-c4cb18aff3ee", "AQAAAAEAACcQAAAAEKWu9uMlZ0WexClt3iE/BkOdHbracY3Hz1CjE8K52xhq4h46MRG8ilFLQk9kJfhMIw==", "33b6d4ef-a7ea-4056-96d5-6f09bd11967b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af29cd8e-fd3c-4d2c-95b4-5e96276c4244", "AQAAAAEAACcQAAAAEEBOM/yp+EMiKgstrbtrtB99W6LTZ9pfTqre7JPtLPrcpsJnO1oEfOcemN73DrIjkQ==", "b2684f4b-d935-473e-b515-1171581c0d2a" });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "AccessFailedCount", "AvatarURL", "CampusId", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "Fullname", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SPId", "SecurityStamp", "TwoFactorEnabled", "UserName", "isAccountActive" },
                values: new object[] { new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), 0, null, "Hanoi", "d07b1ad0-2fad-4bff-a05f-473529acdfe2", null, "nguyenducanh01.57@gmail.com", true, "Nguyễn Đức Anh", null, false, null, "NGUYENDUCANH01.57@GMAIL.COM", "STUDENT", "AQAAAAEAACcQAAAAEDReunfPU/ep5TUNC2YTrYomqzEjmZFG23Vqp9xeP7HZSRqqRz/lVMi7lfFAuW6k0Q==", null, null, false, null, "9a882c6b-b8ea-4555-8559-b2f6a7a87f19", false, "DucAnh", false });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 17, 47, 736, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 17, 47, 736, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 17, 47, 736, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 17, 47, 736, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 17, 47, 736, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 17, 47, 736, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 17, 47, 736, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 17, 47, 736, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 17, 47, 736, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "20d031c7-680e-4a3b-8e6c-f67601791aa6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "41a8851a-b13b-47aa-a81d-9437e0e1a65b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "37e9b13d-ff3b-48d1-952a-895577cf5e85");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "8c7ba5c4-b144-4280-aa52-c999ba69a1e9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "60d02b39-d273-4094-b2c3-36f5d960ae37");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("8cd07dc4-46b6-4974-be57-0b9ef4a2ab3c"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("a896baa6-bd75-4630-aa9b-42ebde4efc29"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.InsertData(
                table: "RequestChangeMajor",
                columns: new[] { "RequestID", "AccountId", "DateRequest", "Description", "FileReasonRequestChangeMajor", "MajorNew", "Status" },
                values: new object[,]
                {
                    { 1, new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), new DateTime(2024, 10, 17, 1, 17, 47, 736, DateTimeKind.Local).AddTicks(6571), "Em muốn chuyển ngành!", "file", "HME", false },
                    { 2, new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), new DateTime(2024, 10, 17, 1, 17, 47, 736, DateTimeKind.Local).AddTicks(6574), "Em muốn chuyển ngành!", "file", "HME", false }
                });

            migrationBuilder.InsertData(
                table: "StudentProfile",
                columns: new[] { "SpId", "AccountId", "AddressRecipientResults", "CIAddress", "CIDate", "CampusId", "CitizenIentificationNumber", "District", "Dob", "EmailStudent", "Fullname", "FullnameParents", "Gender", "ImgAcademicTranscript1", "ImgAcademicTranscript2", "ImgAcademicTranscript3", "ImgAcademicTranscript4", "ImgAcademicTranscript5", "ImgCitizenIdentification1", "ImgCitizenIdentification2", "ImgDiploma", "Major", "Nation", "PermanentAddress", "PhoneParents", "PhoneStudent", "Province", "RecipientResults", "SchoolName", "SpecificAddress", "StudentCode", "TypeOfDiploma", "TypeOfTranscript", "Ward", "YearOfGraduation" },
                values: new object[] { new Guid("46d0be06-e4a7-4a73-bce3-517d4f3ca3c2"), new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), null, "HCM", new DateTime(2024, 10, 17, 1, 17, 47, 736, DateTimeKind.Local).AddTicks(6550), "Hanoi", "038301012121", null, new DateTime(2024, 10, 17, 1, 17, 47, 736, DateTimeKind.Local).AddTicks(6553), "nguyenducanh01.57@gmail.com", "Nguyễn Đức Anh", null, true, null, null, null, null, null, null, null, null, "HAO", null, null, null, "0971341555", null, null, null, null, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"), new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("8cd07dc4-46b6-4974-be57-0b9ef4a2ab3c"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("a896baa6-bd75-4630-aa9b-42ebde4efc29"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("46d0be06-e4a7-4a73-bce3-517d4f3ca3c2"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"), new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa") });

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"));

            migrationBuilder.DropColumn(
                name: "Status",
                table: "RequestChangeMajor");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbe2b24d-9f91-49c6-b3fd-dfb232f2604d", "AQAAAAEAACcQAAAAENE50+QyC9OKmOB0UwytE+ahdFakWARPLdL4TfNMhahrLvjZra8ns86R07UakqtPtw==", "2c3daa50-d216-4fbd-8831-a1e3bde89a93" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ade944e6-3e80-4681-b778-d51d937d3078", "AQAAAAEAACcQAAAAEMCN+HQzvZJt5cNV1ih2h5VR8HpRaDtus4GkAoDVzG2ch9A7gmbWzC/Y9Af33p8kWA==", "c8bc242f-bef7-4a1c-a040-644c09be81d5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "825116ad-8f7b-4acd-8607-7b68cb61ad51", "AQAAAAEAACcQAAAAEKTtjpOnfunbzob5kjVPtlnjTAPoWqREFrb2g7pVbUPq5Vwl/UXuP9sD42A7aUIg6w==", "10ac4c91-d1ce-4bc6-880f-7042a67469ac" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fb07a32-d905-4914-8f93-40d7d542458d", "AQAAAAEAACcQAAAAEIi9n5euFkz/8FeAjMyHRhg0L+7GtInCxOcTYmUreOevzUiW9Hf5OnielHnlrfWtoA==", "224b1051-cc42-4f1c-a4fe-1b96f0015130" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 1, 46, 494, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 1, 46, 494, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 1, 46, 494, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 1, 46, 494, DateTimeKind.Local).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 1, 46, 494, DateTimeKind.Local).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 1, 46, 494, DateTimeKind.Local).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 1, 46, 494, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 1, 46, 494, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 1, 46, 494, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "cb04b13a-6b3a-4d9f-8138-c9cc95857768");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "640a9979-23f5-4585-9647-0c1cd8fec715");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "dab150b2-3335-4592-b7e7-6ac9011e691a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "5bf8050b-2b6a-4f04-a267-d410789626bb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "09154e36-aca7-420a-bffa-99ec8a476d1e");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("094948ad-ed56-4886-baea-a8479efa865f"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("a6024aeb-6929-4b2d-9965-2ec999d4fd90"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });
        }
    }
}
