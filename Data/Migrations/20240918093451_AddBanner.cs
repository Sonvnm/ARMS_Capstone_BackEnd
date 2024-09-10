using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class AddBanner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banner",
                columns: table => new
                {
                    BannerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banner", x => x.BannerId);
                    table.ForeignKey(
                        name: "FK_Banner_Campus_CampusId",
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
                values: new object[] { "1f559d46-f86b-485f-b9ad-c44f637a5a3c", "AQAAAAEAACcQAAAAEO0C2YNastofu/qxW+aMbCRYZUUCvBm2zuHar7uGGso5jVepcfafg16/r72zKBtISw==", "c5df0edf-f613-46aa-832e-e49c4b2f30f2" });

            migrationBuilder.InsertData(
                table: "Banner",
                columns: new[] { "BannerId", "CampusId", "Img" },
                values: new object[,]
                {
                    { 1, "Hanoi", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner1.jpg?alt=media&token=3b681990-e08c-4e87-a69b-d1586a72398d" },
                    { 2, "Hanoi", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner2.jpg?alt=media&token=fcd81d71-4b88-4443-a07d-3e21d2ad19bc" },
                    { 3, "Hanoi", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner3.jpg?alt=media&token=829186db-6511-49ff-a4b7-48211a4d83db" },
                    { 4, "Danang", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner1.jpg?alt=media&token=3b681990-e08c-4e87-a69b-d1586a72398d" },
                    { 5, "Danang", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner2.jpg?alt=media&token=fcd81d71-4b88-4443-a07d-3e21d2ad19bc" },
                    { 6, "Danang", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner3.jpg?alt=media&token=829186db-6511-49ff-a4b7-48211a4d83db" },
                    { 7, "HCM", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner1.jpg?alt=media&token=3b681990-e08c-4e87-a69b-d1586a72398d" },
                    { 8, "HCM", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner2.jpg?alt=media&token=fcd81d71-4b88-4443-a07d-3e21d2ad19bc" },
                    { 9, "HCM", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner3.jpg?alt=media&token=829186db-6511-49ff-a4b7-48211a4d83db" },
                    { 10, "Cantho", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner1.jpg?alt=media&token=3b681990-e08c-4e87-a69b-d1586a72398d" },
                    { 11, "Cantho", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner2.jpg?alt=media&token=fcd81d71-4b88-4443-a07d-3e21d2ad19bc" },
                    { 12, "Cantho", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner3.jpg?alt=media&token=829186db-6511-49ff-a4b7-48211a4d83db" },
                    { 13, "Thanhhoa", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner1.jpg?alt=media&token=3b681990-e08c-4e87-a69b-d1586a72398d" },
                    { 14, "Thanhhoa", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner2.jpg?alt=media&token=fcd81d71-4b88-4443-a07d-3e21d2ad19bc" },
                    { 15, "Thanhhoa", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner3.jpg?alt=media&token=829186db-6511-49ff-a4b7-48211a4d83db" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "1429b19f-d98d-4254-862e-de557196d140");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "700db8a3-afa8-47b0-bc92-69fdb5cc8ffa");

            migrationBuilder.CreateIndex(
                name: "IX_Banner_CampusId",
                table: "Banner",
                column: "CampusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banner");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a82d0a4-a13c-4feb-9dc6-1adb31334d15", "AQAAAAEAACcQAAAAEAs06y1prirFXjpKf0+Hq/yD7nsMpOihwp6NbesjgAcaYLVze++Sd5mu+U58jB1TVQ==", "98870d48-99bb-4bcd-beae-a690c35ebfca" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "5ac84db9-d112-42f3-b02b-d49d07992fdf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "b43b4df2-0c2e-42d7-ab26-f35caba8035a");
        }
    }
}
