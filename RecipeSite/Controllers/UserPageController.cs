using Microsoft.AspNetCore.Mvc;
using RecipeSite.Data;
using RecipeSite.Models;

namespace RecipeSite.Controllers
{
    public class UserPageController : Controller
    {
        public readonly ApplicationDbContext context;



        public UserPageController(ApplicationDbContext _context)
        {

            context = _context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateRecipe()
        {
            return View("CreateRecipe");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateRecipe(Recipe Recipe)
        {
            return RedirectToAction("CreateRecipe", "UserPage");
        }
    }
}