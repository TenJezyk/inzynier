using SportSystem.Data.Models;

namespace SportSystem.Repositories.Interfaces
{
    public interface IUserTeamRepository
    {
        public Task Add(UserTeam userTeam);
        public IEnumerable<UserTeam> GetAll();
    }
}
