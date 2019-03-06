using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movies_system.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<MovieActor> MovieActors { get; set; }
        //public Author Author { get; set; }
        //public ICollection<> BookCategories { get; set; }
    }
}
