using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGAccountupdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("9a8aa16f-2177-491b-b7a8-90e4959d4b71"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("e94547de-1875-48ab-bd89-7b049ab9693a"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1527f7f7-293e-46da-bdab-19ef138329e6", "SchoolService@gmail.com", "AQAAAAEAACcQAAAAECNgSrUFhMJ+8ihr/5079HSexk26Icxb0u/Z60cWuB6ugCQsPl0Coi5mjMD9WkMevQ==", "f8c23856-e741-43be-856a-1721486435d4", "SchoolService" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9121b087-265d-4faa-b350-d68f5e7332dd", "AdmissionOfficer@gmail.com", "ADMISSIONOFFICER@GMAIL.COM", "ADMISSIONOFFICER", "AQAAAAEAACcQAAAAEBxxw2qzr9OLeUs0pklldCAItxOMyYRPHzIw1/AshP0kBzjzd92tTJlK624ImmaDjg==", "5ac82e18-b0ba-434f-b1b1-918054b9bb3e", "AdmissionOfficer" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb54db15-ee9e-4e94-857e-0b8e5c4477a7", "AQAAAAEAACcQAAAAEHOtzEVtkwTphE9VYfRaU7Lms2VGwULJ//EprL0xhtKsmJz7O7qZz+UqvnTtMiZ79w==", "a1378278-f980-4ed4-8bcf-af0d4283ffce" });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "AccessFailedCount", "AvatarURL", "CampusId", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "Fullname", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SPId", "SecurityStamp", "TwoFactorEnabled", "UserName", "isAccountActive" },
                values: new object[] { new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"), 0, null, "Hanoi", "b15d2b5d-99c0-4ee5-990a-008c134dc58e", null, "AdmissionCouncil@gmail.com", true, "Admission Council Hanoi", null, false, null, "ADMISSIONCOUNCIL@GMAIL.COM", "ADMISSIONCOUNCIL", "AQAAAAEAACcQAAAAEBtt4oX0Md/fUyNSlWcAZHcJ3h7myLflSHK1JEz4v2P40pRxdHMSy4jNDoGeKk2iFA==", null, null, false, null, "9748172a-0706-4b1f-b962-e0e67c9f9a5d", false, "AdmissionCouncil", false });

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
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5c07f51a-ada3-488e-a9ad-e8fa417984df", "AdmissionOfficer", "ADMISSIONOFFICER" });

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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"), "f50eae76-8cf0-4ee6-8923-c5d967f03763", "AdmissionCouncil", "ADMISSIONCOUNCIL" });

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("6832d500-a44a-4cac-8070-b522800caacf"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("98b1e579-1ea0-4313-94e8-f9aa77791fe5"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"), new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("6832d500-a44a-4cac-8070-b522800caacf"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("98b1e579-1ea0-4313-94e8-f9aa77791fe5"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"), new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e") });

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "321d6368-ef28-4cfb-a981-0a3d9b665fec", "schoolservice@gmail.com", "AQAAAAEAACcQAAAAEAt4OmbAR2bOgsr8SEqyaBgpTml8r7o5B5QNIHTieVZs2wNZcJQHq2rzsx/2bc9SRg==", "b84b151a-3ac0-466d-8766-1f6506dbafac", "schoolservice" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a7aef389-96bc-4abd-a185-92195925fdee", "adminofficer@gmail.com", "ADMINOFFICER@GMAIL.COM", "ADMINOFFICER", "AQAAAAEAACcQAAAAENchazOzHBs8Ub7PHzMLhcznwzhYKeJ+RF7qW9AhR7qk1f+lJ159+7fh3LY9UTBtDQ==", "43e58ae1-48ce-4591-9478-27c3ef036780", "adminofficer" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75791546-f903-4d23-8ef6-3c0428176caa", "AQAAAAEAACcQAAAAEKuxFfUWpJLx7uQICydqOijXnjyeCPlZflEx7CjDqd5pyZpvQgiANB9ebWgDUkYb+w==", "e22678ab-04a1-42f0-90a5-9ea8e608c180" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 17, 21, 13, 443, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 17, 21, 13, 443, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 17, 21, 13, 443, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 17, 21, 13, 443, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 17, 21, 13, 443, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 17, 21, 13, 443, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 17, 21, 13, 443, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 17, 21, 13, 443, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 17, 21, 13, 443, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "0587d85f-ffcd-4a2a-ade7-e735c994dfbb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ee29cf60-5fcf-4cd4-887b-0d53fbf72c96", "AdminOfficer", "ADMINOFFICER" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "4fe28cbc-0258-4009-968b-6874ecb2c03f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "9da9710c-4e58-4b0e-8442-13d669b6aaeb");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("9a8aa16f-2177-491b-b7a8-90e4959d4b71"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("e94547de-1875-48ab-bd89-7b049ab9693a"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });
        }
    }
}
