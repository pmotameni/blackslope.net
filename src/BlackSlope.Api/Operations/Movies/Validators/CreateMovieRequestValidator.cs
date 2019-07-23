﻿using BlackSlope.Api.Common.Validators;
using BlackSlope.Api.Operations.Movies.Enumerators;
using BlackSlope.Api.Operations.Movies.Requests;
using BlackSlope.Api.Operations.Movies.Validators.Interfaces;
using BlackSlope.Services.MovieService;
using FluentValidation;

namespace BlackSlope.Api.Operations.Movies.Validators
{
    public class CreateMovieRequestValidator : BlackslopeValidator<CreateMovieRequest>, ICreateMovieRequestValidator
    {
        public CreateMovieRequestValidator(IMovieService movieService)
        {
            RuleFor(x => x.Movie)
                .NotNull()
                .WithState(x => MovieErrorCode.NullRequestModel);

            RuleFor(x => x.Movie).MustAsync(async (x, cancellationtoken) => {
                bool exists = await movieService.CheckIfMovieExists(x.Title, x.ReleaseDate);
                return !exists;
            }).WithState(x => MovieErrorCode.MovieAlreadyExists);

            RuleFor(x => x.Movie).SetValidator(new CreateMovieRequestViewModelValidator());
        }
    }
}
