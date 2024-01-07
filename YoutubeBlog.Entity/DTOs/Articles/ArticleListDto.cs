using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Entity.DTOs.Articles
{
    public class ArticleListDto
    {
        public IList<Article> Articles { get; set; }
        public Guid? CategoryId { get; set; }
        public virtual int CurrentPage { get; set; } = 1;
        public virtual int PageSize { get; set; } = 3;
        public virtual int TotalCount { get; set; }
        public virtual int TotalPage => (int)Math.Ceiling(decimal.Divide(TotalCount, PageSize));
        public virtual bool ShowPrevious =>CurrentPage > 1; 
        public virtual bool ShowNext =>CurrentPage < TotalPage; 
        public virtual bool isAscending { get; set; } = false;


    }
}
