using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class updatecampus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campus_IntroduceCampus_IntroduceId",
                table: "Campus");

            migrationBuilder.DropTable(
                name: "IntroduceCampus");

            migrationBuilder.DropIndex(
                name: "IX_Campus_IntroduceId",
                table: "Campus");

            migrationBuilder.AddColumn<string>(
                name: "Achievements",
                table: "Campus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "History",
                table: "Campus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrainingMotto",
                table: "Campus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhyChooseUs",
                table: "Campus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "192c146b-db29-401b-9e7e-aa05cb6c64c3", "AQAAAAEAACcQAAAAEOjF15dM/NUcsjqsZhVhX+sg1v8upeH6EXo0RF5SFnkp8kMd35ZBw3KJFzTz/GovPA==", "887629b5-47ff-4501-8ebf-b35a763a4b9b" });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4941), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4943), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4944), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4944), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4944) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4945), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4946), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4947), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4948), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4948) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4949), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4950), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4951), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 12,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4951), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4951) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 13,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4952), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 14,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4953), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AdmissionTimeID",
                keyValue: 15,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4954), new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "Cantho",
                columns: new[] { "Achievements", "History", "TrainingMotto", "WhyChooseUs" },
                values: new object[] { "Trường Cao đẳng Nghề XYZ đã đạt được nhiều thành tích đáng tự hào trong suốt quá trình phát triển:\r\n\r\nDanh hiệu “Trường nghề xuất sắc” do Bộ Lao động - Thương binh và Xã hội trao tặng trong nhiều năm liên tiếp.\r\nThành tích đào tạo: Hơn 10.000 học viên đã tốt nghiệp và làm việc tại các công ty, tập đoàn lớn trong và ngoài nước.\r\nGiải thưởng về sáng tạo và nghiên cứu khoa học: Học viên của trường đã đạt nhiều giải thưởng tại các cuộc thi tay nghề và sáng tạo kỹ thuật cấp quốc gia.\r\nThành tích hợp tác quốc tế: Nhà trường đã ký kết nhiều chương trình hợp tác đào tạo và trao đổi học viên với các trường nghề uy tín ở nước ngoài, nâng cao chất lượng giáo dục và mở ra cơ hội học tập quốc tế cho học viên.", "Giới thiệu về lịch sử thành lập Trường Cao đẳng Nghề XYZ\r\n\r\nTrường Cao đẳng Nghề XYZ được thành lập vào năm 1995 với sứ mệnh cung cấp nguồn nhân lực chất lượng cao cho các ngành công nghiệp, dịch vụ và nông nghiệp trên cả nước. Trong suốt hơn hai thập kỷ phát triển, nhà trường đã không ngừng cải tiến, mở rộng quy mô đào tạo và nâng cao chất lượng giảng dạy nhằm đáp ứng nhu cầu ngày càng cao của xã hội và thị trường lao động.\r\n\r\nBan đầu, trường chỉ đào tạo một số ngành nghề cơ bản với quy mô nhỏ, nhưng nhờ sự nỗ lực của đội ngũ cán bộ, giảng viên và sự đầu tư của nhà nước, trường đã phát triển thành một cơ sở giáo dục nghề nghiệp đa ngành, đa lĩnh vực. Hiện nay, Trường Cao đẳng Nghề XYZ tự hào là một trong những đơn vị đi đầu trong việc đào tạo các ngành nghề kỹ thuật, công nghệ và dịch vụ, trang bị cho học viên kiến thức thực tiễn và kỹ năng chuyên môn cao.\r\n\r\nVới phương châm “Học đi đôi với hành”, trường luôn chú trọng vào việc kết hợp giữa lý thuyết và thực hành, giúp học viên sẵn sàng tham gia vào thị trường lao động ngay sau khi tốt nghiệp. Trải qua quá trình hình thành và phát triển, Trường Cao đẳng Nghề XYZ đã khẳng định được vị thế của mình trong hệ thống giáo dục nghề nghiệp và góp phần quan trọng vào sự phát triển của ngành nghề tại Việt Nam.", "Với phương châm \"Học đi đôi với hành, vững lý thuyết – chắc tay nghề\", Trường Cao đẳng Nghề XYZ luôn hướng tới việc đào tạo ra những thế hệ học viên có đầy đủ kiến thức chuyên môn và kỹ năng thực hành, đáp ứng tốt yêu cầu của thị trường lao động hiện đại.\r\n\r\nPhương châm này được cụ thể hóa thông qua các yếu tố:\r\n\r\nGiảng dạy bám sát nhu cầu thị trường: Chương trình đào tạo luôn được cập nhật theo xu hướng phát triển của các ngành công nghiệp và dịch vụ, đảm bảo học viên được trang bị những kiến thức và kỹ năng mới nhất.\r\nPhát triển toàn diện: Bên cạnh kỹ năng nghề nghiệp, trường còn chú trọng phát triển kỹ năng mềm, như kỹ năng giao tiếp, làm việc nhóm, và tư duy sáng tạo, giúp học viên tự tin hơn trong công việc.\r\nHọc tập suốt đời: Nhà trường khuyến khích tinh thần học tập không ngừng nghỉ, giúp học viên luôn sẵn sàng thích nghi với những thay đổi của xã hội và công nghệ.", "Trường Cao đẳng Nghề XYZ luôn được học viên và doanh nghiệp đánh giá cao nhờ vào những ưu điểm vượt trội sau:\r\n\r\nChất lượng đào tạo hàng đầu: Với đội ngũ giảng viên giàu kinh nghiệm và cơ sở vật chất hiện đại, trường đảm bảo cung cấp cho học viên một nền tảng kiến thức vững chắc cùng kỹ năng nghề nghiệp thiết thực.\r\nChương trình đào tạo thực tiễn: Nhà trường luôn chú trọng việc kết hợp lý thuyết với thực hành, giúp học viên không chỉ nắm vững kiến thức mà còn được rèn luyện các kỹ năng cần thiết để làm việc ngay khi ra trường.\r\nMối liên kết chặt chẽ với doanh nghiệp: Trường hợp tác với nhiều doanh nghiệp trong các lĩnh vực khác nhau, tạo điều kiện cho học viên thực tập và có cơ hội việc làm ngay sau khi tốt nghiệp.\r\nMôi trường học tập thân thiện: Nhà trường không chỉ tạo ra một môi trường học tập chuyên nghiệp mà còn thân thiện, tạo điều kiện tốt nhất cho sự phát triển toàn diện của học viên.\r\nCơ hội việc làm cao: Với tỷ lệ học viên có việc làm sau khi ra trường đạt trên 90%, Trường Cao đẳng Nghề XYZ cam kết mang đến cho học viên những cơ hội việc làm tốt nhất." });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "Danang",
                columns: new[] { "Achievements", "History", "TrainingMotto", "WhyChooseUs" },
                values: new object[] { "Trường Cao đẳng Nghề XYZ đã đạt được nhiều thành tích đáng tự hào trong suốt quá trình phát triển:\r\n\r\nDanh hiệu “Trường nghề xuất sắc” do Bộ Lao động - Thương binh và Xã hội trao tặng trong nhiều năm liên tiếp.\r\nThành tích đào tạo: Hơn 10.000 học viên đã tốt nghiệp và làm việc tại các công ty, tập đoàn lớn trong và ngoài nước.\r\nGiải thưởng về sáng tạo và nghiên cứu khoa học: Học viên của trường đã đạt nhiều giải thưởng tại các cuộc thi tay nghề và sáng tạo kỹ thuật cấp quốc gia.\r\nThành tích hợp tác quốc tế: Nhà trường đã ký kết nhiều chương trình hợp tác đào tạo và trao đổi học viên với các trường nghề uy tín ở nước ngoài, nâng cao chất lượng giáo dục và mở ra cơ hội học tập quốc tế cho học viên.", "Giới thiệu về lịch sử thành lập Trường Cao đẳng Nghề XYZ\r\n\r\nTrường Cao đẳng Nghề XYZ được thành lập vào năm 1995 với sứ mệnh cung cấp nguồn nhân lực chất lượng cao cho các ngành công nghiệp, dịch vụ và nông nghiệp trên cả nước. Trong suốt hơn hai thập kỷ phát triển, nhà trường đã không ngừng cải tiến, mở rộng quy mô đào tạo và nâng cao chất lượng giảng dạy nhằm đáp ứng nhu cầu ngày càng cao của xã hội và thị trường lao động.\r\n\r\nBan đầu, trường chỉ đào tạo một số ngành nghề cơ bản với quy mô nhỏ, nhưng nhờ sự nỗ lực của đội ngũ cán bộ, giảng viên và sự đầu tư của nhà nước, trường đã phát triển thành một cơ sở giáo dục nghề nghiệp đa ngành, đa lĩnh vực. Hiện nay, Trường Cao đẳng Nghề XYZ tự hào là một trong những đơn vị đi đầu trong việc đào tạo các ngành nghề kỹ thuật, công nghệ và dịch vụ, trang bị cho học viên kiến thức thực tiễn và kỹ năng chuyên môn cao.\r\n\r\nVới phương châm “Học đi đôi với hành”, trường luôn chú trọng vào việc kết hợp giữa lý thuyết và thực hành, giúp học viên sẵn sàng tham gia vào thị trường lao động ngay sau khi tốt nghiệp. Trải qua quá trình hình thành và phát triển, Trường Cao đẳng Nghề XYZ đã khẳng định được vị thế của mình trong hệ thống giáo dục nghề nghiệp và góp phần quan trọng vào sự phát triển của ngành nghề tại Việt Nam.", "Với phương châm \"Học đi đôi với hành, vững lý thuyết – chắc tay nghề\", Trường Cao đẳng Nghề XYZ luôn hướng tới việc đào tạo ra những thế hệ học viên có đầy đủ kiến thức chuyên môn và kỹ năng thực hành, đáp ứng tốt yêu cầu của thị trường lao động hiện đại.\r\n\r\nPhương châm này được cụ thể hóa thông qua các yếu tố:\r\n\r\nGiảng dạy bám sát nhu cầu thị trường: Chương trình đào tạo luôn được cập nhật theo xu hướng phát triển của các ngành công nghiệp và dịch vụ, đảm bảo học viên được trang bị những kiến thức và kỹ năng mới nhất.\r\nPhát triển toàn diện: Bên cạnh kỹ năng nghề nghiệp, trường còn chú trọng phát triển kỹ năng mềm, như kỹ năng giao tiếp, làm việc nhóm, và tư duy sáng tạo, giúp học viên tự tin hơn trong công việc.\r\nHọc tập suốt đời: Nhà trường khuyến khích tinh thần học tập không ngừng nghỉ, giúp học viên luôn sẵn sàng thích nghi với những thay đổi của xã hội và công nghệ.", "Trường Cao đẳng Nghề XYZ luôn được học viên và doanh nghiệp đánh giá cao nhờ vào những ưu điểm vượt trội sau:\r\n\r\nChất lượng đào tạo hàng đầu: Với đội ngũ giảng viên giàu kinh nghiệm và cơ sở vật chất hiện đại, trường đảm bảo cung cấp cho học viên một nền tảng kiến thức vững chắc cùng kỹ năng nghề nghiệp thiết thực.\r\nChương trình đào tạo thực tiễn: Nhà trường luôn chú trọng việc kết hợp lý thuyết với thực hành, giúp học viên không chỉ nắm vững kiến thức mà còn được rèn luyện các kỹ năng cần thiết để làm việc ngay khi ra trường.\r\nMối liên kết chặt chẽ với doanh nghiệp: Trường hợp tác với nhiều doanh nghiệp trong các lĩnh vực khác nhau, tạo điều kiện cho học viên thực tập và có cơ hội việc làm ngay sau khi tốt nghiệp.\r\nMôi trường học tập thân thiện: Nhà trường không chỉ tạo ra một môi trường học tập chuyên nghiệp mà còn thân thiện, tạo điều kiện tốt nhất cho sự phát triển toàn diện của học viên.\r\nCơ hội việc làm cao: Với tỷ lệ học viên có việc làm sau khi ra trường đạt trên 90%, Trường Cao đẳng Nghề XYZ cam kết mang đến cho học viên những cơ hội việc làm tốt nhất." });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "Hanoi",
                columns: new[] { "Achievements", "History", "TrainingMotto", "WhyChooseUs" },
                values: new object[] { "Trường Cao đẳng Nghề XYZ đã đạt được nhiều thành tích đáng tự hào trong suốt quá trình phát triển:\r\n\r\nDanh hiệu “Trường nghề xuất sắc” do Bộ Lao động - Thương binh và Xã hội trao tặng trong nhiều năm liên tiếp.\r\nThành tích đào tạo: Hơn 10.000 học viên đã tốt nghiệp và làm việc tại các công ty, tập đoàn lớn trong và ngoài nước.\r\nGiải thưởng về sáng tạo và nghiên cứu khoa học: Học viên của trường đã đạt nhiều giải thưởng tại các cuộc thi tay nghề và sáng tạo kỹ thuật cấp quốc gia.\r\nThành tích hợp tác quốc tế: Nhà trường đã ký kết nhiều chương trình hợp tác đào tạo và trao đổi học viên với các trường nghề uy tín ở nước ngoài, nâng cao chất lượng giáo dục và mở ra cơ hội học tập quốc tế cho học viên.", "Giới thiệu về lịch sử thành lập Trường Cao đẳng Nghề XYZ\r\n\r\nTrường Cao đẳng Nghề XYZ được thành lập vào năm 1995 với sứ mệnh cung cấp nguồn nhân lực chất lượng cao cho các ngành công nghiệp, dịch vụ và nông nghiệp trên cả nước. Trong suốt hơn hai thập kỷ phát triển, nhà trường đã không ngừng cải tiến, mở rộng quy mô đào tạo và nâng cao chất lượng giảng dạy nhằm đáp ứng nhu cầu ngày càng cao của xã hội và thị trường lao động.\r\n\r\nBan đầu, trường chỉ đào tạo một số ngành nghề cơ bản với quy mô nhỏ, nhưng nhờ sự nỗ lực của đội ngũ cán bộ, giảng viên và sự đầu tư của nhà nước, trường đã phát triển thành một cơ sở giáo dục nghề nghiệp đa ngành, đa lĩnh vực. Hiện nay, Trường Cao đẳng Nghề XYZ tự hào là một trong những đơn vị đi đầu trong việc đào tạo các ngành nghề kỹ thuật, công nghệ và dịch vụ, trang bị cho học viên kiến thức thực tiễn và kỹ năng chuyên môn cao.\r\n\r\nVới phương châm “Học đi đôi với hành”, trường luôn chú trọng vào việc kết hợp giữa lý thuyết và thực hành, giúp học viên sẵn sàng tham gia vào thị trường lao động ngay sau khi tốt nghiệp. Trải qua quá trình hình thành và phát triển, Trường Cao đẳng Nghề XYZ đã khẳng định được vị thế của mình trong hệ thống giáo dục nghề nghiệp và góp phần quan trọng vào sự phát triển của ngành nghề tại Việt Nam.", "Với phương châm \"Học đi đôi với hành, vững lý thuyết – chắc tay nghề\", Trường Cao đẳng Nghề XYZ luôn hướng tới việc đào tạo ra những thế hệ học viên có đầy đủ kiến thức chuyên môn và kỹ năng thực hành, đáp ứng tốt yêu cầu của thị trường lao động hiện đại.\r\n\r\nPhương châm này được cụ thể hóa thông qua các yếu tố:\r\n\r\nGiảng dạy bám sát nhu cầu thị trường: Chương trình đào tạo luôn được cập nhật theo xu hướng phát triển của các ngành công nghiệp và dịch vụ, đảm bảo học viên được trang bị những kiến thức và kỹ năng mới nhất.\r\nPhát triển toàn diện: Bên cạnh kỹ năng nghề nghiệp, trường còn chú trọng phát triển kỹ năng mềm, như kỹ năng giao tiếp, làm việc nhóm, và tư duy sáng tạo, giúp học viên tự tin hơn trong công việc.\r\nHọc tập suốt đời: Nhà trường khuyến khích tinh thần học tập không ngừng nghỉ, giúp học viên luôn sẵn sàng thích nghi với những thay đổi của xã hội và công nghệ.", "Trường Cao đẳng Nghề XYZ luôn được học viên và doanh nghiệp đánh giá cao nhờ vào những ưu điểm vượt trội sau:\r\n\r\nChất lượng đào tạo hàng đầu: Với đội ngũ giảng viên giàu kinh nghiệm và cơ sở vật chất hiện đại, trường đảm bảo cung cấp cho học viên một nền tảng kiến thức vững chắc cùng kỹ năng nghề nghiệp thiết thực.\r\nChương trình đào tạo thực tiễn: Nhà trường luôn chú trọng việc kết hợp lý thuyết với thực hành, giúp học viên không chỉ nắm vững kiến thức mà còn được rèn luyện các kỹ năng cần thiết để làm việc ngay khi ra trường.\r\nMối liên kết chặt chẽ với doanh nghiệp: Trường hợp tác với nhiều doanh nghiệp trong các lĩnh vực khác nhau, tạo điều kiện cho học viên thực tập và có cơ hội việc làm ngay sau khi tốt nghiệp.\r\nMôi trường học tập thân thiện: Nhà trường không chỉ tạo ra một môi trường học tập chuyên nghiệp mà còn thân thiện, tạo điều kiện tốt nhất cho sự phát triển toàn diện của học viên.\r\nCơ hội việc làm cao: Với tỷ lệ học viên có việc làm sau khi ra trường đạt trên 90%, Trường Cao đẳng Nghề XYZ cam kết mang đến cho học viên những cơ hội việc làm tốt nhất." });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "HCM",
                columns: new[] { "Achievements", "History", "TrainingMotto", "WhyChooseUs" },
                values: new object[] { "Trường Cao đẳng Nghề XYZ đã đạt được nhiều thành tích đáng tự hào trong suốt quá trình phát triển:\r\n\r\nDanh hiệu “Trường nghề xuất sắc” do Bộ Lao động - Thương binh và Xã hội trao tặng trong nhiều năm liên tiếp.\r\nThành tích đào tạo: Hơn 10.000 học viên đã tốt nghiệp và làm việc tại các công ty, tập đoàn lớn trong và ngoài nước.\r\nGiải thưởng về sáng tạo và nghiên cứu khoa học: Học viên của trường đã đạt nhiều giải thưởng tại các cuộc thi tay nghề và sáng tạo kỹ thuật cấp quốc gia.\r\nThành tích hợp tác quốc tế: Nhà trường đã ký kết nhiều chương trình hợp tác đào tạo và trao đổi học viên với các trường nghề uy tín ở nước ngoài, nâng cao chất lượng giáo dục và mở ra cơ hội học tập quốc tế cho học viên.", "Giới thiệu về lịch sử thành lập Trường Cao đẳng Nghề XYZ\r\n\r\nTrường Cao đẳng Nghề XYZ được thành lập vào năm 1995 với sứ mệnh cung cấp nguồn nhân lực chất lượng cao cho các ngành công nghiệp, dịch vụ và nông nghiệp trên cả nước. Trong suốt hơn hai thập kỷ phát triển, nhà trường đã không ngừng cải tiến, mở rộng quy mô đào tạo và nâng cao chất lượng giảng dạy nhằm đáp ứng nhu cầu ngày càng cao của xã hội và thị trường lao động.\r\n\r\nBan đầu, trường chỉ đào tạo một số ngành nghề cơ bản với quy mô nhỏ, nhưng nhờ sự nỗ lực của đội ngũ cán bộ, giảng viên và sự đầu tư của nhà nước, trường đã phát triển thành một cơ sở giáo dục nghề nghiệp đa ngành, đa lĩnh vực. Hiện nay, Trường Cao đẳng Nghề XYZ tự hào là một trong những đơn vị đi đầu trong việc đào tạo các ngành nghề kỹ thuật, công nghệ và dịch vụ, trang bị cho học viên kiến thức thực tiễn và kỹ năng chuyên môn cao.\r\n\r\nVới phương châm “Học đi đôi với hành”, trường luôn chú trọng vào việc kết hợp giữa lý thuyết và thực hành, giúp học viên sẵn sàng tham gia vào thị trường lao động ngay sau khi tốt nghiệp. Trải qua quá trình hình thành và phát triển, Trường Cao đẳng Nghề XYZ đã khẳng định được vị thế của mình trong hệ thống giáo dục nghề nghiệp và góp phần quan trọng vào sự phát triển của ngành nghề tại Việt Nam.", "Với phương châm \"Học đi đôi với hành, vững lý thuyết – chắc tay nghề\", Trường Cao đẳng Nghề XYZ luôn hướng tới việc đào tạo ra những thế hệ học viên có đầy đủ kiến thức chuyên môn và kỹ năng thực hành, đáp ứng tốt yêu cầu của thị trường lao động hiện đại.\r\n\r\nPhương châm này được cụ thể hóa thông qua các yếu tố:\r\n\r\nGiảng dạy bám sát nhu cầu thị trường: Chương trình đào tạo luôn được cập nhật theo xu hướng phát triển của các ngành công nghiệp và dịch vụ, đảm bảo học viên được trang bị những kiến thức và kỹ năng mới nhất.\r\nPhát triển toàn diện: Bên cạnh kỹ năng nghề nghiệp, trường còn chú trọng phát triển kỹ năng mềm, như kỹ năng giao tiếp, làm việc nhóm, và tư duy sáng tạo, giúp học viên tự tin hơn trong công việc.\r\nHọc tập suốt đời: Nhà trường khuyến khích tinh thần học tập không ngừng nghỉ, giúp học viên luôn sẵn sàng thích nghi với những thay đổi của xã hội và công nghệ.", "Trường Cao đẳng Nghề XYZ luôn được học viên và doanh nghiệp đánh giá cao nhờ vào những ưu điểm vượt trội sau:\r\n\r\nChất lượng đào tạo hàng đầu: Với đội ngũ giảng viên giàu kinh nghiệm và cơ sở vật chất hiện đại, trường đảm bảo cung cấp cho học viên một nền tảng kiến thức vững chắc cùng kỹ năng nghề nghiệp thiết thực.\r\nChương trình đào tạo thực tiễn: Nhà trường luôn chú trọng việc kết hợp lý thuyết với thực hành, giúp học viên không chỉ nắm vững kiến thức mà còn được rèn luyện các kỹ năng cần thiết để làm việc ngay khi ra trường.\r\nMối liên kết chặt chẽ với doanh nghiệp: Trường hợp tác với nhiều doanh nghiệp trong các lĩnh vực khác nhau, tạo điều kiện cho học viên thực tập và có cơ hội việc làm ngay sau khi tốt nghiệp.\r\nMôi trường học tập thân thiện: Nhà trường không chỉ tạo ra một môi trường học tập chuyên nghiệp mà còn thân thiện, tạo điều kiện tốt nhất cho sự phát triển toàn diện của học viên.\r\nCơ hội việc làm cao: Với tỷ lệ học viên có việc làm sau khi ra trường đạt trên 90%, Trường Cao đẳng Nghề XYZ cam kết mang đến cho học viên những cơ hội việc làm tốt nhất." });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "Thanhhoa",
                columns: new[] { "Achievements", "History", "TrainingMotto", "WhyChooseUs" },
                values: new object[] { "Trường Cao đẳng Nghề XYZ đã đạt được nhiều thành tích đáng tự hào trong suốt quá trình phát triển:\r\n\r\nDanh hiệu “Trường nghề xuất sắc” do Bộ Lao động - Thương binh và Xã hội trao tặng trong nhiều năm liên tiếp.\r\nThành tích đào tạo: Hơn 10.000 học viên đã tốt nghiệp và làm việc tại các công ty, tập đoàn lớn trong và ngoài nước.\r\nGiải thưởng về sáng tạo và nghiên cứu khoa học: Học viên của trường đã đạt nhiều giải thưởng tại các cuộc thi tay nghề và sáng tạo kỹ thuật cấp quốc gia.\r\nThành tích hợp tác quốc tế: Nhà trường đã ký kết nhiều chương trình hợp tác đào tạo và trao đổi học viên với các trường nghề uy tín ở nước ngoài, nâng cao chất lượng giáo dục và mở ra cơ hội học tập quốc tế cho học viên.", "Giới thiệu về lịch sử thành lập Trường Cao đẳng Nghề XYZ\r\n\r\nTrường Cao đẳng Nghề XYZ được thành lập vào năm 1995 với sứ mệnh cung cấp nguồn nhân lực chất lượng cao cho các ngành công nghiệp, dịch vụ và nông nghiệp trên cả nước. Trong suốt hơn hai thập kỷ phát triển, nhà trường đã không ngừng cải tiến, mở rộng quy mô đào tạo và nâng cao chất lượng giảng dạy nhằm đáp ứng nhu cầu ngày càng cao của xã hội và thị trường lao động.\r\n\r\nBan đầu, trường chỉ đào tạo một số ngành nghề cơ bản với quy mô nhỏ, nhưng nhờ sự nỗ lực của đội ngũ cán bộ, giảng viên và sự đầu tư của nhà nước, trường đã phát triển thành một cơ sở giáo dục nghề nghiệp đa ngành, đa lĩnh vực. Hiện nay, Trường Cao đẳng Nghề XYZ tự hào là một trong những đơn vị đi đầu trong việc đào tạo các ngành nghề kỹ thuật, công nghệ và dịch vụ, trang bị cho học viên kiến thức thực tiễn và kỹ năng chuyên môn cao.\r\n\r\nVới phương châm “Học đi đôi với hành”, trường luôn chú trọng vào việc kết hợp giữa lý thuyết và thực hành, giúp học viên sẵn sàng tham gia vào thị trường lao động ngay sau khi tốt nghiệp. Trải qua quá trình hình thành và phát triển, Trường Cao đẳng Nghề XYZ đã khẳng định được vị thế của mình trong hệ thống giáo dục nghề nghiệp và góp phần quan trọng vào sự phát triển của ngành nghề tại Việt Nam.", "Với phương châm \"Học đi đôi với hành, vững lý thuyết – chắc tay nghề\", Trường Cao đẳng Nghề XYZ luôn hướng tới việc đào tạo ra những thế hệ học viên có đầy đủ kiến thức chuyên môn và kỹ năng thực hành, đáp ứng tốt yêu cầu của thị trường lao động hiện đại.\r\n\r\nPhương châm này được cụ thể hóa thông qua các yếu tố:\r\n\r\nGiảng dạy bám sát nhu cầu thị trường: Chương trình đào tạo luôn được cập nhật theo xu hướng phát triển của các ngành công nghiệp và dịch vụ, đảm bảo học viên được trang bị những kiến thức và kỹ năng mới nhất.\r\nPhát triển toàn diện: Bên cạnh kỹ năng nghề nghiệp, trường còn chú trọng phát triển kỹ năng mềm, như kỹ năng giao tiếp, làm việc nhóm, và tư duy sáng tạo, giúp học viên tự tin hơn trong công việc.\r\nHọc tập suốt đời: Nhà trường khuyến khích tinh thần học tập không ngừng nghỉ, giúp học viên luôn sẵn sàng thích nghi với những thay đổi của xã hội và công nghệ.", "Trường Cao đẳng Nghề XYZ luôn được học viên và doanh nghiệp đánh giá cao nhờ vào những ưu điểm vượt trội sau:\r\n\r\nChất lượng đào tạo hàng đầu: Với đội ngũ giảng viên giàu kinh nghiệm và cơ sở vật chất hiện đại, trường đảm bảo cung cấp cho học viên một nền tảng kiến thức vững chắc cùng kỹ năng nghề nghiệp thiết thực.\r\nChương trình đào tạo thực tiễn: Nhà trường luôn chú trọng việc kết hợp lý thuyết với thực hành, giúp học viên không chỉ nắm vững kiến thức mà còn được rèn luyện các kỹ năng cần thiết để làm việc ngay khi ra trường.\r\nMối liên kết chặt chẽ với doanh nghiệp: Trường hợp tác với nhiều doanh nghiệp trong các lĩnh vực khác nhau, tạo điều kiện cho học viên thực tập và có cơ hội việc làm ngay sau khi tốt nghiệp.\r\nMôi trường học tập thân thiện: Nhà trường không chỉ tạo ra một môi trường học tập chuyên nghiệp mà còn thân thiện, tạo điều kiện tốt nhất cho sự phát triển toàn diện của học viên.\r\nCơ hội việc làm cao: Với tỷ lệ học viên có việc làm sau khi ra trường đạt trên 90%, Trường Cao đẳng Nghề XYZ cam kết mang đến cho học viên những cơ hội việc làm tốt nhất." });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 21, 0, 42, 31, 104, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "1e31e0cc-7fbd-4f20-baf7-fc08b3ea9812");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "8db44d5c-c0c4-414b-ae1d-600c28cc5b53");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Achievements",
                table: "Campus");

            migrationBuilder.DropColumn(
                name: "History",
                table: "Campus");

            migrationBuilder.DropColumn(
                name: "TrainingMotto",
                table: "Campus");

            migrationBuilder.DropColumn(
                name: "WhyChooseUs",
                table: "Campus");

            migrationBuilder.CreateTable(
                name: "IntroduceCampus",
                columns: table => new
                {
                    IntroduceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Achievements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CampusId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    History = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainingMotto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhyChooseUs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntroduceCampus", x => x.IntroduceId);
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

            migrationBuilder.InsertData(
                table: "IntroduceCampus",
                columns: new[] { "IntroduceId", "Achievements", "CampusId", "History", "TrainingMotto", "WhyChooseUs" },
                values: new object[,]
                {
                    { 1, "Trường Cao đẳng Nghề XYZ đã đạt được nhiều thành tích đáng tự hào trong suốt quá trình phát triển:\r\n\r\nDanh hiệu “Trường nghề xuất sắc” do Bộ Lao động - Thương binh và Xã hội trao tặng trong nhiều năm liên tiếp.\r\nThành tích đào tạo: Hơn 10.000 học viên đã tốt nghiệp và làm việc tại các công ty, tập đoàn lớn trong và ngoài nước.\r\nGiải thưởng về sáng tạo và nghiên cứu khoa học: Học viên của trường đã đạt nhiều giải thưởng tại các cuộc thi tay nghề và sáng tạo kỹ thuật cấp quốc gia.\r\nThành tích hợp tác quốc tế: Nhà trường đã ký kết nhiều chương trình hợp tác đào tạo và trao đổi học viên với các trường nghề uy tín ở nước ngoài, nâng cao chất lượng giáo dục và mở ra cơ hội học tập quốc tế cho học viên.", "Hanoi", "Giới thiệu về lịch sử thành lập Trường Cao đẳng Nghề XYZ\r\n\r\nTrường Cao đẳng Nghề XYZ được thành lập vào năm 1995 với sứ mệnh cung cấp nguồn nhân lực chất lượng cao cho các ngành công nghiệp, dịch vụ và nông nghiệp trên cả nước. Trong suốt hơn hai thập kỷ phát triển, nhà trường đã không ngừng cải tiến, mở rộng quy mô đào tạo và nâng cao chất lượng giảng dạy nhằm đáp ứng nhu cầu ngày càng cao của xã hội và thị trường lao động.\r\n\r\nBan đầu, trường chỉ đào tạo một số ngành nghề cơ bản với quy mô nhỏ, nhưng nhờ sự nỗ lực của đội ngũ cán bộ, giảng viên và sự đầu tư của nhà nước, trường đã phát triển thành một cơ sở giáo dục nghề nghiệp đa ngành, đa lĩnh vực. Hiện nay, Trường Cao đẳng Nghề XYZ tự hào là một trong những đơn vị đi đầu trong việc đào tạo các ngành nghề kỹ thuật, công nghệ và dịch vụ, trang bị cho học viên kiến thức thực tiễn và kỹ năng chuyên môn cao.\r\n\r\nVới phương châm “Học đi đôi với hành”, trường luôn chú trọng vào việc kết hợp giữa lý thuyết và thực hành, giúp học viên sẵn sàng tham gia vào thị trường lao động ngay sau khi tốt nghiệp. Trải qua quá trình hình thành và phát triển, Trường Cao đẳng Nghề XYZ đã khẳng định được vị thế của mình trong hệ thống giáo dục nghề nghiệp và góp phần quan trọng vào sự phát triển của ngành nghề tại Việt Nam.", "Với phương châm \"Học đi đôi với hành, vững lý thuyết – chắc tay nghề\", Trường Cao đẳng Nghề XYZ luôn hướng tới việc đào tạo ra những thế hệ học viên có đầy đủ kiến thức chuyên môn và kỹ năng thực hành, đáp ứng tốt yêu cầu của thị trường lao động hiện đại.\r\n\r\nPhương châm này được cụ thể hóa thông qua các yếu tố:\r\n\r\nGiảng dạy bám sát nhu cầu thị trường: Chương trình đào tạo luôn được cập nhật theo xu hướng phát triển của các ngành công nghiệp và dịch vụ, đảm bảo học viên được trang bị những kiến thức và kỹ năng mới nhất.\r\nPhát triển toàn diện: Bên cạnh kỹ năng nghề nghiệp, trường còn chú trọng phát triển kỹ năng mềm, như kỹ năng giao tiếp, làm việc nhóm, và tư duy sáng tạo, giúp học viên tự tin hơn trong công việc.\r\nHọc tập suốt đời: Nhà trường khuyến khích tinh thần học tập không ngừng nghỉ, giúp học viên luôn sẵn sàng thích nghi với những thay đổi của xã hội và công nghệ.", "Trường Cao đẳng Nghề XYZ luôn được học viên và doanh nghiệp đánh giá cao nhờ vào những ưu điểm vượt trội sau:\r\n\r\nChất lượng đào tạo hàng đầu: Với đội ngũ giảng viên giàu kinh nghiệm và cơ sở vật chất hiện đại, trường đảm bảo cung cấp cho học viên một nền tảng kiến thức vững chắc cùng kỹ năng nghề nghiệp thiết thực.\r\nChương trình đào tạo thực tiễn: Nhà trường luôn chú trọng việc kết hợp lý thuyết với thực hành, giúp học viên không chỉ nắm vững kiến thức mà còn được rèn luyện các kỹ năng cần thiết để làm việc ngay khi ra trường.\r\nMối liên kết chặt chẽ với doanh nghiệp: Trường hợp tác với nhiều doanh nghiệp trong các lĩnh vực khác nhau, tạo điều kiện cho học viên thực tập và có cơ hội việc làm ngay sau khi tốt nghiệp.\r\nMôi trường học tập thân thiện: Nhà trường không chỉ tạo ra một môi trường học tập chuyên nghiệp mà còn thân thiện, tạo điều kiện tốt nhất cho sự phát triển toàn diện của học viên.\r\nCơ hội việc làm cao: Với tỷ lệ học viên có việc làm sau khi ra trường đạt trên 90%, Trường Cao đẳng Nghề XYZ cam kết mang đến cho học viên những cơ hội việc làm tốt nhất." },
                    { 2, "Trường Cao đẳng Nghề XYZ đã đạt được nhiều thành tích đáng tự hào trong suốt quá trình phát triển:\r\n\r\nDanh hiệu “Trường nghề xuất sắc” do Bộ Lao động - Thương binh và Xã hội trao tặng trong nhiều năm liên tiếp.\r\nThành tích đào tạo: Hơn 10.000 học viên đã tốt nghiệp và làm việc tại các công ty, tập đoàn lớn trong và ngoài nước.\r\nGiải thưởng về sáng tạo và nghiên cứu khoa học: Học viên của trường đã đạt nhiều giải thưởng tại các cuộc thi tay nghề và sáng tạo kỹ thuật cấp quốc gia.\r\nThành tích hợp tác quốc tế: Nhà trường đã ký kết nhiều chương trình hợp tác đào tạo và trao đổi học viên với các trường nghề uy tín ở nước ngoài, nâng cao chất lượng giáo dục và mở ra cơ hội học tập quốc tế cho học viên.", "Danang", "Giới thiệu về lịch sử thành lập Trường Cao đẳng Nghề XYZ\r\n\r\nTrường Cao đẳng Nghề XYZ được thành lập vào năm 1995 với sứ mệnh cung cấp nguồn nhân lực chất lượng cao cho các ngành công nghiệp, dịch vụ và nông nghiệp trên cả nước. Trong suốt hơn hai thập kỷ phát triển, nhà trường đã không ngừng cải tiến, mở rộng quy mô đào tạo và nâng cao chất lượng giảng dạy nhằm đáp ứng nhu cầu ngày càng cao của xã hội và thị trường lao động.\r\n\r\nBan đầu, trường chỉ đào tạo một số ngành nghề cơ bản với quy mô nhỏ, nhưng nhờ sự nỗ lực của đội ngũ cán bộ, giảng viên và sự đầu tư của nhà nước, trường đã phát triển thành một cơ sở giáo dục nghề nghiệp đa ngành, đa lĩnh vực. Hiện nay, Trường Cao đẳng Nghề XYZ tự hào là một trong những đơn vị đi đầu trong việc đào tạo các ngành nghề kỹ thuật, công nghệ và dịch vụ, trang bị cho học viên kiến thức thực tiễn và kỹ năng chuyên môn cao.\r\n\r\nVới phương châm “Học đi đôi với hành”, trường luôn chú trọng vào việc kết hợp giữa lý thuyết và thực hành, giúp học viên sẵn sàng tham gia vào thị trường lao động ngay sau khi tốt nghiệp. Trải qua quá trình hình thành và phát triển, Trường Cao đẳng Nghề XYZ đã khẳng định được vị thế của mình trong hệ thống giáo dục nghề nghiệp và góp phần quan trọng vào sự phát triển của ngành nghề tại Việt Nam.", "Với phương châm \"Học đi đôi với hành, vững lý thuyết – chắc tay nghề\", Trường Cao đẳng Nghề XYZ luôn hướng tới việc đào tạo ra những thế hệ học viên có đầy đủ kiến thức chuyên môn và kỹ năng thực hành, đáp ứng tốt yêu cầu của thị trường lao động hiện đại.\r\n\r\nPhương châm này được cụ thể hóa thông qua các yếu tố:\r\n\r\nGiảng dạy bám sát nhu cầu thị trường: Chương trình đào tạo luôn được cập nhật theo xu hướng phát triển của các ngành công nghiệp và dịch vụ, đảm bảo học viên được trang bị những kiến thức và kỹ năng mới nhất.\r\nPhát triển toàn diện: Bên cạnh kỹ năng nghề nghiệp, trường còn chú trọng phát triển kỹ năng mềm, như kỹ năng giao tiếp, làm việc nhóm, và tư duy sáng tạo, giúp học viên tự tin hơn trong công việc.\r\nHọc tập suốt đời: Nhà trường khuyến khích tinh thần học tập không ngừng nghỉ, giúp học viên luôn sẵn sàng thích nghi với những thay đổi của xã hội và công nghệ.", "Trường Cao đẳng Nghề XYZ luôn được học viên và doanh nghiệp đánh giá cao nhờ vào những ưu điểm vượt trội sau:\r\n\r\nChất lượng đào tạo hàng đầu: Với đội ngũ giảng viên giàu kinh nghiệm và cơ sở vật chất hiện đại, trường đảm bảo cung cấp cho học viên một nền tảng kiến thức vững chắc cùng kỹ năng nghề nghiệp thiết thực.\r\nChương trình đào tạo thực tiễn: Nhà trường luôn chú trọng việc kết hợp lý thuyết với thực hành, giúp học viên không chỉ nắm vững kiến thức mà còn được rèn luyện các kỹ năng cần thiết để làm việc ngay khi ra trường.\r\nMối liên kết chặt chẽ với doanh nghiệp: Trường hợp tác với nhiều doanh nghiệp trong các lĩnh vực khác nhau, tạo điều kiện cho học viên thực tập và có cơ hội việc làm ngay sau khi tốt nghiệp.\r\nMôi trường học tập thân thiện: Nhà trường không chỉ tạo ra một môi trường học tập chuyên nghiệp mà còn thân thiện, tạo điều kiện tốt nhất cho sự phát triển toàn diện của học viên.\r\nCơ hội việc làm cao: Với tỷ lệ học viên có việc làm sau khi ra trường đạt trên 90%, Trường Cao đẳng Nghề XYZ cam kết mang đến cho học viên những cơ hội việc làm tốt nhất." },
                    { 3, "Trường Cao đẳng Nghề XYZ đã đạt được nhiều thành tích đáng tự hào trong suốt quá trình phát triển:\r\n\r\nDanh hiệu “Trường nghề xuất sắc” do Bộ Lao động - Thương binh và Xã hội trao tặng trong nhiều năm liên tiếp.\r\nThành tích đào tạo: Hơn 10.000 học viên đã tốt nghiệp và làm việc tại các công ty, tập đoàn lớn trong và ngoài nước.\r\nGiải thưởng về sáng tạo và nghiên cứu khoa học: Học viên của trường đã đạt nhiều giải thưởng tại các cuộc thi tay nghề và sáng tạo kỹ thuật cấp quốc gia.\r\nThành tích hợp tác quốc tế: Nhà trường đã ký kết nhiều chương trình hợp tác đào tạo và trao đổi học viên với các trường nghề uy tín ở nước ngoài, nâng cao chất lượng giáo dục và mở ra cơ hội học tập quốc tế cho học viên.", "Cantho", "Giới thiệu về lịch sử thành lập Trường Cao đẳng Nghề XYZ\r\n\r\nTrường Cao đẳng Nghề XYZ được thành lập vào năm 1995 với sứ mệnh cung cấp nguồn nhân lực chất lượng cao cho các ngành công nghiệp, dịch vụ và nông nghiệp trên cả nước. Trong suốt hơn hai thập kỷ phát triển, nhà trường đã không ngừng cải tiến, mở rộng quy mô đào tạo và nâng cao chất lượng giảng dạy nhằm đáp ứng nhu cầu ngày càng cao của xã hội và thị trường lao động.\r\n\r\nBan đầu, trường chỉ đào tạo một số ngành nghề cơ bản với quy mô nhỏ, nhưng nhờ sự nỗ lực của đội ngũ cán bộ, giảng viên và sự đầu tư của nhà nước, trường đã phát triển thành một cơ sở giáo dục nghề nghiệp đa ngành, đa lĩnh vực. Hiện nay, Trường Cao đẳng Nghề XYZ tự hào là một trong những đơn vị đi đầu trong việc đào tạo các ngành nghề kỹ thuật, công nghệ và dịch vụ, trang bị cho học viên kiến thức thực tiễn và kỹ năng chuyên môn cao.\r\n\r\nVới phương châm “Học đi đôi với hành”, trường luôn chú trọng vào việc kết hợp giữa lý thuyết và thực hành, giúp học viên sẵn sàng tham gia vào thị trường lao động ngay sau khi tốt nghiệp. Trải qua quá trình hình thành và phát triển, Trường Cao đẳng Nghề XYZ đã khẳng định được vị thế của mình trong hệ thống giáo dục nghề nghiệp và góp phần quan trọng vào sự phát triển của ngành nghề tại Việt Nam.", "Với phương châm \"Học đi đôi với hành, vững lý thuyết – chắc tay nghề\", Trường Cao đẳng Nghề XYZ luôn hướng tới việc đào tạo ra những thế hệ học viên có đầy đủ kiến thức chuyên môn và kỹ năng thực hành, đáp ứng tốt yêu cầu của thị trường lao động hiện đại.\r\n\r\nPhương châm này được cụ thể hóa thông qua các yếu tố:\r\n\r\nGiảng dạy bám sát nhu cầu thị trường: Chương trình đào tạo luôn được cập nhật theo xu hướng phát triển của các ngành công nghiệp và dịch vụ, đảm bảo học viên được trang bị những kiến thức và kỹ năng mới nhất.\r\nPhát triển toàn diện: Bên cạnh kỹ năng nghề nghiệp, trường còn chú trọng phát triển kỹ năng mềm, như kỹ năng giao tiếp, làm việc nhóm, và tư duy sáng tạo, giúp học viên tự tin hơn trong công việc.\r\nHọc tập suốt đời: Nhà trường khuyến khích tinh thần học tập không ngừng nghỉ, giúp học viên luôn sẵn sàng thích nghi với những thay đổi của xã hội và công nghệ.", "Trường Cao đẳng Nghề XYZ luôn được học viên và doanh nghiệp đánh giá cao nhờ vào những ưu điểm vượt trội sau:\r\n\r\nChất lượng đào tạo hàng đầu: Với đội ngũ giảng viên giàu kinh nghiệm và cơ sở vật chất hiện đại, trường đảm bảo cung cấp cho học viên một nền tảng kiến thức vững chắc cùng kỹ năng nghề nghiệp thiết thực.\r\nChương trình đào tạo thực tiễn: Nhà trường luôn chú trọng việc kết hợp lý thuyết với thực hành, giúp học viên không chỉ nắm vững kiến thức mà còn được rèn luyện các kỹ năng cần thiết để làm việc ngay khi ra trường.\r\nMối liên kết chặt chẽ với doanh nghiệp: Trường hợp tác với nhiều doanh nghiệp trong các lĩnh vực khác nhau, tạo điều kiện cho học viên thực tập và có cơ hội việc làm ngay sau khi tốt nghiệp.\r\nMôi trường học tập thân thiện: Nhà trường không chỉ tạo ra một môi trường học tập chuyên nghiệp mà còn thân thiện, tạo điều kiện tốt nhất cho sự phát triển toàn diện của học viên.\r\nCơ hội việc làm cao: Với tỷ lệ học viên có việc làm sau khi ra trường đạt trên 90%, Trường Cao đẳng Nghề XYZ cam kết mang đến cho học viên những cơ hội việc làm tốt nhất." },
                    { 4, "Trường Cao đẳng Nghề XYZ đã đạt được nhiều thành tích đáng tự hào trong suốt quá trình phát triển:\r\n\r\nDanh hiệu “Trường nghề xuất sắc” do Bộ Lao động - Thương binh và Xã hội trao tặng trong nhiều năm liên tiếp.\r\nThành tích đào tạo: Hơn 10.000 học viên đã tốt nghiệp và làm việc tại các công ty, tập đoàn lớn trong và ngoài nước.\r\nGiải thưởng về sáng tạo và nghiên cứu khoa học: Học viên của trường đã đạt nhiều giải thưởng tại các cuộc thi tay nghề và sáng tạo kỹ thuật cấp quốc gia.\r\nThành tích hợp tác quốc tế: Nhà trường đã ký kết nhiều chương trình hợp tác đào tạo và trao đổi học viên với các trường nghề uy tín ở nước ngoài, nâng cao chất lượng giáo dục và mở ra cơ hội học tập quốc tế cho học viên.", "HCM", "Giới thiệu về lịch sử thành lập Trường Cao đẳng Nghề XYZ\r\n\r\nTrường Cao đẳng Nghề XYZ được thành lập vào năm 1995 với sứ mệnh cung cấp nguồn nhân lực chất lượng cao cho các ngành công nghiệp, dịch vụ và nông nghiệp trên cả nước. Trong suốt hơn hai thập kỷ phát triển, nhà trường đã không ngừng cải tiến, mở rộng quy mô đào tạo và nâng cao chất lượng giảng dạy nhằm đáp ứng nhu cầu ngày càng cao của xã hội và thị trường lao động.\r\n\r\nBan đầu, trường chỉ đào tạo một số ngành nghề cơ bản với quy mô nhỏ, nhưng nhờ sự nỗ lực của đội ngũ cán bộ, giảng viên và sự đầu tư của nhà nước, trường đã phát triển thành một cơ sở giáo dục nghề nghiệp đa ngành, đa lĩnh vực. Hiện nay, Trường Cao đẳng Nghề XYZ tự hào là một trong những đơn vị đi đầu trong việc đào tạo các ngành nghề kỹ thuật, công nghệ và dịch vụ, trang bị cho học viên kiến thức thực tiễn và kỹ năng chuyên môn cao.\r\n\r\nVới phương châm “Học đi đôi với hành”, trường luôn chú trọng vào việc kết hợp giữa lý thuyết và thực hành, giúp học viên sẵn sàng tham gia vào thị trường lao động ngay sau khi tốt nghiệp. Trải qua quá trình hình thành và phát triển, Trường Cao đẳng Nghề XYZ đã khẳng định được vị thế của mình trong hệ thống giáo dục nghề nghiệp và góp phần quan trọng vào sự phát triển của ngành nghề tại Việt Nam.", "Với phương châm \"Học đi đôi với hành, vững lý thuyết – chắc tay nghề\", Trường Cao đẳng Nghề XYZ luôn hướng tới việc đào tạo ra những thế hệ học viên có đầy đủ kiến thức chuyên môn và kỹ năng thực hành, đáp ứng tốt yêu cầu của thị trường lao động hiện đại.\r\n\r\nPhương châm này được cụ thể hóa thông qua các yếu tố:\r\n\r\nGiảng dạy bám sát nhu cầu thị trường: Chương trình đào tạo luôn được cập nhật theo xu hướng phát triển của các ngành công nghiệp và dịch vụ, đảm bảo học viên được trang bị những kiến thức và kỹ năng mới nhất.\r\nPhát triển toàn diện: Bên cạnh kỹ năng nghề nghiệp, trường còn chú trọng phát triển kỹ năng mềm, như kỹ năng giao tiếp, làm việc nhóm, và tư duy sáng tạo, giúp học viên tự tin hơn trong công việc.\r\nHọc tập suốt đời: Nhà trường khuyến khích tinh thần học tập không ngừng nghỉ, giúp học viên luôn sẵn sàng thích nghi với những thay đổi của xã hội và công nghệ.", "Trường Cao đẳng Nghề XYZ luôn được học viên và doanh nghiệp đánh giá cao nhờ vào những ưu điểm vượt trội sau:\r\n\r\nChất lượng đào tạo hàng đầu: Với đội ngũ giảng viên giàu kinh nghiệm và cơ sở vật chất hiện đại, trường đảm bảo cung cấp cho học viên một nền tảng kiến thức vững chắc cùng kỹ năng nghề nghiệp thiết thực.\r\nChương trình đào tạo thực tiễn: Nhà trường luôn chú trọng việc kết hợp lý thuyết với thực hành, giúp học viên không chỉ nắm vững kiến thức mà còn được rèn luyện các kỹ năng cần thiết để làm việc ngay khi ra trường.\r\nMối liên kết chặt chẽ với doanh nghiệp: Trường hợp tác với nhiều doanh nghiệp trong các lĩnh vực khác nhau, tạo điều kiện cho học viên thực tập và có cơ hội việc làm ngay sau khi tốt nghiệp.\r\nMôi trường học tập thân thiện: Nhà trường không chỉ tạo ra một môi trường học tập chuyên nghiệp mà còn thân thiện, tạo điều kiện tốt nhất cho sự phát triển toàn diện của học viên.\r\nCơ hội việc làm cao: Với tỷ lệ học viên có việc làm sau khi ra trường đạt trên 90%, Trường Cao đẳng Nghề XYZ cam kết mang đến cho học viên những cơ hội việc làm tốt nhất." },
                    { 5, "Trường Cao đẳng Nghề XYZ đã đạt được nhiều thành tích đáng tự hào trong suốt quá trình phát triển:\r\n\r\nDanh hiệu “Trường nghề xuất sắc” do Bộ Lao động - Thương binh và Xã hội trao tặng trong nhiều năm liên tiếp.\r\nThành tích đào tạo: Hơn 10.000 học viên đã tốt nghiệp và làm việc tại các công ty, tập đoàn lớn trong và ngoài nước.\r\nGiải thưởng về sáng tạo và nghiên cứu khoa học: Học viên của trường đã đạt nhiều giải thưởng tại các cuộc thi tay nghề và sáng tạo kỹ thuật cấp quốc gia.\r\nThành tích hợp tác quốc tế: Nhà trường đã ký kết nhiều chương trình hợp tác đào tạo và trao đổi học viên với các trường nghề uy tín ở nước ngoài, nâng cao chất lượng giáo dục và mở ra cơ hội học tập quốc tế cho học viên.", "Thanhhoa", "Giới thiệu về lịch sử thành lập Trường Cao đẳng Nghề XYZ\r\n\r\nTrường Cao đẳng Nghề XYZ được thành lập vào năm 1995 với sứ mệnh cung cấp nguồn nhân lực chất lượng cao cho các ngành công nghiệp, dịch vụ và nông nghiệp trên cả nước. Trong suốt hơn hai thập kỷ phát triển, nhà trường đã không ngừng cải tiến, mở rộng quy mô đào tạo và nâng cao chất lượng giảng dạy nhằm đáp ứng nhu cầu ngày càng cao của xã hội và thị trường lao động.\r\n\r\nBan đầu, trường chỉ đào tạo một số ngành nghề cơ bản với quy mô nhỏ, nhưng nhờ sự nỗ lực của đội ngũ cán bộ, giảng viên và sự đầu tư của nhà nước, trường đã phát triển thành một cơ sở giáo dục nghề nghiệp đa ngành, đa lĩnh vực. Hiện nay, Trường Cao đẳng Nghề XYZ tự hào là một trong những đơn vị đi đầu trong việc đào tạo các ngành nghề kỹ thuật, công nghệ và dịch vụ, trang bị cho học viên kiến thức thực tiễn và kỹ năng chuyên môn cao.\r\n\r\nVới phương châm “Học đi đôi với hành”, trường luôn chú trọng vào việc kết hợp giữa lý thuyết và thực hành, giúp học viên sẵn sàng tham gia vào thị trường lao động ngay sau khi tốt nghiệp. Trải qua quá trình hình thành và phát triển, Trường Cao đẳng Nghề XYZ đã khẳng định được vị thế của mình trong hệ thống giáo dục nghề nghiệp và góp phần quan trọng vào sự phát triển của ngành nghề tại Việt Nam.", "Với phương châm \"Học đi đôi với hành, vững lý thuyết – chắc tay nghề\", Trường Cao đẳng Nghề XYZ luôn hướng tới việc đào tạo ra những thế hệ học viên có đầy đủ kiến thức chuyên môn và kỹ năng thực hành, đáp ứng tốt yêu cầu của thị trường lao động hiện đại.\r\n\r\nPhương châm này được cụ thể hóa thông qua các yếu tố:\r\n\r\nGiảng dạy bám sát nhu cầu thị trường: Chương trình đào tạo luôn được cập nhật theo xu hướng phát triển của các ngành công nghiệp và dịch vụ, đảm bảo học viên được trang bị những kiến thức và kỹ năng mới nhất.\r\nPhát triển toàn diện: Bên cạnh kỹ năng nghề nghiệp, trường còn chú trọng phát triển kỹ năng mềm, như kỹ năng giao tiếp, làm việc nhóm, và tư duy sáng tạo, giúp học viên tự tin hơn trong công việc.\r\nHọc tập suốt đời: Nhà trường khuyến khích tinh thần học tập không ngừng nghỉ, giúp học viên luôn sẵn sàng thích nghi với những thay đổi của xã hội và công nghệ.", "Trường Cao đẳng Nghề XYZ luôn được học viên và doanh nghiệp đánh giá cao nhờ vào những ưu điểm vượt trội sau:\r\n\r\nChất lượng đào tạo hàng đầu: Với đội ngũ giảng viên giàu kinh nghiệm và cơ sở vật chất hiện đại, trường đảm bảo cung cấp cho học viên một nền tảng kiến thức vững chắc cùng kỹ năng nghề nghiệp thiết thực.\r\nChương trình đào tạo thực tiễn: Nhà trường luôn chú trọng việc kết hợp lý thuyết với thực hành, giúp học viên không chỉ nắm vững kiến thức mà còn được rèn luyện các kỹ năng cần thiết để làm việc ngay khi ra trường.\r\nMối liên kết chặt chẽ với doanh nghiệp: Trường hợp tác với nhiều doanh nghiệp trong các lĩnh vực khác nhau, tạo điều kiện cho học viên thực tập và có cơ hội việc làm ngay sau khi tốt nghiệp.\r\nMôi trường học tập thân thiện: Nhà trường không chỉ tạo ra một môi trường học tập chuyên nghiệp mà còn thân thiện, tạo điều kiện tốt nhất cho sự phát triển toàn diện của học viên.\r\nCơ hội việc làm cao: Với tỷ lệ học viên có việc làm sau khi ra trường đạt trên 90%, Trường Cao đẳng Nghề XYZ cam kết mang đến cho học viên những cơ hội việc làm tốt nhất." }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Campus_IntroduceId",
                table: "Campus",
                column: "IntroduceId",
                unique: true,
                filter: "[IntroduceId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Campus_IntroduceCampus_IntroduceId",
                table: "Campus",
                column: "IntroduceId",
                principalTable: "IntroduceCampus",
                principalColumn: "IntroduceId");
        }
    }
}
