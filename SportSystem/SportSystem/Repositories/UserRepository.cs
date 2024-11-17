using SportSystem.Data.DataContext;
using SportSystem.Data.Models;
using SportSystem.Repositories.Interfaces;

namespace SportSystem.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SportSystemDbContext _context;

        public UserRepository(SportSystemDbContext context)
        {
            _context = context;
        }
        public Guid Add(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
            return user.Id;
        }

        public IEnumerable<User> GetAll()
        {
            var result = _context.User;
            return result;
        }
    }
}
