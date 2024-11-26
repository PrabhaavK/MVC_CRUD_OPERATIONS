using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using MVC_StoredProc_ViewModel_Demo;
using MVC_StoredProc_ViewModel_Demo.Models.ViewModels;
 

namespace MVC_StoredProc_ViewModel_Demo.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options){ }
        public DbSet<Product> Products { get; set;}
        public DbSet<Category> Categories {get; set;}
        public DbSet<CatProductViewModel> productsBycat { get; set; }
    }
}
