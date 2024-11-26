using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Net.NetworkInformation;
using System.Buffers;
using System;
using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using MVC_Custom_Validation_Demo.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("MyConStr") ??
    throw new InvalidOperationException("Connection string 'MyConStr' not found.");


builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(connectionString));


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
