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
    public class TypeOfStoragesController : Controller
    {
        private readonly RawMaterialsContext _context;

        RawMaterialsContext db;

        public TypeOfStoragesController(RawMaterialsContext context)
        {
            _context = context;
            this.db = context;
        }

        // GET: TypeOfStorages
        public async Task<IActionResult> Index(int page = 1)
        {
            int pageSize = 5;   // количество элементов на странице

            IQueryable<TypeOfStorage> source = db.TypeOfStorages;
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                TypeOfStorages = items
            };
            return View(viewModel);
        }

        // GET: TypeOfStorages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeOfStorage = await _context.TypeOfStorages
                .FirstOrDefaultAsync(m => m.TypeOfStoragesID == id);
            if (typeOfStorage == null)
            {
                return NotFound();
            }

            return View(typeOfStorage);
        }

        // GET: TypeOfStorages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TypeOfStorages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TypeOfStoragesID,NameOfTypeOfStorages,TypesOfRawMaterialsInStorage,FireProtection,SpecialEquipment,Humidity")] TypeOfStorage typeOfStorage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(typeOfStorage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typeOfStorage);
        }

        // GET: TypeOfStorages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeOfStorage = await _context.TypeOfStorages.FindAsync(id);
            if (typeOfStorage == null)
            {
                return NotFound();
            }
            return View(typeOfStorage);
        }

        // POST: TypeOfStorages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TypeOfStoragesID,NameOfTypeOfStorages,TypesOfRawMaterialsInStorage,FireProtection,SpecialEquipment,Humidity")] TypeOfStorage typeOfStorage)
        {
            if (id != typeOfStorage.TypeOfStoragesID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typeOfStorage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypeOfStorageExists(typeOfStorage.TypeOfStoragesID))
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
            return View(typeOfStorage);
        }

        // GET: TypeOfStorages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeOfStorage = await _context.TypeOfStorages
                .FirstOrDefaultAsync(m => m.TypeOfStoragesID == id);
            if (typeOfStorage == null)
            {
                return NotFound();
            }

            return View(typeOfStorage);
        }

        // POST: TypeOfStorages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var typeOfStorage = await _context.TypeOfStorages.FindAsync(id);
            _context.TypeOfStorages.Remove(typeOfStorage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypeOfStorageExists(int id)
        {
            return _context.TypeOfStorages.Any(e => e.TypeOfStoragesID == id);
        }
    }
}
