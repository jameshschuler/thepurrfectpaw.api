using AutoMapper;
using ThePurrfectPaw.API.Entities;
using ThePurrfectPaw.API.Models.Response;

namespace ThePurrfectPaw.API.Profiles
{
    public class SheltersProfile : Profile
    {
        public SheltersProfile()
        {
            CreateMap<Shelter, ShelterDto>();
        }
    }
}
