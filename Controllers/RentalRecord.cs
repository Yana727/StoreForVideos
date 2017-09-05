using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StoreForVideos;

namespace StoreForVideos.Controllers
{
    public class RentalRecord : Controller
    {
        private readonly superstoreContext _context;

        public RentalRecord(superstoreContext context)
        {
            _context = context;
        }

        // GET: RentalRecord
        public async Task<IActionResult> Index()
        {
            return View(await _context.RentalRecordModel.ToListAsync());
        }

        // GET: RentalRecord/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentalRecordModel = await _context.RentalRecordModel
                .SingleOrDefaultAsync(m => m.Id == id);
            if (rentalRecordModel == null)
            {
                return NotFound();
            }

            return View(rentalRecordModel);
        }

        // GET: RentalRecord/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RentalRecord/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RentalID,MovieID,CustomerID,RentalDate,DueDate,ReturnDate")] RentalRecordModel rentalRecordModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rentalRecordModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rentalRecordModel);
        }

        // GET: RentalRecord/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentalRecordModel = await _context.RentalRecordModel.SingleOrDefaultAsync(m => m.Id == id);
            if (rentalRecordModel == null)
            {
                return NotFound();
            }
            return View(rentalRecordModel);
        }

        // POST: RentalRecord/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RentalID,MovieID,CustomerID,RentalDate,DueDate,ReturnDate")] RentalRecordModel rentalRecordModel)
        {
            if (id != rentalRecordModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rentalRecordModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentalRecordModelExists(rentalRecordModel.Id))
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
            return View(rentalRecordModel);
        }

        // GET: RentalRecord/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentalRecordModel = await _context.RentalRecordModel
                .SingleOrDefaultAsync(m => m.Id == id);
            if (rentalRecordModel == null)
            {
                return NotFound();
            }

            return View(rentalRecordModel);
        }

        // POST: RentalRecord/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rentalRecordModel = await _context.RentalRecordModel.SingleOrDefaultAsync(m => m.Id == id);
            _context.RentalRecordModel.Remove(rentalRecordModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentalRecordModelExists(int id)
        {
            return _context.RentalRecordModel.Any(e => e.Id == id);
        }
    }
}
