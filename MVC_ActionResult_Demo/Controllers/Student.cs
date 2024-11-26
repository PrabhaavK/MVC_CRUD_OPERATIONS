using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_ActionResult_Demo.Models;

namespace MVC_ActionResult_Demo.Controllers
{
    public class Student
    {
        public RedirectToRouteResult Index4()
        {
            return RedirectToRoute(new { Controller = "Student", Action = "Index" });  

    }}
}