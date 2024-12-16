using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class StudentProfile
    {
        public Guid SpId { get; set; }
        public string? StudentCode { get; set; } // mã học sinh Mã cơ sở + mã ngành + mã khóa học + mã học sinh
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
        public int? YearOfGraduation { get; set; } // năm tốt nghiệp
        public string? SchoolName { get; set; } // tên trường
        public bool? RecipientResults { get; set; } // true học sinh nhận 
        public bool? PermanentAddress { get; set; } // true - địa chỉ thường trú
        public string? AddressRecipientResults { get; set; } // lưu địa chỉ nhận khác
        public string? ImgCitizenIdentification1 { get; set; }
        public string? ImgCitizenIdentification2 { get; set; }
        public string? ImgDiplomaMajor { get; set; } // ảnh bằng ngành 1
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
        public DateTime TimeRegister { get; set; }

        public string? Note { get; set; }
        public virtual TypeOfDiploma? TypeOfDiplomaMajor { get; set; }// loại bằng ngành 
        public virtual TypeOfTranscript? TypeOfTranscriptMajor { get; set; }// loại học bạ ngành 
        public int? PriorityDetailPriorityID { get; set; }
        public virtual PriorityDetail? PriorityDetail { get; set; }// loại điểm ưu tiên
        public virtual TypeofStatusForMajor? TypeofStatusMajor { get; set; } // trạng thái xét tuyển ngành 
        public virtual TypeofStatus? TypeofStatusProfile { get; set; } // trạng thái hồ sơ
        // hồ sơ nhập học
        public string? AdmissionForm { get; set; }
        public string? BirthCertificate { get; set; }
        // đợt tuyển sinh
        public int AdmissionTimeId { get; set; }
        public virtual AdmissionTime? AdmissionTime { get; set; }
        // account
        public Guid? AccountId { get; set; }
        public virtual Account? Account { get; set; }
        public virtual Campus? Campus { get; set; }
        public virtual ICollection<AcademicTranscript>? AcademicTranscripts { get; set; }
        public virtual ICollection<PayFeeAdmission>? PayFeeAdmissions { get; set; }
        // ngành đăng ký
        public virtual Major? MajorNV { get; set; }//  ngành 1
    }
}