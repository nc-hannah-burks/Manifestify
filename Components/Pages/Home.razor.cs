using System.ComponentModel.DataAnnotations;

namespace ManifestifyBlazorApp;

public class Login
{
    [Required(ErrorMessage = "The email address is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    [Display(Name = "Email address")]

    public string? Email { get; set; }
    [Required]
    public string? Password { get; set; }


}
