namespace ASPDataWork.Models
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User() { }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
