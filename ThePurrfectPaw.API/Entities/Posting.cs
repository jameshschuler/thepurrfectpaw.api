using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
