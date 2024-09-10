using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGAdmissioInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("3b0d6479-750c-4180-bd7e-cc8df19e4317"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("917fc4fe-1f05-487b-bc5d-8c8fa044437c"));

            migrationBuilder.AddColumn<int>(
                name: "AdmissionInformationID",
                table: "Campus",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AdmissionInformation",
                columns: table => new
                {
                    AdmissionInformationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeeRegister = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FeeAdmission = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AdmissionProfileDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CampusId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmissionInformation", x => x.AdmissionInformationID);
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "436268a8-8d30-4215-92c2-6b09d453a687", "AQAAAAEAACcQAAAAEBC4i/Ycrsybw3sgFslAtEKVsQhFxJxRfJKwrofALagPt74KYElxuNqRW7woQYVX3g==", "e19b048d-e66a-4975-95c5-f17f3dcd7d92" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcc82264-2bd8-4fb7-9681-601294cee1a2", "AQAAAAEAACcQAAAAEArVxXYariGPWPKv3CZE9c7heI7CftDvkCNuVPrZFpywrP7w6kSgMa94qtOqy0JV2A==", "9fbe3c0d-d431-4758-84c1-eb93578fce93" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d801a54-8840-49ad-8b2e-91172824adc4", "AQAAAAEAACcQAAAAELOR1F5fx+jEhKzelkKgfneFL/cZwY4ixh/L7Re1Y/WwgeuWHTfnQSCQ3oUqon8+Jg==", "368db6f5-cfdb-437b-b07d-4650d50dda8c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d9ab6d2-74df-4424-901b-36c6c3e48c35", "AQAAAAEAACcQAAAAELJNcfuhkiOhPfbBsPylevFl75p9PmnYwfHACzGwXVWTbc54hDoPFbjuxYDAMBW4aQ==", "b06bac1d-ab7f-483c-98d1-3a291c3ca46e" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 20, 41, 7, 507, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 20, 41, 7, 507, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 20, 41, 7, 507, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 20, 41, 7, 507, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 20, 41, 7, 507, DateTimeKind.Local).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 20, 41, 7, 507, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 20, 41, 7, 507, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 20, 41, 7, 507, DateTimeKind.Local).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 20, 41, 7, 507, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "93c180df-4ddd-4eb4-855e-e9d7f3f467cf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "faba832c-b258-465b-850d-47ec83e107e5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "a27074c3-0284-4c16-af49-29df906df43f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "7a8d6f04-dfaf-4779-a629-7e456d831343");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "6d37f5fa-497d-4aad-8be8-b0ced7a2defb");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("d76e5d00-b874-4259-ae41-36b5c2b079e1"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("f9daf9bd-8887-4d2a-a127-54fb4f32e10c"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Campus_AdmissionInformationID",
                table: "Campus",
                column: "AdmissionInformationID",
                unique: true,
                filter: "[AdmissionInformationID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Campus_AdmissionInformation_AdmissionInformationID",
                table: "Campus",
                column: "AdmissionInformationID",
                principalTable: "AdmissionInformation",
                principalColumn: "AdmissionInformationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campus_AdmissionInformation_AdmissionInformationID",
                table: "Campus");

            migrationBuilder.DropTable(
                name: "AdmissionInformation");

            migrationBuilder.DropIndex(
                name: "IX_Campus_AdmissionInformationID",
                table: "Campus");

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("d76e5d00-b874-4259-ae41-36b5c2b079e1"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("f9daf9bd-8887-4d2a-a127-54fb4f32e10c"));

            migrationBuilder.DropColumn(
                name: "AdmissionInformationID",
                table: "Campus");

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
    }
}
