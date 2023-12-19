using HoangTrungNguyenn_211243705.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Drawing.Printing;

namespace HoangTrungNguyenn_211243705.Controllers
{
    public class HomeController : Controller
    {
        NewShopContext db = new NewShopContext();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            //List<Product> lpdb = db.Products
            //                    .OrderByDescending(h => h.ProviderId).Take(6).ToList();
            //return View(lpdb);
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
