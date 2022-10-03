using System.ComponentModel.DataAnnotations;

namespace eCommerceMovieTickets.Models
{
    public class Actor : PersonBase
    {
        [Key]
        public int Id { get; set; }
    }
}
