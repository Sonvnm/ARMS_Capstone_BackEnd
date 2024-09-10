using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGAdmissioInformationupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("776ec075-d622-4891-8b92-e035da0b7562"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("c9da5df0-b5fd-49d1-995c-1ae64e26383f"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83ec9a96-e413-400b-8b7a-f5305c44fdcb", "AQAAAAEAACcQAAAAEH8cmvZfr4YGXSendRMp5o9MlvLer7v4bzqwhX8uHAf0h2WIhANwoxxdJ2j3B0j/fw==", "4f3c1ce8-5b96-4ae1-9f5b-ccd960f1d3e0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e95d8e84-02f5-4103-8ad8-c12e1e8e63b7", "AQAAAAEAACcQAAAAEORHDcLiufqPUCx+9oKLPf3ArFPvB/jdJf7+5K7nIWfOLr04P0gvFRrXVgOY73WM0g==", "3a8cdf57-ae69-4c68-add3-f51469e5a9de" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b6bb746-d56f-4568-ad43-2ff03bd701b5", "AQAAAAEAACcQAAAAECHouc/PBWNHnZVJ36Y3jQpcogl3p9mNFajnUfgI7RPnrup1VyXK0gFa+9JDyIK2Ow==", "7c7e374a-18cb-40a5-932a-7c8c934327e4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1bb6b07-ac6e-4f5f-9c02-a75101c83588", "AQAAAAEAACcQAAAAELCzlr/W8E5BGygFkFsys8BRRehQfhul1z+1ClV3Ebx5cgN6bjZgLkOVVnS8edG9Fg==", "2e521c39-454c-42a5-a0fa-606b6d1228fe" });

            migrationBuilder.InsertData(
                table: "AdmissionInformation",
                columns: new[] { "AdmissionInformationID", "AdmissionProfileDescription", "CampusId", "FeeAdmission", "FeeRegister" },
                values: new object[,]
                {
                    { 2, "01 Phiếu đăng ký học theo mẫu quy định của trường. Phiếu đăng ký học thí sinh có thể điền trực tiếp, hoặc tải về tự in tại đây, hoặc đến nhận tại văn phòng tuyển sinh trên toàn quốc.\r\n01 Bản sao công chứng Căn cước công dân hoặc Chứng minh nhân dân.\r\n01 Bản sao công chứng Bằng tốt nghiệp hoặc Giấy chứng nhận tốt nghiệp tạm thời.\r\n01 Bản sao công chứng bảng điểm(nếu xét học bạ).\r\n2 ảnh 3x4\r\n", "Danang", 4600000m, 100000m },
                    { 3, "01 Phiếu đăng ký học theo mẫu quy định của trường. Phiếu đăng ký học thí sinh có thể điền trực tiếp, hoặc tải về tự in tại đây, hoặc đến nhận tại văn phòng tuyển sinh trên toàn quốc.\r\n01 Bản sao công chứng Căn cước công dân hoặc Chứng minh nhân dân.\r\n01 Bản sao công chứng Bằng tốt nghiệp hoặc Giấy chứng nhận tốt nghiệp tạm thời.\r\n01 Bản sao công chứng bảng điểm(nếu xét học bạ).\r\n2 ảnh 3x4\r\n", "Cantho", 4600000m, 100000m },
                    { 4, "01 Phiếu đăng ký học theo mẫu quy định của trường. Phiếu đăng ký học thí sinh có thể điền trực tiếp, hoặc tải về tự in tại đây, hoặc đến nhận tại văn phòng tuyển sinh trên toàn quốc.\r\n01 Bản sao công chứng Căn cước công dân hoặc Chứng minh nhân dân.\r\n01 Bản sao công chứng Bằng tốt nghiệp hoặc Giấy chứng nhận tốt nghiệp tạm thời.\r\n01 Bản sao công chứng bảng điểm(nếu xét học bạ).\r\n2 ảnh 3x4\r\n", "HCM", 4600000m, 100000m },
                    { 5, "01 Phiếu đăng ký học theo mẫu quy định của trường. Phiếu đăng ký học thí sinh có thể điền trực tiếp, hoặc tải về tự in tại đây, hoặc đến nhận tại văn phòng tuyển sinh trên toàn quốc.\r\n01 Bản sao công chứng Căn cước công dân hoặc Chứng minh nhân dân.\r\n01 Bản sao công chứng Bằng tốt nghiệp hoặc Giấy chứng nhận tốt nghiệp tạm thời.\r\n01 Bản sao công chứng bảng điểm(nếu xét học bạ).\r\n2 ảnh 3x4\r\n", "Thanhhoa", 4600000m, 100000m }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 23, 25, 16, 338, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 23, 25, 16, 338, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 23, 25, 16, 338, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 23, 25, 16, 338, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 23, 25, 16, 338, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 23, 25, 16, 338, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 23, 25, 16, 338, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 23, 25, 16, 338, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 16, 23, 25, 16, 338, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "f43a6599-5cf1-41c0-bcae-c8d53aba08d4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "3db4164d-9736-41bd-b8ce-58d6709781d9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "d95b677e-2752-4121-a409-b2edc9f63733");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "f6af5a74-a625-47fc-a4d0-b60150cff6f7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "4692a4e5-4bab-4595-aefd-7e4a429a5683");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("50a16cfa-1042-451a-b1d5-04358e69668e"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("e866c803-8d39-486e-8502-e536836a450a"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("50a16cfa-1042-451a-b1d5-04358e69668e"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("e866c803-8d39-486e-8502-e536836a450a"));

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
        }
    }
}
