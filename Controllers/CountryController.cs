using BasicMVC_CinemaNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicMVC_CinemaNetProject.Controllers
{
    public class CountryController : Controller
    {
        ApplicationContext db = new ApplicationContext();
        // GET: Country
        public ActionResult Index()
        {
            IEnumerable<Country> countries = db.Countries;
            ViewBag.Countries = countries;
            return View();
        }

        // GET: Country/Details/5
        public ActionResult Details(int id)
        {
            Country country = db.Countries.Find(id);
            return View();
        }

        // GET: Country/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Country/Create
        [HttpPost]
        public ActionResult Create(Country country)
        {
            try
            {
                // TODO: Add insert logic here
                db.Countries.Add(country);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Country/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Country/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Country country)
        {
            try
            {
                // TODO: Add update logic here
                Country countryToUpdate = db.Countries.Find(id);
                countryToUpdate.Name = country.Name;
                countryToUpdate.NationalLanguage = country.NationalLanguage;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Country/Delete/5
        public ActionResult Delete(int id)
        {
            Country countryToDelete = db.Countries.Find(id);
            if (countryToDelete != null)
            {
                db.Countries.Remove(countryToDelete);
                db.SaveChanges();
                RedirectToAction("Index");
            } else
            {
                Console.WriteLine("Country with id = " + id + " does not exist.");
            }
            return RedirectToAction("Index");
        }

        // POST: Country/Delete/5
        [HttpPost]
        public ActionResult Delete(Country countryToDelete)
        {
            try
            {
                db.Countries.Remove(countryToDelete);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
    }
}
