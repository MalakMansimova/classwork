using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebFrontToBack.DAL;

namespace WebFrontToBack.Controllers
{
    public class WorksController : Controller
    {

        private readonly AppDbContext _context;
        public WorksController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Works
                .OrderByDescending(s => s.Id)
                .Take(8)
                .ToListAsync());
        }
    }
}
