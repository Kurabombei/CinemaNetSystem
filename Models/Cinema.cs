using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicMVC_CinemaNetProject;
using BasicMVC_CinemaNetProject.Models;

namespace BasicMVC_CinemaNetProject.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Street { get; set; }
        public string Email { get; set; }

        public virtual City Cities { get; set; }
        public int CitiesID { get; set; }
    }
}
