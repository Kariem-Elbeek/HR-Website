using System.ComponentModel.DataAnnotations;

namespace Demo.PL.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        //[MinLength(6, ErrorMessage = "Minimum Length is 6 chars")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
