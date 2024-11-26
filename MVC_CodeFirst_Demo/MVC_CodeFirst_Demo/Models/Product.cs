using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_CodeFirst_Demo.Models
{
    public class Product
    {
        [Key]
        public int ProdId { get; set; }

        [Required(ErrorMessage ="Product Name should be there ")]
        public string ProdName { get; set; }

        
        public decimal Price { get; set; }

        
        public string Mfd { get; set; }

        
        public string Exd { get; set; }

        
        public Category? Category { get; set; }

    }
}
