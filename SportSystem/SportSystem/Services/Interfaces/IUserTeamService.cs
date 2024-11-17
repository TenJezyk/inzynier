using SportSystem.Data.Models;

namespace SportSystem.Services.Interfaces
{
    public interface IUserTeamService
    {
        public Task AddUserTeam(UserTeam userteam);
        public List<User> GetByTeam(Guid team);
        public List<Team> GetTeams();
    }
}
