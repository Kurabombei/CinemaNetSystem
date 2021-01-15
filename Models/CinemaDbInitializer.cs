using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BasicMVC_CinemaNetProject.Models;

namespace BasicMVC_CinemaNetProject.Models
{

    public class CinemaDbInitializer : DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext db)
        {
            Country c1 = new Country { Name = "Ukraine", NationalLanguage = "Ukrainian" };
            Country c2 = new Country { Name = "Japan", NationalLanguage = "Japanese" };
            Country c3 = new Country { Name = "France", NationalLanguage = "French" };
            db.Countries.Add(c1);
            db.Countries.Add(c2);
            db.Countries.Add(c3);

            City ci1 = new City { Name = "Lviv", Population = 740000, Country = c1 };
            City ci2 = new City { Name = "Tokyo", Population = 664046, Country = c2 };
            City ci3 = new City { Name = "Paris", Population = 2148000, Country = c3 };
            City ci4 = new City { Name = "Kyiv", Population = 2420500, Country = c1 };
            db.Cities.Add(ci1);
            db.Cities.Add(ci2);
            db.Cities.Add(ci3);
            db.Cities.Add(ci4);

            db.Cinemas.Add(new Cinema { Name = "ParisTheatermua", Street = "St Demus'", Email = "Supercinema@fff.com", Cities = ci3 });
            db.Cinemas.Add(new Cinema { Name = "PlanetakinoImax", Street = "Pid dubom 7", Email = "Planetakino@fff.com", Cities = ci1 });
            db.Cinemas.Add(new Cinema { Name = "Kiokushinkawa", Street = "Somewhere 5a", Email = "Kio@fff.com", Cities = ci2 });

            base.Seed(db);
        }
    }

}