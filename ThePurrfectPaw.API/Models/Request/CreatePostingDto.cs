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
        public int? AnimalId { get; set; }

        [Required]
        public int? ShelterId { get; set; }

        [Required]
        public int? LocationId { get; set; }
    }
}
