using Humanizer.Localisation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SportSystem.Data.DataContext;
using SportSystem.Data.Models;
using SportSystem.Services;
using SportSystem.Services.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportSystem.Pages
{
    public class GameListModel : PageModel
{

        private readonly IGameService _gameService;
        private readonly ILocationService _locationService;
        private readonly ITeamService _teamService;


        [BindProperty]
        public Location Location { get; set; }

        
    public List<Location> AvailableLocations { get; set; }


    public List<Game> Games { get; set; }

    public void OnGet()
    {

    }

    public GameListModel(IGameService gameService,ITeamService teamService ,ILocationService locationService)
    {
        
            _gameService = gameService;
            _locationService = locationService;
            _teamService = teamService;
        AvailableLocations = _locationService.GetLocations();
    }

    public void OnPost()
    {

        var locationId = Location.Id;
            if (locationId != Guid.Empty)
                Games = GetGamesForLocation(locationId);
    }


        private List<Game> GetGamesForLocation(Guid locationId)
        {

                var games1 = _gameService.GetGamesByLocation(locationId);
            List<Game> Gamelist = _gameService.GetGames();
            List<Team> Teamslist = _teamService.GetAll();

            List<Game> games = new List<Game>();
            foreach (Game game in Gamelist)
            {



                if (game.LocationId == locationId)
                {
                    foreach (Team team in Teamslist)
                    {
                        if (game.HostTeamId == team.Id)
                            game.HostTeam = team;
                        if (game.VisitorTeamId == team.Id)
                            game.VisitorsTeam = team;

                        if (game.HostTeam != null && game.VisitorsTeam != null)
                            break;

                    }

                    games.Add(game);
                }
            }

            return games1;
        }
    }
}