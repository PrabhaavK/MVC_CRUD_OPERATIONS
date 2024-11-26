using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_CodeFirst_Demo.Models
{
    public class User
    {
        [Key]
        public int Id { get; set;}

        [Required(ErrorMessage = "must enter name")]
        public string? Username { get; set;}

        //[Required(ErrorMessage = "password is must")]
        public string? Password { get; set;}

        [Compare("Password",ErrorMessage=" must be same  ")]
        public string? ConfirmPassword { get; set; }
    }
}

