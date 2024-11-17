using SportSystem.Data.Models;

namespace SportSystem.Repositories.Interfaces
{
    public interface IGameRepository
    {
        public Task Add(Game game);
        public IEnumerable<Game> GetAll();
    }
}
