using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_ActionResult_Demo.Models;

namespace MVC_ActionResult_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ViewResult Index()
        {
            return View(nameof(SecondView));  
        }

        public ViewResult SecondView()
        {
            return View();
        }

        public ContentResult Index1()
        {
            return Content("Content View");  
        }

        public FileResult Index2()
        {   
            return File("~/Files/TestFile.txt", "text/plain");
        }
        
        public JsonResult Index3()
        {
            return Json(new { Name = "Prabhav", Id = 30 });
        }

        public RedirectToRouteResult Index4()
        {
            return RedirectToRoute(new { Controller = "Student", Action = "Index" });  // Corrected method call and used double quotes
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
