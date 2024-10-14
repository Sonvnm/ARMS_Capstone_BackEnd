using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BlogSer
{
    public interface IBlogService
    {
        Task<Blog> GetBlog(int BlogId);
        Task<List<BlogCategory>> GetBlogCategories(string CampusId);
        Task<List<Blog>> GetBlogs(string CampusId);
        Task AddNewBlog(Blog blog);
        Task UpdateBlog(Blog blog);
    }
}
