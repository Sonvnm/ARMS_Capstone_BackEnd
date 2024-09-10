using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGAdmissionTimeupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("9f300283-09d6-443e-9020-2b192d6c70ca"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("db74e973-ee1d-4516-9b34-d9e5e1bcb841"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41e6988d-6ba8-4d2a-809f-234dd68c238d", "AQAAAAEAACcQAAAAECEZ9kxAYRync/rducFbQyIJXYM6TQTujdXq7/ncU6zhchA9iavHzyR0hdJRqPhhlQ==", "1d2e5d36-3d47-43ea-9fd3-27857735234a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c628fc8-0801-4e34-a380-a52bb4958055", "AQAAAAEAACcQAAAAEGMSQxRpSwCwiSa98liDdl0FNWSGDyYfmw7DZpX28GBmVRJ5kSkD9aGpk8DBGSNFHw==", "6731efa8-93dd-4313-ba91-87a9c6828be7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd3d09b6-29bc-4380-952e-aa2ecd41fa91", "AQAAAAEAACcQAAAAEKkQ96NYz6+7Y0hYyw+j9tbCD6Ht/0UqswPe797nG0iQEU3MB3lwN8+jbdad9szgzA==", "39428432-77da-484d-8b5c-f9ca27db67fa" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d36a0af4-98bf-460e-83e3-8bbb2a3e237f", "AQAAAAEAACcQAAAAEFVjCK0yagxVzCBU2NKmV4YObcCSeEy8yRmgL/dGVb7HCsPEWWy5U7aadO+aNTA+9A==", "ba1ad2e7-940a-4fcc-8627-997875f9621a" });

            migrationBuilder.InsertData(
                table: "AdmissionTime",
                columns: new[] { "AIId", "AdmissionInformationName", "CampusId", "EndAdmission", "EndRegister", "StartAdmission", "StartRegister", "Year" },
                values: new object[,]
                {
                    { 1, "Đợt 1", "Hanoi", new DateTime(2024, 4, 30, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2024 },
                    { 2, "Đợt 2", "Hanoi", new DateTime(2024, 7, 30, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2024 },
                    { 3, "Đợt 3", "Hanoi", new DateTime(2024, 9, 1, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2024 }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 1, 25, 8, 775, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 1, 25, 8, 775, DateTimeKind.Local).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 1, 25, 8, 775, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 1, 25, 8, 775, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 1, 25, 8, 775, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 1, 25, 8, 775, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 1, 25, 8, 775, DateTimeKind.Local).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 1, 25, 8, 775, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 1, 25, 8, 775, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "f5110717-7ff2-49f6-8553-3934ea765c99");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "cf2f39e4-c998-4f73-8a0f-59c3494312ef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "5ad6f332-ea31-49ea-a183-bd2f5c2cdfe0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "7668cb5f-61e1-45f4-ae46-4a8ffaa005a5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "8375ba06-4102-4a05-be02-9949377c30a7");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("3b0d6479-750c-4180-bd7e-cc8df19e4317"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("917fc4fe-1f05-487b-bc5d-8c8fa044437c"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdmissionTime",
                keyColumn: "AIId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AdmissionTime",
                keyColumn: "AIId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AdmissionTime",
                keyColumn: "AIId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("3b0d6479-750c-4180-bd7e-cc8df19e4317"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("917fc4fe-1f05-487b-bc5d-8c8fa044437c"));

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
        }
    }
}
