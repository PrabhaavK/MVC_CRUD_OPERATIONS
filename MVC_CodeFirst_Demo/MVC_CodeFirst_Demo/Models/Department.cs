using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_CodeFirst_Demo.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }

        [Required]
        public string? DeptName { get; set; }

        //one to many relationship with Employee
        public  ICollection <Employee> Employees { get; set; }
    }
}
