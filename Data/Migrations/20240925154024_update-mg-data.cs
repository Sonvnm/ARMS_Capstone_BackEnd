using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class updatemgdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ARId",
                table: "TypeAdmissionForMajor",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c604bc2-1ef2-48fa-a23d-d80864eb8253", "AQAAAAEAACcQAAAAEBVmGrddjFmwTLlnXxx7OZc6iBB7hQymmXbCfrCdgpiF0aUB1gm/ulBVWv/5RlGHmg==", "ea9d8996-52e6-434d-ad70-2464e366df21" });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1771), new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1773), new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1775), new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1776), new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1777), new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1779), new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1780), new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1781), new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1782), new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1783), new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1783) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1785), new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 12,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1786), new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 13,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1787), new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1787) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 14,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1788), new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 15,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1790), new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 22, 40, 22, 945, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "53e2cdc5-b06c-4bd6-bb32-7382af5d60a9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "c509e52c-2130-4625-b6e4-707e4878cfd4");

            migrationBuilder.UpdateData(
                table: "TypeAcademicRecord",
                keyColumn: "ARId",
                keyValue: "Xet_1nam",
                column: "DiplomaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TypeAcademicRecord",
                keyColumn: "ARId",
                keyValue: "Xet_3ky",
                column: "DiplomaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TypeAcademicRecord",
                keyColumn: "ARId",
                keyValue: "Xet_3nam",
                column: "DiplomaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TypeAcademicRecord",
                keyColumn: "ARId",
                keyValue: "Xet_5ky",
                column: "DiplomaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TypeAcademicRecord",
                keyColumn: "ARId",
                keyValue: "Xet_lop10_lop11_Hk1_12",
                column: "DiplomaId",
                value: 3);

            migrationBuilder.InsertData(
                table: "TypeAdmissionForMajor",
                columns: new[] { "DiplomaId", "SpecializeMajorID", "ARId" },
                values: new object[,]
                {
                    { 1, "AO", null },
                    { 1, "BS", null },
                    { 1, "BT", null },
                    { 1, "FO", null },
                    { 1, "HM", null },
                    { 1, "JA", null },
                    { 1, "KA", null }
                });

            migrationBuilder.InsertData(
                table: "TypeAdmissionForMajor",
                columns: new[] { "DiplomaId", "SpecializeMajorID", "ARId" },
                values: new object[] { 1, "RM", null });

            migrationBuilder.InsertData(
                table: "TypeAdmissionForMajor",
                columns: new[] { "DiplomaId", "SpecializeMajorID", "ARId" },
                values: new object[] { 1, "SM", null });

            migrationBuilder.InsertData(
                table: "TypeAdmissionForMajor",
                columns: new[] { "DiplomaId", "SpecializeMajorID", "ARId" },
                values: new object[] { 1, "SO", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TypeAdmissionForMajor",
                keyColumns: new[] { "DiplomaId", "SpecializeMajorID" },
                keyValues: new object[] { 1, "AO" });

            migrationBuilder.DeleteData(
                table: "TypeAdmissionForMajor",
                keyColumns: new[] { "DiplomaId", "SpecializeMajorID" },
                keyValues: new object[] { 1, "BS" });

            migrationBuilder.DeleteData(
                table: "TypeAdmissionForMajor",
                keyColumns: new[] { "DiplomaId", "SpecializeMajorID" },
                keyValues: new object[] { 1, "BT" });

            migrationBuilder.DeleteData(
                table: "TypeAdmissionForMajor",
                keyColumns: new[] { "DiplomaId", "SpecializeMajorID" },
                keyValues: new object[] { 1, "FO" });

            migrationBuilder.DeleteData(
                table: "TypeAdmissionForMajor",
                keyColumns: new[] { "DiplomaId", "SpecializeMajorID" },
                keyValues: new object[] { 1, "HM" });

            migrationBuilder.DeleteData(
                table: "TypeAdmissionForMajor",
                keyColumns: new[] { "DiplomaId", "SpecializeMajorID" },
                keyValues: new object[] { 1, "JA" });

            migrationBuilder.DeleteData(
                table: "TypeAdmissionForMajor",
                keyColumns: new[] { "DiplomaId", "SpecializeMajorID" },
                keyValues: new object[] { 1, "KA" });

            migrationBuilder.DeleteData(
                table: "TypeAdmissionForMajor",
                keyColumns: new[] { "DiplomaId", "SpecializeMajorID" },
                keyValues: new object[] { 1, "RM" });

            migrationBuilder.DeleteData(
                table: "TypeAdmissionForMajor",
                keyColumns: new[] { "DiplomaId", "SpecializeMajorID" },
                keyValues: new object[] { 1, "SM" });

            migrationBuilder.DeleteData(
                table: "TypeAdmissionForMajor",
                keyColumns: new[] { "DiplomaId", "SpecializeMajorID" },
                keyValues: new object[] { 1, "SO" });

            migrationBuilder.AlterColumn<string>(
                name: "ARId",
                table: "TypeAdmissionForMajor",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e3127d8-804d-4967-b5b4-0f605597ca57", "AQAAAAEAACcQAAAAELyrJr5ZCDdRRVjK81pAG+PPldAPpkbsFmrxMN7t2CvCTNjwdKOjM71/h0imRnEtpw==", "7a7591f9-9517-4615-bac5-2fcb2f28e3cd" });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8988), new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8989), new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8990), new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8991), new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8992), new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8993), new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8994), new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8993) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8994), new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8995), new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8996), new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8997), new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 12,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8998), new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 13,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8999), new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 14,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8999), new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 15,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(9000), new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 18, 9, 33, 897, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "8f6e164c-a88e-4b6f-92d0-6664aa7b9802");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "df4f135d-0465-4212-9601-09650b3e99d9");

            migrationBuilder.UpdateData(
                table: "TypeAcademicRecord",
                keyColumn: "ARId",
                keyValue: "Xet_1nam",
                column: "DiplomaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TypeAcademicRecord",
                keyColumn: "ARId",
                keyValue: "Xet_3ky",
                column: "DiplomaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TypeAcademicRecord",
                keyColumn: "ARId",
                keyValue: "Xet_3nam",
                column: "DiplomaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TypeAcademicRecord",
                keyColumn: "ARId",
                keyValue: "Xet_5ky",
                column: "DiplomaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TypeAcademicRecord",
                keyColumn: "ARId",
                keyValue: "Xet_lop10_lop11_Hk1_12",
                column: "DiplomaId",
                value: 2);
        }
    }
}
