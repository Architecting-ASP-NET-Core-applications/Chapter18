using System.ComponentModel.DataAnnotations;

namespace Chapter18Form.Shared;

public class Person
{
    [Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Surname is required.")]
    public string Surname { get; set; }

    [CustomAgeValidation]
    public int Age { get; set; }
}
