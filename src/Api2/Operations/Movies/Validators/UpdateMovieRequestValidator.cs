﻿using BlackSlope.Api.Common.Validators;
using BlackSlope.Api.Operations.Movies.Enumerators;
using BlackSlope.Api.Operations.Movies.Requests;
using BlackSlope.Api.Operations.Movies.Validators.Interfaces;
using FluentValidation;

namespace BlackSlope.Api.Operations.Movies.Validators
{
    public class UpdateMovieRequestValidator : BlackslopeValidator<UpdateMovieRequest>, IUpdateMovieRequestValidator
    {
        public UpdateMovieRequestValidator()
        {
            RuleFor(x => x.Movie)
                .NotNull()
                .WithState(x => MovieErrorCode.NullRequestModel);

            RuleFor(x => x.Movie).SetValidator(new UpdateMovieRequestViewModelValidator());
        }
    }
}