using BasicMVC_CinemaNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicMVC_CinemaNetProject.Controllers
{
    public class CinemaController : Controller
    {
        ApplicationContext db = new ApplicationContext();

        // GET: Cinema
        public ActionResult Index()
        {
            IEnumerable<Cinema> cinemas = db.Cinemas;
            ViewBag.Cinemas = cinemas;
            return View();
        }
        // GET: Cinema/Details/5
        public ActionResult Details(int id)
        {
            Cinema cinema = db.Cinemas.Find(id);
            ViewBag.Cinema = cinema;
            return View();
        }

        // GET: Cinema/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cinema/Create
        [HttpPost]
        public ActionResult Create(Cinema cinema)
        {
            try
            {
                cinema.Cities = db.Cities.Find(cinema.CitiesID);
                // TODO: Add insert logic here
                db.Cinemas.Add(cinema);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cinema/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cinema/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Cinema cinema) //FormCollection collection
        {
            try
            {
                // TODO: Add update logic here
                Cinema cinemaToEdit = db.Cinemas.Find(id);
                cinemaToEdit.Name = cinema.Name;
                cinemaToEdit.Street = cinema.Street;
                cinemaToEdit.Email = cinema.Email;
                cinemaToEdit.CitiesID = cinema.CitiesID;
                cinemaToEdit.Cities = db.Cities.Find(cinemaToEdit.CitiesID);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cinema/Delete/5
        public ActionResult Delete(int id)
        {
            Cinema cinemaToDelete = db.Cinemas.Find(id);
            if (cinemaToDelete != null)
            {
                db.Cinemas.Remove(cinemaToDelete);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Cinema with id = " + id + " does not exist.");
            }
            return RedirectToAction("Index");
        }

        // POST: Cinema/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Cinema cinema)
        {
            try
            {
                // TODO: Add delete logic here
                db.Cinemas.Remove(cinema);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
