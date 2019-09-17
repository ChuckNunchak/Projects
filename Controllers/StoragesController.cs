using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StoragesController : Controller
    {
        private readonly RawMaterialsContext _context;

        RawMaterialsContext db;
        public StoragesController(RawMaterialsContext context)
        {
            _context = context;
            this.db = context;
        }

        // GET: Storages
        public async Task<IActionResult> Index(int page = 1)
        {
            int pageSize = 5;   // количество элементов на странице

            IQueryable<Storage> source = db.Storages.Include(a => a.TypeOfStorage);
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Storages = items
            };
            return View(viewModel);
        }

        // GET: Storages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storage = await _context.Storages
                .Include(s => s.TypeOfStorage)
                .FirstOrDefaultAsync(m => m.StoragesID == id);
            if (storage == null)
            {
                return NotFound();
            }

            return View(storage);
        }

        // GET: Storages/Create
        public IActionResult Create()
        {
            ViewData["TypeOfStoragesID"] = new SelectList(_context.TypeOfStorages, "TypeOfStoragesID", "TypeOfStoragesID");
            return View();
        }

        // POST: Storages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StoragesID,NameOfStorage,InventoryNumber,DesignatedEmployee,SquareOfStorage,Tonnage,FillingPercentage,TypeOfStoragesID")] Storage storage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(storage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TypeOfStoragesID"] = new SelectList(_context.TypeOfStorages, "TypeOfStoragesID", "TypeOfStoragesID", storage.TypeOfStoragesID);
            return View(storage);
        }

        // GET: Storages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storage = await _context.Storages.FindAsync(id);
            if (storage == null)
            {
                return NotFound();
            }
            ViewData["TypeOfStoragesID"] = new SelectList(_context.TypeOfStorages, "TypeOfStoragesID", "TypeOfStoragesID", storage.TypeOfStoragesID);
            return View(storage);
        }

        // POST: Storages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StoragesID,NameOfStorage,InventoryNumber,DesignatedEmployee,SquareOfStorage,Tonnage,FillingPercentage,TypeOfStoragesID")] Storage storage)
        {
            if (id != storage.StoragesID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(storage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StorageExists(storage.StoragesID))
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
            ViewData["TypeOfStoragesID"] = new SelectList(_context.TypeOfStorages, "TypeOfStoragesID", "TypeOfStoragesID", storage.TypeOfStoragesID);
            return View(storage);
        }

        // GET: Storages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storage = await _context.Storages
                .Include(s => s.TypeOfStorage)
                .FirstOrDefaultAsync(m => m.StoragesID == id);
            if (storage == null)
            {
                return NotFound();
            }

            return View(storage);
        }

        // POST: Storages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var storage = await _context.Storages.FindAsync(id);
            _context.Storages.Remove(storage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StorageExists(int id)
        {
            return _context.Storages.Any(e => e.StoragesID == id);
        }
    }
}
