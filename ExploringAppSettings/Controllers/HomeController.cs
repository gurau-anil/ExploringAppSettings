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
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IOptions<PrintSetting> printSetting, IConfiguration configuration)
        {
            _logger = logger;
            _printSetting = printSetting;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            PrintSetting printSetting = _printSetting.Value;

            // Getting Configuration Section and Mapping it to a model
            var pSetting = _configuration.GetSection("PrintSetting").Get<PrintSetting>();

            string settingVal = _configuration.GetValue<string>("MySetting");

            //Getting value of subsection
            string sectionInfo = _configuration.GetValue<string>("Section:SubSection:Info");
            string subSectionInfo = _configuration.GetValue<string>("Section:SubSection:Info");
            string subSubSectionInfo = _configuration.GetValue<string>("Section:SubSection:SubSubSection:Info");
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