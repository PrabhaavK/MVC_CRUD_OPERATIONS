using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_Custom_Validation_Demo.CustomValidation
{
    public class CustomAdmissionData : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime dateTime = Convert.ToDateTime(value);
            if (dateTime > DateTime.Now)
            {
                return new ValidationResult(ErrorMessage ?? "Admission date should not exceed current date");
            }
            return ValidationResult.Success;
        }
    }
}
