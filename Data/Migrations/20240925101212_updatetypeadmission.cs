using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class updatetypeadmission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TypeOfDiploma_TypeAcademicRecord_ARId",
                table: "TypeOfDiploma");

            migrationBuilder.DropIndex(
                name: "IX_TypeOfDiploma_ARId",
                table: "TypeOfDiploma");

            migrationBuilder.DeleteData(
                table: "TypeOfDiploma",
                keyColumn: "DiplomaId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TypeOfDiploma",
                keyColumn: "DiplomaId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TypeOfDiploma",
                keyColumn: "DiplomaId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TypeOfDiploma",
                keyColumn: "DiplomaId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TypeOfDiploma",
                keyColumn: "DiplomaId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TypeOfDiploma",
                keyColumn: "DiplomaId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TypeOfDiploma",
                keyColumn: "DiplomaId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TypeOfDiploma",
                keyColumn: "DiplomaId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TypeOfDiploma",
                keyColumn: "DiplomaId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TypeOfDiploma",
                keyColumn: "DiplomaId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TypeOfDiploma",
                keyColumn: "DiplomaId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TypeOfDiploma",
                keyColumn: "DiplomaId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TypeOfDiploma",
                keyColumn: "DiplomaId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TypeOfDiploma",
                keyColumn: "DiplomaId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TypeOfDiploma",
                keyColumn: "DiplomaId",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "ARId",
                table: "TypeOfDiploma");

            migrationBuilder.AlterColumn<int>(
                name: "AdmissionPlanID",
                table: "TypeOfDiploma",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DiplomaId",
                table: "TypeAcademicRecord",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.UpdateData(
                table: "TypeOfDiploma",
                keyColumn: "DiplomaId",
                keyValue: 1,
                columns: new[] { "AdmissionPlanID", "DiplomaName" },
                values: new object[] { null, "Tốt nghiệp THCS" });

            migrationBuilder.UpdateData(
                table: "TypeOfDiploma",
                keyColumn: "DiplomaId",
                keyValue: 2,
                columns: new[] { "AdmissionPlanID", "DiplomaName" },
                values: new object[] { null, "Tốt nghiệp Trung cấp loại giỏi" });

            migrationBuilder.UpdateData(
                table: "TypeOfDiploma",
                keyColumn: "DiplomaId",
                keyValue: 3,
                columns: new[] { "AdmissionPlanID", "DiplomaName" },
                values: new object[] { null, "Xét học bạ THPT" });

            migrationBuilder.UpdateData(
                table: "TypeOfDiploma",
                keyColumn: "DiplomaId",
                keyValue: 4,
                columns: new[] { "AdmissionPlanID", "DiplomaName" },
                values: new object[] { null, "Tốt nghiệp THPT" });

            migrationBuilder.UpdateData(
                table: "TypeOfDiploma",
                keyColumn: "DiplomaId",
                keyValue: 5,
                columns: new[] { "AdmissionPlanID", "DiplomaName" },
                values: new object[] { null, "Tốt nghiệp đại học, cao đẳng " });

            migrationBuilder.CreateIndex(
                name: "IX_TypeAcademicRecord_DiplomaId",
                table: "TypeAcademicRecord",
                column: "DiplomaId");

            migrationBuilder.AddForeignKey(
                name: "FK_TypeAcademicRecord_TypeOfDiploma_DiplomaId",
                table: "TypeAcademicRecord",
                column: "DiplomaId",
                principalTable: "TypeOfDiploma",
                principalColumn: "DiplomaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TypeAcademicRecord_TypeOfDiploma_DiplomaId",
                table: "TypeAcademicRecord");

            migrationBuilder.DropIndex(
                name: "IX_TypeAcademicRecord_DiplomaId",
                table: "TypeAcademicRecord");

            migrationBuilder.DropColumn(
                name: "DiplomaId",
                table: "TypeAcademicRecord");

            migrationBuilder.AlterColumn<int>(
                name: "AdmissionPlanID",
                table: "TypeOfDiploma",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ARId",
                table: "TypeOfDiploma",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2b66003-69ed-4cf5-a4a9-f1e8852c851a", "AQAAAAEAACcQAAAAEOR+2VnK20q7yF/zQLxiKnC6KD1wiPnzC+5Qayh+4yCeP+Y+z8P9JWuzEObo3HHc4w==", "410fef20-7e62-48f7-83c5-9cbb5631f262" });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9232), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9234), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9233) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9235), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9236), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9235) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9237), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9237), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9238), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9239), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9240), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9241), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9242), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 12,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9243), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 13,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9244), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 14,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9245), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 15,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9245), new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 11, 49, 57, 514, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "bf663c1e-4608-4ea1-84bd-9463f5440646");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "63986db4-f1eb-42b4-b0c7-1cb89fa83499");

            migrationBuilder.UpdateData(
                table: "TypeOfDiploma",
                keyColumn: "DiplomaId",
                keyValue: 1,
                columns: new[] { "AdmissionPlanID", "DiplomaName" },
                values: new object[] { 1, "Tốt nghiệp THCS, học lớp 10,11,12 - học 2 năm" });

            migrationBuilder.UpdateData(
                table: "TypeOfDiploma",
                keyColumn: "DiplomaId",
                keyValue: 2,
                columns: new[] { "AdmissionPlanID", "DiplomaName" },
                values: new object[] { 1, "Tốt nghiệp THCS" });

            migrationBuilder.UpdateData(
                table: "TypeOfDiploma",
                keyColumn: "DiplomaId",
                keyValue: 3,
                columns: new[] { "AdmissionPlanID", "DiplomaName" },
                values: new object[] { 1, "Tốt nghiệp THPT hoặc bổ túc THPT - Học 1 năm đến 1,5 năm" });

            migrationBuilder.UpdateData(
                table: "TypeOfDiploma",
                keyColumn: "DiplomaId",
                keyValue: 4,
                columns: new[] { "AdmissionPlanID", "DiplomaName" },
                values: new object[] { 1, "Tốt nghiệp ĐH-CD-TC- Học 1 năm" });

            migrationBuilder.UpdateData(
                table: "TypeOfDiploma",
                keyColumn: "DiplomaId",
                keyValue: 5,
                columns: new[] { "AdmissionPlanID", "DiplomaName" },
                values: new object[] { 2, "Tốt nghiệp THCS, học lớp 10,11,12 - học 2 năm" });

            migrationBuilder.InsertData(
                table: "TypeOfDiploma",
                columns: new[] { "DiplomaId", "ARId", "AdmissionPlanID", "DiplomaName" },
                values: new object[,]
                {
                    { 6, null, 2, "Tốt nghiệp THCS" },
                    { 7, null, 2, "Tốt nghiệp THPT hoặc bổ túc THPT - Học 1 năm đến 1,5 năm" },
                    { 8, null, 2, "Tốt nghiệp ĐH-CD-TC- Học 1 năm" },
                    { 9, null, 3, "Tốt nghiệp THCS, học lớp 10,11,12 - học 2 năm" },
                    { 10, null, 3, "Tốt nghiệp THCS" },
                    { 11, null, 3, "Tốt nghiệp THPT hoặc bổ túc THPT - Học 1 năm đến 1,5 năm" },
                    { 12, null, 3, "Tốt nghiệp ĐH-CD-TC- Học 1 năm" }
                });

            migrationBuilder.InsertData(
                table: "TypeOfDiploma",
                columns: new[] { "DiplomaId", "ARId", "AdmissionPlanID", "DiplomaName" },
                values: new object[,]
                {
                    { 13, null, 4, "Tốt nghiệp THCS, học lớp 10,11,12 - học 2 năm" },
                    { 14, null, 4, "Tốt nghiệp THCS" },
                    { 15, null, 4, "Tốt nghiệp THPT hoặc bổ túc THPT - Học 1 năm đến 1,5 năm" },
                    { 16, null, 4, "Tốt nghiệp ĐH-CD-TC- Học 1 năm" },
                    { 17, null, 5, "Tốt nghiệp THCS, học lớp 10,11,12 - học 2 năm" },
                    { 18, null, 5, "Tốt nghiệp THCS" },
                    { 19, null, 5, "Tốt nghiệp THPT hoặc bổ túc THPT - Học 1 năm đến 1,5 năm" },
                    { 20, null, 5, "Tốt nghiệp ĐH-CD-TC- Học 1 năm" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TypeOfDiploma_ARId",
                table: "TypeOfDiploma",
                column: "ARId");

            migrationBuilder.AddForeignKey(
                name: "FK_TypeOfDiploma_TypeAcademicRecord_ARId",
                table: "TypeOfDiploma",
                column: "ARId",
                principalTable: "TypeAcademicRecord",
                principalColumn: "ARId");
        }
    }
}
