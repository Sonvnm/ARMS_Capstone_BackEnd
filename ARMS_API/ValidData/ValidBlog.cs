using Data.DTO;
using Data.Models;
using Service.StudentProfileServ;

namespace ARMS_API.ValidData
{
    public class ValidBlog
    {
        private UserInput _userInput;

        private IStudentProfileService _studentProfileService;
        public ValidBlog(UserInput userInput, IStudentProfileService studentProfileService)
        {
            _userInput = userInput;
            _studentProfileService = studentProfileService;
        }

        internal void InputBlog(Blog_SS_DTO blogDTO)
        {
            try
            {
                if (blogDTO == null) throw new Exception("Không nhận được dữ liệu!");
                if (string.IsNullOrEmpty(blogDTO.Content)) throw new Exception("Không được để trống nội dung bài viết!");
                if (string.IsNullOrEmpty(blogDTO.Title)) throw new Exception("Không được để trống tiêu đề bài viết!");
                if (string.IsNullOrEmpty(blogDTO.Description)) throw new Exception("Không được để trống mô tả bài viết!");
                if (blogDTO.BlogCategoryId == 0) throw new Exception("Vui lòng chọn loại bài viết!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
