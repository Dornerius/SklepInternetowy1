using Microsoft.AspNetCore.Mvc;
using SklepData.Data;
using SklepPortalWWW.Models;
using System.Diagnostics;
using System.Linq;

namespace SklepPortalWWW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SklepContext _context;

        public HomeController(ILogger<HomeController> logger, SklepContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index(int? id)
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

            if (id == null)
                id = _context.Page.First().IdPage;
            var item = _context.Page.Find(id);

            return View(item);
        }


        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
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
