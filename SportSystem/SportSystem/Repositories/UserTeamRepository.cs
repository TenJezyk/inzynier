using SportSystem.Data.DataContext;
using SportSystem.Data.Models;
using SportSystem.Repositories.Interfaces;

namespace SportSystem.Repositories
{
    public class UserTeamRepository : IUserTeamRepository
    {
        private readonly SportSystemDbContext _context;
        public UserTeamRepository(SportSystemDbContext context) 
        {
            _context = context;
        }

        public Task Add(UserTeam userTeam)
        {
            _context.UserTeams.Add(userTeam);
            var result = _context.SaveChanges();
            return Task.FromResult(result);
        }
        public IEnumerable<UserTeam> GetAll()
        {
            var result = _context.UserTeams;
            return result;
        }
    }
}
