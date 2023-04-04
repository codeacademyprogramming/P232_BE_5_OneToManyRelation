using EternaMVC.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EternaMVC.Controllers
{
    public class TeamController : Controller
    {
        private readonly EternaDbContext _context;

        public TeamController(EternaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = _context.TeamMembers.ToList();

            return View(model);
        }
    }
}
