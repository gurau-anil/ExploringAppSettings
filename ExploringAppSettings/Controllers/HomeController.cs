using ExploringAppSettings.Models;
using ExploringAppSettings.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace ExploringAppSettings.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOptions<PrintSetting> _printSetting;

        public HomeController(ILogger<HomeController> logger, IOptions<PrintSetting> printSetting)
        {
            _logger = logger;
            _printSetting = printSetting;
        }

        public IActionResult Index()
        {
            PrintSetting printSetting = _printSetting.Value;
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