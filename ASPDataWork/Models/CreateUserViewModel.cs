using System.ComponentModel.DataAnnotations;

namespace ASPDataWork.Models
{
    public class CreateUserViewModel
    {
        [Required(ErrorMessage = "Введите имя")]
        [MaxLength(50, ErrorMessage = "Длина не должна быть больше 50 символов")]
        public string Name { get; set; }

        [Range(1, 110, ErrorMessage = "Недопустимыый возраст")]
        public int Age { get; set; }
    }
}
