using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using WebFrontToBack.DAL;
using WebFrontToBack.Models;

namespace WebFrontToBack.Controllers
{
    public class ServicesController : Controller
    {
        private readonly AppDbContext _context;
        public ServicesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Services
                .OrderByDescending(s => s.Id)
                .Where(s => !s.IsDeleted)
                .Take(8)
                .Include(s => s.ServiceImages)
                .ToListAsync());
        }

     
    }
}
