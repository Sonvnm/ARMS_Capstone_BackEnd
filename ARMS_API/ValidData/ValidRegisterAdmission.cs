using Data.DTO;
using Repository.StudentProfileRepo;
using Service.StudentProfileServ;

namespace ARMS_API.ValidData
{
    public class ValidRegisterAdmission
    {
        private UserInput _userInput;

        private IStudentProfileService _studentProfileService;
        public ValidRegisterAdmission(UserInput userInput, IStudentProfileService studentProfileService)
        {
            _userInput = userInput;
            _studentProfileService = studentProfileService;
        }

        public async void InputAddRegisterAdmission(RegisterAdmissionProfileDTO registerAdmissionProfileDTO)
        {
            if (registerAdmissionProfileDTO == null) throw new Exception("Không nhận được dữ liệu!");
            // fullname
            if (string.IsNullOrEmpty(registerAdmissionProfileDTO.Fullname)) throw new Exception("Không được để trống họ và tên!");
            //dob student
            if (registerAdmissionProfileDTO.Dob == null) throw new Exception("Không được để trống ngày sinh!");
            if (!_userInput.IsValidDateOfBirth(registerAdmissionProfileDTO.Dob)) throw new Exception("Ngày sinh không được lớn hơn ngày hiện tại!");
            //email student
            if (string.IsNullOrEmpty(registerAdmissionProfileDTO.EmailStudent)) throw new Exception("Không được để trống email của học sinh!");
            if (!_userInput.IsValidEmail(registerAdmissionProfileDTO.EmailStudent)) throw new Exception("Email học sinh không hợp lệ!");
            //if (await _studentProfileService.isExistEmailStudent(registerAdmissionProfileDTO.EmailStudent)) throw new Exception("Email đã được đăng ký!");
            // phone number
            if (string.IsNullOrEmpty(registerAdmissionProfileDTO.PhoneStudent)) throw new Exception("Không được để trống số điện thoại của học sinh!");
            if (!_userInput.IsValidPhoneNumber(registerAdmissionProfileDTO.PhoneStudent)) throw new Exception("Số điện thoại học sinh không hợp lệ!");
            //if (await _studentProfileService.isExistEmailStudent(registerAdmissionProfileDTO.PhoneStudent)) throw new Exception("Số điện thoại đã được đăng ký!");
            // CID
            if (registerAdmissionProfileDTO.CitizenIentificationNumber == null) throw new Exception("Không được để trống số căn cước công dân!");
            if (!_userInput.IsValidCCCD(registerAdmissionProfileDTO.CitizenIentificationNumber)) throw new Exception("Định dạng số căn cước công dân không đúng!");
            //if (await _studentProfileService.isExistEmailStudent(registerAdmissionProfileDTO.CitizenIentificationNumber)) throw new Exception("Số căn cước công dân đã được đăng ký!");
            //CI address
            if (string.IsNullOrEmpty(registerAdmissionProfileDTO.CIAddress)) throw new Exception("Nơi cấp căn cước không được để trống!");
            // CI date
            if (registerAdmissionProfileDTO.CIDate == null) throw new Exception("Ngày cấp căn cước không được để trống!");
            if (!_userInput.IsValidCIDate(registerAdmissionProfileDTO.CIDate)) throw new Exception("Ngày cấp căn cước không hợp lệ!");
            // Province
            if (string.IsNullOrEmpty(registerAdmissionProfileDTO.Province)) throw new Exception("Tỉnh thành không được để trống!");
            // District
            if (string.IsNullOrEmpty(registerAdmissionProfileDTO.District)) throw new Exception("Huyện không được để trống!");
            // Ward
            if (string.IsNullOrEmpty(registerAdmissionProfileDTO.Ward)) throw new Exception("Xã không được để trống!");
            // fullname parents
            if (string.IsNullOrEmpty(registerAdmissionProfileDTO.FullnameParents)) throw new Exception("Không được để trống họ và tên phụ huynh!");
            // phone number parents
            if (string.IsNullOrEmpty(registerAdmissionProfileDTO.PhoneParents)) throw new Exception("Không được để trống số điện thoại phụ huynh!");
            // campus
            if (string.IsNullOrEmpty(registerAdmissionProfileDTO.CampusId)) throw new Exception("Vui lòng chọn campus!");
            // major
            if (string.IsNullOrEmpty(registerAdmissionProfileDTO.Major)) throw new Exception("Vui lòng chọn ngành học!");
            // YearOfGraduation
            if (registerAdmissionProfileDTO.YearOfGraduation == null) throw new Exception("Vui lòng nhập năm tốt nghiệp!");
            // SchoolName
            if (registerAdmissionProfileDTO.SchoolName == null) throw new Exception("Vui lòng nhập tên trường học!");
            // RecipientResults
            if (registerAdmissionProfileDTO.RecipientResults == null) throw new Exception("Vui lòng chọn người nhận kết quả!");
            // 
            if (registerAdmissionProfileDTO.PermanentAddress == null && string.IsNullOrEmpty(registerAdmissionProfileDTO.AddressRecipientResults)) throw new Exception("Vui lòng chọn địa chỉ nhận kết quả!");
            // ImgCitizenIdentification1
            if (string.IsNullOrEmpty(registerAdmissionProfileDTO.ImgCitizenIdentification1)) throw new Exception("Vui lòng chọn ảnh căn cước mặt trước!");
            // ImgCitizenIdentification2
            if (string.IsNullOrEmpty(registerAdmissionProfileDTO.ImgCitizenIdentification2)) throw new Exception("Vui lòng chọn ảnh căn cước mặt sau!");
        }
    }
}
