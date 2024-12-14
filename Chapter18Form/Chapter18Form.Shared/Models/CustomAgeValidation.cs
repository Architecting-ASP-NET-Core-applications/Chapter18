using System.ComponentModel.DataAnnotations;

namespace Chapter18Form.Shared;

public class CustomAgeValidation : ValidationAttribute
{
    protected override ValidationResult IsValid
        (object value, ValidationContext validationContext)
    {
        int age = (int)value;
        if (age < 18)
        {
            return new ValidationResult
                ("Age must be 18 or older.");
        }
        return ValidationResult.Success;
    }
}
