using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c44b9438-b6ec-4fbe-ad43-28c817e60758", "AQAAAAEAACcQAAAAEMs9fhQoy/5cb0cZmgefotw5nuVdH2wxEMcQe6IPwHOECo1Hgn/FbaCZmE/l5jYRUA==", "70d06c15-3f53-4e4e-97ce-23d36ef21ae0" });

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

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "BlogId", "Content", "CreatedDate", "FacebookUserId", "FacebookUserName", "ParentCommentId" },
                values: new object[,]
                {
                    { 1, 1, "This is the first comment", new DateTime(2024, 9, 19, 1, 56, 42, 855, DateTimeKind.Local).AddTicks(5121), "fb12345", "John Doe", null },
                    { 3, 2, "Another comment on the second blog", new DateTime(2024, 9, 19, 1, 56, 42, 855, DateTimeKind.Local).AddTicks(5127), "fb54321", "Alice", null }
                });

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

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "BlogId", "Content", "CreatedDate", "FacebookUserId", "FacebookUserName", "ParentCommentId" },
                values: new object[] { 2, 1, "This is a reply to the first comment", new DateTime(2024, 9, 19, 1, 56, 42, 855, DateTimeKind.Local).AddTicks(5124), "fb67890", "Jane Smith", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd2c0e9b-e2c5-493a-bff6-754a6a2f8ae1", "AQAAAAEAACcQAAAAEJUQ+1sEuCmWXJr0VkH9vvak8qdJUTV2oXZR0OGOQk3Kw7AvVJjcn8B/23j9fH5VKg==", "8341cd8e-4c65-4527-9056-aea55f5e7371" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 1, 51, 25, 12, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 1, 51, 25, 12, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 1, 51, 25, 12, DateTimeKind.Local).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 1, 51, 25, 12, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 1, 51, 25, 12, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 1, 51, 25, 12, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 1, 51, 25, 12, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 1, 51, 25, 12, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 19, 1, 51, 25, 12, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "cf9e1e26-d61b-48d6-b39a-e5a1f7c9fc2c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "5bfd2da8-5b99-4ab2-ba42-56413e5946aa");
        }
    }
}
