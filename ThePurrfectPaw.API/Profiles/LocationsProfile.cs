using AutoMapper;
using ThePurrfectPaw.API.Entities;
using ThePurrfectPaw.API.Models.Response;

namespace ThePurrfectPaw.API.Profiles
{
    public class LocationsProfile : Profile
    {
        public LocationsProfile()
        {
            CreateMap<Location, LocationDto>();
        }
    }
}
