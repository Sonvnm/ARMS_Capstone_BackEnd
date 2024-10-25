using AutoMapper;
using Data.DTO;

namespace ARMS_API.ValidData
{
    public class ValidStudentConsultation
    {
        private UserInput _userInput;
        public ValidStudentConsultation(UserInput userInput)
        {
            _userInput = userInput;
        }
        public void InputStudentConsultation(StudentConsultationDTO studentConsultationDTO)
        {
            if (studentConsultationDTO == null)
            {
                throw new ArgumentNullException(nameof(studentConsultationDTO), "Không nhận được dữ liệu");
            }

            switch (true)
            {
                case bool _ when string.IsNullOrEmpty(studentConsultationDTO.FullName):
                    throw new ArgumentException("Không được để trống họ và tên", nameof(studentConsultationDTO.FullName));

                case bool _ when string.IsNullOrEmpty(studentConsultationDTO.Email):
                    throw new ArgumentException("Không được để trống email", nameof(studentConsultationDTO.Email));

                case bool _ when !_userInput.IsValidEmail(studentConsultationDTO.Email):
                    throw new FormatException("Email không hợp lệ!");

                case bool _ when string.IsNullOrEmpty(studentConsultationDTO.PhoneNumber):
                    throw new ArgumentException("Không được để trống số điện thoại", nameof(studentConsultationDTO.PhoneNumber));

                case bool _ when !_userInput.IsValidPhoneNumber(studentConsultationDTO.PhoneNumber):
                    throw new FormatException("Số điện thoại không hợp lệ!");

                case bool _ when studentConsultationDTO.MajorID == null:
                    throw new ArgumentException("Không được để trống ngành học", nameof(studentConsultationDTO.MajorID));

                case bool _ when string.IsNullOrEmpty(studentConsultationDTO.LinkFB):
                    throw new ArgumentException("Không được để trống link Facebook", nameof(studentConsultationDTO.LinkFB));

                default:
                    break;
            }
        }

        public void UpdateStudentConsultation(StudentConsultation_AO_DTO studentConsultationDTO)
        {
            try
            {
                if (studentConsultationDTO == null) throw new Exception("Không nhận được dữ liệu");
                if (string.IsNullOrEmpty(studentConsultationDTO.FullName)) throw new Exception("Không được để trống họ và tên");
                if (string.IsNullOrEmpty(studentConsultationDTO.Email)) throw new Exception("Không được để trống email");
                if (!_userInput.IsValidEmail(studentConsultationDTO.Email)) throw new Exception("Email không hợp lệ!");
                if (string.IsNullOrEmpty(studentConsultationDTO.PhoneNumber)) throw new Exception("Không được để trống số điện thoại");
                if (!_userInput.IsValidPhoneNumber(studentConsultationDTO.PhoneNumber)) throw new Exception("Số điện thoại không hợp lệ!");
                if (studentConsultationDTO.MajorID == null) throw new Exception("Không được để trống ngành học");
                if (string.IsNullOrEmpty(studentConsultationDTO.LinkFB)) throw new Exception("Không được để trống link facebook");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
