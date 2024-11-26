using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using MVC_Custom_Validation_Demo.CustomValidation;


namespace MVC_Custom_Validation_Demo.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "Please enter your name")]
        public string FristName { get; set; }

        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Choose admission Date")]
        [Display(Name = "Addmission Date")]

        [DataType(DataType.Date)]
        [CustomAdmissionData(ErrorMessage = "Admission data should not exceed current date")]
        public DateTime DOA { get; set; }

        public DateTime DOB { get; set; }
    }
}
