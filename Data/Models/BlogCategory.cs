using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class BlogCategory
    {
        public int BlogCategoryId { get; set; }
        public string BlogCategoryName { get; set; }
        public string CampusId { get; set; }
        public virtual Campus Campus { get; set; }
        public virtual ICollection<Blog>? Blogs { get; set; }
    }
}
