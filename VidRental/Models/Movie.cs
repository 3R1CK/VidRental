using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Web;

namespace VidRental.Models
{
    public class Movie
    {   [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public String Name { get; set; }
        [Required]
        [StringLength(255)]
        public Genre Genre { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        [Required]
        public byte Stock { get; set; }
        [Required]
        public byte GenreId { get; set; }
    }
}