using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JornadasApp.Data;
using JornadasApp.Models;

namespace JornadasApp.Controllers
{
    public class WorkDayTimersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WorkDayTimersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WorkDayTimers
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.WorkDayTimers.Include(w => w.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: WorkDayTimers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workDayTimer = await _context.Jornadas;
        }
    }
}