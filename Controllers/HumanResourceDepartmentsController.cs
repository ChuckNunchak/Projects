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
    public class HumanResourceDepartmentsController : Controller
    {
        private readonly RawMaterialsContext _context;
        RawMaterialsContext db;
        public HumanResourceDepartmentsController(RawMaterialsContext context)
        {
            _context = context;
            this.db = context;
        }

        // GET: HumanResourceDepartments
        public async Task<IActionResult> Index(int page = 1)
        {
            int pageSize = 5;   // количество элементов на странице

            IQueryable<HumanResourceDepartment> source = db.HumanResourcesDepartment;
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                HumanResourcesDepartment = items
            };
            return View(viewModel);
        }

        // GET: HumanResourceDepartments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var humanResourceDepartment = await _context.HumanResourcesDepartment
                .FirstOrDefaultAsync(m => m.HumanResourcesDepartmentID == id);
            if (humanResourceDepartment == null)
            {
                return NotFound();
            }

            return View(humanResourceDepartment);
        }

        // GET: HumanResourceDepartments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HumanResourceDepartments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HumanResourcesDepartmentID,Initial,LengthOfService,AcceptRawMaterials")] HumanResourceDepartment humanResourceDepartment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(humanResourceDepartment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(humanResourceDepartment);
        }

        // GET: HumanResourceDepartments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var humanResourceDepartment = await _context.HumanResourcesDepartment.FindAsync(id);
            if (humanResourceDepartment == null)
            {
                return NotFound();
            }
            return View(humanResourceDepartment);
        }

        // POST: HumanResourceDepartments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HumanResourcesDepartmentID,Initial,LengthOfService,AcceptRawMaterials")] HumanResourceDepartment humanResourceDepartment)
        {
            if (id != humanResourceDepartment.HumanResourcesDepartmentID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(humanResourceDepartment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HumanResourceDepartmentExists(humanResourceDepartment.HumanResourcesDepartmentID))
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
            return View(humanResourceDepartment);
        }

        // GET: HumanResourceDepartments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var humanResourceDepartment = await _context.HumanResourcesDepartment
                .FirstOrDefaultAsync(m => m.HumanResourcesDepartmentID == id);
            if (humanResourceDepartment == null)
            {
                return NotFound();
            }

            return View(humanResourceDepartment);
        }

        // POST: HumanResourceDepartments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var humanResourceDepartment = await _context.HumanResourcesDepartment.FindAsync(id);
            _context.HumanResourcesDepartment.Remove(humanResourceDepartment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HumanResourceDepartmentExists(int id)
        {
            return _context.HumanResourcesDepartment.Any(e => e.HumanResourcesDepartmentID == id);
        }
    }
}
