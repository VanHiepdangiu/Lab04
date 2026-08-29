// ============================================================
// Lab 04 - Controller nang cao: Account/Profile + Route
// Sinh vien: Nguyen Van Hiep - MSSV: 2410900035 - Lop: K24CNT1
// Hoc phan: Phat trien ung dung voi cong nghe .NET
// ============================================================
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using lab04.Models;

namespace lab04.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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
