using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGRequestChangeMajorupdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("44471f01-3f53-49a8-aad1-4b59484102cd"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("64a23b99-cb3f-4a41-a5ac-d4e11d0fa095"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("c4658317-e0c2-4385-8117-9b98fe4fb4d5"));

            migrationBuilder.AlterColumn<string>(
                name: "MajorNew",
                table: "RequestChangeMajor",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a355932-1f5c-4041-9e1c-4f1173c4e2c7", "AQAAAAEAACcQAAAAECRQ5eKVuaH3sxhTI8l833t3prlHYZsyTK4HYDw0RE7kPWdPbbSqsRg3f/vljooLUg==", "e9f98848-b257-4d88-9043-a42bf51c311a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e364ea9b-35ee-4f99-a9e1-16c2b67cd289", "AQAAAAEAACcQAAAAEBfBonIVe7ig3k61FewrQtMp7Rr45yC89nHXr9almy6ConIvcvTmeKBBsHbjkXMklA==", "83c24534-089c-4d35-9dcd-d11e487eac33" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47907a5a-6d62-4623-9180-2ec1d9903562", "AQAAAAEAACcQAAAAEEA1pe70CJIUvLjLAllHczOpeJvtUvepnPPbi76pYT49hm4kpswweDZ0bgEOJ7GvxA==", "ec301443-1acb-4a00-a9af-c6dc9b3ed352" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4dc4c19-c6ad-4109-99b0-d094e2fec762", "AQAAAAEAACcQAAAAEJYuxthsSpRJ2afO4lrmShvlcMsOk1IWaDZpGirxWuToxKtFKXKaGlPxhabPcK/6yg==", "9a3e8f08-dc39-4978-9805-841b9a99afdd" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9aed1a8-a2dd-4c5e-b575-2c5ffce75b01", "AQAAAAEAACcQAAAAEIeYYvuEVX90ytFhLSKGjP0nQSsks0geHpqR5msg+SzZH78xKBzzjcsjDuxxDP6BXQ==", "938673b4-8e27-4148-a8d1-a49651e188f5" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "652602d3-4a1c-4146-94e9-5e70fb030bc7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "9d9b1d2a-4d8a-4e09-80ba-ffe33d8aa5a3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "32e52fb4-815f-40f7-a546-8de3f66296e6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "4fc90ad5-1dfb-4f33-a89b-72ddca373b33");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "f4ca2544-a5ba-4a14-b385-eade089442d1");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("5e977d09-9c66-4f83-b01e-2a2948f5a49b"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("da2b90f9-9c84-4c75-8bbc-4887ef252bfc"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.InsertData(
                table: "StudentProfile",
                columns: new[] { "SpId", "AccountId", "AddressRecipientResults", "CIAddress", "CIDate", "CampusId", "CitizenIentificationNumber", "District", "Dob", "EmailStudent", "Fullname", "FullnameParents", "Gender", "ImgAcademicTranscript1", "ImgAcademicTranscript2", "ImgAcademicTranscript3", "ImgAcademicTranscript4", "ImgAcademicTranscript5", "ImgCitizenIdentification1", "ImgCitizenIdentification2", "ImgDiploma", "Major", "Nation", "PermanentAddress", "PhoneParents", "PhoneStudent", "Province", "RecipientResults", "SchoolName", "SpecificAddress", "StudentCode", "TypeOfDiploma", "TypeOfTranscript", "Ward", "YearOfGraduation" },
                values: new object[] { new Guid("bae00227-cb4b-403d-9ec0-193adb3bbfda"), new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), null, "HCM", new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3132), "Hanoi", "038301012121", null, new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3135), "nguyenducanh01.57@gmail.com", "Nguyễn Đức Anh", null, true, null, null, null, null, null, null, null, null, "HAO", null, null, null, "0971341555", null, null, null, null, null, null, null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_RequestChangeMajor_MajorNew",
                table: "RequestChangeMajor",
                column: "MajorNew");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestChangeMajor_Major_MajorNew",
                table: "RequestChangeMajor",
                column: "MajorNew",
                principalTable: "Major",
                principalColumn: "MajorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestChangeMajor_Major_MajorNew",
                table: "RequestChangeMajor");

            migrationBuilder.DropIndex(
                name: "IX_RequestChangeMajor_MajorNew",
                table: "RequestChangeMajor");

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("5e977d09-9c66-4f83-b01e-2a2948f5a49b"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("da2b90f9-9c84-4c75-8bbc-4887ef252bfc"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("bae00227-cb4b-403d-9ec0-193adb3bbfda"));

            migrationBuilder.AlterColumn<string>(
                name: "MajorNew",
                table: "RequestChangeMajor",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4bd4bd4-9686-4862-84c1-b6248ec65bc3", "AQAAAAEAACcQAAAAEHmkoTB7YEhiX3RLtQrl5cnlv9hD9dgoD9/W4dg1VmEU09GivE3ikFkmnf9Zc3wXmw==", "cbf6fe69-68d6-4ab4-a34b-86b877a8c280" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c39a2b02-c0ff-4f1a-a011-cabfbad91662", "AQAAAAEAACcQAAAAEBNUf12YxYh7EYvVG19YJNiTE4I+6i4ztPlA4fwFKY3ECcaWtHUYJtqFAJ+CUoa4UQ==", "bc326fac-2b08-4611-a49f-1e1038c28e7e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bcc62df-c63f-4fe5-8b37-081495674fc2", "AQAAAAEAACcQAAAAEDSHb69ZVhKtbI/XS1bZNNPdnUKwxxujBoVNNItJqeGciULspAQoCDnpub9//WTC6w==", "ae08fe81-7259-4530-a3d1-e6016aedce43" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4954bd8-26a2-426e-9030-35384d9b76da", "AQAAAAEAACcQAAAAEM86OUOFxEU0IIqYeRAsXnSrr6xS2kUDRGOxbU960AspOvitT1Vwl1Cuwn8GWBtgGA==", "73539225-ce76-41e1-92a1-ad03df903170" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1eef574-dcb4-4592-9d58-4026fad2a0d2", "AQAAAAEAACcQAAAAEE4WVHBhUtZ94tJDHvkuuSB7SNszLuefmaCUz6DH8DqCpdpUTtZrr64klYsF/jmZEw==", "3e9b59e9-0ee1-45b9-b015-56a7f03955d4" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 24, 35, 906, DateTimeKind.Local).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 24, 35, 906, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 24, 35, 906, DateTimeKind.Local).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 24, 35, 906, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 24, 35, 906, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 24, 35, 906, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 24, 35, 906, DateTimeKind.Local).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 24, 35, 906, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 24, 35, 906, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 10, 17, 1, 24, 35, 906, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 10, 17, 1, 24, 35, 906, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "ea3d9e6b-76f7-4e35-972d-b8eb5acfa24b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "82029bba-6071-4fe5-999a-d571e459c97a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "a176dcaa-c8ea-4394-9665-f4c5b6efdfc1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "2a9b474a-f0c4-473e-927e-e486fe157678");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "4b32aa03-32ce-4cae-a3da-5701b96a0d3a");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("44471f01-3f53-49a8-aad1-4b59484102cd"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("64a23b99-cb3f-4a41-a5ac-d4e11d0fa095"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.InsertData(
                table: "StudentProfile",
                columns: new[] { "SpId", "AccountId", "AddressRecipientResults", "CIAddress", "CIDate", "CampusId", "CitizenIentificationNumber", "District", "Dob", "EmailStudent", "Fullname", "FullnameParents", "Gender", "ImgAcademicTranscript1", "ImgAcademicTranscript2", "ImgAcademicTranscript3", "ImgAcademicTranscript4", "ImgAcademicTranscript5", "ImgCitizenIdentification1", "ImgCitizenIdentification2", "ImgDiploma", "Major", "Nation", "PermanentAddress", "PhoneParents", "PhoneStudent", "Province", "RecipientResults", "SchoolName", "SpecificAddress", "StudentCode", "TypeOfDiploma", "TypeOfTranscript", "Ward", "YearOfGraduation" },
                values: new object[] { new Guid("c4658317-e0c2-4385-8117-9b98fe4fb4d5"), new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), null, "HCM", new DateTime(2024, 10, 17, 1, 24, 35, 906, DateTimeKind.Local).AddTicks(4347), "Hanoi", "038301012121", null, new DateTime(2024, 10, 17, 1, 24, 35, 906, DateTimeKind.Local).AddTicks(4349), "nguyenducanh01.57@gmail.com", "Nguyễn Đức Anh", null, true, null, null, null, null, null, null, null, null, "HAO", null, null, null, "0971341555", null, null, null, null, null, null, null, null, null });
        }
    }
}
