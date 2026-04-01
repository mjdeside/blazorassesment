using System.ComponentModel.DataAnnotations;

namespace AssesmentOnlineJobs.Model;

public class UserFormModel
{
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Address is required")]
    public string Address { get; set; } = string.Empty;

    [Required(ErrorMessage = "Age is required")]
    [Range(18, 120, ErrorMessage = "You must be at least 18 years old.")]
    public int? Age { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email format")]
    public string Email { get; set; } = string.Empty;
}
