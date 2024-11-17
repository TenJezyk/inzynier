using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SportSystem.Data.DataContext;
using SportSystem.Data.Models;
using SportSystem.Services.Interfaces;
using System.Data.Common;
using System.Linq;
namespace SportSystem.Pages
{
    public class GameCreatorModel : PageModel
    {


		private readonly IGameService _gameService;
		private readonly ITeamService _teamService;
		private readonly ILocationService _locationService;

        [BindProperty]
        public Team HostTeam { get; set; }

        [BindProperty]
        public Team VisitTeam { get; set; }

		[BindProperty]
		public Location Locationselected { get; set; }

		[BindProperty]
		public DateTime GameDate { get; set; }
		public List<Location> AvailableLocations { get; set; }
        public void OnGet()
        {
			
		}
		public GameCreatorModel( ITeamService teamService, IGameService gameService, ILocationService locationService)
		{


			GameDate = DateTime.Now.AddSeconds(-DateTime.Now.Second).AddMilliseconds(-DateTime.Now.Millisecond);
			_gameService = gameService;
			_teamService = teamService;
			_locationService = locationService;
            AvailableLocations = _locationService.GetLocations();
        }

        public void OnPost()
        {
            Team hostTeamToAdd = _teamService.GetTeam(HostTeam.Name);
            Team visitTeamToAdd = _teamService.GetTeam(VisitTeam.Name);
            Location select = new Location();
            select.Id = Locationselected.Id;

            if (hostTeamToAdd != null && visitTeamToAdd != null)
            {
                
                var addinggameresult = _gameService.AddGame(new Game()
                {
                    HostTeam = hostTeamToAdd,
                    VisitorsTeam = visitTeamToAdd,
                    LocationId = select.Id,
                    GameDate = GameDate,
                });
            }
        }
    }
}
