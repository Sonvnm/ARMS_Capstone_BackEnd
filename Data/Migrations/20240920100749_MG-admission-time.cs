using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGadmissiontime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33d937e7-6446-4750-be72-9eef006135ec", "AQAAAAEAACcQAAAAEAvfbN/vtvcIKXQ7T7W1s/6wegIhA57Hzw8a2Fb4WxKFqJwTJBA0SvcPU9Cv4iaGrA==", "165ed4a6-3b9e-468f-8520-99d635460477" });

            migrationBuilder.InsertData(
                table: "AdmissionTime",
                columns: new[] { "AdmissionTimeID", "AdmissionPlanID", "AdmissionTimeName", "TimeEnd", "TimeStart" },
                values: new object[,]
                {
                    { 1, 1, "Đợt 1", new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7073), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7073) },
                    { 2, 1, "Đợt 2", new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7075), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7074) },
                    { 3, 1, "Đợt 3", new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7076), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7076) },
                    { 4, 2, "Đợt 1", new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7077), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7077) },
                    { 5, 2, "Đợt 2", new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7078), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7078) },
                    { 6, 2, "Đợt 3", new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7079), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7078) },
                    { 7, 3, "Đợt 1", new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7080), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7079) },
                    { 8, 3, "Đợt 2", new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7081), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7080) },
                    { 9, 3, "Đợt 3", new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7081), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7081) },
                    { 10, 4, "Đợt 1", new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7082), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7082) },
                    { 11, 4, "Đợt 2", new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7083), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7083) },
                    { 12, 4, "Đợt 3", new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7084), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7084) },
                    { 13, 5, "Đợt 1", new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7085), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7085) },
                    { 14, 5, "Đợt 2", new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7086), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7086) },
                    { 15, 5, "Đợt 3", new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7087), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7086) }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "c82e754b-20ff-460b-8165-b5a53dc8086a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "d9093c33-57be-4759-9352-a36e5cef93c1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8fc643b-4f8c-4aa1-8014-5b9f3ccee423", "AQAAAAEAACcQAAAAEBpo8U7G+BrENq4Md06HteiotywD8cO+XiltDQkYQr1GvMrgHRvg6E1pYs+PSOVGZw==", "46c81469-362a-4363-b156-6c76c7c99b77" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 6, 52, 432, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 6, 52, 432, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 6, 52, 432, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 6, 52, 432, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 6, 52, 432, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 6, 52, 432, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 6, 52, 432, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 6, 52, 432, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 6, 52, 432, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 20, 17, 6, 52, 432, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 20, 17, 6, 52, 432, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 20, 17, 6, 52, 432, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "3226794d-6ffd-43f9-9ffc-65cb63d5c0ce");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "ed067301-08a6-4e2e-b0ea-b22eb25268d6");
        }
    }
}
