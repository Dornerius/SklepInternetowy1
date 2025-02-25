using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SklepData.Data;

namespace SklepPortalWWW.Controllers
{
    public class NewsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SklepContext _context;

        public NewsController(ILogger<HomeController> logger, SklepContext context)
        {
            _logger = logger;
            _context = context;
        }
        public async Task<IActionResult> Index (int? id)
        {
            ViewBag.ModelPage =
                (
                from page in _context.Page
                orderby page.Position
                select page
                ).ToList();
            ViewBag.ModelNews =
                (
                from news in _context.News
                orderby news.Position
                select news
                ).ToList();
          
            var item = await _context.News.FirstOrDefaultAsync(a => a.IdNews == id);

            return View(item);
        }
    }
}
