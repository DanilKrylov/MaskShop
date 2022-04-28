using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaskShop.ViewModels
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage ="Поле логгин не может быть пустым")]
        [MinLength(4, ErrorMessage = "Минимальная длина логина 4 символа")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Поле пароль не может быть пустым")]
        [MinLength(6, ErrorMessage ="Минимальная длина пароля 6 символов")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage ="Поле должно совпадать с паролем")]
        public string ConfirmPassword { get; set; }
    }
}
