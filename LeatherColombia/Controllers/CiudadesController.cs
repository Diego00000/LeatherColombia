using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeatherColombia.Data;
using LeatherColombia.Models;

namespace LeatherColombia.Controllers
{
    public class CiudadesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CiudadesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ciudades
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ciudad.ToListAsync());
        }

        // GET: Ciudades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciudad = await _context.Ciudad
                .FirstOrDefaultAsync(m => m.CiudadID == id);
            if (ciudad == null)
            {
                return NotFound();
            }

            return View(ciudad);
        }

        // GET: Ciudades/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ciudades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CiudadID,Nombre")] Ciudad ciudad)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ciudad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ciudad);
        }

        // GET: Ciudades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciudad = await _context.Ciudad.FindAsync(id);
            if (ciudad == null)
            {
                return NotFound();
            }
            return View(ciudad);
        }

        // POST: Ciudades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CiudadID,Nombre")] Ciudad ciudad)
        {
            if (id != ciudad.CiudadID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ciudad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CiudadExists(ciudad.CiudadID))
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
            return View(ciudad);
        }

        // GET: Ciudades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciudad = await _context.Ciudad
                .FirstOrDefaultAsync(m => m.CiudadID == id);
            if (ciudad == null)
            {
                return NotFound();
            }

            return View(ciudad);
        }

        // POST: Ciudades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ciudad = await _context.Ciudad.FindAsync(id);
            _context.Ciudad.Remove(ciudad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CiudadExists(int id)
        {
            return _context.Ciudad.Any(e => e.CiudadID == id);
        }
    }
}
