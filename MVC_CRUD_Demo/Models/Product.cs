 using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC_CRUD_Demo.Models
{
    public class Product : Category
    {
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public string ProdDesc { get; set; }
        public decimal ProdPrice { get; set; }
        public string ProdType { get; set; }
    }
}