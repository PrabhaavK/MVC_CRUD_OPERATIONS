using System;
using System.Data;
using System.Net.NetworkInformation;
using System.Buffers;
using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using MVC_StoredProc_ViewModel_Demo;
using MVC_StoredProc_ViewModel_Demo.Models;

namespace MVC_StoredProc_ViewModel_Demo.Controllers
{
    public class ProductController : Controller
    {
         private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;

        }
        public ActionResult Index()
        {
            return View(_context.Products);
        }

        [HttpGet]
        public IActionResult GetAllProductsByCat()
        {
            var data = _context.productsBycat.FromSqlInterpolated($"dbo.SP_ProductsBYCategory");
            return View(data);
        }

        [HttpGet("{Id}")]
        public IActionResult GetAllProductsByCatId(int Id)

        {
            var data = _context.productsBycat.FromSqlInterpolated($"dbo.SP_ProductByCatId {Id}");
            return View(data);
        }
    }
}
