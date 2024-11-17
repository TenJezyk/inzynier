using SportSystem.Data.Models;

namespace SportSystem.Repositories.Interfaces
{
    public interface ITeamRepository
    {
        public Task Add(Team team);
        public IEnumerable<Team> GetAll();
    }
}
