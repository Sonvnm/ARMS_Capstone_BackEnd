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
        private readonly IBlogService _blogService;
        private readonly UserInput _userInput;
        private IMapper _mapper;

        public BlogController(
            IBlogService blogService, IMapper mapper,
            UserInput userInput)
        {
            _blogService = blogService;
            _mapper = mapper;
            _userInput = userInput;
        }

        [HttpGet("get-blogcategories")]
        public async Task<IActionResult> GetBlogCategories(
            string CampusId)
        {
            try
            {
                var response = await _blogService.GetBlogCategories(CampusId);
                var responeResult = _mapper.Map<List<BlogCategoryDTO>>(response);
                return Ok(responeResult);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi! Vui lòng thử lại sau!",
                });
            }
        }

        [HttpGet("get-blogs")]
        public async Task<IActionResult> GetBlogs(
            string? CampusId, string? Search,
            int CurrentPage, int? CategoryID)
        {
            try
            {
                ResponeModel<BlogDTO> result = new ResponeModel<BlogDTO>
                {
                    CurrentPage = CurrentPage,
                    CampusId = CampusId,
                    Search = Search
                };

                var response = await _blogService.GetBlogs(CampusId);
                if (!string.IsNullOrEmpty(Search))
                {
                    var searchTerm = _userInput.NormalizeText(Search);
                    response = response
                        .Where(blog =>
                        {
                            var title = _userInput.NormalizeText(blog?.Title ?? "");
                            var description = _userInput.NormalizeText(blog?.Description ?? "");
                            return title.Contains(searchTerm) || description.Contains(searchTerm);
                        })
                        .ToList();
                }

                if (CategoryID != null && CategoryID != 0)
                    response = response
                        .Where(blog => blog.BlogCategoryId == CategoryID)
                        .ToList();

                result.PageCount = (int)Math.Ceiling((double)response.Count() / result.PageSize);
                var blogs = response.Skip((int)((CurrentPage - 1) * result.PageSize)).Take((int)result.PageSize).ToList();

                var responseResult = _mapper.Map<List<BlogDTO>>(blogs);
                result.Item = responseResult;
                result.TotalItems = response.Count;
                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi! Vui lòng thử lại sau!",
                });
            }
        }

        [HttpGet("get-blog")]
        public async Task<IActionResult> GetBlog(
            int BlogId)
        {
            try
            {
                if (BlogId == 0) return NotFound();
                var response = await _blogService.GetBlog(BlogId);
                if (response == null) return NotFound();
                var responeResult = _mapper.Map<BlogDTO>(response);
                return Ok(responeResult);
            }
            catch (Exception)
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi! Vui lòng thử lại sau!",
                });
            }
        }

        [HttpGet("get-top5blogs")]
        public async Task<IActionResult> GetBlogs(
            string? CampusId, int BlogCategoryId)
        {
            try
            {
                var response = await _blogService.GetBlogs(CampusId);
                var filteredResponse = response
                    .Where(x => x.BlogCategoryId == BlogCategoryId)
                    .Take(5)
                    .ToList();

                var responseResult = _mapper.Map<List<BlogDTO>>(filteredResponse);
                return Ok(responseResult);
            }
            catch (Exception)
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi! Vui lòng thử lại sau!",
                });
            }
        }
    }
}
