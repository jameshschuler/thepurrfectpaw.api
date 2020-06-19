using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThePurrfectPaw.API.Entities
{
    public class Posting : IEntity
    {
        [Key]
        public int PostingId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime PostDate { get; set; }

        public bool IsPublic { get; set; } = true;

        public Shelter Shelter { get; set; }

        [ForeignKey("Shelter")]
        public int ShelterId { get; set; }
        
        public Animal Animal { get; set; }

        [ForeignKey( "Animal" )]
        public int AnimalId { get; set; }
    }
}
