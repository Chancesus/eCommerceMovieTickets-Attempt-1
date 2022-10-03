using eCommerceMovieTickets.Data;
using System.ComponentModel.DataAnnotations;

namespace eCommerceMovieTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }   
        public string Description { get; set; }
        public float Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        
    }
}
