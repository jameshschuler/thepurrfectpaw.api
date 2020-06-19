using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThePurrfectPaw.API.Entities
{
    public class Location : IEntity
    {
        [Key]
        public int LocationId { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [MaxLength(13)]
        public string State { get; set; }

        [Required]
        public string StateAbbreviation { get; set; }

        [Required]
        public string Zipcode { get; set; }

        [Required]
        public string Country { get; set; }
    }
}
