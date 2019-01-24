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
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public String Name { get; set; }
        
        [StringLength(255)]
        public Genre Genre { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [Display(Name="Date Added")]
        public DateTime DateAdded { get; set; }
        [Required]
        [Range(1, 20)]
        [Display(Name="Number in Stock")]
        public byte Stock { get; set; }
        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
    }
}