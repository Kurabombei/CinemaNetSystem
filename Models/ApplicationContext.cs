using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMVC_CinemaNetProject.Models
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }

    }
}
