using ASPDataWork.Models;

namespace ASPDataWork.Services
{
    public interface IUserService
    {
        Task AddUser(string name, int age);
        Task<IEnumerable<User>> GetAllUsers();
    }
}