using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class updateFKCampus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdmissionPlan_Campus_CampusId",
                table: "AdmissionPlan");

            migrationBuilder.DropIndex(
                name: "IX_AdmissionPlan_CampusId",
                table: "AdmissionPlan");

            migrationBuilder.AddColumn<int>(
                name: "AdmissionPlanID",
                table: "Campus",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CampusId",
                table: "AdmissionPlan",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

            migrationBuilder.CreateIndex(
                name: "IX_Campus_AdmissionPlanID",
                table: "Campus",
                column: "AdmissionPlanID",
                unique: true,
                filter: "[AdmissionPlanID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Campus_AdmissionPlan_AdmissionPlanID",
                table: "Campus",
                column: "AdmissionPlanID",
                principalTable: "AdmissionPlan",
                principalColumn: "AdmissionPlanID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campus_AdmissionPlan_AdmissionPlanID",
                table: "Campus");

            migrationBuilder.DropIndex(
                name: "IX_Campus_AdmissionPlanID",
                table: "Campus");

            migrationBuilder.DropColumn(
                name: "AdmissionPlanID",
                table: "Campus");

            migrationBuilder.AlterColumn<string>(
                name: "CampusId",
                table: "AdmissionPlan",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33d937e7-6446-4750-be72-9eef006135ec", "AQAAAAEAACcQAAAAEAvfbN/vtvcIKXQ7T7W1s/6wegIhA57Hzw8a2Fb4WxKFqJwTJBA0SvcPU9Cv4iaGrA==", "165ed4a6-3b9e-468f-8520-99d635460477" });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7073), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7075), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7076), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7077), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7078), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7078) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7079), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7078) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7080), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7081), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7081), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7082), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7083), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7083) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 12,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7084), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 13,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7085), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 14,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7086), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 15,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7087), new DateTime(2024, 9, 20, 17, 7, 49, 44, DateTimeKind.Local).AddTicks(7086) });

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

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionPlan_CampusId",
                table: "AdmissionPlan",
                column: "CampusId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdmissionPlan_Campus_CampusId",
                table: "AdmissionPlan",
                column: "CampusId",
                principalTable: "Campus",
                principalColumn: "CampusId");
        }
    }
}
