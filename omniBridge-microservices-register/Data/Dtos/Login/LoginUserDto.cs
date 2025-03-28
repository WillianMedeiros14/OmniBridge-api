using System.ComponentModel.DataAnnotations;

namespace omniBridge_microservices_register.Data.Dtos
{
    public class LoginUserDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
