using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_CodeFirst_Demo.Models
{
    public class Category
    {
        [Key]
        public int CatId { get; set; }

        [Required]
        public string Name { get; set; }

        public  ICollection <Product> Products { get; set; }
    }
}
