using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movies_system.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        //public Author Author { get; set; }
        public ICollection<MovieActor> MovieActors { get; set; }
        public ICollection<MovieGenre> MovieGenres { get; set; }
    }
}
