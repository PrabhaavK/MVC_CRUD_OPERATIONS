using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Data;

namespace MVC_StoredProc_ViewModel_Demo.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
