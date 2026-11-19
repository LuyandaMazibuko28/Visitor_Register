using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VisitorRegister.Data;
using VisitorRegister.Models;

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
        // GET: Visitor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Visitor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("Name,Surname,PhoneNumber,ReasonForVisit,Signature")] Visitor visitor)
        {
            if (!ModelState.IsValid)
            {
                return View(visitor);
            }

            visitor.VisitDateTime = DateTime.UtcNow;
            _context.Visitors.Add(visitor);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}