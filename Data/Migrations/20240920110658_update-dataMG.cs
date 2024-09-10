using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class updatedataMG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "558a7df8-f937-4436-8daa-61462e52d93c", "AQAAAAEAACcQAAAAEB53+6Tx4uVHdaXWgyt3HIM5jzAjtT4C1JPUNgsxS9Qq6Bvi246NS+Y9XPtvOz9H1A==", "41f0ad7a-15d9-4595-8592-ead471aec632" });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8105), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8106), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8106) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8107), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8107) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8108), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8109), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8110), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8111), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8112), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8113), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8114), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8115), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 12,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8116), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 13,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8117), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 14,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8118), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 15,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8123), new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "Cantho",
                column: "AdmissionPlanID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "Danang",
                column: "AdmissionPlanID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "Hanoi",
                column: "AdmissionPlanID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "HCM",
                column: "AdmissionPlanID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "Thanhhoa",
                column: "AdmissionPlanID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 20, 18, 6, 58, 162, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "c6f17940-29e6-42f0-bd92-baf1562b121b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "80a24217-5618-4f2c-982c-71725180947a");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb97bc49-7e47-4a9d-8bf7-e42bf9a50848", "AQAAAAEAACcQAAAAEN93YiqDTF+7MRsjOOlp4qwAs61ropeBt6ei4du8k1w7F+hnwGfAY0Y60EZqxVdMJQ==", "15790760-3b9e-4463-a9c2-8a98313a56d0" });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9512), new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9511) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9513), new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9514), new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9515), new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9516), new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9517), new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9517) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9518), new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9519), new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9520), new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9521), new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9521), new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 12,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9522), new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 13,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9523), new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 14,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9524), new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9524) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 15,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9525), new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "Cantho",
                column: "AdmissionPlanID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "Danang",
                column: "AdmissionPlanID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "Hanoi",
                column: "AdmissionPlanID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "HCM",
                column: "AdmissionPlanID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "Thanhhoa",
                column: "AdmissionPlanID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 20, 17, 19, 27, 185, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "1ea48823-c384-436c-8121-2237d295e883");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "d0cb767d-6301-4f89-b699-6486fd2c6a6a");
        }
    }
}
