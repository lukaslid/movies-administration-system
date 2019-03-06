using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movies_system.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<MovieGenre> MovieGenres { get; set; }
    }
}
