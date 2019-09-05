using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; } 
        [Required]
        [StringLength(8,MinimumLength=5, ErrorMessage="Password length must be in 8 to 5 charecters")]   
        public string Password { get; set; } 
    }
}