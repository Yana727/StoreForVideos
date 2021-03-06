using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StoreForVideos;
using StoreForVideos.Models;

namespace StoreForVideos.Controllers
{
    public class MoviesController : Controller
    {
        private readonly superstoreContext _context;

        public MoviesController(superstoreContext context)
        {
            _context = context;
        }

        // GET: Movies
        public async Task<IActionResult> Index()
        {
            return View(await _context.MovieModel.ToListAsync());
        }


        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieModel = await _context.MovieModel  //finds the movie
                .SingleOrDefaultAsync(m => m.Id == id);
            if (movieModel == null)           //render the movie 
            {
                return NotFound();
            }

            return View(movieModel);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MovieName,MovieDescription,GenreID")] MovieModel movieModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movieModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movieModel);
        }
        //GET: Checked in/Checked out//Added by ME today 9/6
        public async Task<IActionResult>CheckOut (int? id) //USE THIS !
        {
            var movieModel = await _context.MovieModel  //using id to find the movie 
                .SingleOrDefaultAsync(m => m.Id == id);
            
            // Update that movie as checkedout
            movieModel.CheckedOut = true;

            _context.Update(movieModel);
            await _context.SaveChangesAsync();
            
            // Then redirect them back to the list of movies
            return RedirectToAction(nameof(Index));
        }
             public async Task<IActionResult>CheckIn (int? id) //
        {
            var movieModel = await _context.MovieModel  //using id to find the movie 
                .SingleOrDefaultAsync(m => m.Id == id);
            
            // Update that movie as checked in
            movieModel.CheckedOut = false;

            _context.Update(movieModel);
            await _context.SaveChangesAsync();
            
            // Then redirect them back to the list of movies
            return RedirectToAction(nameof(Index));
        }


        // GET: Movies/Edit/5 
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieModel = await _context.MovieModel.SingleOrDefaultAsync(m => m.Id == id);
            if (movieModel == null)
            {
                return NotFound();
            }
            return View(movieModel);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MovieName,MovieDescription,GenreID")] MovieModel movieModel)
        {
            if (id != movieModel.Id)
            {
                return NotFound();                //USE THIS CODE TO DO THE CHECK OUT LOGIC
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movieModel); //something else 
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieModelExists(movieModel.Id))
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
            return View(movieModel);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieModel = await _context.MovieModel
                .SingleOrDefaultAsync(m => m.Id == id);
            if (movieModel == null)
            {
                return NotFound();
            }

            return View(movieModel);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movieModel = await _context.MovieModel.SingleOrDefaultAsync(m => m.Id == id);
            _context.MovieModel.Remove(movieModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieModelExists(int id)
        {
            return _context.MovieModel.Any(e => e.Id == id);
        }
    }
}
