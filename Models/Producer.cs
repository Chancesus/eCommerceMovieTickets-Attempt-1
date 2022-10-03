using System.ComponentModel.DataAnnotations;

namespace eCommerceMovieTickets.Models
{
    public class Producer : PersonBase
    {
        [Key]
        public int Id { get; set; }
    }
}
