using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SportSystem.Data.Models;
using SportSystem.Services.Interfaces;
using System.Collections.Generic;

namespace SportSystem.Pages
{
    public class TeamViewerModel : PageModel
    {
        private readonly IUserTeamService _userTeamService;

        public List<TeamView> TeamsView { get; set; } = new List<TeamView>();

        public class TeamView
        {
            public string TeamName { get; set; }
            public List<string> Players { get; set; } = new List<string>();
        }

        public TeamViewerModel(IUserTeamService userTeamService)
        {
            _userTeamService = userTeamService;
            Show();
        }

        public void OnGet()
        {
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

                TeamsView.Add(teamView);
            }
        }
    }
}
