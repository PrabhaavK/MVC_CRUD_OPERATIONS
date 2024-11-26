using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace MVC_StoredProc_ViewModel_Demo.Models.ViewModels
{
    public class CatProductViewModel
    {
        [Key]
        public int Id { get; set;}
        public string CategoryName { get; set;}
        public string ProductName { get; set;}
        public decimal Price { get; set;}

        
    }
}
