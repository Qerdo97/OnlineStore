using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Models;

namespace OnlineStore.Controllers
{
    [Authorize]

    public class staffsController : Controller
    {
        private readonly OnlineStoreContext _context;

        public staffsController(OnlineStoreContext context)
        {
            _context = context;
        }

        // GET: staffs
        public async Task<IActionResult> Index()
        {
            var onlineStoreContext = _context.staff.Include(s => s.Manager).Include(s => s.Store);
            return View(await onlineStoreContext.ToListAsync());
        }

        // GET: staffs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.staff == null)
            {
                return NotFound();
            }

            var staff = await _context.staff
                .Include(s => s.Manager)
                .Include(s => s.Store)
                .FirstOrDefaultAsync(m => m.StaffId == id);
            if (staff == null)
            {
                return NotFound();
            }

            return View(staff);
        }

        // GET: staffs/Create
        public IActionResult Create()
        {
            ViewData["ManagerId"] = new SelectList(_context.staff, "StaffId", "StaffId");
            ViewData["StoreId"] = new SelectList(_context.Stores, "StoreId", "StoreId");
            return View();
        }

        // POST: staffs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [TempData]
        public string Message { get; set; }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StaffId,FirstName,LastName,Email,Phone,IsActive,StoreId,ManagerId,CreatedDate,CreatedBy,LastModifiedDate,LastModifiedBy")] staff staff)
        {
            try
            {
                _context.Add(staff);
                await _context.SaveChangesAsync();
                Message = "Staff created successfully";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewData["ManagerId"] = new SelectList(_context.staff, "StaffId", "StaffId", staff.ManagerId);
                ViewData["StoreId"] = new SelectList(_context.Stores, "StoreId", "StoreId", staff.StoreId);
                return View(staff);
            }

        }

        // GET: staffs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.staff == null)
            {
                return NotFound();
            }

            var staff = await _context.staff.FindAsync(id);
            if (staff == null)
            {
                return NotFound();
            }
            ViewData["ManagerId"] = new SelectList(_context.staff, "StaffId", "StaffId", staff.ManagerId);
            ViewData["StoreId"] = new SelectList(_context.Stores, "StoreId", "StoreId", staff.StoreId);
            return View(staff);
        }

        // POST: staffs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StaffId,FirstName,LastName,Email,Phone,IsActive,StoreId,ManagerId,CreatedDate,CreatedBy,LastModifiedDate,LastModifiedBy")] staff staff)
        {
            if (id != staff.StaffId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(staff);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!staffExists(staff.StaffId))
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
            ViewData["ManagerId"] = new SelectList(_context.staff, "StaffId", "StaffId", staff.ManagerId);
            ViewData["StoreId"] = new SelectList(_context.Stores, "StoreId", "StoreId", staff.StoreId);
            return View(staff);
        }

        // GET: staffs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.staff == null)
            {
                return NotFound();
            }

            var staff = await _context.staff
                .Include(s => s.Manager)
                .Include(s => s.Store)
                .FirstOrDefaultAsync(m => m.StaffId == id);
            if (staff == null)
            {
                return NotFound();
            }

            return View(staff);
        }

        // POST: staffs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.staff == null)
            {
                return Problem("Entity set 'OnlineStoreContext.staff'  is null.");
            }
            var staff = await _context.staff.FindAsync(id);
            if (staff != null)
            {
                _context.staff.Remove(staff);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool staffExists(int id)
        {
          return (_context.staff?.Any(e => e.StaffId == id)).GetValueOrDefault();
        }
    }
}
