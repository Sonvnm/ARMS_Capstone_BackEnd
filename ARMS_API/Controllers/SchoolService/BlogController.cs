using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.BlogSer;

namespace ARMS_API.Controllers.SchoolService
{
    [Route("api/school-service/[controller]")]
    [ApiController]
   // [Authorize(Roles = "SchoolService")]
    public class BlogController : ControllerBase
    {
        private IBlogService _blogService;
        private ValidBlog _validBlog;
        private readonly IMapper _mapper;
        public BlogController(IBlogService blogService, IMapper mapper, ValidBlog validBlog)
        {
            _blogService = blogService;
            _validBlog = validBlog;
            _mapper = mapper;
        }
        [HttpPost("add-blog")]
        public async Task<IActionResult> AddBlog([FromBody] Blog_SS_DTO BlogDTO)
        {
            try
            {
                //check data
                _validBlog.InputBlog(BlogDTO);
                //mapper
                Blog blog = _mapper.Map<Blog>(BlogDTO);
                //add new
                await _blogService.AddNewBlog(blog);
                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Tạo mới mới thành công!"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseViewModel()
                {
                    Status = false,
                    Message = ex.Message
                });
            }
        }
        [HttpPut("update-blog")]
        public async Task<IActionResult> UpdateBlog(Blog_SS_DTO BlogDTO)
        {
            try
            {
                //check data
                _validBlog.InputBlog(BlogDTO);
                //mapper
                Blog blog = _mapper.Map<Blog>(BlogDTO);
                await _blogService.UpdateBlog(blog);
                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Cập nhật thành công!"
                });

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
