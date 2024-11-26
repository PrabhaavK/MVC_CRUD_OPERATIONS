using System.Data;
using System.Net.NetworkInformation;
using System.Buffers;
using System;
using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using MVC_CodeFirst_Demo.Models;
using MVC_CodeFirst_Demo.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var connectionString = builder.Configuration.GetConnectionString("MyConStr") ??
    throw new InvalidOperationException("Connection string 'MyConStr' not found.");


builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(connectionString));


/// commond dotnet ef migrations add m1
/// 
/// dotnet ef database update

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
