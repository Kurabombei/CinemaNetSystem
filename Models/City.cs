using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicMVC_CinemaNetProject.Models;


namespace BasicMVC_CinemaNetProject.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Population { get; set; }

        public virtual Country Country { get; set; }
        public int CountryId { get; set; }
        public virtual ICollection<Cinema> Cinemas { get; set; }
    }
}
