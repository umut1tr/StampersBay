using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StampersBay.Areas.Identity.Data;
using StampersBay.Models;
using System.Diagnostics;


namespace StampersBay.Controllers
{
    public class TrainerController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;


        public TrainerController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }

        public IActionResult Index()
        {          

            return View();
        }

        public IActionResult Admin()
        {
            var users = _userManager.Users;

            return View(users);
        }
        

        

    }
}
