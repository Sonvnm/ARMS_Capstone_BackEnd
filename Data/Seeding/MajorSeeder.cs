using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class MajorSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public MajorSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            // seed Major
            modelBuilder.Entity<Major>().HasData(
                new Major()
                {
                    MajorID = "HME",
                    MajorName = "Lập trình mobile",
                    MajorCode = "7480201",
                    Description = "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.",
                    TimeStudy = "2 năm",
                    Target = 200,
                    CampusId = "Hanoi",
                    Status =true,
                    isVocationalSchool = false,
                    Tuition = 12000000m,
                },
                new Major()
                {
                    MajorID = "HGE",
                    MajorName = "Lập trình game",
                    MajorCode = "7480201",
                    Description = "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.",
                    TimeStudy = "2 năm",
                    Target = 200,
                    CampusId = "Hanoi",
                    Status = true,
                    isVocationalSchool = false,
                    Tuition = 12000000m,
                },
                new Major()
                {
                    MajorID = "HWE",
                    MajorName = "Lập trình web",
                    MajorCode = "7480201",
                    Description = "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.",
                    TimeStudy = "2 năm",
                    Target = 200,
                    CampusId = "Hanoi",
                    Status = true,
                    isVocationalSchool = false,
                    Tuition = 12000000m,
                },
                new Major()
                {
                    MajorID = "HTE",
                    MajorName = "Kiểm thử",
                    MajorCode = "7480201",
                    Description = "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.",
                    TimeStudy = "2 năm",
                    Target = 200,
                    CampusId = "Hanoi",
                    Status = true,
                    isVocationalSchool = false,
                    Tuition = 12000000m,
                },

                new Major()
                {
                    MajorID = "HEA",
                    MajorName = "Ngôn ngữ anh",
                    MajorCode = "7220201",
                    Description = "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.",
                    TimeStudy = "2 năm",
                    Target = 200,
                    CampusId = "Hanoi",
                    Status = true,
                    isVocationalSchool = false,
                    Tuition = 12000000m,
                },
                new Major() {
                    MajorID = "HJA",
                    MajorName = "Ngôn ngữ nhật",
                    MajorCode = "7220209",
                    Description = "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.",
                    TimeStudy = "2 năm",
                    Target = 200,
                    CampusId = "Hanoi",
                    Status = true,
                    isVocationalSchool = false,
                    Tuition = 12000000m,
                },
                new Major() {
                    MajorID = "HKA",
                    MajorName = "Ngôn ngữ hàn",
                    MajorCode = "7220210",
                    TimeStudy = "24 năm",
                    Target = 200,
                    CampusId = "Hanoi",
                    Status = true,
                    Description = "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.",
                    isVocationalSchool = false,
                    Tuition = 12000000m,
                },

                new Major() {
                    MajorID = "HSM",
                    MajorName = "Marketing",
                    MajorCode = "7340101", 
                    TimeStudy = "2 năm",
                    Target = 200,
                    CampusId = "Hanoi",
                    Status = true,
                    Description = "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.",
                    isVocationalSchool = false,
                    Tuition = 12000000m,
                },
                new Major() {
                    MajorID = "HHM",
                    MajorName = "Quản trị khách sạn",
                    MajorCode = "7340101",
                    TimeStudy = "24 năm",
                    Target = 200,
                    CampusId = "Hanoi",
                    Status = true,
                    Description = "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.",
                    isVocationalSchool = false,
                    Tuition = 12000000m,
                },
                new Major() {
                    MajorID = "HRM",
                    MajorName = "Quản trị nhà hàng",
                    MajorCode = "7340101",
                    TimeStudy = "24 năm",
                    Target = 200,
                    CampusId = "Hanoi",
                    Status = true,
                    Description = "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.",
                    isVocationalSchool = false,
                    Tuition = 12000000m,
                },

                new Major() {
                    MajorID = "HBT",
                    MajorName = "Phum xăm thẩm mỹ",
                    MajorCode = "71490", 
                    TimeStudy = "2 năm",
                    Target = 200,
                    CampusId = "Hanoi",
                    Status = true,
                    Description = "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.",
                    isVocationalSchool = true,
                    Tuition = 12000000m,
                },
                new Major() {
                    MajorID = "HBS",
                    MajorName = "Chăm sóc da và massage", 
                    MajorCode = "71490", 
                    TimeStudy = "2 năm" ,
                    Target = 200,
                    CampusId = "Hanoi",
                    Status = true,
                    Description = "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.",
                    isVocationalSchool = true,
                    Tuition = 12000000m,
                },

                new Major() {
                    MajorID = "HAO",
                    MajorName = "Kiểm toán", 
                    MajorCode = "71490",
                    TimeStudy = "2 năm",
                    Target = 200,
                    CampusId = "Hanoi",
                    Status = true,
                    Description = "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.",
                    isVocationalSchool = false,
                    Tuition = 12000000m,
                },
                new Major() {
                    MajorID = "HSO",
                    MajorName = "Thư ký văn phòng",
                    MajorCode = "71490",
                    TimeStudy = "24 năm",
                    Target = 200,
                    CampusId = "Hanoi",
                    Status = true,
                    Description = "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.",
                    isVocationalSchool = false,
                    Tuition = 12000000m,
                },
                new Major() {
                    MajorID = "HFO",
                    MajorName = "Kỹ thuật chế biến món ăn", 
                    MajorCode = "71490", 
                    TimeStudy = "2 năm",
                    Target = 200,
                    CampusId = "Hanoi",
                    Status = true,
                    Description = "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.",
                    isVocationalSchool = true,
                    Tuition = 12000000m,
                }
                // HCM


                , new Major()
                {
                    MajorID = "SME",
                    MajorName = "Lập trình mobile",
                    MajorCode = "7480201",
                    Description = "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.",
                    TimeStudy = "2 năm",
                    Target = 200,
                    CampusId = "HCM",
                    Status = true,
                    isVocationalSchool = false,
                    Tuition = 12000000m,
                },
                new Major()
                {
                    MajorID = "SGE",
                    MajorName = "Lập trình game",
                    MajorCode = "7480201",
                    Description = "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.",
                    TimeStudy = "2 năm",
                    Target = 200,
                    CampusId = "HCM",
                    Status = true,
                    isVocationalSchool = false,
                    Tuition = 12000000m,
                },
                new Major()
                {
                    MajorID = "SWE",
                    MajorName = "Lập trình web",
                    MajorCode = "7480201",
                    Description = "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.",
                    TimeStudy = "2 năm",
                    Target = 200,
                    CampusId = "HCM",
                    Status = true,
                    isVocationalSchool = false,
                    Tuition = 12000000m,
                },
                new Major()
                {
                    MajorID = "STE",
                    MajorName = "Kiểm thử",
                    MajorCode = "7480201",
                    Description = "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.",
                    TimeStudy = "2 năm",
                    Target = 200,
                    CampusId = "HCM",
                    Status = true,
                    isVocationalSchool = false,
                    Tuition = 12000000m,
                },

                new Major()
                {
                    MajorID = "SEA",
                    MajorName = "Ngôn ngữ anh",
                    MajorCode = "7220201",
                    Description = "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.",
                    TimeStudy = "2 năm",
                    Target = 200,
                    CampusId = "HCM",
                    Status = true,
                    isVocationalSchool = false,
                    Tuition = 12000000m,
                },
                new Major()
                {
                    MajorID = "SJA",
                    MajorName = "Ngôn ngữ nhật",
                    MajorCode = "7220209",
                    Description = "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.",
                    TimeStudy = "2 năm",
                    Target = 200,
                    CampusId = "HCM",
                    Status = true,
                    isVocationalSchool = false,
                    Tuition = 12000000m,
                },
                new Major()
                {
                    MajorID = "SKA",
                    MajorName = "Ngôn ngữ hàn",
                    MajorCode = "7220210",
                    TimeStudy = "24 năm",
                    Target = 200,
                    CampusId = "HCM",
                    Status = true,
                    Description = "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.",
                    isVocationalSchool = false,
                    Tuition = 12000000m,
                },

                new Major()
                {
                    MajorID = "SSM",
                    MajorName = "Marketing",
                    MajorCode = "7340101",
                    TimeStudy = "2 năm",
                    Target = 200,
                    CampusId = "HCM",
                    Status = true,
                    Description = "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.",
                    isVocationalSchool = false,
                    Tuition = 12000000m,
                },
                new Major()
                {
                    MajorID = "SHM",
                    MajorName = "Quản trị khách sạn",
                    MajorCode = "7340101",
                    TimeStudy = "24 năm",
                    Target = 200,
                    CampusId = "HCM",
                    Status = true,
                    Description = "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.",
                    isVocationalSchool = false,
                    Tuition = 12000000m,
                },
                new Major()
                {
                    MajorID = "SRM",
                    MajorName = "Quản trị nhà hàng",
                    MajorCode = "7340101",
                    TimeStudy = "24 năm",
                    Target = 200,
                    CampusId = "HCM",
                    Status = true,
                    Description = "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.",
                    isVocationalSchool = false,
                    Tuition = 12000000m,
                },

                new Major()
                {
                    MajorID = "SBT",
                    MajorName = "Phum xăm thẩm mỹ",
                    MajorCode = "71490",
                    TimeStudy = "2 năm",
                    Target = 200,
                    CampusId = "HCM",
                    Status = true,
                    Description = "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.",
                    isVocationalSchool = true,
                    Tuition = 12000000m,
                },
                new Major()
                {
                    MajorID = "SBS",
                    MajorName = "Chăm sóc da và massage",
                    MajorCode = "71490",
                    TimeStudy = "2 năm",
                    Target = 200,
                    CampusId = "HCM",
                    Status = true,
                    Description = "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.",
                    isVocationalSchool = true,
                    Tuition = 12000000m,
                },

                new Major()
                {
                    MajorID = "SAO",
                    MajorName = "Kiểm toán",
                    MajorCode = "71490",
                    TimeStudy = "2 năm",
                    Target = 200,
                    CampusId = "HCM",
                    Status = true,
                    Description = "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.",
                    isVocationalSchool = false,
                    Tuition = 12000000m,
                },
                new Major()
                {
                    MajorID = "SSO",
                    MajorName = "Thư ký văn phòng",
                    MajorCode = "71490",
                    TimeStudy = "24 năm",
                    Target = 200,
                    CampusId = "HCM",
                    Status = true,
                    Description = "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.",
                    isVocationalSchool = false,
                    Tuition = 12000000m,
                },
                new Major()
                {
                    MajorID = "SFO",
                    MajorName = "Kỹ thuật chế biến món ăn",
                    MajorCode = "71490",
                    TimeStudy = "2 năm",
                    Target = 200,
                    CampusId = "HCM",
                    Status = true,
                    Description = "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.",
                    isVocationalSchool = true,
                    Tuition = 12000000m,
                }
                );
        }
    }
}
