using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGRequestChangeMajor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("2f5f6ffe-e8d7-4fdb-abcb-b5fed2aae6bb"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("cf19b5fc-32b5-42a2-b958-ba4d26ca74dd"));

            migrationBuilder.CreateTable(
                name: "RequestChangeMajor",
                columns: table => new
                {
                    RequestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MajorNew = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateRequest = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileReasonRequestChangeMajor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestChangeMajor", x => x.RequestID);
                    table.ForeignKey(
                        name: "FK_RequestChangeMajor_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_RequestChangeMajor_AccountId",
                table: "RequestChangeMajor",
                column: "AccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RequestChangeMajor");

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("094948ad-ed56-4886-baea-a8479efa865f"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("a6024aeb-6929-4b2d-9965-2ec999d4fd90"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f46d378-b6c8-48d9-b34f-a8ea7d1aac2e", "AQAAAAEAACcQAAAAEOunK3V+8h3yLg4TQT4crrN4gg+9f7cqjhf+bJlhsA/VGPVbF98TOWm/sEQCUF2h/Q==", "877158b9-5509-43c0-9a43-183247384878" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f63049c-6d91-4db5-b66c-1a58e2da771d", "AQAAAAEAACcQAAAAEB58pUszRMA8MWIZP3H0i2slcEQH7jlCPgG9urd8eHTdZG3FEdn87/MNeVK3wGMuGA==", "f7fce632-e6aa-4c69-a60b-8ee9f5832b45" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7e94146-d6e6-4304-9ca4-d8abeb3de9aa", "AQAAAAEAACcQAAAAEEZtSjWiGvkdtr1KFQAv59jE62ySciji4hGx3hvKzv4SpFiHyIeGiPv+5X899fPyuw==", "f07e2f7c-a5e0-4dbb-a141-ca1a08e8df67" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fda71438-3c96-4dc3-8564-a2294a29d4d7", "AQAAAAEAACcQAAAAEMn9PaZX3bOGRaFpVbDlMmCTUEI+Vx7pRNt2Vk0uFvcRULhd48XYM7G7/vq+yGu8AQ==", "a30a18b6-a14d-484b-8234-eef06447e4bc" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 0, 17, 52, 956, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 0, 17, 52, 956, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 0, 17, 52, 956, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 0, 17, 52, 956, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 0, 17, 52, 956, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 0, 17, 52, 956, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 0, 17, 52, 956, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 0, 17, 52, 956, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 0, 17, 52, 956, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "3373c5b3-8607-4947-a785-e6a0d35fa03e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "c2a2c804-1436-4e56-9b61-1e91a2e0aba4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "0e9159b0-3c2a-4a14-abe2-c14fc1ddaafc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "95a86ba7-d500-4548-a0ab-e40c0323d1f2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "fe19d0e8-c6c7-45db-948c-b1a76d758135");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("2f5f6ffe-e8d7-4fdb-abcb-b5fed2aae6bb"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("cf19b5fc-32b5-42a2-b958-ba4d26ca74dd"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });
        }
    }
}
