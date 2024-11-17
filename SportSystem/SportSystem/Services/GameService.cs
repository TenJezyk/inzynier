using SportSystem.Data.Models;
using SportSystem.Repositories.Interfaces;
using SportSystem.Services.Interfaces;

namespace SportSystem.Services
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;
        private readonly ITeamService _teamService;
        private readonly ILocationRepository _locationRepository;

        public GameService(IGameRepository gameRepository, ITeamService teamService, ILocationRepository locationRepository)
        {
            _gameRepository = gameRepository;
            _teamService = teamService;
            _locationRepository = locationRepository;
            
        }

        public Task AddGame(Game game )
        {
            game.Id = Guid.NewGuid();
            var result = _gameRepository.Add(game);
            return Task.CompletedTask;
        }

        public List<Game> GetGames()
        {
            List<Game> games = _gameRepository.GetAll().ToList();
            foreach(var game in games)
            {
                game.HostTeam = _teamService.GetAll().FirstOrDefault(y => y.Id == game.HostTeamId);
                game.VisitorsTeam = _teamService.GetAll().FirstOrDefault(y => y.Id == game.VisitorTeamId);
                game.Location = _locationRepository.GetAll().FirstOrDefault(l => l.Id == game.LocationId);

            }
            return games;
        }

        public List<Game> GetGamesByLocation(Guid locationId)
        {
            var location = _locationRepository.GetAll().FirstOrDefault(l => l.Id == locationId).Id;
            var games = _gameRepository.GetAll().Where(g => g.LocationId == location).ToList();

            foreach(var game in games)
            {
                game.HostTeam = _teamService.GetAll().First(t => t.Id == game.HostTeamId);
                game.VisitorsTeam = _teamService.GetAll().First(t => t.Id == game.VisitorTeamId);
            }

            return games;
        }
    }
}
