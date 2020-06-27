using AutoMapper;
using ThePurrfectPaw.API.Entities;
using ThePurrfectPaw.API.Models.Request;
using ThePurrfectPaw.API.Models.Response;

namespace ThePurrfectPaw.API.Profiles
{
    public class PostingsProfile : Profile
    {
        public PostingsProfile()
        {
            CreateMap<Posting, PostingDto>()
                .ForMember(
                    dest => dest.AnimalName,
                    opt => opt.MapFrom(src => $"{src.Animal.FirstName} {src.Animal.LastName}".Trim())
                )
                .ForMember(
                    dest => dest.LocationId,
                    opt => opt.MapFrom( src => src.Shelter.Location.LocationId )
                )
                .ForMember(
                    dest => dest.City,
                    opt => opt.MapFrom( src => src.Shelter.Location.City )
                )
                .ForMember(
                    dest => dest.State,
                    opt => opt.MapFrom( src => src.Shelter.Location.State )
                );

            CreateMap<CreatePostingDto, Posting>();
        }
    }
}
