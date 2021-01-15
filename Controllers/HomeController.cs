using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BasicMVC_CinemaNetProject.Models;

namespace BasicMVC_CinemaNetProject.Controllers
{
    
    public class HomeController : Controller
    {
        ApplicationContext db = new ApplicationContext();
        
        public ActionResult Index()
        {
            IEnumerable<Country> countries = db.Countries;
            ViewBag.Countries = countries;
            IEnumerable<City> cities = db.Cities;
            ViewBag.Cities = cities;
            IEnumerable<Cinema> cinemas = db.Cinemas;
            ViewBag.Cinemas = cinemas;
            IEnumerable<Cinema> filteredCinemas = cinemas.Where(o => o.CitiesID == 3);
            //.ToList();
            ViewBag.Cinemas = filteredCinemas;
            return View();

        }
        public ActionResult sacredLink()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetQuery(int id)
        {
            ViewBag.BookId = id;
            return View();
        }
        [HttpPost]
        public string Add(Country country)
        {
            
            db.Countries.Add(country);
            db.SaveChanges();
            return "Country " + country.Name + " was successfully added !";
        }
    }
}