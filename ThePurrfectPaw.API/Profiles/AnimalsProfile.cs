using AutoMapper;
using ThePurrfectPaw.API.Entities;
using ThePurrfectPaw.API.Models.Request;

namespace ThePurrfectPaw.API.Profiles
{
    public class AnimalsProfile : Profile
    {
        public AnimalsProfile()
        {
            CreateMap<CreateAnimalDto, Animal>();
        }
    }
}
