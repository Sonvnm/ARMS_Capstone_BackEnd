using Data.DTO;
using Service.MajorSer;
using Service.StudentProfileServ;

namespace ARMS_API.ValidData
{
    public class ValidMajor
    {
        private UserInput _userInput;

        private IMajorService _majorService;
        public ValidMajor(UserInput userInput, IMajorService majorService)
        {
            _userInput = userInput;
            _majorService = majorService;
        }

        internal void InputMajor(Major_Manage_DTO majorDTO)
        {
            try
            {
                if (majorDTO == null) throw new Exception("Không nhận được dữ liệu!");
                if (string.IsNullOrEmpty(majorDTO.MajorName)) throw new Exception("Không được để trống tên ngành học!");
                if (string.IsNullOrEmpty(majorDTO.Description)) throw new Exception("Không được để trống mô tả ngành học!");
                if (string.IsNullOrEmpty(majorDTO.TimeStudy)) throw new Exception("Không được để trống thời gian học!");
                if (majorDTO.isVocationalSchool == null) throw new Exception("Không được để trống hệ đào tạo!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
