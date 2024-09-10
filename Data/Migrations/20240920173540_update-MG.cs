using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class updateMG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiplomaType",
                table: "StudentProfile");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SpecializeMajor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "SpecializeMajor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TimeStudy",
                table: "SpecializeMajor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    SubjectCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SpecializeMajorID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfCredits = table.Column<int>(type: "int", nullable: false),
                    SemesterNumber = table.Column<int>(type: "int", nullable: false),
                    StudyTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => new { x.SubjectCode, x.SpecializeMajorID });
                    table.ForeignKey(
                        name: "FK_Subject_SpecializeMajor_SpecializeMajorID",
                        column: x => x.SpecializeMajorID,
                        principalTable: "SpecializeMajor",
                        principalColumn: "SpecializeMajorID");
                });

            migrationBuilder.CreateTable(
                name: "TypeOfDiploma",
                columns: table => new
                {
                    DiplomaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiplomaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdmissionPlanID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfDiploma", x => x.DiplomaId);
                    table.ForeignKey(
                        name: "FK_TypeOfDiploma_AdmissionPlan_AdmissionPlanID",
                        column: x => x.AdmissionPlanID,
                        principalTable: "AdmissionPlan",
                        principalColumn: "AdmissionPlanID");
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "120ee1d8-22a3-40e1-838a-a5e4d2a5ea8d", "AQAAAAEAACcQAAAAEFsz8RmeD2wIlwjWcmVT1TGbx+9QXbyj0SpXGWOFj87c3lATkSbExsA3GA+s+hsSCA==", "09a167ab-27d7-456d-ae76-f242d5fcc47d" });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6814), new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6816), new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6817), new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6817) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6818), new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6819), new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6820), new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6821), new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6822), new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6823), new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6824), new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6825), new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 12,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6826), new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 13,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6827), new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 14,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6828), new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 15,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6829), new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6829) });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 21, 0, 35, 38, 739, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "A",
                column: "Target",
                value: 200);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "B",
                column: "Target",
                value: 200);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "E",
                column: "Target",
                value: 200);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "O",
                column: "Target",
                value: 200);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "S",
                column: "Target",
                value: 200);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "d682c7b2-74e9-4df7-9164-7f3cc0f9b4f9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "5e7c292f-af86-42e8-ae48-5a41b8367125");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "AO",
                column: "TimeStudy",
                value: "2 năm");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "BS",
                column: "TimeStudy",
                value: "2 năm");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "BT",
                column: "TimeStudy",
                value: "2 năm");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "EA",
                columns: new[] { "Description", "TimeStudy" },
                values: new object[] { "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "2 năm" });

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "FO",
                column: "TimeStudy",
                value: "2 năm");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "GE",
                columns: new[] { "Description", "TimeStudy" },
                values: new object[] { "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.", "2 năm" });

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "HM",
                column: "TimeStudy",
                value: "24 năm");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "JA",
                column: "TimeStudy",
                value: "2 năm");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "KA",
                column: "TimeStudy",
                value: "24 năm");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "ME",
                columns: new[] { "Description", "TimeStudy" },
                values: new object[] { "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.", "2 năm" });

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "RM",
                column: "TimeStudy",
                value: "24 năm");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "SM",
                column: "TimeStudy",
                value: "2 năm");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "SO",
                column: "TimeStudy",
                value: "24 năm");

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "TE",
                columns: new[] { "Description", "TimeStudy" },
                values: new object[] { "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.", "2 năm" });

            migrationBuilder.UpdateData(
                table: "SpecializeMajor",
                keyColumn: "SpecializeMajorID",
                keyValue: "WE",
                columns: new[] { "Description", "TimeStudy" },
                values: new object[] { "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.", "2 năm" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SpecializeMajorID", "SubjectCode", "Note", "NumberOfCredits", "SemesterNumber", "StudyTime", "SubjectName" },
                values: new object[,]
                {
                    { "GE", "DBI101", null, 3, 3, "4 tháng", "Cơ sở lập trình" },
                    { "ME", "DBI101", null, 3, 3, "4 tháng", "Cơ sở lập trình" },
                    { "TE", "DBI101", null, 3, 3, "4 tháng", "Cơ sở lập trình" },
                    { "WE", "DBI101", null, 3, 3, "4 tháng", "Cơ sở lập trình" },
                    { "AO", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "BS", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "BT", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "EA", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "FO", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "GE", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HM", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "JA", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "KA", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "ME", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "RM", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SM", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SO", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "TE", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "WE", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "AO", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "BS", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "BT", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "EA", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "FO", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "GE", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HM", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "JA", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "KA", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "ME", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "RM", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SM", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SO", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "TE", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "WE", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SpecializeMajorID", "SubjectCode", "Note", "NumberOfCredits", "SemesterNumber", "StudyTime", "SubjectName" },
                values: new object[,]
                {
                    { "AO", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "EA", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "HM", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "ME", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "RM", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "SM", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "AO", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "BS", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "BT", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "EA", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "FO", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "GE", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HM", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "JA", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "KA", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "ME", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "RM", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SM", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SO", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "TE", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "WE", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "GE", "MAD101", null, 3, 2, "4 tháng", "Toán cho ngành kỹ thuật" },
                    { "ME", "MAD101", null, 3, 2, "4 tháng", "Toán cho ngành kỹ thuật" },
                    { "TE", "MAD101", null, 3, 2, "4 tháng", "Toán cho ngành kỹ thuật" },
                    { "WE", "MAD101", null, 3, 2, "4 tháng", "Toán cho ngành kỹ thuật" },
                    { "GE", "MAE101", null, 3, 1, "4 tháng", "Toán rời rạc" },
                    { "ME", "MAE101", null, 3, 1, "4 tháng", "Toán rời rạc" },
                    { "TE", "MAE101", null, 3, 1, "4 tháng", "Toán rời rạc" },
                    { "WE", "MAE101", null, 3, 1, "4 tháng", "Toán rời rạc" },
                    { "GE", "PRF101", null, 3, 1, "4 tháng", "Cơ sở lập trình" },
                    { "ME", "PRF101", null, 3, 1, "4 tháng", "Cơ sở lập trình" },
                    { "TE", "PRF101", null, 3, 1, "4 tháng", "Cơ sở lập trình" },
                    { "WE", "PRF101", null, 3, 1, "4 tháng", "Cơ sở lập trình" }
                });

            migrationBuilder.InsertData(
                table: "TypeOfDiploma",
                columns: new[] { "DiplomaId", "AdmissionPlanID", "DiplomaName" },
                values: new object[,]
                {
                    { 1, 1, "Tốt nghiệp THCS, học lớp 10,11,12 - học 2 năm" },
                    { 2, 1, "Tốt nghiệp THCS" },
                    { 3, 1, "Tốt nghiệp THPT hoặc bổ túc THPT - Học 1 năm đến 1,5 năm" },
                    { 4, 1, "Tốt nghiệp ĐH-CD-TC- Học 1 năm" },
                    { 5, 2, "Tốt nghiệp THCS, học lớp 10,11,12 - học 2 năm" },
                    { 6, 2, "Tốt nghiệp THCS" },
                    { 7, 2, "Tốt nghiệp THPT hoặc bổ túc THPT - Học 1 năm đến 1,5 năm" },
                    { 8, 2, "Tốt nghiệp ĐH-CD-TC- Học 1 năm" },
                    { 9, 3, "Tốt nghiệp THCS, học lớp 10,11,12 - học 2 năm" }
                });

            migrationBuilder.InsertData(
                table: "TypeOfDiploma",
                columns: new[] { "DiplomaId", "AdmissionPlanID", "DiplomaName" },
                values: new object[,]
                {
                    { 10, 3, "Tốt nghiệp THCS" },
                    { 11, 3, "Tốt nghiệp THPT hoặc bổ túc THPT - Học 1 năm đến 1,5 năm" },
                    { 12, 3, "Tốt nghiệp ĐH-CD-TC- Học 1 năm" },
                    { 13, 4, "Tốt nghiệp THCS, học lớp 10,11,12 - học 2 năm" },
                    { 14, 4, "Tốt nghiệp THCS" },
                    { 15, 4, "Tốt nghiệp THPT hoặc bổ túc THPT - Học 1 năm đến 1,5 năm" },
                    { 16, 4, "Tốt nghiệp ĐH-CD-TC- Học 1 năm" },
                    { 17, 5, "Tốt nghiệp THCS, học lớp 10,11,12 - học 2 năm" },
                    { 18, 5, "Tốt nghiệp THCS" },
                    { 19, 5, "Tốt nghiệp THPT hoặc bổ túc THPT - Học 1 năm đến 1,5 năm" },
                    { 20, 5, "Tốt nghiệp ĐH-CD-TC- Học 1 năm" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subject_SpecializeMajorID",
                table: "Subject",
                column: "SpecializeMajorID");

            migrationBuilder.CreateIndex(
                name: "IX_TypeOfDiploma_AdmissionPlanID",
                table: "TypeOfDiploma",
                column: "AdmissionPlanID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "TypeOfDiploma");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "SpecializeMajor");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "SpecializeMajor");

            migrationBuilder.DropColumn(
                name: "TimeStudy",
                table: "SpecializeMajor");

            migrationBuilder.AddColumn<int>(
                name: "DiplomaType",
                table: "StudentProfile",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fb05181-e9b5-4b1f-a294-a55098175387", "AQAAAAEAACcQAAAAEAP2gUdvm+0NGfT5EZVPXKtPclDHFkix0XOMGPwJ/xrPLf5ELu8qjBOD1uMePFsVzg==", "e30bd48c-53d9-438f-b22c-8dd1b5883210" });

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
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "A",
                column: "Target",
                value: null);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "B",
                column: "Target",
                value: null);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "E",
                column: "Target",
                value: null);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "O",
                column: "Target",
                value: null);

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "S",
                column: "Target",
                value: null);

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
    }
}
