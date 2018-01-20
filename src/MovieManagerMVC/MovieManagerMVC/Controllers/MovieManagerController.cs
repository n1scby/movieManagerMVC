using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using nb.MovieLibrary;

namespace MovieManagerMVC.Controllers
{
    public class MovieManagerController : Controller
    {
        MovieRepository _movieRepo = new MovieRepository();

        // If List isn't there, create one and redisplay
        public ActionResult BuildList()
        {
            _movieRepo.BuildMovieList();
            return View(_movieRepo.ListMovies());
           
        }



        // GET: MovieManager
        public ActionResult Index()
        {
            return View(_movieRepo.ListMovies());
        }

        // GET: MovieManager/Details/5
        public ActionResult Details(int id)
        {
            return View(_movieRepo.GetMovieById(id));
        }

        // GET: MovieManager/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieManager/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie newMovie, IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                _movieRepo.Add(newMovie);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieManager/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_movieRepo.GetMovieById(id));
        }

        // POST: MovieManager/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Movie updatedMovie, int id, IFormCollection collection)
        {
            try
            {
                _movieRepo.Edit(updatedMovie);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieManager/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_movieRepo.GetMovieById(id));
        }

        // POST: MovieManager/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                _movieRepo.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}