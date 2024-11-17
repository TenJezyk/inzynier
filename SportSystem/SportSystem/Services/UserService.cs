using SportSystem.Data.Models;
using SportSystem.Repositories.Interfaces;
using SportSystem.Services.Interfaces;

namespace SportSystem.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task AddUser(User user)
        {
            user.Id = Guid.NewGuid();
            var result = _userRepository.Add(user);
            return Task.CompletedTask;
        }

        public User GetUser(Guid id)
        {
            var user = _userRepository.GetAll().FirstOrDefault(x => x.Id == id);
            return user;
        }

        public User GetUser(string username)
        {
            User user = _userRepository.GetAll().FirstOrDefault(x=> x.Username==username);
            return user;
        }
    }

}
