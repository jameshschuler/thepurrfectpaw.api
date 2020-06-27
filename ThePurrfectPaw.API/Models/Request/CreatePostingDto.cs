using System.ComponentModel.DataAnnotations;

namespace ThePurrfectPaw.API.Models.Request
{
    public class CreatePostingDto
    {
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public bool IsPublic { get; set; }

        [Required]
        public CreateAnimalDto Animal { get; set; }

        [Required]
        public CreateShelterDto Shelter { get; set; }
    }
}
