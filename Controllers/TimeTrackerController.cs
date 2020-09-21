using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeTrack.Data;
using TimeTrack.Models;

namespace TimeTrack.Controllers
{
    public class TimeTrackController : Controller
    {

        public async Task<IActionResult> Index()
        {
            return View(await _context.Client.ToListAsync());
        }

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        private readonly TimeTrackerContext _context;

        public TimeTrackController(TimeTrackerContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var client = await _context.Client.FirstOrDefaultAsync(m => m.Id == id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }
    }
}