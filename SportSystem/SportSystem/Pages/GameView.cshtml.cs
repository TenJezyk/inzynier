using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SportSystem.Data.Models;
using SportSystem.Services.Interfaces;

namespace SportSystem.Pages
{
    public class GameViewModel : PageModel
    {
        private readonly IGameService _gameService;
        public IList<Game> Games { get; set; }
        public GameViewModel(IGameService gameService)
        {
            _gameService = gameService;
        }

        public void OnGet()
        {
            Games = _gameService.GetGames();
        }
    }
}
