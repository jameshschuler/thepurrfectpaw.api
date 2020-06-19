using AutoMapper;
using ThePurrfectPaw.API.Entities;
using ThePurrfectPaw.API.Models.Response;

namespace ThePurrfectPaw.API.Profiles
{
    public class PostingsProfile : Profile
    {
        public PostingsProfile()
        {
            CreateMap<Posting, PostingDto>();
        }
    }
}
