using System.ComponentModel.DataAnnotations;

namespace MVC_CodeFirst_Demo.Models;

public class Customer
{
    [Key]
    public int Id { get; set; }

    
    [Required]
    [StringLength(30, MinimumLength = 3)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(30, MinimumLength = 3, ErrorMessage = "Minimum Length is should be 3")]
    public string LastName { get; set;}

    public string Address { get; set; }

    public string City { get; set; }

    [EmailAddress(ErrorMessage = "Use Email Pattern")]
    public string Email { get; set; }

   [Phone]
    public string Phone { get; set; }

    public string URL { get; set; }

    [Range (minimum:16 ,maximum:58,ErrorMessage = "Age must be between 16  and 58")]

    public int Age { get; set; }

}
