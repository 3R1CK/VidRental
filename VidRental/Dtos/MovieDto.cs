using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidRental.Dtos
{
    public class MovieDto
    {
        
        public int Id { get; set; }
       
        public String Name { get; set; }

        public DateTime ReleaseDate { get; set; }
       
        public DateTime DateAdded { get; set; }
        
        public byte Stock { get; set; }
      
        public byte GenreId { get; set; }

        public GenreDto Genre { get; set; }
    }
}