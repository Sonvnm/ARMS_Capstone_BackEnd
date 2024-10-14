using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGBlog1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd1dca9e-864d-4e05-92d6-66576662cdd3", "AQAAAAEAACcQAAAAEK7bR3o0p+K/OQBjUi69uuCZsj9nkhz3ra0J5CZ/mkvgX7k+AJCJLD1wTs/Yn3hKJw==", "960da8bf-47ba-4c30-a062-f2a3f62b28ba" });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogCategoryId", "DateCreate", "Description", "Title" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2024, 9, 18, 23, 53, 1, 282, DateTimeKind.Local).AddTicks(5915), "Trăng tròn đã vươn cao tại Hoà Lạc, Rằm tháng Tám đã gần đi qua, các Cóc “ngoan xinh iu” của FPTU đã đi chơi Trung thu về chưa?", "Trăng tròn đã vươn cao tại Hoà Lạc" },
                    { 2, 3, new DateTime(2024, 9, 18, 23, 53, 1, 282, DateTimeKind.Local).AddTicks(5931), " 𝐉𝐢𝐦𝐛𝐨 𝐀𝐫𝐦𝐲 - mang trong mình trọng trách quan trọng nhất đó là bảo vệ và phát triển lãnh thổ với ba đại đội: Cơ bắp, Biết tuốt và Bay bổng.", "[𝐊𝐈𝐂𝐊 𝐎𝐅𝐅] - 𝐉𝐈𝐌𝐁𝐎 𝐔𝐍𝐈𝐓𝐘 𝐅𝐄𝐒𝐓" },
                    { 3, 2, new DateTime(2024, 9, 18, 23, 53, 1, 282, DateTimeKind.Local).AddTicks(5933), " Giới thiệu các phòng ban tại Đại học FPT", "🌟[ORIENTATION WEEK]🌟 GIỚI THIỆU CÁC PHÒNG BAN CHỨC NĂNG TẠI ĐẠI HỌC FPT" },
                    { 4, 1, new DateTime(2024, 9, 18, 23, 53, 1, 282, DateTimeKind.Local).AddTicks(5934), " Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).", "🔈 THÔNG BÁO: VĂN PHÒNG TUYỂN SINH CỦA FPT POLYTECHNIC HÀ NỘI SẼ LÀM VIỆC CẢ TUẦN 🔈" },
                    { 5, 1, new DateTime(2024, 9, 18, 23, 53, 1, 282, DateTimeKind.Local).AddTicks(5935), " Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).", "🔈 THÔNG BÁO: VĂN PHÒNG TUYỂN SINH CỦA FPT POLYTECHNIC HÀ NỘI SẼ LÀM VIỆC CẢ TUẦN 🔈" },
                    { 6, 1, new DateTime(2024, 9, 18, 23, 53, 1, 282, DateTimeKind.Local).AddTicks(5935), " Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).", "🔈 THÔNG BÁO: VĂN PHÒNG TUYỂN SINH CỦA FPT POLYTECHNIC HÀ NỘI SẼ LÀM VIỆC CẢ TUẦN 🔈" },
                    { 7, 1, new DateTime(2024, 9, 18, 23, 53, 1, 282, DateTimeKind.Local).AddTicks(5936), " Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).", "🔈 THÔNG BÁO: VĂN PHÒNG TUYỂN SINH CỦA FPT POLYTECHNIC HÀ NỘI SẼ LÀM VIỆC CẢ TUẦN 🔈" },
                    { 8, 1, new DateTime(2024, 9, 18, 23, 53, 1, 282, DateTimeKind.Local).AddTicks(5937), " Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).", "🔈 THÔNG BÁO: VĂN PHÒNG TUYỂN SINH CỦA FPT POLYTECHNIC HÀ NỘI SẼ LÀM VIỆC CẢ TUẦN 🔈" },
                    { 9, 1, new DateTime(2024, 9, 18, 23, 53, 1, 282, DateTimeKind.Local).AddTicks(5938), " Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).", "🔈 THÔNG BÁO: VĂN PHÒNG TUYỂN SINH CỦA FPT POLYTECHNIC HÀ NỘI SẼ LÀM VIỆC CẢ TUẦN 🔈" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "257fc2c3-74ad-42b2-a863-d6aed72b48fc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "b99f7a34-f24d-4ccf-9b21-599f1dd21d8c");

            migrationBuilder.InsertData(
                table: "BlogDetails",
                columns: new[] { "BDId", "BlogId", "Description", "Img", "TitleImg" },
                values: new object[,]
                {
                    { 1, 1, "Trăng tròn đã vươn cao tại Hoà Lạc, Rằm tháng Tám đã gần đi qua, các Cóc “ngoan xinh iu” của FPTU đã đi chơi Trung thu về chưa? \r\n🥮 Trung thu là dịp để chúng ta ngồi lại bên nhau, hàn huyên với gia đình, bạn bè và những người thân yêu. Hãy cùng tận hưởng Tết Trung Thu bên bánh dẻo, bánh nướng và thả mình vào ánh trăng lung linh để cảm nhận những khoảnh khắc tuyệt diệu, đáng quý này nhé!\r\n✨ Nhân dịp Tết Trung thu, xin gửi những lời chúc tốt đẹp nhất đến thầy cô, anh chị cán bộ trường Đại học FPT, cùng các bạn sinh viên thân yêu! Chúc mọi người một mùa trăng an yên hơn sau những ảnh hưởng lớn của bão vừa qua.\r\n 📌 VÀ ĐỪNG QUÊN lên dây cót, bật chế độ sẵn sàng đón chờ những sự kiện “cực kỳ hoành tráng” đang tới gần. Kết nối, khám phá và trải nghiệm hết mình trong kỳ fall này bạn nhé!", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2FBlog1.jpg?alt=media&token=346b7cd3-c4cb-449c-a586-145f52f63d32", null },
                    { 2, 2, "[𝐊𝐈𝐂𝐊 𝐎𝐅𝐅] - 𝐉𝐈𝐌𝐁𝐎 𝐔𝐍𝐈𝐓𝐘 𝐅𝐄𝐒𝐓\r\n🏞 Tại vùng đất Hola Campus, nơi mà tinh thần học tập, sáng tạo nghệ thuật và sức mạnh thể chất được đề cao luôn tồn tại một lực lượng quân chủng mang tên 𝐉𝐢𝐦𝐛𝐨 𝐀𝐫𝐦𝐲 - mang trong mình trọng trách quan trọng nhất đó là bảo vệ và phát triển lãnh thổ với ba đại đội: Cơ bắp, Biết tuốt và Bay bổng. \r\n✨ Vào năm 2024, những người đứng đầu của 𝐉𝐢𝐦𝐛𝐨 𝐀𝐫𝐦𝐲 đã quyết định tổ chức một sự kiện, một ngày hội đặc biệt mang tên 𝐽𝑖𝑚𝑏𝑜 𝑈𝑛𝑖𝑡𝑦 𝐹𝑒𝑠𝑡. Sự kiện là dịp để các chiến sĩ của cả 3 Đại đội gặp mặt, giao lưu và học hỏi lẫn nhau không chỉ về tinh thần đồng đội mà còn được khám phá thêm những kỹ năng từ các đội khác. \r\n🌷 Đặc biệt, 𝐽𝑖𝑚𝑏𝑜 𝑈𝑛𝑖𝑡𝑦 𝐹𝑒𝑠𝑡 không chỉ giới hạn cho các chiến sĩ của 𝐉𝐢𝐦𝐛𝐨 𝐀𝐫𝐦𝐲 mà còn mở cửa chào đón tất cả những người trẻ của vùng đất Hola Campus có quan tâm và muốn trải nghiệm môi trường, văn hóa đặc trưng của 𝐉𝐢𝐦𝐛𝐨 𝐀𝐫𝐦𝐲 tham gia sự kiện. Nếu như bạn đã sẵn sàng với các chiến binh bước vào thế giới của 𝐉𝐢𝐦𝐛𝐨 𝐀𝐫𝐦𝐲 cùng một tinh thần nhiệt huyết và tràn đầy năng lượng để vượt qua những thử thách đầy cam go thì hãy cùng chúng mình đón chờ hành trình sắp tới nhé!\r\n---------------------------------------\r\n🔥 𝐉𝐈𝐌𝐁𝐎 𝐔𝐍𝐈𝐓𝐘 𝐅𝐄𝐒𝐓 🔥\r\n◻️ Thời gian: 13h - 17h30 thứ hai, ngày 30/09/2024\r\n◻️ Địa điểm: Đường 30m, Đại học FPT Hà Nội \r\n---------------------------------------\r\nTHÔNG TIN LIÊN HỆ\r\n◻️ Trưởng ban Tổ chức: Kiều Bảo Lộc (0367488155)\r\n◻️ Trưởng ban HR: Nguyễn Ngọc Quỳnh (0865349170)", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2FBlog2.jpg?alt=media&token=67d34983-366f-4f30-bb7d-e9977dc71193", null },
                    { 3, 3, "🌟[ORIENTATION WEEK]🌟 GIỚI THIỆU CÁC PHÒNG BAN CHỨC NĂNG TẠI ĐẠI HỌC FPT\r\n🔥Ngay lúc này đây, Phòng Hợp tác Quốc tế và Phát triển Cá nhân ICPDP đang có mặt tại Hội trường NIC cùng các tân sinh viên K20 tham gia Buổi học định hướng với chủ đề “Giới thiệu các phòng ban tại Đại học FPT”.\r\n🔥Tại buổi định hướng, các Cóc út đã được lắng nghe anh Lê Huy Hoàng - Cán bộ quản lý IC, đại diện phòng ICPDP chia sẻ về vai trò và chức năng của Phòng ICPDP, về các cơ hội học tập, trải nghiệm trong và ngoài nước dành cho tất cả các bạn sinh viên FPT.\r\n🫶Phòng ICPDP rất sẵn lòng đồng hành cùng các Cóc trong hành trình 4 năm thanh xuân tại Đại học FPT. Hy vọng chúng mình sẽ có thật nhiều kỷ niệm tại Đại học FPT Hà Nội. \r\n-----------------------------------------------------------\r\nMọi thắc mắc vui lòng liên hệ: Phòng Hợp tác Quốc tế và Phát triển cá nhân ICPDP FPTU", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2FBD3.jpg?alt=media&token=cdd2575f-41b5-4ecd-853a-017ab4a0bebc", null },
                    { 4, 4, " 🌈 Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).\r\n🕰️ Thời gian: \r\nSáng: 8h -12h\r\nChiều: 13h30- 17h30\r\n✅ Các bạn học sinh và phụ huynh lưu ý, khi đến trường thì vào CỔNG SỐ 1 - chỗ cây ATM TP Bank màu tím và đi vào Văn phòng tuyển sinh từ lớp 12 trở lên để làm thủ tục nhập học.\r\n👉 Còn đợi gì nữa, xách balo lên trường nộp hồ sơ và tham quan ngay nào!", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2FBD4.jpg?alt=media&token=1b920d16-2a60-4fcc-98fb-a2c5bc51aa1a", null },
                    { 5, 4, null, "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2FBD4.jpg?alt=media&token=1b920d16-2a60-4fcc-98fb-a2c5bc51aa1a", null },
                    { 6, 5, " 🌈 Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).\r\n🕰️ Thời gian: \r\nSáng: 8h -12h\r\nChiều: 13h30- 17h30\r\n✅ Các bạn học sinh và phụ huynh lưu ý, khi đến trường thì vào CỔNG SỐ 1 - chỗ cây ATM TP Bank màu tím và đi vào Văn phòng tuyển sinh từ lớp 12 trở lên để làm thủ tục nhập học.\r\n👉 Còn đợi gì nữa, xách balo lên trường nộp hồ sơ và tham quan ngay nào!", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2FBD4.jpg?alt=media&token=1b920d16-2a60-4fcc-98fb-a2c5bc51aa1a", null },
                    { 7, 5, null, "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2FBD4.jpg?alt=media&token=1b920d16-2a60-4fcc-98fb-a2c5bc51aa1a", null },
                    { 8, 6, " 🌈 Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).\r\n🕰️ Thời gian: \r\nSáng: 8h -12h\r\nChiều: 13h30- 17h30\r\n✅ Các bạn học sinh và phụ huynh lưu ý, khi đến trường thì vào CỔNG SỐ 1 - chỗ cây ATM TP Bank màu tím và đi vào Văn phòng tuyển sinh từ lớp 12 trở lên để làm thủ tục nhập học.\r\n👉 Còn đợi gì nữa, xách balo lên trường nộp hồ sơ và tham quan ngay nào!", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2FBD4.jpg?alt=media&token=1b920d16-2a60-4fcc-98fb-a2c5bc51aa1a", null },
                    { 9, 6, null, "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2FBD4.jpg?alt=media&token=1b920d16-2a60-4fcc-98fb-a2c5bc51aa1a", null },
                    { 10, 7, " 🌈 Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).\r\n🕰️ Thời gian: \r\nSáng: 8h -12h\r\nChiều: 13h30- 17h30\r\n✅ Các bạn học sinh và phụ huynh lưu ý, khi đến trường thì vào CỔNG SỐ 1 - chỗ cây ATM TP Bank màu tím và đi vào Văn phòng tuyển sinh từ lớp 12 trở lên để làm thủ tục nhập học.\r\n👉 Còn đợi gì nữa, xách balo lên trường nộp hồ sơ và tham quan ngay nào!", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2FBD4.jpg?alt=media&token=1b920d16-2a60-4fcc-98fb-a2c5bc51aa1a", null },
                    { 11, 7, null, "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2FBD4.jpg?alt=media&token=1b920d16-2a60-4fcc-98fb-a2c5bc51aa1a", null },
                    { 12, 8, " 🌈 Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).\r\n🕰️ Thời gian: \r\nSáng: 8h -12h\r\nChiều: 13h30- 17h30\r\n✅ Các bạn học sinh và phụ huynh lưu ý, khi đến trường thì vào CỔNG SỐ 1 - chỗ cây ATM TP Bank màu tím và đi vào Văn phòng tuyển sinh từ lớp 12 trở lên để làm thủ tục nhập học.\r\n👉 Còn đợi gì nữa, xách balo lên trường nộp hồ sơ và tham quan ngay nào!", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2FBD4.jpg?alt=media&token=1b920d16-2a60-4fcc-98fb-a2c5bc51aa1a", null },
                    { 13, 8, null, "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2FBD4.jpg?alt=media&token=1b920d16-2a60-4fcc-98fb-a2c5bc51aa1a", null },
                    { 14, 9, " 🌈 Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).\r\n🕰️ Thời gian: \r\nSáng: 8h -12h\r\nChiều: 13h30- 17h30\r\n✅ Các bạn học sinh và phụ huynh lưu ý, khi đến trường thì vào CỔNG SỐ 1 - chỗ cây ATM TP Bank màu tím và đi vào Văn phòng tuyển sinh từ lớp 12 trở lên để làm thủ tục nhập học.\r\n👉 Còn đợi gì nữa, xách balo lên trường nộp hồ sơ và tham quan ngay nào!", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2FBD4.jpg?alt=media&token=1b920d16-2a60-4fcc-98fb-a2c5bc51aa1a", null },
                    { 15, 9, null, "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2FBD4.jpg?alt=media&token=1b920d16-2a60-4fcc-98fb-a2c5bc51aa1a", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogDetails",
                keyColumn: "BDId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BlogDetails",
                keyColumn: "BDId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BlogDetails",
                keyColumn: "BDId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BlogDetails",
                keyColumn: "BDId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BlogDetails",
                keyColumn: "BDId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BlogDetails",
                keyColumn: "BDId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BlogDetails",
                keyColumn: "BDId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BlogDetails",
                keyColumn: "BDId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BlogDetails",
                keyColumn: "BDId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BlogDetails",
                keyColumn: "BDId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BlogDetails",
                keyColumn: "BDId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BlogDetails",
                keyColumn: "BDId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BlogDetails",
                keyColumn: "BDId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BlogDetails",
                keyColumn: "BDId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BlogDetails",
                keyColumn: "BDId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad2c21f9-a50f-4997-931e-90de827ed9ad", "AQAAAAEAACcQAAAAEEnUNCZ26LOjGswBKKjcYm98r3Tcep5ZlpHW4roR5spYgIz3IfknYin046DQl49lgQ==", "cb73d87a-7416-453f-ae84-92a603612a5e" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "fc0447d9-3f35-43c9-b0b3-ec5c02d3cd6b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "ff3c4368-64ec-4ccc-8913-8b6c142d4a67");
        }
    }
}
