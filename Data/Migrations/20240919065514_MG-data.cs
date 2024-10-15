using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Banner",
                keyColumn: "BannerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Banner",
                keyColumn: "BannerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Banner",
                keyColumn: "BannerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Banner",
                keyColumn: "BannerId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Banner",
                keyColumn: "BannerId",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b8802c3-bba6-4b14-9eec-8c4626e5a60f", "AQAAAAEAACcQAAAAEDZWepffONJFU4w/qklMncKkl6NV7EEroNmK+R6cqlWeo2uH9HjiPQpkJb7ajZpQgw==", "e72f1495-a4d8-4e65-8f6d-50892ebb433b" });

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "BannerId",
                keyValue: 1,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider1.jpg?alt=media&token=8018950a-e9d4-4c97-a81c-2bcea05d72ce");

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "BannerId",
                keyValue: 2,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider2.jpg?alt=media&token=cc8a3de5-1155-4aba-9463-d4108b93330d");

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "BannerId",
                keyValue: 4,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider1.jpg?alt=media&token=8018950a-e9d4-4c97-a81c-2bcea05d72ce");

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "BannerId",
                keyValue: 5,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider2.jpg?alt=media&token=cc8a3de5-1155-4aba-9463-d4108b93330d");

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "BannerId",
                keyValue: 7,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider1.jpg?alt=media&token=8018950a-e9d4-4c97-a81c-2bcea05d72ce");

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "BannerId",
                keyValue: 8,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider2.jpg?alt=media&token=cc8a3de5-1155-4aba-9463-d4108b93330d");

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "BannerId",
                keyValue: 10,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider1.jpg?alt=media&token=8018950a-e9d4-4c97-a81c-2bcea05d72ce");

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "BannerId",
                keyValue: 11,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider2.jpg?alt=media&token=cc8a3de5-1155-4aba-9463-d4108b93330d");

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "BannerId",
                keyValue: 13,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider1.jpg?alt=media&token=8018950a-e9d4-4c97-a81c-2bcea05d72ce");

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "BannerId",
                keyValue: 14,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider2.jpg?alt=media&token=cc8a3de5-1155-4aba-9463-d4108b93330d");

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 13, 55, 13, 409, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 13, 55, 13, 409, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 13, 55, 13, 409, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 13, 55, 13, 409, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 13, 55, 13, 409, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 13, 55, 13, 409, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 13, 55, 13, 409, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 13, 55, 13, 409, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 13, 55, 13, 409, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 19, 13, 55, 13, 409, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 19, 13, 55, 13, 409, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 19, 13, 55, 13, 409, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "d2d75bf0-8ead-4e14-90d0-2f1fdb41cf49");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "98f8a8ff-0962-4ca8-bbe1-6a94c7fad0a1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c44b9438-b6ec-4fbe-ad43-28c817e60758", "AQAAAAEAACcQAAAAEMs9fhQoy/5cb0cZmgefotw5nuVdH2wxEMcQe6IPwHOECo1Hgn/FbaCZmE/l5jYRUA==", "70d06c15-3f53-4e4e-97ce-23d36ef21ae0" });

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "BannerId",
                keyValue: 1,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner1.jpg?alt=media&token=3b681990-e08c-4e87-a69b-d1586a72398d");

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "BannerId",
                keyValue: 2,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner2.jpg?alt=media&token=fcd81d71-4b88-4443-a07d-3e21d2ad19bc");

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "BannerId",
                keyValue: 4,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner1.jpg?alt=media&token=3b681990-e08c-4e87-a69b-d1586a72398d");

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "BannerId",
                keyValue: 5,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner2.jpg?alt=media&token=fcd81d71-4b88-4443-a07d-3e21d2ad19bc");

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "BannerId",
                keyValue: 7,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner1.jpg?alt=media&token=3b681990-e08c-4e87-a69b-d1586a72398d");

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "BannerId",
                keyValue: 8,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner2.jpg?alt=media&token=fcd81d71-4b88-4443-a07d-3e21d2ad19bc");

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "BannerId",
                keyValue: 10,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner1.jpg?alt=media&token=3b681990-e08c-4e87-a69b-d1586a72398d");

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "BannerId",
                keyValue: 11,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner2.jpg?alt=media&token=fcd81d71-4b88-4443-a07d-3e21d2ad19bc");

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "BannerId",
                keyValue: 13,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner1.jpg?alt=media&token=3b681990-e08c-4e87-a69b-d1586a72398d");

            migrationBuilder.UpdateData(
                table: "Banner",
                keyColumn: "BannerId",
                keyValue: 14,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner2.jpg?alt=media&token=fcd81d71-4b88-4443-a07d-3e21d2ad19bc");

            migrationBuilder.InsertData(
                table: "Banner",
                columns: new[] { "BannerId", "CampusId", "Img" },
                values: new object[,]
                {
                    { 3, "Hanoi", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner3.jpg?alt=media&token=829186db-6511-49ff-a4b7-48211a4d83db" },
                    { 6, "Danang", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner3.jpg?alt=media&token=829186db-6511-49ff-a4b7-48211a4d83db" },
                    { 9, "HCM", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner3.jpg?alt=media&token=829186db-6511-49ff-a4b7-48211a4d83db" },
                    { 12, "Cantho", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner3.jpg?alt=media&token=829186db-6511-49ff-a4b7-48211a4d83db" },
                    { 15, "Thanhhoa", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FBanner3.jpg?alt=media&token=829186db-6511-49ff-a4b7-48211a4d83db" }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 1, 56, 42, 855, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 1, 56, 42, 855, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 1, 56, 42, 855, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 1, 56, 42, 855, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 1, 56, 42, 855, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 1, 56, 42, 855, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 1, 56, 42, 855, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 1, 56, 42, 855, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 1, 56, 42, 855, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 19, 1, 56, 42, 855, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 19, 1, 56, 42, 855, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 19, 1, 56, 42, 855, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "6d26eeaa-4656-4785-9704-01c36f7bfa58");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "6dd3503a-55d0-4afe-9141-4cf5fc0c0587");
        }
    }
}
