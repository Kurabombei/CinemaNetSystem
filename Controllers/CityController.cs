using BasicMVC_CinemaNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicMVC_CinemaNetProject.Controllers
{
    public class CityController : Controller
    {
        ApplicationContext db = new ApplicationContext();
        // GET: City
        public ActionResult Index()
        {
            IEnumerable<City> cities = db.Cities;
            ViewBag.Cities = cities;
            return View();
        }

        // GET: City/Details/5
        public ActionResult Details(int id)
        {
            City city = db.Cities.Find(id);
            ViewBag.City = city;
            return View();
        }

        // GET: City/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: City/Create
        [HttpPost]
        public ActionResult Create(City city)
        {
            try
            {
                city.Country = db.Countries.Find(city.CountryId);
                // TODO: Add insert logic here
                db.Cities.Add(city);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: City/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: City/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, City city)
        {
            try
            {
                // TODO: Add update logic here
                City cityToUpdate = db.Cities.Find(id);
                cityToUpdate.Name = city.Name;
                cityToUpdate.Population = city.Population;
                cityToUpdate.CountryId = city.CountryId;
                cityToUpdate.Country = db.Countries.Find(cityToUpdate.CountryId);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: City/Delete/5
        public ActionResult Delete(int id)
        {
            City cityToDelete = db.Cities.Find(id);
            if (cityToDelete != null)
            {
                db.Cities.Remove(cityToDelete);
                db.SaveChanges();
                RedirectToAction("Index");
            }
            else
            {
                Console.WriteLine("City with id = " + id + " does not exist.");
            }
            return RedirectToAction("Index");
        }

        // POST: City/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, City city)
        {
            try
            {
                // TODO: Add delete logic here
                db.Cities.Remove(city);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
    }
}
