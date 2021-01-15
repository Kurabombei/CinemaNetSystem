using System;
using BasicMVC_CinemaNetProject;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicMVC_CinemaNetProject.Models;

namespace BasicMVC_CinemaNetProject.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string NationalLanguage { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}