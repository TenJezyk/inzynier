using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SportSystem.Data.DataContext;
using SportSystem.Data.Models;
using System;
using System.Collections.Generic;

namespace SportSystem.Pages
{
    public class UserRegistrationModel : PageModel
    {
        private readonly SportSystemDbContext _context;
        [BindProperty]
        public User userRegistered { get; set; }

        public UserRegistrationModel(SportSystemDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }
        public void OnPost()
        {

            _context.User.Add(userRegistered);
            _context.SaveChanges();
        }
    }
}