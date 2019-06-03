using AutoMapper;
using BlackSlope.Api.Operations.Movies.ViewModels;
using BlackSlope.Services.MovieService.DomainModels;

namespace BlackSlope.Api.Operations.Movies.MapperProfiles
{
    public class MovieResponseProfile : Profile
    {
        public MovieResponseProfile()
        {
            CreateMap<MovieDomainModel, MovieResponseViewModel>().ReverseMap();
        }
    }
}
