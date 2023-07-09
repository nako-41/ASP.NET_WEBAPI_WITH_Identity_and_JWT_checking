using System.ComponentModel.DataAnnotations;

namespace ASP.NET_WEBAPI_WITH_IDENTITY_JWT_CHECKING.Model
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }

        [Required(ErrorMessage ="Password is required")]
        public string? Password { get; set; }

    }
}
