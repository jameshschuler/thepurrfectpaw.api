using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThePurrfectPaw.API.Entities
{
    public class Animal : IEntity
    {
        [Key]
        public int AnimalId { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }

        [ForeignKey("ShelterId")]
        public Shelter Shelter { get; set; }

        public int ShelterId { get; set; }
    }
}
