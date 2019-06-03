using AutoMapper;
using BlackSlope.Api.Operations.Movies.ViewModels;
using BlackSlope.Services.MovieService.DomainModels;

namespace BlackSlope.Api.Operations.Movies.MapperProfiles
{
    public class UpdateMovieRequestProfile : Profile
    {
        public UpdateMovieRequestProfile()
        {
            CreateMap<UpdateMovieRequestViewModel, MovieDomainModel>().ReverseMap();
        }
    }
}
