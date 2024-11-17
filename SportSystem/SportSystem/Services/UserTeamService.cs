using SportSystem.Data.Models;
using SportSystem.Repositories;
using SportSystem.Repositories.Interfaces;
using SportSystem.Services.Interfaces;

namespace SportSystem.Services
{
    public class UserTeamService : IUserTeamService
    {
        private readonly IUserTeamRepository _userTeamRepository;
        private readonly IUserRepository _UserRepository;
        private readonly ITeamRepository _teamRepository;
        public UserTeamService(IUserTeamRepository userTeamRepository, IUserRepository userRepository, ITeamRepository teamRepository)
        {
            _userTeamRepository = userTeamRepository;
            _UserRepository = userRepository;
            _teamRepository = teamRepository;
        }

        public Task AddUserTeam(UserTeam userTeam)
        {

            var result = _userTeamRepository.Add(userTeam);
            return Task.CompletedTask;
        }

        public List<User> GetByTeam(Guid team)
        {
            var users = _userTeamRepository.GetAll().Where(u => u.TeamId == team).ToList();
            List<User> result = new List<User>();
            foreach (var user in users) 
            {
                result.Add(_UserRepository.GetAll().FirstOrDefault(l => l.Id == user.UserId));
            }
            return result;
        }

        public List<Team> GetTeams()
        {
            var teams = _teamRepository.GetAll().ToList();
            return teams;
        }
    }
}
