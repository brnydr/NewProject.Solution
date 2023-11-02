using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SponsorMatch.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace SponsorMatch.Controllers;

public class HomeController : Controller
 {
        private readonly SponsorMatchContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(UserManager<ApplicationUser> userManager, SponsorMatchContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        [HttpGet("/")]
        public async Task<ActionResult> Index()
        {
            Athlete[] athletes = _db.Athletes.ToArray();
            Dictionary<string, object[]> model = new Dictionary<string, object[]>();
            model.Add("athletes", athletes);
            string userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
            return View(model);
        }
    }
