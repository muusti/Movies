using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities
{
    public class MovieActor
    {
        [Key]
        [Column(Order = 0)]
        public int? MovieId { get; set; }
        public Movie? Movie { get; set; }

        [Key]
        [Column(Order = 1)]
        public int? ActorId { get; set; }
        public Actor? Actor { get; set; }


    }
}
