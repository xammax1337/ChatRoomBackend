using System.ComponentModel.DataAnnotations;

namespace Admix.Models
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }

        [Required, MinLength(6)]
        public string Password { get; set; }
    }
}
