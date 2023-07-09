using System.ComponentModel.DataAnnotations;

namespace ASP.NET_WEBAPI_WITH_IDENTITY_JWT_CHECKING.Model
{
    public class RegisterModel
    {
        [Required(ErrorMessage ="User name is required")]
        public string? Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage ="Email is required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }

    }
}
