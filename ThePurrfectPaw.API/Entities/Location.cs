using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThePurrfectPaw.API.Entities
{
    public class Location : IEntity
    {
        [Key]
        public int LocationId { get; set; }

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

        public ICollection<Animal> Animals { get; set; } = new List<Animal>();
    }
}
