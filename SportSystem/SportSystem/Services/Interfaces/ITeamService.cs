using SportSystem.Data.Models;

namespace SportSystem.Services.Interfaces
{
    public interface ITeamService
    {
        public Task AddTeam(Team team);
        public Team GetTeam(string teamName);

        public List<Team> GetAll();
    }
}
