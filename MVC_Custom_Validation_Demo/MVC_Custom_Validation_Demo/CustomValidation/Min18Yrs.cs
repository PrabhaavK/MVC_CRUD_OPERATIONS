using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_Custom_Validation_Demo.CustomValidation
{
    public class Min18Yrs : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime date)
            {
                int age = DateTime.Now.Year - date.Year;
                if (date > DateTime.Now.AddYears(-age)) age--;

                if (age < 18)
                {
                    return new ValidationResult(ErrorMessage ?? "You must be at least 18 years old.");
                }
            }
            return ValidationResult.Success;
        }
    }
}