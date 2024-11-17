using SportSystem.Data.Models;
using SportSystem.Repositories;
using SportSystem.Repositories.Interfaces;
using SportSystem.Services.Interfaces;
namespace SportSystem.Services
{
    public class TeamService: ITeamService
    {
        private readonly ITeamRepository _TeamRepository;

        public TeamService(ITeamRepository TeamRepository)
        {
            _TeamRepository = TeamRepository;
        }

        public Task AddTeam(Team team)
        {
            team.Id = Guid.NewGuid();

            var result = _TeamRepository.Add(team);
            return Task.CompletedTask;
        }
        public Team GetTeam(string teamName)
        {
            var team = _TeamRepository.GetAll().FirstOrDefault(x => x.Name == teamName);
            return team;
        }

        public List<Team> GetAll()
        {
            List<Team> teams = _TeamRepository.GetAll().ToList();
            return teams;
        }

    }
}
