using DependecjInjectionGencayYildiz.Models;
using DependecjInjectionGencayYildiz.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DependecjInjectionGencayYildiz.Controllers
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
            //ConsoleLog consoleLog = new ConsoleLog();
            TestLog testLog = new TestLog();
            //BU cur yazi duzgun deyil cunki her defe biz elimizle gelib deyismeliyik 
            //bunun evezin DependencyInjection istifade edirik.
            testLog.Log();
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
