using AutoMapper;
using BlackSlope.Api.Operations.Movies.ViewModels;
using BlackSlope.Services.MovieService.DomainModels;

namespace BlackSlope.Api.Operations.Movies.MapperProfiles
{
    public class CreateMovieRequestProfile : Profile
    {
        public CreateMovieRequestProfile()
        {
            CreateMap<CreateMovieRequestViewModel, MovieDomainModel>().ReverseMap();
        }
    }
}
