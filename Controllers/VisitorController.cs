using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VisitorRegister.Data;

namespace VisitorRegister.Controllers
{
    public class VisitorController : Controller
    {
        private readonly VisitorDbContext _context;

        public VisitorController(VisitorDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var visitors = await _context.Visitors
                .OrderByDescending(v => v.VisitDateTime)
                .ToListAsync();

            return View(visitors);
        }
    }
}