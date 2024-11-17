using SportSystem.Data.DataContext;
using SportSystem.Data.Models;
using SportSystem.Repositories.Interfaces;

namespace SportSystem.Repositories
{
    public class TeamRepository :  ITeamRepository
    {
        private readonly SportSystemDbContext _context;
        public TeamRepository(SportSystemDbContext context) 
        {
        _context = context;
        }

        public Task Add(Team team)
        {
            _context.Teams.Add(team);
            var result = _context.SaveChanges();
            return Task.FromResult(result);
        }
        public IEnumerable<Team> GetAll()
        {
            var result = _context.Teams;
            return result;
        }
    }
}
