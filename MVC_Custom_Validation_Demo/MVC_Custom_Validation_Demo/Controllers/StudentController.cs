using System.Security.Principal;
using System;
using System.Data.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Custom_Validation_Demo.Models;

using Microsoft.EntityFrameworkCore;


namespace MVC_Custom_Validation_Demo.Controllers
{
    public class StudentController: Controller
    {
        private readonly AppDbContext _context;
        public StudentController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            var data = _context.students
            ;
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student newStudent)
        {
            if (ModelState.IsValid){
                
                _context.students
                .Add(newStudent);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = _context.students.Find(id);
            return View(data);
        }

        
        [HttpPost]
        public IActionResult Delete(int id, Student studentToDelete)
        {
            var student = _context.GetStudentById(studentToDelete.Id); 
            if (student == null)
            {
                return View("");
            }
            else 
            {
                _context.DeleteStudent(student.Id);
                return RedirectToAction("Index");        
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
             if (id == -1)
            {
                return NotFound();
            }
            else 
            {
                var data = _context.students
                .FirstOrDefault(x => x.Id == id);
                if (data == null){
                    return NotFound();
                }
            }
            return View();
        }

        
        [HttpPost]
        public IActionResult Edit(int id, Student modifiedStudent)
        {
            if (ModelState.IsValid){

                _context.students.Update(modifiedStudent);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {

            var data = _context.students.Find(id);
            return View(data);
             
    
        }
    }
}
