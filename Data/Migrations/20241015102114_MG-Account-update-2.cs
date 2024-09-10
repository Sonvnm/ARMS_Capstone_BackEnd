using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGAccountupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("8db6e8ce-3e3a-4bed-a00e-e7fa46051464"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("d72cd1e9-6b1f-4120-bf0a-454f1916c5a3"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7aef389-96bc-4abd-a185-92195925fdee", "AQAAAAEAACcQAAAAENchazOzHBs8Ub7PHzMLhcznwzhYKeJ+RF7qW9AhR7qk1f+lJ159+7fh3LY9UTBtDQ==", "43e58ae1-48ce-4591-9478-27c3ef036780" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75791546-f903-4d23-8ef6-3c0428176caa", "AQAAAAEAACcQAAAAEKuxFfUWpJLx7uQICydqOijXnjyeCPlZflEx7CjDqd5pyZpvQgiANB9ebWgDUkYb+w==", "e22678ab-04a1-42f0-90a5-9ea8e608c180" });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "AccessFailedCount", "AvatarURL", "CampusId", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "Fullname", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SPId", "SecurityStamp", "TwoFactorEnabled", "UserName", "isAccountActive" },
                values: new object[] { new Guid("17baf918-d5d2-4628-aad1-8a4926520676"), 0, null, "Hanoi", "321d6368-ef28-4cfb-a981-0a3d9b665fec", null, "schoolservice@gmail.com", true, "School Service Hanoi", null, false, null, "SCHOOLSERVICE@GMAIL.COM", "SCHOOLSERVICE", "AQAAAAEAACcQAAAAEAt4OmbAR2bOgsr8SEqyaBgpTml8r7o5B5QNIHTieVZs2wNZcJQHq2rzsx/2bc9SRg==", null, null, false, null, "b84b151a-3ac0-466d-8766-1f6506dbafac", false, "schoolservice", false });

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
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "ee29cf60-5fcf-4cd4-887b-0d53fbf72c96");

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
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"), "0587d85f-ffcd-4a2a-ade7-e735c994dfbb", "SchoolService", "SCHOOLSERVICE" });

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("9a8aa16f-2177-491b-b7a8-90e4959d4b71"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("e94547de-1875-48ab-bd89-7b049ab9693a"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"), new Guid("17baf918-d5d2-4628-aad1-8a4926520676") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("9a8aa16f-2177-491b-b7a8-90e4959d4b71"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("e94547de-1875-48ab-bd89-7b049ab9693a"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"), new Guid("17baf918-d5d2-4628-aad1-8a4926520676") });

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f44f1621-06a9-4d35-86ac-e7ca11aa85f2", "AQAAAAEAACcQAAAAEIp6qXjaCpKTcsvST2NNxegtTrJlKbCg8SyPZxogO7yNdrpDhGzKirnqYJuvE4VUWQ==", "f6338392-fed6-4315-8cca-2b82639bdacc" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7501a969-c816-48b4-ae87-db0f79984107", "AQAAAAEAACcQAAAAEHy5uuDusCKrMuOJkE6RwHD6ljR46dEFcvCQL85Bf+SIGbuTMJRN7N0o86BLHlc7LA==", "f7ed9c63-25d4-4f58-888c-0e5f62070cfe" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 6, 12, 46, 68, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 6, 12, 46, 68, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 6, 12, 46, 68, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 6, 12, 46, 68, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 6, 12, 46, 68, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 6, 12, 46, 68, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 6, 12, 46, 68, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 6, 12, 46, 68, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 15, 6, 12, 46, 68, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "9e467cd3-1a49-4a9d-a4fb-dd0c3982ae02");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "6883845e-5857-42a1-9b2a-013657540da7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "ed663730-bfc1-48cc-867b-7b1cbb526efd");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("8db6e8ce-3e3a-4bed-a00e-e7fa46051464"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("d72cd1e9-6b1f-4120-bf0a-454f1916c5a3"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });
        }
    }
}
