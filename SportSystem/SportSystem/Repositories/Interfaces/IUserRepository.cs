using SportSystem.Data.Models;

namespace SportSystem.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public Guid Add(User user);
        public IEnumerable<User> GetAll();
    }
}
