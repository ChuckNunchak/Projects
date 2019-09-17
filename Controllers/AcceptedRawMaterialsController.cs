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
    public class AcceptedRawMaterialsController : Controller
    {
        private readonly RawMaterialsContext _context;
        RawMaterialsContext db;
        public AcceptedRawMaterialsController(RawMaterialsContext context)
        {
            _context = context;
            this.db = context;
        }

        // GET: AcceptedRawMaterials
        public async Task<IActionResult> Index(int page = 1)
        {
            int pageSize = 5;   // количество элементов на странице


            IQueryable<AcceptedRawMaterial> source = db.AcceptedRawMaterials.Include(a => a.HumanResourceDepartment).Include(a => a.RawMaterial);
            
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,               
                AcceptedRawMaterials = items
            };
            return View(viewModel);
        }

        // GET: AcceptedRawMaterials/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acceptedRawMaterial = await _context.AcceptedRawMaterials
                .Include(a => a.HumanResourceDepartment)
                .Include(a => a.RawMaterial)
                .FirstOrDefaultAsync(m => m.AcceptedRawMaterialsID == id);
            if (acceptedRawMaterial == null)
            {
                return NotFound();
            }

            return View(acceptedRawMaterial);
        }

        // GET: AcceptedRawMaterials/Create
        public IActionResult Create()
        {
            ViewData["HumanResourcesDepartmentID"] = new SelectList(_context.HumanResourcesDepartment, "HumanResourcesDepartmentID", "HumanResourcesDepartmentID");
            ViewData["RawMaterialsID"] = new SelectList(_context.RawMaterials, "RawMaterialsID", "RawMaterialsID");
            return View();
        }

        // POST: AcceptedRawMaterials/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AcceptedRawMaterialsID,TypeOfRawMaterials,NumberKG,Employee,RoomOfStorage,DateAndTime,Cost,RawMaterialsID,HumanResourcesDepartmentID,StoragesID")] AcceptedRawMaterial acceptedRawMaterial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(acceptedRawMaterial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HumanResourcesDepartmentID"] = new SelectList(_context.HumanResourcesDepartment, "HumanResourcesDepartmentID", "HumanResourcesDepartmentID", acceptedRawMaterial.HumanResourcesDepartmentID);
            ViewData["RawMaterialsID"] = new SelectList(_context.RawMaterials, "RawMaterialsID", "RawMaterialsID", acceptedRawMaterial.RawMaterialsID);
            return View(acceptedRawMaterial);
        }

        // GET: AcceptedRawMaterials/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acceptedRawMaterial = await _context.AcceptedRawMaterials.FindAsync(id);
            if (acceptedRawMaterial == null)
            {
                return NotFound();
            }
            ViewData["HumanResourcesDepartmentID"] = new SelectList(_context.HumanResourcesDepartment, "HumanResourcesDepartmentID", "HumanResourcesDepartmentID", acceptedRawMaterial.HumanResourcesDepartmentID);
            ViewData["RawMaterialsID"] = new SelectList(_context.RawMaterials, "RawMaterialsID", "RawMaterialsID", acceptedRawMaterial.RawMaterialsID);
            return View(acceptedRawMaterial);
        }

        // POST: AcceptedRawMaterials/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AcceptedRawMaterialsID,TypeOfRawMaterials,NumberKG,Employee,RoomOfStorage,DateAndTime,Cost,RawMaterialsID,HumanResourcesDepartmentID,StoragesID")] AcceptedRawMaterial acceptedRawMaterial)
        {
            if (id != acceptedRawMaterial.AcceptedRawMaterialsID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(acceptedRawMaterial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AcceptedRawMaterialExists(acceptedRawMaterial.AcceptedRawMaterialsID))
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
            ViewData["HumanResourcesDepartmentID"] = new SelectList(_context.HumanResourcesDepartment, "HumanResourcesDepartmentID", "HumanResourcesDepartmentID", acceptedRawMaterial.HumanResourcesDepartmentID);
            ViewData["RawMaterialsID"] = new SelectList(_context.RawMaterials, "RawMaterialsID", "RawMaterialsID", acceptedRawMaterial.RawMaterialsID);
            return View(acceptedRawMaterial);
        }

        // GET: AcceptedRawMaterials/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acceptedRawMaterial = await _context.AcceptedRawMaterials
                .Include(a => a.HumanResourceDepartment)
                .Include(a => a.RawMaterial)
                .FirstOrDefaultAsync(m => m.AcceptedRawMaterialsID == id);
            if (acceptedRawMaterial == null)
            {
                return NotFound();
            }

            return View(acceptedRawMaterial);
        }

        // POST: AcceptedRawMaterials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var acceptedRawMaterial = await _context.AcceptedRawMaterials.FindAsync(id);
            _context.AcceptedRawMaterials.Remove(acceptedRawMaterial);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AcceptedRawMaterialExists(int id)
        {
            return _context.AcceptedRawMaterials.Any(e => e.AcceptedRawMaterialsID == id);
        }
    }
}
