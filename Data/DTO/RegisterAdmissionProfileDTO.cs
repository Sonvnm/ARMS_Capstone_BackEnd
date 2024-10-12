using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class RegisterAdmissionProfileDTO
    {
        public class AdmissionProfileDTO
        {
            public string? CitizenIentificationNumber { get; set; }
            public string? AdmissionForm { get; set; }
            public string? BirthCertificate { get; set; }
            public virtual PayFeeAdmissionDTO? PayFeeAdmission { get; set; }
        }
        public class PayFeeAdmissionDTO
        {
            public Guid SpId { get; set; }
            public string TxnRef { get; set; }
            public decimal Amount { get; set; }
            public string BankCode { get; set; }
            public string BankTranNo { get; set; }
            public string CardType { get; set; }
            public string OrderInfo { get; set; }
            public DateTime PayDate { get; set; }
            public string ResponseCode { get; set; }
            public string TmnCode { get; set; }
            public string TransactionNo { get; set; }
            public string TransactionStatus { get; set; }
            public string SecureHash { get; set; }
            public bool isFeeRegister { get; set; }
            public bool? Success { get; set; }
        }
        public class AdmissionProfile_AO_DTO
        {
            public Guid SpId { get; set; }
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
            public string? Major1 { get; set; }
            public string MajorName1 { get; set; }
            public int? YearOfGraduation { get; set; }
            public string? SchoolName { get; set; }
            public bool? RecipientResults { get; set; } // true học sinh nhận kết quả
            public bool? PermanentAddress { get; set; } // true - địa chỉ thường trú
            public string? AddressRecipientResults { get; set; } // lưu địa chỉ nhận khác
            public string? ImgCitizenIdentification1 { get; set; }
            public string? ImgCitizenIdentification2 { get; set; }
            public string? ImgDiplomaMajor1 { get; set; } // ảnh bằng ngành 1
            public string? Imgpriority { get; set; } // ảnh bằng chứng xác nhận ưu tiên
            public string? ImgAcademicTranscript1 { get; set; }//kỳ 1 - lớp 10
            public string? ImgAcademicTranscript2 { get; set; }//kỳ 2 - lớp 10
            public string? ImgAcademicTranscript3 { get; set; }//cuối năm - lớp 10
            public string? ImgAcademicTranscript4 { get; set; }//kỳ 1 - lớp 11
            public string? ImgAcademicTranscript5 { get; set; }//kỳ 2 - lớp 11
            public string? ImgAcademicTranscript6 { get; set; }//Cuối năm - lớp 11
            public string? ImgAcademicTranscript7 { get; set; }//kỳ 1 - lớp 12
            public string? ImgAcademicTranscript8 { get; set; }//kỳ 2 - lớp 12
            public string? ImgAcademicTranscript9 { get; set; }//cuối năm - lớp 12
            public virtual TypeOfDiploma? TypeOfDiplomaMajor1 { get; set; }// loại bằng ngành 1
            public virtual TypeOfTranscript? TypeOfTranscriptMajor1 { get; set; }// loại học bạ ngành 1
            public int? PriorityDetailPriorityID { get; set; }
            public virtual ICollection<AcademicTranscript_View_DTO>? AcademicTranscriptsMajor1 { get; set; }
            public virtual TypeofStatusForMajor? TypeofStatusMajor1 { get; set; } // trạng thái xét tuyển ngành 1
            public virtual TypeofStatus? TypeofStatusProfile { get; set; } // trạng thái hồ sơ
            public string? Note { get; set; }
            public string? AdmissionForm { get; set; }
            public string? BirthCertificate { get; set; }
            public int AIId { get; set; }

            // view
            public string? CampusName { get; set; }
            public virtual PriorityDetailDTO? PriorityDetail { get; set; }// loại điểm ưu tiên
            public DateTime TimeRegister { get; set; }
            public virtual ICollection<AcademicTranscriptDTO>? AcademicTranscripts { get; set; }
            public virtual ICollection<PayFeeAdmissionDTO>? PayFeeAdmissions { get; set; }

        }
    }
}
