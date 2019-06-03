using BlackSlope.Api.Operations.Movies.ViewModels;
using System.Collections.Generic;

namespace BlackSlope.Api.Operations.Movies.Responses
{
    public class GetMoviesResponse
    {
        public IEnumerable<MovieResponseViewModel> Movies { get; set; }
    }
}