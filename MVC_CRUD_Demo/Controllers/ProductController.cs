using Microsoft.AspNetCore.Mvc;
using MVC_CRUD_Demo.Models;

namespace MVC_CRUD_Demo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = ProductService.GetAllProducts();
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product newproduct)
        {
            // newproduct.ProdId=ProductService.nextId;
            ProductService.AddProduct(newproduct);

            return RedirectToAction("Index");
            
        }
        [HttpGet]
        public IActionResult Edit(int id){
            var product = ProductService.GetProductById(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(int id, Product product){
            ProductService.UpdateProduct(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id){
            var product = ProductService.GetProductById(id);
            return View(product);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = ProductService.GetProductById(id);
            return View(products);
        }
        [HttpPost]
        public IActionResult Delete(int id, Product products)
        {
            var data = ProductService.GetProductById(id);
            if (data == null)
            {
                return View();
            }else
            {
                productService.DeleteProduct(data);
                return RedirectToAction("Index");
            }
        }
    }
}
