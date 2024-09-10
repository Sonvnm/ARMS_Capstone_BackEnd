using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class AddBlogCateAndAlumi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlumiStudent",
                columns: table => new
                {
                    AlumiStudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desciption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecializeMajorID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlumiStudent", x => x.AlumiStudentId);
                    table.ForeignKey(
                        name: "FK_AlumiStudent_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId");
                    table.ForeignKey(
                        name: "FK_AlumiStudent_SpecializeMajor_SpecializeMajorID",
                        column: x => x.SpecializeMajorID,
                        principalTable: "SpecializeMajor",
                        principalColumn: "SpecializeMajorID");
                });

            migrationBuilder.CreateTable(
                name: "BlogCategory",
                columns: table => new
                {
                    BlogCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogCategory", x => x.BlogCategoryId);
                    table.ForeignKey(
                        name: "FK_BlogCategory_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8422e5df-8ad5-4a96-9fc9-270d14fc4828", "AQAAAAEAACcQAAAAELMPX4CDcG6AAfKQq6DR4FZRMiWhIXAXWWL7Yp1jVhmsFvJxfhc1kAbfXzna3il8jQ==", "e1783e7d-1499-4aec-84ec-88f1d9bd1068" });

            migrationBuilder.InsertData(
                table: "AlumiStudent",
                columns: new[] { "AlumiStudentId", "CampusId", "Desciption", "FullName", "Img", "SpecializeMajorID" },
                values: new object[,]
                {
                    { 1, "Hanoi", "Là một người trẻ, năng động thích môi trường năng động và được học những kiến thức thực tế. Mình nhận thấy đây là môi trường hoàn hảo để chắp cánh ước mơ trở thành nhà quản trị khách sạn của mình.", "Nguyễn Đức Anh", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/AlumiStudent%2Fstudent1.webp?alt=media&token=03b25b7d-e847-4e6d-ae4c-5da00e1c8183", "ME" },
                    { 2, "Hanoi", "Là một người trẻ, năng động thích môi trường năng động và được học những kiến thức thực tế. Mình nhận thấy đây là môi trường hoàn hảo để chắp cánh ước mơ trở thành nhà quản trị khách sạn của mình.", "Vũ Nguyễn Minh Sơn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/AlumiStudent%2Fstudent1.webp?alt=media&token=03b25b7d-e847-4e6d-ae4c-5da00e1c8183", "ME" },
                    { 3, "Hanoi", "Là một người trẻ, năng động thích môi trường năng động và được học những kiến thức thực tế. Mình nhận thấy đây là môi trường hoàn hảo để chắp cánh ước mơ trở thành nhà quản trị khách sạn của mình.", "Lê Quang An", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/AlumiStudent%2Fstudent1.webp?alt=media&token=03b25b7d-e847-4e6d-ae4c-5da00e1c8183", "ME" },
                    { 4, "Hanoi", "Là một người trẻ, năng động thích môi trường năng động và được học những kiến thức thực tế. Mình nhận thấy đây là môi trường hoàn hảo để chắp cánh ước mơ trở thành nhà quản trị khách sạn của mình.", "Trần Tú Anh", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/AlumiStudent%2Fstudent1.webp?alt=media&token=03b25b7d-e847-4e6d-ae4c-5da00e1c8183", "ME" }
                });

            migrationBuilder.InsertData(
                table: "BlogCategory",
                columns: new[] { "BlogCategoryId", "BlogCategoryName", "CampusId" },
                values: new object[,]
                {
                    { 1, "Tuyển sinh", "Hanoi" },
                    { 2, "Hoạt động của sinh viên", "Hanoi" },
                    { 3, "Sự kiện", "Hanoi" },
                    { 4, "Tuyển sinh", "Danang" },
                    { 5, "Hoạt động của sinh viên", "Danang" },
                    { 6, "Sự kiện", "Danang" },
                    { 7, "Tuyển sinh", "Cantho" },
                    { 8, "Hoạt động của sinh viên", "Cantho" },
                    { 9, "Sự kiện", "Cantho" },
                    { 10, "Tuyển sinh", "HCM" },
                    { 11, "Hoạt động của sinh viên", "HCM" },
                    { 12, "Sự kiện", "HCM" },
                    { 13, "Tuyển sinh", "Thanhhoa" },
                    { 14, "Hoạt động của sinh viên", "Thanhhoa" },
                    { 15, "Sự kiện", "Thanhhoa" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "fea78389-b7ed-4e3c-a7dc-f7123db478f8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "c74e5a1e-32cf-4fa6-b419-b897a435e734");

            migrationBuilder.CreateIndex(
                name: "IX_AlumiStudent_CampusId",
                table: "AlumiStudent",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_AlumiStudent_SpecializeMajorID",
                table: "AlumiStudent",
                column: "SpecializeMajorID");

            migrationBuilder.CreateIndex(
                name: "IX_BlogCategory_CampusId",
                table: "BlogCategory",
                column: "CampusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlumiStudent");

            migrationBuilder.DropTable(
                name: "BlogCategory");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5abc50bf-7f25-444a-a085-31adfaeba3a5", "AQAAAAEAACcQAAAAEOOaElqbdmKb1Vki/yCsdzIB3t2jtgNkSKIh8RqUtSMxFA8Ho8zYwfUuforwb0roiw==", "8eda7233-0574-4e43-8a6e-3f710c72db57" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "e6030753-cfee-4008-9e4a-6665885dffb5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "c27cabde-dcb3-470a-9bf6-1d0bdf4721d3");
        }
    }
}
