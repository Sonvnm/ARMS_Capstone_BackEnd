using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class PriorityDetailSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public PriorityDetailSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            // seed TypeAdmission
            modelBuilder.Entity<PriorityDetail>().HasData(
                new PriorityDetail()
                {
                    PriorityID = 1,
                    PriorityName = "Đối tượng 01",
                    PriorityDescription = "Công dân Việt Nam là người dân tộc thiểu số có nơi thường trú trong thời gian học THPT hoặc trung cấp trên 18 tháng tại Khu vực 1.",
                    TypeOfPriority = TypeOfPriority.UT1,

                },
                new PriorityDetail()
                {
                    PriorityID = 2,
                    PriorityName = "Đối tượng 02",
                    PriorityDescription = "Công nhân trực tiếp sản xuất đã làm việc liên tục 5 năm trở lên, trong đó có ít nhất 2 năm là chiến sĩ thi đua được cấp tỉnh trở lên công nhận và cấp bằng khen.",
                    TypeOfPriority = TypeOfPriority.UT1,

                },
                new PriorityDetail()
                {
                    PriorityID = 3,
                    PriorityName = "Đối tượng 03",
                    PriorityDescription = "a) Thương binh, bệnh binh, người có \"Giấy chứng nhận người được hưởng chính sách như thương binh;\r\n\r\nb) Quân nhân; sĩ quan, hạ sĩ quan, chiến sĩ nghĩa vụ trong Công an nhân dân tại ngũ được cử đi học có thời gian phục vụ từ 12 tháng trở lên tại Khu vực 1;\r\n\r\nc) Quân nhân; sĩ quan, hạ sĩ quan, chiến sĩ nghĩa vụ trong Công an nhân dân tại ngũ được cử đi học có thời gian phục vụ từ 18 tháng trở lên;\r\n\r\nd) Quân nhân; sĩ quan, hạ sĩ quan, chiến sĩ nghĩa vụ trong Công an nhân dân đã xuất ngũ, được công nhận hoàn thành nghĩa vụ phục vụ tại ngũ theo quy định;",
                    TypeOfPriority = TypeOfPriority.UT1,

                },
                new PriorityDetail()
                {
                    PriorityID = 4,
                    PriorityName = "Đối tượng 04",
                    PriorityDescription = "a) Thân nhân liệt sĩ;\r\n\r\nb) Con thương binh, con bệnh binh, con của người được hưởng chính sách như thương binh bị suy giảm khả năng lao động từ 81% trở lên;\r\n\r\nc) Con của người hoạt động kháng chiến bị nhiễm chất độc hóa học bị suy giảm khả năng lao động 81% trở lên;\r\n\r\nd) Con của Anh hùng Lực lượng vũ trang nhân dân; con của Anh hùng Lao động trong thời kỳ kháng chiến;\r\n\r\nđ) Con của người hoạt động kháng chiến bị dị dạng, dị tật do hậu quả của chất độc hóa học đang hưởng trợ cấp hàng tháng.",
                    TypeOfPriority = TypeOfPriority.UT1,

                },
                new PriorityDetail()
                {
                    PriorityID = 5,
                    PriorityName = "Đối tượng 05",
                    PriorityDescription = "a) Thanh niên xung phong tập trung được cử đi học;\r\n\r\nb) Quân nhân; sĩ quan, hạ sĩ quan, chiến sĩ nghĩa vụ trong Công an nhân dân tại ngũ được cử đi học có thời gian phục vụ dưới 12 tháng ở Khu vực 1 và dưới 18 tháng ở khu vực khác;\r\n\r\nc) Chỉ huy trưởng, Chỉ huy phó ban chỉ huy quân sự xã, phường, thị trấn; Thôn đội trưởng, Trung đội trưởng Dân quân tự vệ nòng cốt, Dân quân tự vệ đã hoàn thành nghĩa vụ tham gia Dân quân tự vệ nòng cốt từ 12 tháng trở lên, dự thi vào ngành Quân sự cơ sở. Thời hạn tối đa được hưởng ưu tiên là 18 tháng kể từ ngày ký quyết định xuất ngũ đến ngày ĐKXT.",
                    TypeOfPriority = TypeOfPriority.UT2,

                }
                ,
                new PriorityDetail()
                {
                    PriorityID = 6,
                    PriorityName = "Đối tượng 06",
                    PriorityDescription = "a) Công dân Việt Nam là người dân tộc thiểu số có nơi thường trú ở ngoài khu vực đã quy định thuộc đối tượng 01;\r\n\r\nb) Con thương binh, con bệnh binh, con của người được hưởng chính sách như thương binh bị suy giảm khả năng lao động dưới 81%;\r\n\r\nc) Con của người hoạt động kháng chiến bị nhiễm chất độc hóa học có tỷ lệ suy giảm khả năng lao động dưới 81%.",
                    TypeOfPriority = TypeOfPriority.UT2,

                }
                ,
                new PriorityDetail()
                {
                    PriorityID = 7,
                    PriorityName = "Đối tượng 07",
                    PriorityDescription = "a) Người khuyết tật nặng có giấy xác nhận khuyết tật của cơ quan có thẩm quyền cấp theo quy định tại Thông tư liên tịch số 37/2012/TTLT- BLĐTBXH-BYT-BTC-BGDĐT ngày 28 tháng 12 năm 2012 của Bộ Lao động - Thương binh và Xã hội, Bộ Y tế, Bộ Tài chính và Bộ GDĐT quy định về việc xác định mức độ khuyết tật do Hội đồng xác định mức độ khuyết tật thực hiện;\r\n\r\nb) Người lao động ưu tú thuộc tất cả thành phần kinh tế từ cấp tỉnh, cấp bộ trở lên được công nhận danh hiệu thợ giỏi, nghệ nhân, được cấp bằng hoặc huy hiệu Lao động sáng tạo của Tổng Liên đoàn Lao động Việt Nam hoặc Trung ương Đoàn TNCS Hồ Chí Minh;\r\n\r\nc) Giáo viên đã giảng dạy đủ 3 năm trở lên dự tuyển vào các ngành đào tạo giáo viên;\r\n\r\nd) Y tá, dược tá, hộ lý, y sĩ, điều dưỡng viên, hộ sinh viên, kỹ thuật viên, người có bằng trung cấp Dược đã công tác đủ 3 năm trở lên dự tuyển vào đúng ngành tốt nghiệp thuộc lĩnh vực sức khỏe.",
                    TypeOfPriority = TypeOfPriority.UT2,

                }
                );

        }
    }
}
