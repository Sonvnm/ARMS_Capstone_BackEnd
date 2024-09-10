using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class add_MG3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeAdmissionForMajor",
                table: "TypeAdmissionForMajor");

            migrationBuilder.DropIndex(
                name: "IX_TypeAdmissionForMajor_DiplomaId",
                table: "TypeAdmissionForMajor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeAdmissionForMajor",
                table: "TypeAdmissionForMajor",
                columns: new[] { "DiplomaId", "SpecializeMajorID" });

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

            migrationBuilder.CreateIndex(
                name: "IX_TypeAdmissionForMajor_ARId",
                table: "TypeAdmissionForMajor",
                column: "ARId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeAdmissionForMajor",
                table: "TypeAdmissionForMajor");

            migrationBuilder.DropIndex(
                name: "IX_TypeAdmissionForMajor_ARId",
                table: "TypeAdmissionForMajor");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeAdmissionForMajor",
                table: "TypeAdmissionForMajor",
                columns: new[] { "ARId", "SpecializeMajorID" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "081dc360-1ae0-44d8-bfa8-a01a4d254f1a", "AQAAAAEAACcQAAAAEFod1xGbDa9APgWPdRbPaq+Bi1wnu1sa6D04ejbFhSzU+KdIvHrR5wdGvmpC8GTHCg==", "9e029062-f7e6-4040-abee-c7414da0a89c" });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9666), new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9669), new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9672), new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9674), new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9676), new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9678), new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9680), new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9682), new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9684), new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9686), new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9688), new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9687) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 12,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9690), new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 13,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9692), new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 14,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9694), new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9693) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 15,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9696), new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 17, 59, 46, 701, DateTimeKind.Local).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "33b41af4-d981-4074-b5c6-b47f23e2e11b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "dc9285c8-e3dd-491a-8988-a17fbd7e63ff");

            migrationBuilder.CreateIndex(
                name: "IX_TypeAdmissionForMajor_DiplomaId",
                table: "TypeAdmissionForMajor",
                column: "DiplomaId");
        }
    }
}
