using ASPDataWork.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPDataWork.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddUser(string name, int age)
        {
            var user = new User { Name = name, Age = age };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
