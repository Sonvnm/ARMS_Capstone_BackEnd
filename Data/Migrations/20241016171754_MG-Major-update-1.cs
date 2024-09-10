using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGMajorupdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("50a16cfa-1042-451a-b1d5-04358e69668e"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("e866c803-8d39-486e-8502-e536836a450a"));

            migrationBuilder.AddColumn<decimal>(
                name: "Tuition",
                table: "Major",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

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
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HAO",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HBS",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HBT",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HEA",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HFO",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HGE",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HHM",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HJA",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HKA",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HME",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HRM",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HSM",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HSO",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HTE",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HWE",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SAO",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SBS",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SBT",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SEA",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SFO",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SGE",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SHM",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SJA",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SKA",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SME",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SRM",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SSM",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SSO",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "STE",
                column: "Tuition",
                value: 12000000m);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SWE",
                column: "Tuition",
                value: 12000000m);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("2f5f6ffe-e8d7-4fdb-abcb-b5fed2aae6bb"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("cf19b5fc-32b5-42a2-b958-ba4d26ca74dd"));

            migrationBuilder.DropColumn(
                name: "Tuition",
                table: "Major");

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
    }
}
