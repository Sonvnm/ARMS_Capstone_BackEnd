using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class addtypeadmissionmajor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TypeAdmissionForMajor",
                columns: table => new
                {
                    SpecializeMajorID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ARId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DiplomaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeAdmissionForMajor", x => new { x.ARId, x.SpecializeMajorID });
                    table.ForeignKey(
                        name: "FK_TypeAdmissionForMajor_SpecializeMajor_SpecializeMajorID",
                        column: x => x.SpecializeMajorID,
                        principalTable: "SpecializeMajor",
                        principalColumn: "SpecializeMajorID");
                    table.ForeignKey(
                        name: "FK_TypeAdmissionForMajor_TypeAcademicRecord_ARId",
                        column: x => x.ARId,
                        principalTable: "TypeAcademicRecord",
                        principalColumn: "ARId");
                    table.ForeignKey(
                        name: "FK_TypeAdmissionForMajor_TypeOfDiploma_DiplomaId",
                        column: x => x.DiplomaId,
                        principalTable: "TypeOfDiploma",
                        principalColumn: "DiplomaId");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_TypeAdmissionForMajor_SpecializeMajorID",
                table: "TypeAdmissionForMajor",
                column: "SpecializeMajorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TypeAdmissionForMajor");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60ca28a7-6cd8-44bb-a35f-dfc55dd79104", "AQAAAAEAACcQAAAAEFdqvOfg4v7gjKTenjzRewTIO3e179mQ2bkk+F/aOkzKzMOxC3Hazg8VfLyZdr0vBA==", "73d33a53-1ae4-4601-a197-656e2e7d8714" });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1260), new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1259) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1261), new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1261) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1262), new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1263), new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1263) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1264), new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1265), new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1266), new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1266) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1267), new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1267) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1268), new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1269), new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1270), new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 12,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1271), new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1271) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 13,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1272), new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 14,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1273), new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 15,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1274), new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 17, 12, 11, 659, DateTimeKind.Local).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "c8442eb8-68a5-49df-bd44-fafdf2cbf5e0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "99fed5f9-5e1a-4893-9309-be339042844a");
        }
    }
}
