using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class updatedataAdmission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fb05181-e9b5-4b1f-a294-a55098175387", "AQAAAAEAACcQAAAAEAP2gUdvm+0NGfT5EZVPXKtPclDHFkix0XOMGPwJ/xrPLf5ELu8qjBOD1uMePFsVzg==", "e30bd48c-53d9-438f-b22c-8dd1b5883210" });

            migrationBuilder.UpdateData(
                table: "AdmissionPlan",
                keyColumn: "AdmissionPlanID",
                keyValue: 1,
                column: "Prioritize",
                value: "Điểm ưu tiên đối tượng và khu vực thực hiện theo Quy định của Bộ Giáo dục & Đào tạo.");

            migrationBuilder.UpdateData(
                table: "AdmissionPlan",
                keyColumn: "AdmissionPlanID",
                keyValue: 2,
                column: "Prioritize",
                value: "Điểm ưu tiên đối tượng và khu vực thực hiện theo Quy định của Bộ Giáo dục & Đào tạo.");

            migrationBuilder.UpdateData(
                table: "AdmissionPlan",
                keyColumn: "AdmissionPlanID",
                keyValue: 3,
                column: "Prioritize",
                value: "Điểm ưu tiên đối tượng và khu vực thực hiện theo Quy định của Bộ Giáo dục & Đào tạo.");

            migrationBuilder.UpdateData(
                table: "AdmissionPlan",
                keyColumn: "AdmissionPlanID",
                keyValue: 4,
                column: "Prioritize",
                value: "Điểm ưu tiên đối tượng và khu vực thực hiện theo Quy định của Bộ Giáo dục & Đào tạo.");

            migrationBuilder.UpdateData(
                table: "AdmissionPlan",
                keyColumn: "AdmissionPlanID",
                keyValue: 5,
                column: "Prioritize",
                value: "Điểm ưu tiên đối tượng và khu vực thực hiện theo Quy định của Bộ Giáo dục & Đào tạo.");

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(602), new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(602) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(605), new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(606), new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(606) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(607), new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(607) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(608), new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(608) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(610), new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(611), new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(611) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(614), new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(614) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(615), new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(617), new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 12,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(618), new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(618) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 13,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(619), new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 14,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(620), new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 15,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(622), new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 20, 18, 11, 55, 552, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "a77fa082-368e-4e63-a032-e9582618e051");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "481a4233-11ea-40ba-818e-edc0dfed78d0");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "558a7df8-f937-4436-8daa-61462e52d93c", "AQAAAAEAACcQAAAAEB53+6Tx4uVHdaXWgyt3HIM5jzAjtT4C1JPUNgsxS9Qq6Bvi246NS+Y9XPtvOz9H1A==", "41f0ad7a-15d9-4595-8592-ead471aec632" });

            migrationBuilder.UpdateData(
                table: "AdmissionPlan",
                keyColumn: "AdmissionPlanID",
                keyValue: 1,
                column: "Prioritize",
                value: "");

            migrationBuilder.UpdateData(
                table: "AdmissionPlan",
                keyColumn: "AdmissionPlanID",
                keyValue: 2,
                column: "Prioritize",
                value: "");

            migrationBuilder.UpdateData(
                table: "AdmissionPlan",
                keyColumn: "AdmissionPlanID",
                keyValue: 3,
                column: "Prioritize",
                value: "");

            migrationBuilder.UpdateData(
                table: "AdmissionPlan",
                keyColumn: "AdmissionPlanID",
                keyValue: 4,
                column: "Prioritize",
                value: "");

            migrationBuilder.UpdateData(
                table: "AdmissionPlan",
                keyColumn: "AdmissionPlanID",
                keyValue: 5,
                column: "Prioritize",
                value: "");

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8105), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8106), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8106) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8107), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8107) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8108), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8109), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8110), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8111), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8112), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8113), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8114), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8115), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 12,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8116), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 13,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8117), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 14,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8118), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 15,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8123), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "c6f17940-29e6-42f0-bd92-baf1562b121b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "80a24217-5618-4f2c-982c-71725180947a");
        }
    }
}
