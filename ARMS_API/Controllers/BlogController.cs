using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.BlogSer;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ARMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private IBlogService _blogService;
        private UserInput _userInput;
        private readonly IMapper _mapper;
        public BlogController(IBlogService blogService, IMapper mapper, UserInput userInput)
        {
            _blogService = blogService;
            _userInput = userInput;
            _mapper = mapper;
        }
        [HttpGet("get-blogcategories")]
        public async Task<IActionResult> GetBlogCategories(string CampusId)
        {
            try
            {
                List<BlogCategory> response = await _blogService.GetBlogCategories(CampusId);
                List<BlogCategoryDTO> responeResult = _mapper.Map<List<BlogCategoryDTO>>(response);
                return Ok(responeResult);
            }
            catch (Exception)
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi! Vui lòng thử lại sau!"
                });
            }
        }
        [HttpGet("get-blogs")]
        public async Task<IActionResult> GetBlogs(string? CampusId, string? Search, int CurrentPage, int? CategoryID)
        {
            try
            {
                //respone data
                ResponeModel<BlogDTO> result = new ResponeModel<BlogDTO>();
                result.CurrentPage = CurrentPage;
                result.CampusId = CampusId;
                result.Search = Search;

                List<Blog> response = await _blogService.GetBlogs(CampusId);

                // Search
                if (!string.IsNullOrEmpty(Search))
                {
                    string searchTerm = _userInput.NormalizeText(Search);
                    response = response
                                .Where(blog =>
                                {
                                    string title = _userInput.NormalizeText(blog?.Title ?? "");
                                    string description = _userInput.NormalizeText(blog?.Description ?? "");
                                    return title.Contains(searchTerm) || description.Contains(searchTerm);
                                })
                                .ToList();
                }

                if (CategoryID != 0 && CategoryID!=null)
                {
                    response = response
                                .Where(blog =>blog.BlogCategoryId == CategoryID)
                                .ToList();
                };

                // Paging
                result.PageCount = (int)Math.Ceiling(response.Count() / (double)result.PageSize);
                var blogs = response
                    .Skip(((int)result.CurrentPage - 1) * (int)result.PageSize)
                    .Take((int)result.PageSize)
                    .ToList();

                // Map to BlogDTO
                List<BlogDTO> responseResult = _mapper.Map<List<BlogDTO>>(blogs);
                result.Item = responseResult;
                result.TotalItems = response.Count;
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi! Vui lòng thử lại sau!"
                });
            }
        }
        [HttpGet("get-blog")]
        public async Task<IActionResult> GetBlog(int BlogId)
        {
            try
            {
                Blog response = await _blogService.GetBlog(BlogId);
                if (response == null || BlogId == 0) return NotFound();
                BlogDTO responeResult = _mapper.Map<BlogDTO>(response);
                return Ok(responeResult);
            }
            catch (Exception)
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi! Vui lòng thử lại sau!"
                });
            }
        }
        [HttpGet("get-top5blogs")]
        public async Task<IActionResult> GetBlogs(string? CampusId, int BlogCategoryId)
        {
            try
            {

                List<Blog> response = await _blogService.GetBlogs(CampusId);
                response = response
                    .Where(x => x.BlogCategoryId == BlogCategoryId)
                    .Take(5)
                    .ToList();
                // Map to BlogDTO
                List<BlogDTO> responseResult = _mapper.Map<List<BlogDTO>>(response);
                return Ok(responseResult);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi! Vui lòng thử lại sau!"
                });
            }
        }
    }
}
