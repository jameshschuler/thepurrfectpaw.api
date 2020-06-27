using System;
using System.ComponentModel.DataAnnotations;

namespace ThePurrfectPaw.API.Models.Request
{
    public class CreateAnimalDto
    {
        public DateTime? DateOfBirth { get; set; }

        [Required]
        [MaxLength( 100 )]
        public string FirstName { get; set; }

        [MaxLength( 100 )]
        public string LastName { get; set; }
    }
}
