using SportSystem.Data.Models;

namespace SportSystem.Services.Interfaces
{
    public interface IGameService
    {
        public Task AddGame(Game game);

        public List<Game> GetGames();

        public List<Game> GetGamesByLocation(Guid locationId);
    }
}
