using System.ComponentModel.DataAnnotations;

namespace ASPDataWork.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Введите имя")]
        [MaxLength(50, ErrorMessage = "Длина не должна быть больше 50 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите возраст")]
        [Range(1, 110, ErrorMessage = "Недопустимыый возраст")]
        public int Age { get; set; }

        public User() { }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
