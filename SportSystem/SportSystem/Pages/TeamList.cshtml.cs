using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SportSystem.Data.DataContext;
using SportSystem.Data.Models;


namespace SportSystem.Pages
{
    public class TeamListModel : PageModel

    {
        private readonly SportSystemDbContext _context;

        
        public TeamListModel(ILogger<IndexModel> logger, SportSystemDbContext context)
        {
            _context = context;
        }

        public IList<Team> Teams { get; set; }
        public IList<Game> Games { get; set; }
        public int GetNumberOfGamesPlayed(Guid teamId)
        {
            return _context.Games.Count(m => m.HostTeamId == teamId || m.VisitorTeamId == teamId);
        }
        public void OnGet()
        {
            Teams = _context.Teams.ToList();
            
        }
        

    }
}
