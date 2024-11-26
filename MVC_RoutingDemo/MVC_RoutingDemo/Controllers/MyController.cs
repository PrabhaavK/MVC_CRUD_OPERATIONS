
using System;
using Microsoft.AspNetCore.Mvc;

namespace MVC_RoutingDemo.Controllers
{[Route("auth")]

    public class MyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("~/good")]
        public IActionResult Welcome()
        {
            return View();
        }
    }
}
