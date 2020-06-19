using System;

namespace ThePurrfectPaw.API.Models.Response
{
    public class PostingDto
    {
        public int PostingId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime PostDate { get; set; }

        public double Age { get { return (DateTime.Now - PostDate).TotalDays; } }

        public int ShelterId { get; set; }

        public string ShelterName { get; set; }
    }
}
