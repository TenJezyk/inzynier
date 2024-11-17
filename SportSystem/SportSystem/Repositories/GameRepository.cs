using SportSystem.Data.DataContext;
using SportSystem.Data.Models;
using SportSystem.Repositories.Interfaces;

namespace SportSystem.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly SportSystemDbContext _context;
        public GameRepository(SportSystemDbContext context)
        {
            _context = context;
        }

        public Task Add(Game game)
        {
            _context.Games.Add(game);
            var result = _context.SaveChanges();
            return Task.FromResult(result);
        }
        public IEnumerable<Game> GetAll()
        {
            var result = _context.Games;
            return result;
        }
    }
}
