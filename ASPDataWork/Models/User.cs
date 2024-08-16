using System.ComponentModel.DataAnnotations;

namespace ASPDataWork.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(1, 110)]
        public int Age { get; set; }

        public User() { }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
