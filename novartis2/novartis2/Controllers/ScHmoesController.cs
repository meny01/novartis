using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MSContext;
using novartis2.Data;

namespace novartis2.Controllers
{
    public class ScHmoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ScHmoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ScHmoes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ScHmos.Include(s => s.CreatorAccount).Include(s => s.ModifierAccount);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ScHmoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scHmo = await _context.ScHmos
                .Include(s => s.CreatorAccount)
                .Include(s => s.ModifierAccount)
                .SingleOrDefaultAsync(m => m.HmoId == id);
            if (scHmo == null)
            {
                return NotFound();
            }

            return View(scHmo);
        }

        // GET: ScHmoes/Create
        public IActionResult Create()
        {
            ViewData["CreatorAccountId"] = new SelectList(_context.accounts, "AccountId", "FirstName");
            ViewData["ModifierAccountId"] = new SelectList(_context.accounts, "AccountId", "FirstName");
            return View();
        }

        // POST: ScHmoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HmoId,HmoName,DateCreated,DateModified,IsActive,CreatorAccountId,ModifierAccountId")] ScHmo scHmo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(scHmo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CreatorAccountId"] = new SelectList(_context.accounts, "AccountId", "FirstName", scHmo.CreatorAccountId);
            ViewData["ModifierAccountId"] = new SelectList(_context.accounts, "AccountId", "FirstName", scHmo.ModifierAccountId);
            return View(scHmo);
        }

        // GET: ScHmoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scHmo = await _context.ScHmos.SingleOrDefaultAsync(m => m.HmoId == id);
            if (scHmo == null)
            {
                return NotFound();
            }
            ViewData["CreatorAccountId"] = new SelectList(_context.accounts, "AccountId", "FirstName", scHmo.CreatorAccountId);
            ViewData["ModifierAccountId"] = new SelectList(_context.accounts, "AccountId", "FirstName", scHmo.ModifierAccountId);
            return View(scHmo);
        }

        // POST: ScHmoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HmoId,HmoName,DateCreated,DateModified,IsActive,CreatorAccountId,ModifierAccountId")] ScHmo scHmo)
        {
            if (id != scHmo.HmoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scHmo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScHmoExists(scHmo.HmoId))
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
            ViewData["CreatorAccountId"] = new SelectList(_context.accounts, "AccountId", "FirstName", scHmo.CreatorAccountId);
            ViewData["ModifierAccountId"] = new SelectList(_context.accounts, "AccountId", "FirstName", scHmo.ModifierAccountId);
            return View(scHmo);
        }

        // GET: ScHmoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scHmo = await _context.ScHmos
                .Include(s => s.CreatorAccount)
                .Include(s => s.ModifierAccount)
                .SingleOrDefaultAsync(m => m.HmoId == id);
            if (scHmo == null)
            {
                return NotFound();
            }

            return View(scHmo);
        }

        // POST: ScHmoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var scHmo = await _context.ScHmos.SingleOrDefaultAsync(m => m.HmoId == id);
            _context.ScHmos.Remove(scHmo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScHmoExists(int id)
        {
            return _context.ScHmos.Any(e => e.HmoId == id);
        }
    }
}
