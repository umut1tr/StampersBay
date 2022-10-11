using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StampersBay.Areas.Identity.Data;
using StampersBay.Models;
using System.Diagnostics;


namespace StampersBay.Controllers
{
    public class UserController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<UserController> _logger;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IWebHostEnvironment _environment;

        public UserController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, ILogger<UserController> logger, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _logger = logger;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {

            return null;
        }


        // Stamp user in called from button from User/Index
        public async Task<IActionResult> Stamping()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user.isStampedIn != true)
            {
                user.isStampedIn = true;

                await _userManager.UpdateAsync(user);
                await _context.SaveChangesAsync();
                return View("Index");
            }
            else
            {
                user.isStampedIn = false;

                await _userManager.UpdateAsync(user);
                await _context.SaveChangesAsync();
                return View("Index");
            }

        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}
