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

        private readonly TimeTrackerContext _context;

        public TimeTrackController(TimeTrackerContext context)
        {
            _context = context;
        }

        // Get method for getting the details for the specific client
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

        // This is the get method for the editing of data, it just gets the record you want to edit
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var client = await _context.Client.FindAsync(id);
            if(client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        // This is the post method for the editing of data
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, 
            [Bind("Id,Name,StartDate,Location")] 
            Client client)
        {
            if (id != client.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(client);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientExists(client.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }

        // This is the get method to create a new client ==============================
        public IActionResult Create()
        {
            return View();
        }

        // This is the post method to create a new client ==============================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("Id,Name,StartDate,Location")
            ] Client client)
        {
            if (ModelState.IsValid)
            {
                _context.Add(client);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }

        // Method used just in this controller to determine if a client exists.
        // you can find it being used above
        private bool ClientExists(int id)
        {
            return _context.Client.Any(e => e.Id == id);
        }
    }
}