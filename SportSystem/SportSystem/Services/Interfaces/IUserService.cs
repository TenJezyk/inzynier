using SportSystem.Data.Models;

namespace SportSystem.Services.Interfaces
{
    public interface IUserService
    {
        public Task AddUser(User user);
        public User GetUser(Guid id);

        public User GetUser(string username);
    }
}
