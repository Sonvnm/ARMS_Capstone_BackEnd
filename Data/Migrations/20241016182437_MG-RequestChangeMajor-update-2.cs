using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGRequestChangeMajorupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestChangeMajor_Account_AccountId",
                table: "RequestChangeMajor");

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

            migrationBuilder.AddColumn<string>(
                name: "CampusId",
                table: "RequestChangeMajor",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "CampusId", "DateRequest" },
                values: new object[] { "Hanoi", new DateTime(2024, 10, 17, 1, 24, 35, 906, DateTimeKind.Local).AddTicks(4361) });

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                columns: new[] { "CampusId", "DateRequest" },
                values: new object[] { "Hanoi", new DateTime(2024, 10, 17, 1, 24, 35, 906, DateTimeKind.Local).AddTicks(4364) });

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

            migrationBuilder.CreateIndex(
                name: "IX_RequestChangeMajor_CampusId",
                table: "RequestChangeMajor",
                column: "CampusId");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestChangeMajor_Account_AccountId",
                table: "RequestChangeMajor",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestChangeMajor_Campus_CampusId",
                table: "RequestChangeMajor",
                column: "CampusId",
                principalTable: "Campus",
                principalColumn: "CampusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestChangeMajor_Account_AccountId",
                table: "RequestChangeMajor");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestChangeMajor_Campus_CampusId",
                table: "RequestChangeMajor");

            migrationBuilder.DropIndex(
                name: "IX_RequestChangeMajor_CampusId",
                table: "RequestChangeMajor");

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

            migrationBuilder.DropColumn(
                name: "CampusId",
                table: "RequestChangeMajor");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d181be20-bc11-4216-a091-6ba78f1972a4", "AQAAAAEAACcQAAAAEDC97V2DMx7Mf7e0JuPWTyJ34KtgDh+N/533w7ZrN4VJvbwXr7N3p7/YZKqGvCFnow==", "808a27f0-fe95-4fe2-81ff-8fe65ce552b0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d07b1ad0-2fad-4bff-a05f-473529acdfe2", "AQAAAAEAACcQAAAAEDReunfPU/ep5TUNC2YTrYomqzEjmZFG23Vqp9xeP7HZSRqqRz/lVMi7lfFAuW6k0Q==", "9a882c6b-b8ea-4555-8559-b2f6a7a87f19" });

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
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 10, 17, 1, 17, 47, 736, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 10, 17, 1, 17, 47, 736, DateTimeKind.Local).AddTicks(6574));

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
                table: "StudentProfile",
                columns: new[] { "SpId", "AccountId", "AddressRecipientResults", "CIAddress", "CIDate", "CampusId", "CitizenIentificationNumber", "District", "Dob", "EmailStudent", "Fullname", "FullnameParents", "Gender", "ImgAcademicTranscript1", "ImgAcademicTranscript2", "ImgAcademicTranscript3", "ImgAcademicTranscript4", "ImgAcademicTranscript5", "ImgCitizenIdentification1", "ImgCitizenIdentification2", "ImgDiploma", "Major", "Nation", "PermanentAddress", "PhoneParents", "PhoneStudent", "Province", "RecipientResults", "SchoolName", "SpecificAddress", "StudentCode", "TypeOfDiploma", "TypeOfTranscript", "Ward", "YearOfGraduation" },
                values: new object[] { new Guid("46d0be06-e4a7-4a73-bce3-517d4f3ca3c2"), new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), null, "HCM", new DateTime(2024, 10, 17, 1, 17, 47, 736, DateTimeKind.Local).AddTicks(6550), "Hanoi", "038301012121", null, new DateTime(2024, 10, 17, 1, 17, 47, 736, DateTimeKind.Local).AddTicks(6553), "nguyenducanh01.57@gmail.com", "Nguyễn Đức Anh", null, true, null, null, null, null, null, null, null, null, "HAO", null, null, null, "0971341555", null, null, null, null, null, null, null, null, null });

            migrationBuilder.AddForeignKey(
                name: "FK_RequestChangeMajor_Account_AccountId",
                table: "RequestChangeMajor",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
