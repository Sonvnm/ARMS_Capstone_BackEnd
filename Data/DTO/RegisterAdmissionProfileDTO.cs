using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class RegisterAdmissionProfileDTO
    {
        public string Fullname { get; set; }
        public DateTime? Dob { get; set; }
        public bool? Gender { get; set; }
        public string? Nation { get; set; } // dân tộc
        public string? CitizenIentificationNumber { get; set; } // căn cước công dân
        public DateTime? CIDate { get; set; } // ngày cấp
        public string? CIAddress { get; set; } // nơi cấp
        public string? Province { get; set; } // tỉnh
        public string? District { get; set; } // huyện
        public string? Ward { get; set; } // xã 
        public string? SpecificAddress { get; set; } // địa chỉ nhà
        public string EmailStudent { get; set; } // duy nhất
        public string PhoneStudent { get; set; } // duy nhất
        public string? FullnameParents { get; set; }
        public string? PhoneParents { get; set; }
        public string CampusId { get; set; }
        public string? Major { get; set; }
        public int? YearOfGraduation { get; set; }
        public string? SchoolName { get; set; }
        public bool? RecipientResults { get; set; } // true học sinh nhận kết quả
        public bool? PermanentAddress { get; set; } // true - địa chỉ thường trú
        public string? AddressRecipientResults { get; set; } // lưu địa chỉ nhận khác
        public string? ImgCitizenIdentification1 { get; set; }
        public string? ImgCitizenIdentification2 { get; set; }
        public string? ImgDiploma { get; set; } // ảnh bằng
        public string? ImgAcademicTranscript1 { get; set; } // kỳ 1_10 | lop10  | lop12 | Kỳ 1_11 | Lop10  |
        public string? ImgAcademicTranscript2 { get; set; } // kỳ 2_10 | lop11  |       | Kỳ 2_11 | Lop11  |
        public string? ImgAcademicTranscript3 { get; set; } // kỳ 1_11 | lop12  |       | Kỳ 1_12 | HK1 12 |
        public string? ImgAcademicTranscript4 { get; set; } // kỳ 2_11 |        |       |         |        |
        public string? ImgAcademicTranscript5 { get; set; } // kỳ 1_12 |        |       |         |        |
        public bool? PayFee { get; set; } // trạng thái thanh toán
        public virtual TypeOfDiploma TypeOfDiploma { get; set; }// loại bằng
        public virtual TypeOfTranscript? TypeOfTranscript { get; set; }// loại học bạ
    }
}
