using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class updatemgdata01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TypeAdmissionForMajor",
                keyColumns: new[] { "DiplomaId", "SpecializeMajorID" },
                keyValues: new object[] { 2, "EA" });

            migrationBuilder.DeleteData(
                table: "TypeAdmissionForMajor",
                keyColumns: new[] { "DiplomaId", "SpecializeMajorID" },
                keyValues: new object[] { 2, "GE" });

            migrationBuilder.DeleteData(
                table: "TypeAdmissionForMajor",
                keyColumns: new[] { "DiplomaId", "SpecializeMajorID" },
                keyValues: new object[] { 2, "ME" });

            migrationBuilder.DeleteData(
                table: "TypeAdmissionForMajor",
                keyColumns: new[] { "DiplomaId", "SpecializeMajorID" },
                keyValues: new object[] { 2, "TE" });

            migrationBuilder.DeleteData(
                table: "TypeAdmissionForMajor",
                keyColumns: new[] { "DiplomaId", "SpecializeMajorID" },
                keyValues: new object[] { 2, "WE" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57801493-adbe-4ab7-9633-13f109a96c77", "AQAAAAEAACcQAAAAEJRNLrV+xGkNPfCyghxBUuFSodhH3vwomJ4rKvCARtwDszxkr9zsobJzHCONE9a6LA==", "da1820e0-2ab3-468c-8dcb-c623c860a0b0" });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5157), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5158), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5159), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5160), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5161), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5162), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5163), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5165), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5165), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5168), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5170), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 12,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5171), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 13,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5172), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 14,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5173), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 15,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5174), new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 22, 41, 58, 367, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "3cb1200c-8814-458e-b03f-420417da6ee7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "1f57ab74-e87b-469c-910b-5e79c3b92d32");

            migrationBuilder.InsertData(
                table: "TypeAdmissionForMajor",
                columns: new[] { "DiplomaId", "SpecializeMajorID", "ARId" },
                values: new object[,]
                {
                    { 3, "EA", "Xet_lop10_lop11_Hk1_12" },
                    { 3, "GE", "Xet_5ky" },
                    { 3, "ME", "Xet_1nam" },
                    { 3, "TE", "Xet_3nam" },
                    { 3, "WE", "Xet_3ky" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TypeAdmissionForMajor",
                keyColumns: new[] { "DiplomaId", "SpecializeMajorID" },
                keyValues: new object[] { 3, "EA" });

            migrationBuilder.DeleteData(
                table: "TypeAdmissionForMajor",
                keyColumns: new[] { "DiplomaId", "SpecializeMajorID" },
                keyValues: new object[] { 3, "GE" });

            migrationBuilder.DeleteData(
                table: "TypeAdmissionForMajor",
                keyColumns: new[] { "DiplomaId", "SpecializeMajorID" },
                keyValues: new object[] { 3, "ME" });

            migrationBuilder.DeleteData(
                table: "TypeAdmissionForMajor",
                keyColumns: new[] { "DiplomaId", "SpecializeMajorID" },
                keyValues: new object[] { 3, "TE" });

            migrationBuilder.DeleteData(
                table: "TypeAdmissionForMajor",
                keyColumns: new[] { "DiplomaId", "SpecializeMajorID" },
                keyValues: new object[] { 3, "WE" });

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

            migrationBuilder.InsertData(
                table: "TypeAdmissionForMajor",
                columns: new[] { "DiplomaId", "SpecializeMajorID", "ARId" },
                values: new object[,]
                {
                    { 2, "EA", "Xet_lop10_lop11_Hk1_12" },
                    { 2, "GE", "Xet_5ky" },
                    { 2, "ME", "Xet_1nam" },
                    { 2, "TE", "Xet_3nam" },
                    { 2, "WE", "Xet_3ky" }
                });
        }
    }
}
