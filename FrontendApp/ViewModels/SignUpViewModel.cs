using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontendApp.ViewModels;

public class SignUpViewModel
{
    [Required]
    public string FirstName { get; set; } = null!;

    [Required]
    public string LastName { get; set;} = null!;

    [Required]
    [RegularExpression(@"^[a-zA-Z0-9.!#$%&'+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?).[a-zA-Z]{2,}$", ErrorMessage = "An valid email address is required")]
    public string Email { get; set; } = null!;


    [Required]
    public string Password { get; set; } = null!;

    [Required]
    [Compare (nameof(Password))]
    public string ConfirmPassword { get; set; } = null!;
}
