using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class BlogSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public BlogSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<BlogCategory>().HasData(
                new BlogCategory()
                {
                    BlogCategoryId = 1,
                    BlogCategoryName = "Tuyển sinh",
                    CampusId = "Hanoi"
                },
                new BlogCategory()
                {
                    CampusId = "Hanoi",
                    BlogCategoryId = 2,
                    BlogCategoryName = "Hoạt động của sinh viên",
                },
                new BlogCategory()
                {
                    CampusId = "Hanoi",
                    BlogCategoryId = 3,
                    BlogCategoryName = "Sự kiện",
                },
                new BlogCategory()
                {
                    BlogCategoryId = 4,
                    BlogCategoryName = "Tuyển sinh",
                    CampusId = "Danang"
                },
                new BlogCategory()
                {
                    CampusId = "Danang",
                    BlogCategoryId = 5,
                    BlogCategoryName = "Hoạt động của sinh viên",
                },
                new BlogCategory()
                {
                    CampusId = "Danang",
                    BlogCategoryId = 6,
                    BlogCategoryName = "Sự kiện",
                },
                new BlogCategory()
                {
                    BlogCategoryId = 7,
                    BlogCategoryName = "Tuyển sinh",
                    CampusId = "Cantho"
                },
                new BlogCategory()
                {
                    CampusId = "Cantho",
                    BlogCategoryId = 8,
                    BlogCategoryName = "Hoạt động của sinh viên",
                },
                new BlogCategory()
                {
                    CampusId = "Cantho",
                    BlogCategoryId = 9,
                    BlogCategoryName = "Sự kiện",
                },
                new BlogCategory()
                {
                    BlogCategoryId = 10,
                    BlogCategoryName = "Tuyển sinh",
                    CampusId = "HCM"
                },
                new BlogCategory()
                {
                    CampusId = "HCM",
                    BlogCategoryId = 11,
                    BlogCategoryName = "Hoạt động của sinh viên",
                },
                new BlogCategory()
                {
                    CampusId = "HCM",
                    BlogCategoryId = 12,
                    BlogCategoryName = "Sự kiện",
                },
                new BlogCategory()
                {
                    BlogCategoryId = 13,
                    BlogCategoryName = "Tuyển sinh",
                    CampusId = "Thanhhoa"
                },
                new BlogCategory()
                {
                    CampusId = "Thanhhoa",
                    BlogCategoryId = 14,
                    BlogCategoryName = "Hoạt động của sinh viên",
                },
                new BlogCategory()
                {
                    CampusId = "Thanhhoa",
                    BlogCategoryId = 15,
                    BlogCategoryName = "Sự kiện",
                }
                );
            //seed data blog 
            modelBuilder.Entity<Blog>().HasData(
                new Blog()
                {
                    BlogId = 1,
                    BlogCategoryId = 3,
                    DateCreate = DateTime.Now,
                    Title = "Trăng tròn đã vươn cao tại Hoà Lạc",
                    Description = "Trăng tròn đã vươn cao tại Hoà Lạc, Rằm tháng Tám đã gần đi qua, các Cóc “ngoan xinh iu” của FPTU đã đi chơi Trung thu về chưa?",
                    Content = "Trăng tròn đã vươn cao tại Hoà Lạc, Rằm tháng Tám đã gần đi qua, các Cóc “ngoan xinh iu” của FPTU đã đi chơi Trung thu về chưa? \r\n\U0001f96e Trung thu là dịp để chúng ta ngồi lại bên nhau, hàn huyên với gia đình, bạn bè và những người thân yêu. Hãy cùng tận hưởng Tết Trung Thu bên bánh dẻo, bánh nướng và thả mình vào ánh trăng lung linh để cảm nhận những khoảnh khắc tuyệt diệu, đáng quý này nhé!\r\n✨ Nhân dịp Tết Trung thu, xin gửi những lời chúc tốt đẹp nhất đến thầy cô, anh chị cán bộ trường Đại học FPT, cùng các bạn sinh viên thân yêu! Chúc mọi người một mùa trăng an yên hơn sau những ảnh hưởng lớn của bão vừa qua.\r\n 📌 VÀ ĐỪNG QUÊN lên dây cót, bật chế độ sẵn sàng đón chờ những sự kiện “cực kỳ hoành tráng” đang tới gần. Kết nối, khám phá và trải nghiệm hết mình trong kỳ fall này bạn nhé!",

                },
                new Blog()
                {
                    BlogId = 2,
                    BlogCategoryId = 3,
                    DateCreate = DateTime.Now,
                    Title = "[𝐊𝐈𝐂𝐊 𝐎𝐅𝐅] - 𝐉𝐈𝐌𝐁𝐎 𝐔𝐍𝐈𝐓𝐘 𝐅𝐄𝐒𝐓",
                    Description = " 𝐉𝐢𝐦𝐛𝐨 𝐀𝐫𝐦𝐲 - mang trong mình trọng trách quan trọng nhất đó là bảo vệ và phát triển lãnh thổ với ba đại đội: Cơ bắp, Biết tuốt và Bay bổng.",
                    Content = "[𝐊𝐈𝐂𝐊 𝐎𝐅𝐅] - 𝐉𝐈𝐌𝐁𝐎 𝐔𝐍𝐈𝐓𝐘 𝐅𝐄𝐒𝐓\r\n🏞 Tại vùng đất Hola Campus, nơi mà tinh thần học tập, sáng tạo nghệ thuật và sức mạnh thể chất được đề cao luôn tồn tại một lực lượng quân chủng mang tên 𝐉𝐢𝐦𝐛𝐨 𝐀𝐫𝐦𝐲 - mang trong mình trọng trách quan trọng nhất đó là bảo vệ và phát triển lãnh thổ với ba đại đội: Cơ bắp, Biết tuốt và Bay bổng. \r\n✨ Vào năm 2024, những người đứng đầu của 𝐉𝐢𝐦𝐛𝐨 𝐀𝐫𝐦𝐲 đã quyết định tổ chức một sự kiện, một ngày hội đặc biệt mang tên 𝐽𝑖𝑚𝑏𝑜 𝑈𝑛𝑖𝑡𝑦 𝐹𝑒𝑠𝑡. Sự kiện là dịp để các chiến sĩ của cả 3 Đại đội gặp mặt, giao lưu và học hỏi lẫn nhau không chỉ về tinh thần đồng đội mà còn được khám phá thêm những kỹ năng từ các đội khác. \r\n🌷 Đặc biệt, 𝐽𝑖𝑚𝑏𝑜 𝑈𝑛𝑖𝑡𝑦 𝐹𝑒𝑠𝑡 không chỉ giới hạn cho các chiến sĩ của 𝐉𝐢𝐦𝐛𝐨 𝐀𝐫𝐦𝐲 mà còn mở cửa chào đón tất cả những người trẻ của vùng đất Hola Campus có quan tâm và muốn trải nghiệm môi trường, văn hóa đặc trưng của 𝐉𝐢𝐦𝐛𝐨 𝐀𝐫𝐦𝐲 tham gia sự kiện. Nếu như bạn đã sẵn sàng với các chiến binh bước vào thế giới của 𝐉𝐢𝐦𝐛𝐨 𝐀𝐫𝐦𝐲 cùng một tinh thần nhiệt huyết và tràn đầy năng lượng để vượt qua những thử thách đầy cam go thì hãy cùng chúng mình đón chờ hành trình sắp tới nhé!\r\n---------------------------------------\r\n🔥 𝐉𝐈𝐌𝐁𝐎 𝐔𝐍𝐈𝐓𝐘 𝐅𝐄𝐒𝐓 🔥\r\n◻️ Thời gian: 13h - 17h30 thứ hai, ngày 30/09/2024\r\n◻️ Địa điểm: Đường 30m, Đại học FPT Hà Nội \r\n---------------------------------------\r\nTHÔNG TIN LIÊN HỆ\r\n◻️ Trưởng ban Tổ chức: Kiều Bảo Lộc (0367488155)\r\n◻️ Trưởng ban HR: Nguyễn Ngọc Quỳnh (0865349170)",

                },
                new Blog()
                {
                    BlogId = 3,
                    BlogCategoryId = 2,
                    DateCreate = DateTime.Now,
                    Title = "🌟[ORIENTATION WEEK]🌟 GIỚI THIỆU CÁC PHÒNG BAN CHỨC NĂNG TẠI ĐẠI HỌC FPT",
                    Description = " Giới thiệu các phòng ban tại Đại học FPT",
                    Content = "🌟[ORIENTATION WEEK]🌟 GIỚI THIỆU CÁC PHÒNG BAN CHỨC NĂNG TẠI ĐẠI HỌC FPT\r\n🔥Ngay lúc này đây, Phòng Hợp tác Quốc tế và Phát triển Cá nhân ICPDP đang có mặt tại Hội trường NIC cùng các tân sinh viên K20 tham gia Buổi học định hướng với chủ đề “Giới thiệu các phòng ban tại Đại học FPT”.\r\n🔥Tại buổi định hướng, các Cóc út đã được lắng nghe anh Lê Huy Hoàng - Cán bộ quản lý IC, đại diện phòng ICPDP chia sẻ về vai trò và chức năng của Phòng ICPDP, về các cơ hội học tập, trải nghiệm trong và ngoài nước dành cho tất cả các bạn sinh viên FPT.\r\n\U0001faf6Phòng ICPDP rất sẵn lòng đồng hành cùng các Cóc trong hành trình 4 năm thanh xuân tại Đại học FPT. Hy vọng chúng mình sẽ có thật nhiều kỷ niệm tại Đại học FPT Hà Nội. \r\n-----------------------------------------------------------\r\nMọi thắc mắc vui lòng liên hệ: Phòng Hợp tác Quốc tế và Phát triển cá nhân ICPDP FPTU",

                },
                new Blog()
                {
                    BlogId = 4,
                    BlogCategoryId = 1,
                    DateCreate = DateTime.Now,
                    Title = "🔈 THÔNG BÁO: VĂN PHÒNG TUYỂN SINH CỦA FPT POLYTECHNIC HÀ NỘI SẼ LÀM VIỆC CẢ TUẦN 🔈",
                    Description = " Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).",
                    Content = " 🌈 Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).\r\n🕰️ Thời gian: \r\nSáng: 8h -12h\r\nChiều: 13h30- 17h30\r\n✅ Các bạn học sinh và phụ huynh lưu ý, khi đến trường thì vào CỔNG SỐ 1 - chỗ cây ATM TP Bank màu tím và đi vào Văn phòng tuyển sinh từ lớp 12 trở lên để làm thủ tục nhập học.\r\n👉 Còn đợi gì nữa, xách balo lên trường nộp hồ sơ và tham quan ngay nào!",

                },
                new Blog()
                {
                    BlogId = 5,
                    BlogCategoryId = 1,
                    DateCreate = DateTime.Now,
                    Title = "🔈 THÔNG BÁO: VĂN PHÒNG TUYỂN SINH CỦA FPT POLYTECHNIC HÀ NỘI SẼ LÀM VIỆC CẢ TUẦN 🔈",
                    Description = " Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).",
                    Content = " 🌈 Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).\r\n🕰️ Thời gian: \r\nSáng: 8h -12h\r\nChiều: 13h30- 17h30\r\n✅ Các bạn học sinh và phụ huynh lưu ý, khi đến trường thì vào CỔNG SỐ 1 - chỗ cây ATM TP Bank màu tím và đi vào Văn phòng tuyển sinh từ lớp 12 trở lên để làm thủ tục nhập học.\r\n👉 Còn đợi gì nữa, xách balo lên trường nộp hồ sơ và tham quan ngay nào!",

                },
                new Blog()
                {
                    BlogId = 6,
                    BlogCategoryId = 1,
                    DateCreate = DateTime.Now,
                    Title = "🔈 THÔNG BÁO: VĂN PHÒNG TUYỂN SINH CỦA FPT POLYTECHNIC HÀ NỘI SẼ LÀM VIỆC CẢ TUẦN 🔈",
                    Description = " Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).",
                    Content = " 🌈 Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).\r\n🕰️ Thời gian: \r\nSáng: 8h -12h\r\nChiều: 13h30- 17h30\r\n✅ Các bạn học sinh và phụ huynh lưu ý, khi đến trường thì vào CỔNG SỐ 1 - chỗ cây ATM TP Bank màu tím và đi vào Văn phòng tuyển sinh từ lớp 12 trở lên để làm thủ tục nhập học.\r\n👉 Còn đợi gì nữa, xách balo lên trường nộp hồ sơ và tham quan ngay nào!",


                },
                new Blog()
                {
                    BlogId = 7,
                    BlogCategoryId = 1,
                    DateCreate = DateTime.Now,
                    Title = "🔈 THÔNG BÁO: VĂN PHÒNG TUYỂN SINH CỦA FPT POLYTECHNIC HÀ NỘI SẼ LÀM VIỆC CẢ TUẦN 🔈",
                    Description = " Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).",
                    Content = " 🌈 Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).\r\n🕰️ Thời gian: \r\nSáng: 8h -12h\r\nChiều: 13h30- 17h30\r\n✅ Các bạn học sinh và phụ huynh lưu ý, khi đến trường thì vào CỔNG SỐ 1 - chỗ cây ATM TP Bank màu tím và đi vào Văn phòng tuyển sinh từ lớp 12 trở lên để làm thủ tục nhập học.\r\n👉 Còn đợi gì nữa, xách balo lên trường nộp hồ sơ và tham quan ngay nào!",

                },
                new Blog()
                {
                    BlogId = 8,
                    BlogCategoryId = 1,
                    DateCreate = DateTime.Now,
                    Title = "🔈 THÔNG BÁO: VĂN PHÒNG TUYỂN SINH CỦA FPT POLYTECHNIC HÀ NỘI SẼ LÀM VIỆC CẢ TUẦN 🔈",
                    Description = " Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).",
                    Content = " 🌈 Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).\r\n🕰️ Thời gian: \r\nSáng: 8h -12h\r\nChiều: 13h30- 17h30\r\n✅ Các bạn học sinh và phụ huynh lưu ý, khi đến trường thì vào CỔNG SỐ 1 - chỗ cây ATM TP Bank màu tím và đi vào Văn phòng tuyển sinh từ lớp 12 trở lên để làm thủ tục nhập học.\r\n👉 Còn đợi gì nữa, xách balo lên trường nộp hồ sơ và tham quan ngay nào!",

                },
                new Blog()
                {
                    BlogId = 9,
                    BlogCategoryId = 1,
                    DateCreate = DateTime.Now,
                    Title = "🔈 THÔNG BÁO: VĂN PHÒNG TUYỂN SINH CỦA FPT POLYTECHNIC HÀ NỘI SẼ LÀM VIỆC CẢ TUẦN 🔈",
                    Description = " Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).",
                    Content = " 🌈 Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).\r\n🕰️ Thời gian: \r\nSáng: 8h -12h\r\nChiều: 13h30- 17h30\r\n✅ Các bạn học sinh và phụ huynh lưu ý, khi đến trường thì vào CỔNG SỐ 1 - chỗ cây ATM TP Bank màu tím và đi vào Văn phòng tuyển sinh từ lớp 12 trở lên để làm thủ tục nhập học.\r\n👉 Còn đợi gì nữa, xách balo lên trường nộp hồ sơ và tham quan ngay nào!",

                });
        }
    }
}
