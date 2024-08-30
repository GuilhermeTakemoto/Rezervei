using System.ComponentModel.DataAnnotations;

namespace Rezervei.Object.Contracts
{
    public class Login
    {
        [Required(ErrorMessage = "o e-mail é requerido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é requerida!")]
        public string Password { get; set; }

    }
}
