namespace ThePurrfectPaw.API.Models.Response
{
    public class ShelterDto
    {
        public int ShelterId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public LocationDto Location { get; set; }
    }
}
