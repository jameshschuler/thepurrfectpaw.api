using System;
using System.ComponentModel.DataAnnotations;

namespace ThePurrfectPaw.API.Entities
{
    public class Animal : IEntity
    {
        [Key]
        public int AnimalId { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }
    }
}
