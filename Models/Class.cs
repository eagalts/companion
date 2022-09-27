using System.ComponentModel.DataAnnotations;
namespace Companion.Models
{
    public class Class
    {
        [Display(Name = "Логин")]
        [Required(ErrorMessage = "Введите логин")]
        public string login { get; set; }
        [Display(Name = "Пароль")]
        [Required(ErrorMessage = "Введите пароль")]
        public string password { get; set; }
    }
}
