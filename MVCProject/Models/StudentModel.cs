using System.ComponentModel.DataAnnotations;

namespace MVCProject.Models;

public class StudentModel
{
    public string Name { get; set; }
    public int Age { get; set; }
    [MinLength(8, ErrorMessage ="Address must be 8 char long")]
    public string? Address { get; set; }
    [EmailAddress]
    public string? Email { get; set; }
    
    [RegularExpression(@"^[A-Z][a-z]{3}[0-9]{4}$",
        ErrorMessage = "Value must start with one uppercase letter, followed by three lowercase letters, and end with four digits.")]
    public string Password { get; set; }
}
