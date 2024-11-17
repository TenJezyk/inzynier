using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SportSystem.Data.DataContext;
using SportSystem.Data.Models;
using SportSystem.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace SportSystem.Pages
{
    public class TrainerViewModel : PageModel
    {
        private readonly IUserTeamService _userTeamService;
        private readonly SportSystemDbContext _context;

        public List<TeamView> TeamsView { get; set; } = new List<TeamView>();
        public IList<Team> Teams { get; set; }
        public IList<Game> Games { get; set; }

        public class TeamView
        {
            public string TeamName { get; set; }
            public List<string> Players { get; set; } = new List<string>();
            public int NumberOfGamesPlayed { get; set; }
        }


        public TrainerViewModel(IUserTeamService userTeamService, ILogger<IndexModel> logger, SportSystemDbContext context)
        {
            _userTeamService = userTeamService;
            _context = context;
            Show();
        }
        public int GetNumberOfGamesPlayed(Guid teamId)
        {
            return _context.Games.Count(m => m.HostTeamId == teamId || m.VisitorTeamId == teamId);
        }

        public void OnGet()
        {
            Teams = _context.Teams.ToList();
        }

        private void Show()
        {
            List<Team> teams = _userTeamService.GetTeams();

            foreach (Team team in teams)
            {
                TeamView teamView = new TeamView();
                teamView.TeamName = team.Name;

                List<User> users = _userTeamService.GetByTeam(team.Id);

                foreach (User user in users)
                {
                    teamView.Players.Add(user.Username);
                }
                teamView.NumberOfGamesPlayed = GetNumberOfGamesPlayed(team.Id);

                TeamsView.Add(teamView);
            }
        }

    }
}
