 using System.Collections.Generic;
using System.Linq;

namespace MVC_CRUD_Demo.Models
{
      public class ProductService
    {
        private static List<Product> products;
        private static int nextId = 6;

        static ProductService()
        {
            products = new List<Product>
            {
                new Product { ProdId = 1, ProdName = "Fruits", ProdPrice = 30 },
                new Product { ProdId = 2, ProdName = "Good Day", ProdPrice = 20 },
                new Product { ProdId = 3, ProdName = "Amul Butter Milk", ProdPrice = 40 },
                new Product { ProdId = 4, ProdName = "Lassi", ProdPrice = 50 },
                new Product { ProdId = 5, ProdName = "Ice Cream", ProdPrice = 80 }
            };
        }

        public static List<Product> GetAllProducts()
        {
            return products;
        }

        public static Product GetProductById(int id)
        {
            return products.FirstOrDefault(p => p.ProdId == id);
        }

        public static void AddProduct(Product product)
        {
            product.ProdId = nextId;
            products.Add(product);
            nextId++;
        }

        public static void UpdateProduct(Product modifiedProduct)
        {
            int index = products.FindIndex(x => x.ProdId == modifiedProduct.ProdId);
            if (index != -1)
            {
                products[index] = modifiedProduct;
            }
        }

        public static void DeleteProduct(int id)
        {
            var product = GetProductById(id);
            if (product != null)
            {
                products.Remove(product);
            }
        }
    }
}
