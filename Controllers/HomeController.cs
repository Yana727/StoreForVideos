using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreForVideos.Models;

namespace StoreForVideos.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly superstoreContext _context; //database
        public HomeController(superstoreContext context)
        {
            this._context = context;
        }
        public IActionResult Seed()
        {
            // Create genres, movies, and customers for our database.
            var seedGenre = new List<GenreModel>(){
               new GenreModel
                {
                    GenreName = "Horror"
                },
               new GenreModel
                {
                    GenreName = "Comedy"
                },
                new GenreModel
                {
                    GenreName = "Action"
                }
            };
            var seedMovies = new List<MovieModel>()
            {
                new MovieModel
                {
                MovieName = "John Wick",
                MovieDescription = "Shootem Bang Bang",
                GenreID = 3
                },
                new MovieModel
                {
                MovieName = "SuperBad",
                MovieDescription = "Laugh Haha",
                GenreID = 2
                },
                new MovieModel
                {
                MovieName = "Evil Dead",
                MovieDescription = "Scary Run scared",
                GenreID = 1
                }
            };
            var seedCustomers = new List<CustomerModel>()
            {
                new CustomerModel
                {
                    CustomerName = "Robby",
                    CustomerPhone = 8675309
                },
                new CustomerModel
                {
                    CustomerName = "Barandyn",
                    CustomerPhone = 1234567
                },
                new CustomerModel
                {
                    CustomerName = "Jeremiah",
                    CustomerPhone = 9876543
                }
            };

            // Adding all of the dummy data to our database
            seedCustomers.ForEach(person => _context.CustomerModel.Add(person));
            seedGenre.ForEach(genre => _context.GenreModel.Add(genre));
            seedMovies.ForEach(vid => _context.MovieModel.Add(vid));

            // saving the changes..
            _context.SaveChanges();

            return Ok();
        }

        public IActionResult Index()
        {
            return View(new List<MovieModel>());
        }
    
        public IActionResult Movies()
        {
            return View(_context.MovieModel.ToList());
        }

        public IActionResult RentalRecord()
        {
            return View(_context.RentalRecordModel.ToList());
        }

        public IActionResult Returned()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
