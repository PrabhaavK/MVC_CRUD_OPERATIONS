using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MVC_RoutingDemo.Models;

namespace MVC_RoutingDemo.Controllers
{[Route("stud")]

    public class StudentController : Controller 
    {
        
        public List<Student> studlist = new List<Student>();

        public StudentController(){
            studlist.Add(new Student() { Id = 101, Name = "Bill" });
            studlist.Add(new Student() { Id = 102, Name = "Milliy" });
            studlist.Add(new Student() { Id = 103, Name = "gate" });
            studlist.Add(new Student() { Id = 104, Name = "Will" });
            studlist.Add(new Student() { Id = 105, Name = "Ben" });
        }

        
        public IActionResult GetAllStudent()
        {

            return View(studlist); 
        }
        [HttpGet]
        [Route("getone{id :int}")]
        public IActionResult GetStudentById(int id)
        {
            var data = studlist.Find(x => x.Id == id);
            return View(data);
        }
    }
}