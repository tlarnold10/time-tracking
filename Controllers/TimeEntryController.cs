using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TimeTrack.Data;
using TimeTrack.Models;

namespace TimeTrack.Controllers
{
    public class TimeEntryController : Controller
    {
        private readonly TimeTrackerContext _context;

        public TimeEntryController(TimeTrackerContext context)
        {
            _context = context;
        }

        // GET: TimeEntry
        public async Task<IActionResult> Index()
        {
            var timeTrackerContext = _context.TimeEntry.Include(t => t.Project);
            return View(await timeTrackerContext.ToListAsync());
        }

        // GET: TimeEntry/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeEntry = await _context.TimeEntry
                .Include(t => t.Project)
                .FirstOrDefaultAsync(m => m.TimeEntryId == id);
            if (timeEntry == null)
            {
                return NotFound();
            }

            return View(timeEntry);
        }

        // GET: TimeEntry/Create
        public IActionResult Create()
        {
            ViewData["ProjectId"] = new SelectList(_context.Project, "ProjectId", "ProjectId");
            return View();
        }

        // POST: TimeEntry/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TimeEntryId,Time,WorkDate,ProjectId")] TimeEntry timeEntry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(timeEntry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectId"] = new SelectList(_context.Project, "ProjectId", "ProjectId", timeEntry.ProjectId);
            return View(timeEntry);
        }

        // GET: TimeEntry/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeEntry = await _context.TimeEntry.FindAsync(id);
            if (timeEntry == null)
            {
                return NotFound();
            }
            ViewData["ProjectId"] = new SelectList(_context.Project, "ProjectId", "ProjectId", timeEntry.ProjectId);
            return View(timeEntry);
        }

        // POST: TimeEntry/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TimeEntryId,Time,WorkDate,ProjectId")] TimeEntry timeEntry)
        {
            if (id != timeEntry.TimeEntryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(timeEntry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TimeEntryExists(timeEntry.TimeEntryId))
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
            ViewData["ProjectId"] = new SelectList(_context.Project, "ProjectId", "ProjectId", timeEntry.ProjectId);
            return View(timeEntry);
        }

        // GET: TimeEntry/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeEntry = await _context.TimeEntry
                .Include(t => t.Project)
                .FirstOrDefaultAsync(m => m.TimeEntryId == id);
            if (timeEntry == null)
            {
                return NotFound();
            }

            return View(timeEntry);
        }

        // POST: TimeEntry/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var timeEntry = await _context.TimeEntry.FindAsync(id);
            _context.TimeEntry.Remove(timeEntry);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TimeEntryExists(int id)
        {
            return _context.TimeEntry.Any(e => e.TimeEntryId == id);
        }
    }
}
