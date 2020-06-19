using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThePurrfectPaw.API.Entities
{
    public class Shelter : IEntity
    {
        [Key]
        public int ShelterId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public Location Location { get; set; }

        [ForeignKey( "Location" )]
        public int LocationId { get; set; }

        // TODO: public ICollection<Posting> Postings { get; set; } = new List<Posting>();
    }
}
