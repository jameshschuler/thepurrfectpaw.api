using System;

namespace ThePurrfectPaw.API.Models.Response
{
    public class PostingDto
    {
        public int AnimalId { get; set; }

        public string AnimalName { get; set; }

        public string City { get; set; }

        public int LocationId { get; set; }
        
        public int PostingId { get; set; }

        public double PostingAge { get { return (DateTime.Now - PostDate).TotalDays; } }
        
        public string State { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime PostDate { get; set; }

        public int ShelterId { get; set; }

        public string ShelterName { get; set; }
    }
}
