using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGAdmissioInformationupdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campus_AdmissionInformation_AdmissionInformationID",
                table: "Campus");

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

            migrationBuilder.AlterColumn<string>(
                name: "CampusId",
                table: "AdmissionInformation",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c494698-08b2-444e-bc28-f61700c616ed", "AQAAAAEAACcQAAAAEPNctqxPeQSPDDCelBxQEwqkrVi1UKhTUtTMyh73mDjJyrPUGlafiyjjbEWnn1OAOQ==", "75c6fdb1-7e1e-40f5-b291-f4d3e886c42a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "801ff1d0-44c7-44bb-a4d5-a342a9bafbc4", "AQAAAAEAACcQAAAAEA6cTEfX7cAxxXGq+4JonyY+9EhY8PTHbx3eYYrxuaaeLHt8HpXlHs8aU7DSSsoS1w==", "a15fe2eb-b344-41dc-9042-76590f613e72" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd3204f8-c82f-47d4-864a-b9ecc830ed02", "AQAAAAEAACcQAAAAEBta2iUwmDVgSAeJJLgvCs685aRWnLlUKaFNnL0F+esPwqjBCuTPjSlLB1ib9wtP5Q==", "65a2acab-531a-476d-bf52-f15cb7bc3961" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4cfb333-7cdd-4af7-9c31-88b488a836d4", "AQAAAAEAACcQAAAAEE8mk4a8Amp5kwIwJnqe+zNNnja1WTiSha9fG/KXFq96Z21AtsheHmWCzSogrnVRuA==", "559fb5f5-379e-47fc-ad9b-68361ba0a496" });

            migrationBuilder.InsertData(
                table: "AdmissionInformation",
                columns: new[] { "AdmissionInformationID", "AdmissionProfileDescription", "CampusId", "FeeAdmission", "FeeRegister" },
                values: new object[] { 1, "01 Phiếu đăng ký học theo mẫu quy định của trường. Phiếu đăng ký học thí sinh có thể điền trực tiếp, hoặc tải về tự in tại đây, hoặc đến nhận tại văn phòng tuyển sinh trên toàn quốc.\r\n01 Bản sao công chứng Căn cước công dân hoặc Chứng minh nhân dân.\r\n01 Bản sao công chứng Bằng tốt nghiệp hoặc Giấy chứng nhận tốt nghiệp tạm thời.\r\n01 Bản sao công chứng bảng điểm(nếu xét học bạ).\r\n2 ảnh 3x4\r\n", "Hanoi", 4600000m, 100000m });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 23, 23, 2, 471, DateTimeKind.Local).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 23, 23, 2, 471, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 23, 23, 2, 471, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 23, 23, 2, 471, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 23, 23, 2, 471, DateTimeKind.Local).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 23, 23, 2, 471, DateTimeKind.Local).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 23, 23, 2, 471, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 23, 23, 2, 471, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 23, 23, 2, 471, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "6a8513e4-9d58-4fde-8edd-307a10279ece");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "6c47675f-3e52-45d7-89f2-9c2be8c08186");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "08194ac3-8b7f-4d6b-af92-c11592ac2221");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "7565df0c-8c8f-4244-90d4-831e79a24aa1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "391fb793-9d5b-4a66-be8b-fcbc2d72ad03");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("776ec075-d622-4891-8b92-e035da0b7562"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("c9da5df0-b5fd-49d1-995c-1ae64e26383f"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionInformation_CampusId",
                table: "AdmissionInformation",
                column: "CampusId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AdmissionInformation_Campus_CampusId",
                table: "AdmissionInformation",
                column: "CampusId",
                principalTable: "Campus",
                principalColumn: "CampusId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdmissionInformation_Campus_CampusId",
                table: "AdmissionInformation");

            migrationBuilder.DropIndex(
                name: "IX_AdmissionInformation_CampusId",
                table: "AdmissionInformation");

            migrationBuilder.DeleteData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("776ec075-d622-4891-8b92-e035da0b7562"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("c9da5df0-b5fd-49d1-995c-1ae64e26383f"));

            migrationBuilder.AddColumn<int>(
                name: "AdmissionInformationID",
                table: "Campus",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CampusId",
                table: "AdmissionInformation",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
    }
}
