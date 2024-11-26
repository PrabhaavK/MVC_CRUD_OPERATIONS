using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_CodeFirst_Demo.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public decimal Salary { get; set; }

        public Department? Department { get; set; }
    }
}
