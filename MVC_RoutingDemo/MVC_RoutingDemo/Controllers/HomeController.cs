using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_RoutingDemo.Models;

namespace MVC_RoutingDemo.Controllers;

[Route("myhome")]

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [Route("Hello")]
    [Route("Wish")]
    [Route("")]

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
