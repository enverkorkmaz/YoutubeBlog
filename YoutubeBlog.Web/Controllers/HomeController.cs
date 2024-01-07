using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using YoutubeBlog.Service.Services.Abstractions;
using YoutubeBlog.Service.Services.Concrete;
using YoutubeBlog.Web.Models;

namespace YoutubeBlog.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArticleService articleService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,IArticleService articleService)
        {
            this.articleService = articleService;
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> Index(Guid? categoryId,int currentPage = 1,int pageSize = 3,bool isAscending = false)
        {
            var articles = await articleService.GetAllByPagingAsync(categoryId, currentPage, pageSize, isAscending);
            return View(articles);
        }
        [HttpGet]
        public async Task<IActionResult> Search(string keyword, int currentPage = 1, int pageSize = 3, bool isAscending = false)
        {
            var articles = await articleService.SearchAsync(keyword, currentPage, pageSize, isAscending);
            return View(articles);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}