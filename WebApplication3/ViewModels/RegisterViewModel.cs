using System.ComponentModel.DataAnnotations;

namespace WebApplication3.ViewModels
{
    public class RegisterViewModel
    {
        [Required] [Display(Name = "Email")] 
        public string Email { get; set; }
        
        [Required] [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердить пароль")]
        public string PasswordConfirm { get; set; }
    }
}