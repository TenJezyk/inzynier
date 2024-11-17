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
    public class TeamCreatorModel : PageModel
    {
        [BindProperty]
        public Team TeamCreated { get; set; }

        private readonly ITeamService _teamService;
        private readonly IUserTeamService _userTeamService;
        private readonly IUserService _userService;

        [BindProperty]
        public string UserNames { get; set; }

        public string ErrorMessage { get; set; } 

        public TeamCreatorModel(ITeamService teamService, IUserTeamService userTeamService, IUserService userService)
        {
            _teamService = teamService;
            _userTeamService = userTeamService;
            _userService = userService;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (TeamCreated.Name==null) 
            {
                ErrorMessage = "Invalid input. Please check the entered data.";
                Console.WriteLine(TeamCreated.Name);
                return Page(); // Powrót do widoku w przypadku b³êdnych danych

            }
           string[] _users = UserNames.Split(",");
            var addingTeamResult = _teamService.AddTeam(TeamCreated);
            foreach (string user in _users)
            {
                User usertoadd = _userService.GetUser(user);
                if (usertoadd != null)
                {
                    _userTeamService.AddUserTeam(new()
                    {
                        User=usertoadd,
                        Team=TeamCreated,
                    });

                    Console.WriteLine(TeamCreated.Name);
                }

            }

            Console.WriteLine(TeamCreated.Name);
            Console.WriteLine(UserNames);



          
            if (addingTeamResult == null)
            {
                ErrorMessage = "Error occurred while adding the team. Please try again.";
                return Page(); // Powrót do widoku w przypadku b³êdu podczas dodawania zespo³u
            }

         
            return Page();
        }
    }
}